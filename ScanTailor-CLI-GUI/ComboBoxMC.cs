using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ComboBoxMC
{
    public partial class ComboBoxMC : ComboBox
    {
        public ComboBoxMC()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            InitializeComponent();
        }
        ~ComboBoxMC()
        {
            disposeButtons();
        }
        public void PostConstructorComboBoxMC(Form host)
        {
            _host = host;
        }
        #region Win32 API
        [DllImport("user32.dll")]
        private static extern bool GetComboBoxInfo(IntPtr hWnd, ref COMBOBOXINFO pcbi);
        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hwnd, ref RECT lpRect);
        [DllImport("User32.dll")]
        private static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);
        #endregion
        #region Win32 Constants
        private const int WM_CTLCOLORLISTBOX = 0x134;
        #endregion
        #region Win32 Structures
        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct COMBOBOXINFO
        {
            public Int32 cbSize;
            public RECT rcItem;
            public RECT rcButton;
            public int buttonState;
            public IntPtr hwndCombo;
            public IntPtr hwndEdit;
            public IntPtr hwndList;
        }
        #endregion
        #region Constanten
        #endregion

        private Form _host;
        private String[] _columnNames;
        private int[] _columnWidths;
        private int _valueMemberColumnIndex, _itemIndex;
        private FontStyle _valueMemberFontStyle;
        private Color _valueMemberForeColor = SystemColors.WindowText;
        private Color _valueMemberBackColor = SystemColors.Window;
        private int _sepLineWidth = 1;
        private int _columnPadding = 5;
        private int _columnHeaderHight = 21;
        private Font _columnHeaderFont;
        private ContentAlignment _columnHeaderContentAlignment = ContentAlignment.MiddleLeft;
        private bool _drawGrid, _bypass, _simpleIni;
        private IntPtr _lhandle, _ehandle;
        private Button[] _knopf;
        private Point _comboExatLoc;

        #region Attributes
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new DrawMode DrawMode
        {
            get
            {
                return base.DrawMode;
            }
            set
            {
                if (value != DrawMode.OwnerDrawVariable)
                {
                    throw new NotSupportedException("Needs to be DrawMode.OwnerDrawVariable");
                }
                base.DrawMode = value;
            }
        }
        public new ComboBoxStyle DropDownStyle
        {
            get
            {
                return base.DropDownStyle;
            }
            set
            {
                base.DropDownStyle = value;
            }
        }
        public FontStyle ValueMemberFontStyle
        {
            get { return _valueMemberFontStyle; }
            set { _valueMemberFontStyle = value; }
        }
        public Color ValueMemberForeColor
        {
            get { return _valueMemberForeColor; }
            set { _valueMemberForeColor = value; }
        }
        public Color ValueMemberBackColor
        {
            get { return _valueMemberBackColor; }
            set { _valueMemberBackColor = value; }
        }
        public int SepLineWidth
        {
            get { return _sepLineWidth; }
            set { _sepLineWidth = value; }
        }
        public int ColumnPadding
        {
            get { return _columnPadding; }
            set { _columnPadding = value; }
        }
        public int ColumnHeaderHight
        {
            get { return _columnHeaderHight; }
            set { _columnHeaderHight = value; }
        }
        public Font ColumnHeaderFont
        {
            get { return _columnHeaderFont; }
            set { _columnHeaderFont = value ?? new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold); }
        }
        public ContentAlignment ColumnHeaderContentAlignment
        {
            get { return _columnHeaderContentAlignment; }
            set { _columnHeaderContentAlignment = value; }
        }
        public bool DrawGrid
        {
            get { return _drawGrid; }
            set { _drawGrid = value; }
        }
        #endregion

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            COMBOBOXINFO info = new COMBOBOXINFO();
            info.cbSize = Marshal.SizeOf(info);
            GetComboBoxInfo(Handle, ref info);
            _ehandle = info.hwndEdit;
            _lhandle = info.hwndList;
        }
        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            InitializeColumns();
        }
        protected override void OnValueMemberChanged(EventArgs e)
        {
            base.OnValueMemberChanged(e);
            InitializeValueMemberColumn();
            IniSimpleCombo();
        }
        protected override void OnDisplayMemberChanged(EventArgs e)
        {
            base.OnDisplayMemberChanged(e);
            IniSimpleCombo();
        }
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            if (DesignMode) return;

            if (_columnWidths != null)
            {
                for (var colIndex = 0; colIndex < _columnNames.Length; colIndex++)
                {
                    var item = Convert.ToString(FilterItemOnProperty(Items[e.Index], _columnNames[colIndex]));
                    var cw = 0;
                    if (_host != null)
                    {
                        cw = (int)Math.Ceiling(e.Graphics.MeasureString(_columnNames[colIndex], _columnHeaderFont).Width) + 6;
                    }
                    var ci = (int)Math.Ceiling(e.Graphics.MeasureString(item, Font).Width);
                    cw += _columnPadding;
                    ci += _columnPadding;
                    if (colIndex < _columnNames.Length - 1)
                    {
                        cw += _sepLineWidth;
                        ci += _sepLineWidth;
                    }
                    _columnWidths[colIndex] = Math.Max(_columnWidths[colIndex], cw);
                    _columnWidths[colIndex] = Math.Max(_columnWidths[colIndex], ci);
                }
            }
            else
            {
                var iw = (int)Math.Ceiling(e.Graphics.MeasureString(Items[e.Index].ToString(), Font).Width) + 6;
                DropDownWidth = Math.Max(DropDownWidth, iw);
            }
        }
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            if (_columnWidths != null)
            {
                DropDownWidth = CalculateTotalWidth(Size.Height);
            }
         }
        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
            if (DropDownStyle != ComboBoxStyle.Simple)
            {
                var lp = PointToScreen(Point.Empty);
                RECT rect = new RECT();
                GetClientRect(_lhandle, ref rect);
                var lw = DropDownWidth;
                var lh = (rect.Bottom/ItemHeight)*ItemHeight;
                lh = Math.Min(MaxDropDownItems * ItemHeight, lh);
                if (lh/ItemHeight < Items.Count)
                {
                    lw += SystemInformation.VerticalScrollBarWidth;
                }
                lh += 2;
                lp.Y += Size.Height;
                if (_host != null) lp.Y += _columnHeaderHight;
                MoveWindow(_lhandle, lp.X, lp.Y, lw, lh, true);
            }
        }
        protected override void OnDropDownClosed(EventArgs e)
        {
            base.OnDropDownClosed(e);
            disposeButtons();
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (DesignMode) return;
            if (e.Index >= 0)
            {
                e.DrawBackground();
                using (Pen linePen = new Pen(SystemColors.GrayText, _sepLineWidth), gridPen = new Pen(SystemColors.GrayText, 1))
                {
                    using (var brush = new SolidBrush(ForeColor))
                    {
                        if ((e.State & DrawItemState.ComboBoxEdit) != DrawItemState.ComboBoxEdit)
                        {
                            if (_columnWidths == null)
                            {
                                e.Graphics.DrawString(Convert.ToString(Items[e.Index]), Font, brush, e.Bounds);
                            }
                            else
                            {
                                var boundsRect = e.Bounds;
                                var lastRight = 0;
                                var sepdivto = (int) Math.Round((float) _sepLineWidth/2, MidpointRounding.AwayFromZero);
                                for (int colIndex = 0; colIndex < _columnNames.Length; colIndex++)
                                {
                                    var item = Convert.ToString(FilterItemOnProperty(Items[e.Index], _columnNames[colIndex]));
                                    boundsRect.X = lastRight;
                                    boundsRect.Width = _columnWidths[colIndex];
                                    if (colIndex == _valueMemberColumnIndex)
                                    {
                                        using (var vbrush = new SolidBrush(_valueMemberForeColor))
                                        {
                                            using (var bbrush = new SolidBrush(_valueMemberBackColor))
                                            {
                                                using (var boldFont = new Font(Font, _valueMemberFontStyle))
                                                {
                                                    if ((_itemIndex != e.Index)  || _bypass)
                                                    {
                                                        boundsRect.Width -= _sepLineWidth;
                                                        e.Graphics.FillRectangle(bbrush, boundsRect);
                                                        boundsRect.Width += _sepLineWidth;
                                                        _bypass = false;
                                                    }
                                                    e.Graphics.DrawString(item, boldFont, vbrush, boundsRect);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        e.Graphics.DrawString(item, Font, brush, boundsRect);
                                    }
                                    if (_drawGrid) e.Graphics.DrawRectangle(gridPen, boundsRect.X, boundsRect.Y - 1, boundsRect.Width, boundsRect.Height);
                                    if (colIndex < _columnNames.Length - 1)
                                    {
                                        e.Graphics.DrawLine(linePen, boundsRect.Right - sepdivto, boundsRect.Top, boundsRect.Right - sepdivto, boundsRect.Bottom);
                                    }
                                    lastRight = boundsRect.Right;
                                }
                            }
                            e.DrawFocusRectangle();
                        }
                        else if(_columnWidths == null)
                        {
                            e.Graphics.DrawString(Convert.ToString(Items[e.Index]), Font, brush, e.Bounds);
                        }
                        else
                        {
                            e.Graphics.DrawString(Convert.ToString(FilterItemOnProperty(Items[e.Index], DisplayMember)), Font, brush, e.Bounds);
                        }
                    }
                }
            }
        }
        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case WM_CTLCOLORLISTBOX:
                    if (_itemIndex != SelectedIndex)
                    {
                        _itemIndex = SelectedIndex;
                    }
                    else
                    {
                        _bypass = true;
                    }
                    break;
            }
            base.WndProc(ref msg);
        }

        private void InitializeColumns()
        {
            var propertyDescriptorCollection = DataManager.GetItemProperties();
            _columnWidths = new int[propertyDescriptorCollection.Count];
            _columnNames = new String[propertyDescriptorCollection.Count];
            for (var colIndex = 0; colIndex < propertyDescriptorCollection.Count; colIndex++)
            {
                _columnNames[colIndex] = propertyDescriptorCollection[colIndex].Name;
            }
        }
        private void InitializeValueMemberColumn()
        {
            var colIndex = 0;
            foreach (var columnName in _columnNames)
            {
                if (String.Compare(columnName, ValueMember, true, CultureInfo.CurrentUICulture) == 0)
                {
                    _valueMemberColumnIndex = colIndex;
                    break;
                }
                colIndex++;
            }
        }
        private void IniSimpleCombo()
        {
            if (!_simpleIni && DropDownStyle == ComboBoxStyle.Simple)
            {
                RECT rect = new RECT();
                GetClientRect(_ehandle, ref rect);
                var _edithight = rect.Bottom + 6;
                DropDownWidth = CalculateTotalWidth(_edithight);
                GetClientRect(_lhandle, ref rect);
                var y = _edithight;
                _edithight += 4;
                var lh = (((Size.Height - _edithight) / ItemHeight) * ItemHeight);
                lh = Math.Min(lh, MaxDropDownItems * ItemHeight);
                if (lh / ItemHeight < Items.Count)
                {
                    DropDownWidth += SystemInformation.VerticalScrollBarWidth;
                }
                if (_host != null)
                {
                    lh += _columnHeaderHight;
                    y += _columnHeaderHight;
                }
                lh += _edithight;
                Size = new Size(DropDownWidth, lh);
                DropDownHeight = lh - y;
                MoveWindow(_lhandle, 0, y, DropDownWidth, DropDownHeight, true);
                _simpleIni = true;
            }
        }
        private int CalculateTotalWidth(int edithight)
        {
            _comboExatLoc = FindExatLocation();
            var totalWidth = 0;
            var cc = _columnWidths.Length;
            if (_host != null)
            {
                _knopf = new Button[cc];
            }
            for (var co = 0; co < cc; co++)
            {
                if (_host != null)
                {
                    _knopf[co] = new Button();
                    _knopf[co].Text = _columnNames[co];
                    _knopf[co].Height = _columnHeaderHight;
                    if (co == 0)
                    {
                        _knopf[co].Width = _columnWidths[co] + 3;
                        _knopf[co].Location = new Point(_comboExatLoc.X, _comboExatLoc.Y + edithight);
                    }
                    else
                    {
                        _knopf[co].Width = _columnWidths[co] + 1;
                        _knopf[co].Location = new Point(_comboExatLoc.X + totalWidth + 2, _comboExatLoc.Y + edithight);
                    }
                    _knopf[co].Font = _columnHeaderFont;
                    _knopf[co].TextAlign = _columnHeaderContentAlignment;
                    if (DropDownStyle == ComboBoxStyle.Simple)
                    {
                        _knopf[co].Click += headerButton_Click;
                    }
                    _host.Controls.Add(_knopf[co]);
                    _knopf[co].BringToFront();
                }
                totalWidth += _columnWidths[co];
            }
            return totalWidth;
        }
        private Point FindExatLocation()
        {
            Control ctrl = this;
            Point p;
            for (p = ctrl.Location; ctrl.Parent != null & !(ctrl.Parent is Form); ctrl = ctrl.Parent)
            {
                p.Offset(ctrl.Parent.Location);
            }
            p.X--;
            return p;
        }
        private void headerButton_Click(object sender, EventArgs e)
        {
            Button hButton = (Button)sender;
            Debug.WriteLine("Hello:" + hButton.Text);
        }
        private void disposeButtons()
        {
            if (_knopf != null)
            {
                for (int i = 0; i < _knopf.Count(); i++)
                {
                    _knopf[i].Dispose();
                }
                _knopf = null;
            }
        }
    }
}
