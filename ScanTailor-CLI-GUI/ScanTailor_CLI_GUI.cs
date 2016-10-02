using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanTailor_CLI_GUI
{
    public partial class Form_ScanTailor_CLI : Form
    {
        #region INI Records
        private const string I_ScanTailorCLI = "ScanTailorCLI";
        private const string I_InputDirectory = "InputDirectory";
        private const string I_OutputDirectory = "OutputDirectory";

        private const string I_Verbose = "verbose";
        private const string I_Layout = "layout";
        private const string I_LayoutDirection = "layout-direction";
        private const string I_Orientation = "orientation";
        private const string I_Rotate = "rotate";
        private const string I_Deskew = "deskew";
        private const string I_SkewDeviation = "skew-deviation";
        private const string I_DisableContentDetection = "disable-content-detection";
        private const string I_EnablePageDetection = "enable-page-detection";
        private const string I_EnableFineTuning = "enable-fine-tuning";
        private const string I_ForceDisablePageDetection = "force-disable-page-detection";
        private const string I_DisableContentTextMask = "disable-content-text-mask";
        private const string I_ContentDetection = "content-detection";
        private const string I_ContentDeviation = "content-deviation";
        private const string I_ContentBox = "content-box";
        private const string I_EnableAutoMargins = "enable-auto-margins";
        private const string I_Margins = "margins";
        private const string I_MarginsLeft = "margins-left";
        private const string I_MarginsRight = "margins-right";
        private const string I_MarginsTop = "margins-top";
        private const string I_MarginsBottom = "margins-bottom";
        private const string I_DefaultMargins = "default-margins";
        private const string I_DefaultMarginsLeft = "default-margins-left";
        private const string I_DefaultMarginsRight = "default-margins-right";
        private const string I_DefaultMarginsTop = "default-margins-top";
        private const string I_DefaultMarginsBottom = "default-margins-bottom";
        private const string I_MatchLayout = "match-layout";
        private const string I_MatchLayoutTolerance = "match-layout-tolerance";
        private const string I_MatchLayoutDefault = "match-layout-default";
        private const string I_Alignment = "alignment";
        private const string I_AlignmentVertical = "alignment-vertical";
        private const string I_AlignmentHorizontal = "alignment-horizontal";
        private const string I_AlignmentTolerance = "alignment-tolerance";
        private const string I_DPI = "dpi";
        private const string I_DPIX = "dpi-x";
        private const string I_DPIY = "dpi-y";
        private const string I_OutputDPI = "output-dpi";
        private const string I_OutputDPIX = "output-dpi-x";
        private const string I_OutputDPIY = "output-dpi-y";
        private const string I_DefaultOutputDPI = "default-output-dpi";
        private const string I_ColorMode = "color-mode";
        private const string I_DefaultColorMode = "default-color-mode";
        private const string I_PictureShape = "picture-shape";
        private const string I_WhiteMargins = "white-margins";
        private const string I_NormalizeIllumination = "normalize-illumination";
        private const string I_Threshold = "threshold";
        private const string I_Despeckle = "despeckle";
        private const string I_Dewarping = "dewarping";
        private const string I_DepthPerception = "depth-perception";
        private const string I_StartFilter = "start-filter";
        private const string I_EndFilter = "end-filter";
        private const string I_TiffCompression = "tiff-compression";
        private const string I_TiffForceRGB = "tiff-force-rgb";
        private const string I_TiffForceGrayscale = "tiff-force-grayscale";
        private const string I_TiffForceKeepColorSpace = "tiff-force-keep-color-space";
        private const string I_PageDetectionBox = "page-detection-box";
        private const string I_PageDetectionTolerance = "page-detection-tolerance";
        private const string I_DisableCheckOutput = "disable-check-output";
        //User
        private const string I_ProjectImageMode = "project-image-mode";
        private const string I_VerboseGUI = "verbose-GUI";
        private const string I_Parallel = "run-parallel";
        private const string I_IrfanView = "i_view32";
        private const string I_UseIrfanView = "Use-IrfanView";
        private const string I_ApplyRotateTo = "Apply-Rotate-To";
        #endregion
        #region Struct
        struct ImgRecord
        {
            internal int imgc;
            internal string img;
        }
        #endregion
        #region private variables
        private string _CurrentProfile;
        private string _ProfilesDir = Application.StartupPath + "\\Profiles\\";
        private ProfileString _aini;
        private bool _FormLoaded,_CMDChanged;
        private BackgroundWorker BW_CL;
        private static string _ScanTailor_CLI, _IrfanView, _InputDirectory, _OutputDirectory, _CL;
        private static bool _Verbose, _DoParallel, _ProjectImageMode, _UseIW;
        private static decimal _RotationAngle;
        private static int _ApplyRotateTo, _DPI, _Filter0;
        private static uint _ImgCounter;
        #endregion
        public Form_ScanTailor_CLI()
        {
            InitializeComponent();
            BasicSetup();
            BW_CL = new BackgroundWorker();
            BW_CL.WorkerReportsProgress = true;
            BW_CL.DoWork += BW_CL_DoWork;
            BW_CL.ProgressChanged += BW_CL_ProgressChanged;
            BW_CL.RunWorkerCompleted += BW_CL_RunWorkerCompleted;
        }
        private void Form_ScanTailor_CLI_Load(object sender, EventArgs e)
        {
            Text = "ScanTailor-CLI GUI [Ver. " + Application.ProductVersion + " 2015]";
            CenterToScreen();
            MCCB_Layout.ValueMemberFontStyle = FontStyle.Bold;
            Text_Output.Text = "Ready...";
        }
        private void Form_ScanTailor_CLI_Shown(object sender, EventArgs e)
        {
            _FormLoaded = true;
            if (_aini.IsIniReadOnly)
            {
                MessageBox.Show(this, "The application directory seems to be read-only!\r\nUAC?", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void CB_Profile_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_CMDChanged) DoProfileNeedSave();
            _FormLoaded = false;
            FillSettings();
            _FormLoaded = true;
            SyncCMD();
        }
        #region CMDChanged
        private void CMDChanged_Changed(object sender, EventArgs e)
        {
            CMDChanged();
        }
        private void CheckB_IrfanView_CheckedChanged(object sender, EventArgs e)
        {
            CB_ApplyRotateTo.Enabled = CheckB_UseIrfanView.Checked;
            CMDChanged();
        }
        #endregion
        #region Buttons
        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (!BW_CL.IsBusy)
            {
                Button_Start.Text = "Stop";
                Text_Output.Clear();
                _Verbose = CheckB_VerboseGUI.Checked;
                _DoParallel = CheckB_Parallel.Checked;
                _ProjectImageMode = CheckB_ProjectORImageMode.Checked;
                _UseIW = CheckB_UseIrfanView.Checked;
                _ApplyRotateTo = CB_ApplyRotateTo.SelectedIndex;
                _RotationAngle = UpDown_Rotate.Value;
                _ImgCounter = 0;
                _DPI = (int)UpDown_DPI.Value;
                _Filter0 = (int)UpDown_StartFilter.Value;
                if (_UseIW && _ApplyRotateTo != 0 && _Filter0 == 1)
                {
                    if (!File.Exists(_IrfanView))
                    {
                        MessageBoxEx.Show(this, "IrfanView executable dosn't exists!", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (File.Exists(_ScanTailor_CLI))
                {
                    Text_Output.Text = "Starting ScanTailor-CLI threads...";
                    BW_CL.RunWorkerAsync(null);
                }
                else
                {
                    MessageBoxEx.Show(this, "ScanTailor-CLI executable dosn't exists!", "Abort!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Button_InputDir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_InputDirectory))
            {
                FBD_InputDir.SelectedPath = _InputDirectory;
            }
            if (FBD_InputDir.ShowDialog(this) == DialogResult.OK)
            {
                _InputDirectory = FBD_InputDir.SelectedPath;
                Text_InputDir.Text = _InputDirectory;
                TT_STCLI.SetToolTip(Text_InputDir, _InputDirectory);
                _aini.Write(I_InputDirectory,_InputDirectory);
            }
        }
        private void Button_OutputDir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_OutputDirectory))
            {
                FBD_OutputDir.SelectedPath = _OutputDirectory;
            }
            if (FBD_OutputDir.ShowDialog(this) == DialogResult.OK)
            {
                _OutputDirectory = FBD_OutputDir.SelectedPath;
                Text_OutputDir.Text = _OutputDirectory;
                TT_STCLI.SetToolTip(Text_OutputDir, _OutputDirectory);
                _aini.Write(I_OutputDirectory, _OutputDirectory);
            }
        }
        private void Button_ScanTailorExe_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_ScanTailor_CLI))
            {
                var tdir = Path.GetDirectoryName(_ScanTailor_CLI);
                if (Directory.Exists(tdir))
                {
                    OFD_ScanTailor_exe.InitialDirectory = tdir;
                }
            }
            if (OFD_ScanTailor_exe.ShowDialog() == DialogResult.OK)
            {
                _ScanTailor_CLI = OFD_ScanTailor_exe.FileName;
                Text_ScanTailor_CLI.Text = _ScanTailor_CLI;
                TT_STCLI.SetToolTip(Text_ScanTailor_CLI, _ScanTailor_CLI);
                _aini.Write(I_ScanTailorCLI, _ScanTailor_CLI);
            }
        }
        private void Button_IrfanViewExe_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_IrfanView))
            {
                var tdir = Path.GetDirectoryName(_IrfanView);
                if (Directory.Exists(tdir))
                {
                    OFD_i_view32_exe.InitialDirectory = tdir;
                }
            }
            if (OFD_i_view32_exe.ShowDialog() == DialogResult.OK)
            {
                _IrfanView = OFD_i_view32_exe.FileName;
                Text_IrfanViewExe.Text = _IrfanView;
                TT_STCLI.SetToolTip(Text_IrfanViewExe, _IrfanView);
                _aini.Write(I_IrfanView, _IrfanView);
            }
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            _CurrentProfile = CB_Profile.Text;
            SaveProfile(true);
            FillProfiles();
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            var profile = CB_Profile.Text;
            if (!String.IsNullOrEmpty(profile))
            {
                CB_Profile.Items.Remove(profile);
                profile = _ProfilesDir + profile + ".INI";
                File.Delete(profile);
            }
        }
        private void Button_CopyCL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("\"" + _ScanTailor_CLI + "\" " + _CL.TrimEnd());
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void BasicSetup()
        {
            // INI
            _aini = new ProfileString(Application.StartupPath + "\\ScanTailor-CLI-GUI.ini");
            _InputDirectory = _aini.Read(I_InputDirectory);
            if (Directory.Exists(_InputDirectory))
            {
                Text_InputDir.Text = _InputDirectory;
                TT_STCLI.SetToolTip(Text_InputDir, _InputDirectory);
            }

            _OutputDirectory = _aini.Read(I_OutputDirectory);
            if (Directory.Exists(_OutputDirectory))
            {
                Text_OutputDir.Text = _OutputDirectory;
                TT_STCLI.SetToolTip(Text_OutputDir, _OutputDirectory);
            }

            _ScanTailor_CLI = _aini.Read(I_ScanTailorCLI);
            if (!File.Exists(_ScanTailor_CLI))
            {
                _ScanTailor_CLI = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Scan Tailor\\scantailor-cli.exe";
            }

            if (File.Exists(_ScanTailor_CLI))
            {
                Text_ScanTailor_CLI.Text = _ScanTailor_CLI;
                TT_STCLI.SetToolTip(Text_ScanTailor_CLI, _ScanTailor_CLI);
                _aini.Write(I_ScanTailorCLI,_ScanTailor_CLI);
            }

            _IrfanView = _aini.Read(I_IrfanView);
            if (!File.Exists(_IrfanView))
            {
                _IrfanView = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\IrfanView\\i_view32.exe";
            }

            if (File.Exists(_IrfanView))
            {
                Text_IrfanViewExe.Text = _IrfanView;
                TT_STCLI.SetToolTip(Text_IrfanViewExe, _IrfanView);
                _aini.Write(I_IrfanView,_IrfanView);
            }

            // Layouts
            var dataTable = new DataTable("Layouts");
            dataTable.Columns.Add("Layout", typeof(String));
            dataTable.Columns.Add("Value", typeof(String));

            dataTable.Rows.Add("", "");
            dataTable.Rows.Add("Auto detect - default -", "0.0");
            dataTable.Rows.Add("One page layout", "1.0");
            dataTable.Rows.Add("One page layout (cutting is needed)", "1.5");
            dataTable.Rows.Add("Two page layout", "2.0");

            MCCB_Layout.DataSource = dataTable;
            MCCB_Layout.DisplayMember = "Layout";
            MCCB_Layout.ValueMember = "Value";
            Directory.CreateDirectory(_ProfilesDir);
            FillProfiles();
        }
        private void FillProfiles()
        {
            var profiles = Directory.GetFiles(_ProfilesDir, "*.INI");
            CB_Profile.Items.Clear();
            foreach (var profile in profiles)
            {
                CB_Profile.Items.Add(Path.GetFileNameWithoutExtension(profile));
            }
        }
        private void FillSettings()
        {
            _CurrentProfile = CB_Profile.Text;
            if (!String.IsNullOrEmpty(_CurrentProfile))
            {
                var profile = _ProfilesDir + _CurrentProfile + ".INI";
                ProfileString _pini = new ProfileString(profile);
                CheckB_Verbose.Checked = _pini.ReadBool(I_Verbose);                                         //--verbose
                MCCB_Layout.SelectedValue = _pini.Read(I_Layout);                                           //--layout
                CB_LayoutDirection.Text = _pini.Read(I_LayoutDirection);                                    //--layout-direction
                CB_Orientation.Text = _pini.Read(I_Orientation);                                            //--orientation
                UpDown_Rotate.Value = _pini.ReadDecimal(I_Rotate, 0);                                       //--rotate
                CB_Deskew.Text = _pini.Read(I_Deskew);                                                      //--deskew
                UpDown_SkewDeviation.Value = _pini.ReadDecimal(I_SkewDeviation, 0);                         //--skew-deviation
                CheckB_DisableContentDetection.Checked = _pini.ReadBool(I_DisableContentDetection);         //--disable-content-detection
                CheckB_EnablePageDetection.Checked = _pini.ReadBool(I_EnablePageDetection);                 //--enable-page-detection
                CheckB_EnableFineTuning.Checked = _pini.ReadBool(I_EnableFineTuning);                       //--enable-fine-tuning
                CheckB_ForceDisablePageDetection.Checked = _pini.ReadBool(I_ForceDisablePageDetection);     //--force-disable-page-detection
                CheckB_DisableContentTextMask.Checked = _pini.ReadBool(I_DisableContentTextMask);           //--disable-content-text-mask
                CB_ContentDetection.Text = _pini.Read(I_ContentDetection);                                  //--content-detection
                UpDown_ContentDeviation.Value = _pini.ReadDecimal(I_ContentDeviation, 0);                   //--content-deviation
                UpDown_ContentBox_L.Value = _pini.ReadInt(I_ContentBox + "L", 0);                           //--content-box
                UpDown_ContentBox_T.Value = _pini.ReadInt(I_ContentBox + "T", 0);
                UpDown_ContentBox_W.Value = _pini.ReadInt(I_ContentBox + "W", 0);
                UpDown_ContentBox_H.Value = _pini.ReadInt(I_ContentBox + "H", 0);
                CheckB_EnableAutoMargins.Checked = _pini.ReadBool(I_EnableAutoMargins);                     //--enable-auto-margins
                UpDown_Margins.Value = _pini.ReadInt(I_Margins, 0);                                         //--margins
                UpDown_Margins_L.Value = _pini.ReadInt(I_MarginsLeft, 0);                                   //--margins-left
                UpDown_Margins_R.Value = _pini.ReadInt(I_MarginsRight, 0);                                  //--margins-right
                UpDown_Margins_T.Value = _pini.ReadInt(I_MarginsTop, 0);                                    //--margins-top
                UpDown_Margins_B.Value = _pini.ReadInt(I_MarginsBottom, 0);                                 //--margins-bottom
                UpDown_DefaultMargins.Value = _pini.ReadInt(I_DefaultMargins, 0);                           //--default-margins
                UpDown_DefaultMargins_L.Value = _pini.ReadInt(I_DefaultMarginsLeft, 0);                     //--default-margins-left
                UpDown_DefaultMargins_R.Value = _pini.ReadInt(I_DefaultMarginsRight, 0);                    //--default-margins-right
                UpDown_DefaultMargins_T.Value = _pini.ReadInt(I_DefaultMarginsTop, 0);                      //--default-margins-top
                UpDown_DefaultMargins_B.Value = _pini.ReadInt(I_DefaultMarginsBottom, 0);                   //--default-margins-bottom
                CheckB_MatchLayout.Checked = _pini.ReadBool(I_MatchLayout,true);                            //--match-layout
                UpDown_MatchLayoutTolerance.Value = _pini.ReadDecimal(I_MatchLayoutTolerance, 0);           //--match-layout-tolerance
                CheckB_MatchLayoutDefault.Checked = _pini.ReadBool(I_MatchLayoutDefault,true);              //--match-layout-default
                CB_Alignment.Text = _pini.Read(I_Alignment);                                                //--alignment
                CB_AlignmentVertical.Text = _pini.Read(I_AlignmentVertical);                                //--alignment-vertical
                CB_AlignmentHorizontal.Text = _pini.Read(I_AlignmentHorizontal);                            //--alignment-horizontal
                UpDown_AlignmentTolerance.Value = _pini.ReadDecimal(I_AlignmentTolerance, 0);               //--alignment-tolerance
                UpDown_DPI.Value = _pini.ReadInt(I_DPI, 0);                                                 //--dpi
                UpDown_DPI_X.Value = _pini.ReadInt(I_DPIX, 0);                                              //--dpi-x
                UpDown_DPI_Y.Value = _pini.ReadInt(I_DPIY, 0);                                              //--dpi-y
                UpDown_OutputDPI.Value = _pini.ReadInt(I_OutputDPI, 0);                                     //--output-dpi
                UpDown_OutputDPI_X.Value = _pini.ReadInt(I_OutputDPIX, 0);                                  //--output-dpi-x
                UpDown_OutputDPI_Y.Value = _pini.ReadInt(I_OutputDPIY, 0);                                  //--output-dpi-y
                UpDown_DefaultOutputDPI.Value = _pini.ReadInt(I_DefaultOutputDPI, 0);                       //--default-output-dpi
                CB_ColorMode.Text = _pini.Read(I_ColorMode);                                                //--color-mode
                CB_DefaultColorMode.Text = _pini.Read(I_DefaultColorMode);                                  //--default-color-mode
                CB_PictureShape.Text = _pini.Read(I_PictureShape);                                          //--picture-shape
                CheckB_WhiteMargins.Checked = _pini.ReadBool(I_WhiteMargins);                               //--white-margins
                CheckB_NormalizeIllumination.Checked = _pini.ReadBool(I_NormalizeIllumination);             //--normalize-illumination
                UpDown_Treshold.Value = _pini.ReadInt(I_Threshold, 0);                                      //--threshold
                CB_Despeckle.Text = _pini.Read(I_Despeckle);                                                //--despeckle
                CB_Dewarping.Text = _pini.Read(I_Dewarping);                                                //--dewarping
                UpDown_DepthPerception.Value = _pini.ReadDecimal(I_DepthPerception, 0);                     //--depth-perception
                UpDown_StartFilter.Value = _pini.ReadInt(I_StartFilter, 0);                                 //--start-filter
                UpDown_EndFilter.Value = _pini.ReadInt(I_EndFilter, 0);                                     //--end-filter
                CB_TiffCompression.Text = _pini.Read(I_TiffCompression);                                    //--tiff-compression
                CheckB_TiffForceRGB.Checked = _pini.ReadBool(I_TiffForceRGB);                               //--tiff-force-rgb
                CheckB_TiffForceGrayscale.Checked = _pini.ReadBool(I_TiffForceGrayscale);                   //--tiff-force-grayscale
                CheckB_TiffForceKeepColorSpace.Checked = _pini.ReadBool(I_TiffForceKeepColorSpace);         //--tiff-force-keep-color-space
                UpDown_PageDetectionBox_H.Value = _pini.ReadInt(I_PageDetectionBox + "H", 0);               //--page-detection-box
                UpDown_PageDetectionBox_W.Value = _pini.ReadInt(I_PageDetectionBox + "W", 0);
                UpDown_PageDetectionTolerance.Value = _pini.ReadDecimal(I_PageDetectionTolerance, 0);       //--page-detection-tolerance
                CheckB_DisableCheckOutput.Checked = _pini.ReadBool(I_DisableCheckOutput);                   //--disable-check-output
                // User
                CheckB_VerboseGUI.Checked = _pini.ReadBool(I_VerboseGUI);
                CheckB_Parallel.Checked = _pini.ReadBool(I_Parallel);
                CheckB_ProjectORImageMode.Checked = _pini.ReadBool(I_ProjectImageMode);
                var tb = _pini.ReadBool(I_UseIrfanView);
                CheckB_UseIrfanView.Checked = tb;
                CB_ApplyRotateTo.Enabled = tb;
                CB_ApplyRotateTo.Text = _pini.Read(I_ApplyRotateTo);
            }
        }
        private void DoProfileNeedSave()
        {
            if (!String.IsNullOrEmpty(_CurrentProfile))
            {
                if (MessageBoxEx.Show(this, "Parameters have changed!\r\nDo You like to save them?", "Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveProfile();
                }
            }
            _CMDChanged = false;
        }
        private void SaveProfile(bool CheckOverwrite = false)
        {
            _CMDChanged = false;
            if (!String.IsNullOrEmpty(_CurrentProfile))
            {
                var profile = _ProfilesDir + _CurrentProfile + ".INI";
                if (CheckOverwrite & File.Exists(profile))
                {
                    if (MessageBoxEx.Show(this, "Profile already exists, overwrite it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                }
                ProfileString _pini = new ProfileString(profile);

                _pini.Write(I_Verbose, CheckB_Verbose.Checked);                                     //--verbose
                _pini.Write(I_Layout, MCCB_Layout.SelectedValue.ToString());                        //--layout
                _pini.Write(I_LayoutDirection, CB_LayoutDirection.Text);                            //--layout-direction
                _pini.Write(I_Orientation, CB_Orientation.Text);                                    //--orientation
                _pini.Write(I_Rotate, UpDown_Rotate.Value);                                         //--rotate
                _pini.Write(I_Deskew, CB_Deskew.Text);                                              //--deskew
                _pini.Write(I_SkewDeviation, UpDown_SkewDeviation.Value);                           //--skew-deviation
                _pini.Write(I_DisableContentDetection, CheckB_DisableContentDetection.Checked);     //--disable-content-detection
                _pini.Write(I_EnablePageDetection, CheckB_EnablePageDetection.Checked);             //--enable-page-detection
                _pini.Write(I_EnableFineTuning, CheckB_EnableFineTuning.Checked);                   //--enable-fine-tuning
                _pini.Write(I_ForceDisablePageDetection, CheckB_ForceDisablePageDetection.Checked); //--force-disable-page-detection
                _pini.Write(I_DisableContentTextMask, CheckB_DisableContentTextMask.Checked);       //--disable-content-text-mask
                _pini.Write(I_ContentDetection, CB_ContentDetection.Text);                          //--content-detection
                _pini.Write(I_ContentDeviation, UpDown_ContentDeviation.Value);                      //--content-deviation
                _pini.Write(I_ContentBox + "L", UpDown_ContentBox_L.Value);
                _pini.Write(I_ContentBox + "T", UpDown_ContentBox_T.Value);
                _pini.Write(I_ContentBox + "W", UpDown_ContentBox_W.Value);
                _pini.Write(I_ContentBox + "H", UpDown_ContentBox_H.Value);                         //--content-box
                _pini.Write(I_EnableAutoMargins, CheckB_EnableAutoMargins.Checked);                 //--enable-auto-margins
                _pini.Write(I_Margins, UpDown_Margins.Value);                                       //--margins
                _pini.Write(I_MarginsLeft, UpDown_Margins_L.Value);                                 //--margins-left
                _pini.Write(I_MarginsRight, UpDown_Margins_R.Value);                                //--margins-right
                _pini.Write(I_MarginsTop, UpDown_Margins_T.Value);                                  //--margins-top
                _pini.Write(I_MarginsBottom, UpDown_Margins_B.Value);                               //--margins-bottom
                _pini.Write(I_DefaultMargins, UpDown_DefaultMargins.Value);                         //--default-margins
                _pini.Write(I_DefaultMarginsLeft, UpDown_DefaultMargins_L.Value);                   //--default-margins-left
                _pini.Write(I_DefaultMarginsRight, UpDown_DefaultMargins_R.Value);                  //--default-margins-right
                _pini.Write(I_DefaultMarginsTop, UpDown_DefaultMargins_T.Value);                    //--default-margins-top
                _pini.Write(I_DefaultMarginsBottom, UpDown_DefaultMargins_B.Value);                 //--default-margins-bottom
                _pini.Write(I_MatchLayout, CheckB_MatchLayout.Checked);                             //--match-layout
                _pini.Write(I_MatchLayoutTolerance, UpDown_MatchLayoutTolerance.Value);             //--match-layout-tolerance
                _pini.Write(I_MatchLayoutDefault, CheckB_MatchLayoutDefault.Checked);               //--match-layout-default
                _pini.Write(I_Alignment, CB_Alignment.Text);                                        //--alignment
                _pini.Write(I_AlignmentVertical, CB_AlignmentVertical.Text);                        //--alignment-vertical
                _pini.Write(I_AlignmentHorizontal, CB_AlignmentHorizontal.Text);                    //--alignment-horizontal
                _pini.Write(I_AlignmentTolerance, UpDown_AlignmentTolerance.Value);                 //--alignment-tolerance
                _pini.Write(I_DPI, UpDown_DPI.Value);                                               //--dpi
                _pini.Write(I_DPIX, UpDown_DPI_X.Value);                                            //--dpi-x
                _pini.Write(I_DPIY, UpDown_DPI_Y.Value);                                            //--dpi-y
                _pini.Write(I_OutputDPI, UpDown_OutputDPI.Value);                                   //--output-dpi
                _pini.Write(I_OutputDPIX, UpDown_OutputDPI_X.Value);                                //--output-dpi-x
                _pini.Write(I_OutputDPIY, UpDown_OutputDPI_Y.Value);                                //--output-dpi-y
                _pini.Write(I_DefaultOutputDPI, UpDown_DefaultOutputDPI.Value);                     //--default-output-dpi
                _pini.Write(I_ColorMode, CB_ColorMode.Text);                                        //--color-mode
                _pini.Write(I_DefaultColorMode, CB_DefaultColorMode.Text);                          //--default-color-mode
                _pini.Write(I_PictureShape, CB_PictureShape.Text);                                  //--picture-shape
                _pini.Write(I_WhiteMargins, CheckB_WhiteMargins.Checked);                           //--white-margins
                _pini.Write(I_NormalizeIllumination, CheckB_NormalizeIllumination.Checked);         //--normalize-illumination
                _pini.Write(I_Threshold, UpDown_Treshold.Value);                                    //--threshold
                _pini.Write(I_Despeckle, CB_Despeckle.Text);                                        //--despeckle
                _pini.Write(I_Dewarping, CB_Dewarping.Text);                                        //--dewarping
                _pini.Write(I_DepthPerception, UpDown_DepthPerception.Value);                       //--depth-perception
                _pini.Write(I_StartFilter, UpDown_StartFilter.Value);                               //--start-filter
                _pini.Write(I_EndFilter, UpDown_EndFilter.Value);                                   //--end-filter
                _pini.Write(I_TiffCompression, CB_TiffCompression.Text);                            //--tiff-compression
                _pini.Write(I_TiffForceRGB, CheckB_TiffForceRGB.Checked);                           //--tiff-force-rgb
                _pini.Write(I_TiffForceGrayscale, CheckB_TiffForceGrayscale.Checked);               //--tiff-force-grayscale
                _pini.Write(I_TiffForceKeepColorSpace, CheckB_TiffForceKeepColorSpace.Checked);     //--tiff-force-keep-color-space
                _pini.Write(I_PageDetectionBox + "H", UpDown_PageDetectionBox_H.Value);             //--page-detection-box
                _pini.Write(I_PageDetectionBox + "W", UpDown_PageDetectionBox_W.Value);
                _pini.Write(I_PageDetectionTolerance, UpDown_PageDetectionTolerance.Value);         //--page-detection-tolerance
                _pini.Write(I_DisableCheckOutput, CheckB_DisableCheckOutput.Checked);               //--disable-check-output
                // User
                _pini.Write(I_ProjectImageMode, CheckB_ProjectORImageMode.Checked);
                _pini.Write(I_VerboseGUI, CheckB_VerboseGUI.Checked);
                _pini.Write(I_Parallel, CheckB_Parallel.Checked);
                _pini.Write(I_UseIrfanView, CheckB_UseIrfanView.Checked);
                _pini.Write(I_ApplyRotateTo, CB_ApplyRotateTo.Text);
            }
        }
        private void CMDChanged()
        {
            if (_FormLoaded)
            {
                SyncCMD();
                _CMDChanged = true;
            }
        }
        private void SyncCMD()
        {
            if (_FormLoaded)
            {
                var cmd = "--";
                if (CheckB_Verbose.Checked) cmd += I_Verbose + "\r\n--";                                            //--verbose
                if (CheckB_DisableCheckOutput.Checked) cmd += I_DisableCheckOutput + "\r\n--";                      //--disable-check-output
                Decimal td = UpDown_StartFilter.Value;                                                              //--start-filter
                if (td != 0) cmd += I_StartFilter + "=" + td + "\r\n--";
                td = UpDown_EndFilter.Value;                                                                        //--end-filter
                if (td != 0) cmd += I_EndFilter + "=" + td + "\r\n--";
                td = UpDown_DPI.Value;                                                                              //--dpi
                if (td != 0) cmd += I_DPI + "=" + td + "\r\n--";
                td = UpDown_DPI_X.Value;                                                                            //--dpi-x
                if (td != 0) cmd += I_DPIX + "=" + td + "\r\n--";
                td = UpDown_DPI_Y.Value;                                                                            //--dpi-y
                if (td != 0) cmd += I_DPIY + "=" + td + "\r\n--";
                if (!CheckB_UseIrfanView.Checked)
                {
                    td = UpDown_Rotate.Value;                                                                       //--rotate
                    if (td != 0) cmd += I_Rotate + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                }
                var tst = MCCB_Layout.SelectedValue.ToString();                                                     //--layout
                if (tst != String.Empty) cmd += I_Layout + "=" + tst + "\r\n--";
                tst = CB_Orientation.Text;                                                                          //--orientation
                if (tst != String.Empty) cmd += I_Orientation + "=" + tst + "\r\n--";
                tst = CB_LayoutDirection.Text;                                                                      //--layout-direction
                if (tst != String.Empty) cmd += I_LayoutDirection + "=" + tst + "\r\n--";
                if (CheckB_MatchLayout.Checked) cmd += I_MatchLayout + "\r\n--";                                    //--match-layout
                if (CheckB_MatchLayoutDefault.Checked) cmd += I_MatchLayoutDefault + "\r\n--";                      //--match-layout-default
                td = UpDown_MatchLayoutTolerance.Value;                                                             //--match-layout-tolerance
                if (td != 0) cmd += I_MatchLayoutTolerance + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                tst = CB_Deskew.Text;                                                                               //--deskew
                if (tst != String.Empty) cmd += I_Deskew + "=" + tst + "\r\n--";
                td = UpDown_SkewDeviation.Value;                                                                    //--skew-deviation
                if (td != 0) cmd += I_SkewDeviation + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                if (CheckB_DisableContentDetection.Checked) cmd += I_DisableContentDetection + "\r\n--";            //--disable-content-detection
                if (CheckB_DisableContentTextMask.Checked) cmd += I_DisableContentTextMask + "\r\n--";              //--disable-content-text-mask
                if (CheckB_EnablePageDetection.Checked) cmd += I_EnablePageDetection + "\r\n--";                    //--enable-page-detection
                if (CheckB_ForceDisablePageDetection.Checked) cmd += I_ForceDisablePageDetection + "\r\n--";        //--force-disable-page-detection
                if (CheckB_EnableFineTuning.Checked) cmd += I_EnableFineTuning + "\r\n--";                          //--enable-fine-tuning
                tst = CB_ContentDetection.Text;                                                                     //--content-detection
                if (tst != String.Empty) cmd += I_ContentDetection + "=" + tst + "\r\n--";
                td = UpDown_ContentDeviation.Value;                                                                 //--content-deviation
                if (td != 0) cmd += I_ContentDeviation + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";    
                var l = (int)UpDown_ContentBox_L.Value;                                                             //--content-box
                var t = (int)UpDown_ContentBox_T.Value;
                var w = (int)UpDown_ContentBox_W.Value;
                var h = (int)UpDown_ContentBox_H.Value;
                if ((l | t | w | h) > 0)
                {
                    cmd += I_ContentBox + "=" + l + "x" + t + ":" + w + "x" + h + "\r\n--";
                }
                w = (int)UpDown_PageDetectionBox_W.Value;                                                           //--page-detection-box
                h = (int)UpDown_PageDetectionBox_H.Value;
                if ((w | h) > 0)
                {
                    cmd += I_PageDetectionBox + "=" + w + "x" + h + "\r\n--";
                }
                td = UpDown_PageDetectionTolerance.Value;                                                           //--page-detection-tolerance
                if (td != 0) cmd += I_PageDetectionTolerance + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                if (CheckB_EnableAutoMargins.Checked) cmd += I_EnableAutoMargins + "\r\n--";                        //--enable-auto-margins
                td = UpDown_Margins.Value;                                                                          //--margins
                if (td != 0) cmd += I_Margins + "=" + td + "\r\n--";
                td = UpDown_Margins_L.Value;                                                                        //--margins-left
                if (td != 0) cmd += I_MarginsLeft + "=" + td + "\r\n--";
                td = UpDown_Margins_R.Value;                                                                        //--margins-right
                if (td != 0) cmd += I_MarginsRight + "=" + td + "\r\n--";
                td = UpDown_Margins_T.Value;                                                                        //--margins-top
                if (td != 0) cmd += I_MarginsTop + "=" + td + "\r\n--";
                td = UpDown_Margins_B.Value;                                                                        //--margins-bottom
                if (td != 0) cmd += I_MarginsBottom + "=" + td + "\r\n--";
                td = UpDown_DefaultMargins.Value;                                                                   //--default-margins
                if (td != 0) cmd += I_DefaultMargins + "=" + td + "\r\n--";
                td = UpDown_DefaultMargins_L.Value;                                                                 //--default-margins-left
                if (td != 0) cmd += I_DefaultMarginsLeft + "=" + td + "\r\n--";
                td = UpDown_DefaultMargins_R.Value;                                                                 //--default-margins-right
                if (td != 0) cmd += I_DefaultMarginsRight + "=" + td + "\r\n--";
                td = UpDown_DefaultMargins_T.Value;                                                                 //--default-margins-top
                if (td != 0) cmd += I_DefaultMarginsTop + "=" + td + "\r\n--";
                td = UpDown_DefaultMargins_B.Value;                                                                 //--default-margins-bottom
                if (td != 0) cmd += I_DefaultMarginsBottom + "=" + td + "\r\n--";
                tst = CB_Alignment.Text;                                                                            //--alignment
                if (tst != String.Empty) cmd += I_Alignment + "=" + tst + "\r\n--";
                tst = CB_AlignmentVertical.Text;                                                                    //--alignment-vertical
                if (tst != String.Empty) cmd += I_AlignmentVertical + "=" + tst + "\r\n--";
                tst = CB_AlignmentHorizontal.Text;                                                                  //--alignment-horizontal
                if (tst != String.Empty) cmd += I_AlignmentHorizontal + "=" + tst + "\r\n--";
                td = UpDown_AlignmentTolerance.Value;                                                               //--alignment-tolerance
                if (td != 0) cmd += I_AlignmentTolerance + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                td = UpDown_DepthPerception.Value;                                                                  //--depth-perception
                if (td != 0) cmd += I_DepthPerception + "=" + td.ToString(new CultureInfo("en-US")) + "\r\n--";
                if (CheckB_WhiteMargins.Checked) cmd += I_WhiteMargins + "\r\n--";                                  //--white-margins
                if (CheckB_NormalizeIllumination.Checked) cmd += I_NormalizeIllumination + "\r\n--";                //--normalize-illumination
                td = UpDown_Treshold.Value;                                                                         //--threshold
                if (td != 0) cmd += I_Threshold + "=" + td + "\r\n--";
                tst = CB_Despeckle.Text;                                                                            //--despeckle
                if (tst != String.Empty) cmd += I_Despeckle + "=" + tst + "\r\n--";
                tst = CB_Dewarping.Text;                                                                            //--dewarping
                if (tst != String.Empty) cmd += I_Dewarping + "=" + tst + "\r\n--";
                tst = CB_PictureShape.Text;                                                                         //--picture-shape
                if (tst != String.Empty) cmd += I_PictureShape + "=" + tst + "\r\n--";
                td = UpDown_OutputDPI.Value;                                                                        //--output-dpi
                if (td != 0) cmd += I_OutputDPI + "=" + td + "\r\n--";
                td = UpDown_OutputDPI_X.Value;                                                                      //--output-dpi-x
                if (td != 0) cmd += I_OutputDPIX + "=" + td + "\r\n--";
                td = UpDown_OutputDPI_Y.Value;                                                                      //--output-dpi-y
                if (td != 0) cmd += I_OutputDPIY + "=" + td + "\r\n--";
                td = UpDown_DefaultOutputDPI.Value;                                                                 //--default-output-dpi
                if (td != 0) cmd += I_DefaultOutputDPI + "=" + td + "\r\n--";
                if (CheckB_TiffForceRGB.Checked) cmd += I_TiffForceRGB + "\r\n--";                                  //--tiff-force-rgb
                if (CheckB_TiffForceGrayscale.Checked) cmd += I_TiffForceGrayscale + "\r\n--";                      //--tiff-force-grayscale
                if (CheckB_TiffForceKeepColorSpace.Checked) cmd += I_TiffForceKeepColorSpace + "\r\n--";            //--tiff-force-keep-color-space
                tst = CB_ColorMode.Text;                                                                            //--color-mode
                if (tst != String.Empty) cmd += I_ColorMode + "=" + tst + "\r\n--";
                tst = CB_DefaultColorMode.Text;                                                                     //--default-color-mode
                if (tst != String.Empty) cmd += I_DefaultColorMode + "=" + tst + "\r\n--";
                tst = CB_TiffCompression.Text;                                                                      //--tiff-compression
                if (tst != String.Empty) cmd += I_TiffCompression + "=" + tst + "\r\n";
                cmd = cmd.TrimEnd('-');
                Text_CMD.Text = cmd;
                _CL = cmd.Replace("\r\n", " ");
            }
        }
        #region BackgroundWorker
        private void BW_CL_DoWork(object sender, DoWorkEventArgs e)
        {
            var numberOfCores = Environment.ProcessorCount;
            if (!_ProjectImageMode)
            {
                #region IrfanView Rotate
                if ((_UseIW) && (_ApplyRotateTo > 0) && (_Filter0 <= 1))
                {
                    var images = Directory.GetFiles(_InputDirectory, "*.*", SearchOption.AllDirectories);
                    BW_CL.ReportProgress(4, "Pages:" + images.Length);
                    var ra = (int)_RotationAngle;
                    if (_DoParallel)
                    {
                        var ImageList = new List<ImgRecord>();
                        var lastbook = "";
                        var ic = 0;
                        foreach (var image in images)
                        {
                            var book = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(image));
                            if (book != lastbook)
                            {
                                ic = 0;
                                lastbook = book;
                            }
                            ic++;
                            var ir = new ImgRecord();
                            ir.imgc = ic;
                            ir.img = image;
                            ImageList.Add(ir);
                        }
                        Parallel.ForEach(ImageList, new ParallelOptions { MaxDegreeOfParallelism = numberOfCores }, image =>
                        {
                            var cliw = image.img;
                            var ora = 0;
                            if (Path.GetExtension(image.img).ToLower() == ".jpg")
                            {
                                cliw += " /jpg_rotate=(";
                                ora = JPGRotationString(image.imgc, ref cliw);
                                if (ora != 0)
                                {
                                    ExecuteIW(image.img, cliw, IWRotationOptionToRotationAngle(ora));
                                }
                            }
                            else
                            {
                                ora = ra;
                                if (NonJPGRotationString(ref ora, image.imgc, ref cliw))
                                {
                                    cliw += image.img + " /cmdexit";
                                    ExecuteIW(image.img, cliw, ora);
                                }

                            }
                        });
                    }
                    else // Using single thread
                    {
                        var ic = 0;
                        string lastbook = "";
                        foreach (var image in images)
                        {
                            var book = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(image));
                            if (book != lastbook)
                            {
                                ic = 0;
                                lastbook = book;
                            }
                            ic++;
                            var ora = 0;
                            var cliw = image;
                            if (Path.GetExtension(image).ToLower() == ".jpg")
                            {
                                cliw += " /jpg_rotate=(";
                                ora = JPGRotationString(ic, ref cliw);
                                if (ora != 0)
                                {
                                    ExecuteIW(image, cliw, IWRotationOptionToRotationAngle(ora));
                                }

                            }
                            else
                            {
                                ora = ra;
                                if (NonJPGRotationString(ref ora, ic, ref cliw))
                                {
                                    cliw += image + " /cmdexit";
                                    ExecuteIW(image, cliw, ora);
                                }

                            }
                        }
                    }
                    if (_Filter0 == 0) return;  // With Start-Filter = 0 we can skip project creation steps after rotation
                    BW_CL.ReportProgress(2, "...rotation completed\r\n");
                }
                #endregion
                var books = Directory.GetDirectories(_InputDirectory);
                if (_DoParallel)
                {
                    Parallel.ForEach(books, new ParallelOptions { MaxDegreeOfParallelism = numberOfCores }, bookdir =>
                    {
                        ExecuteSTP(bookdir);
                    });
                }
                else
                {
                    foreach (var bookdir in books)
                    {
                        ExecuteSTP(bookdir);
                    }
                }
            }
            else
            {
                var projects = Directory.GetFiles(_InputDirectory, "*.ScanTailor");
                if (_DoParallel)
                {
                    Parallel.ForEach(projects, new ParallelOptions { MaxDegreeOfParallelism = numberOfCores }, project =>
                    {
                        ExecuteST(project);
                    });
                }
                else
                {
                    foreach (var project in projects)
                    {
                        ExecuteST(project);
                    }
                }

            }
        }
        private int GetIWRotationOption()
        {
            var ra = (int)_RotationAngle;
            var ro = 0;
            switch (ra)
            {
                case 90:
                    ro = 3;
                    break;
                case 180:
                    ro = 4;
                    break;
                case 270:
                    ro = 5;
                    break;
            }
            return ro;
        }
        private int IWRotationOptionToRotationAngle(int ro)
        {
            var ra = 0;
            switch (ro)
            {
                case 3:
                    ra = 90;
                    break;
                case 4:
                    ra = 180;
                    break;
                case 5:
                    ra = 270;
                    break;
            }
            return ra;
        }
        private int JPGRotationString(int ic, ref string cliw)
        {
            var ora = GetIWRotationOption();
            if (ora != 0)
            {
                if (_ApplyRotateTo == 2)
                {
                    if (ic%2 == 0)
                    {
                        switch (ora)
                        {
                            case 3:
                                ora = 5;
                                break;
                            case 5:
                                ora = 3;
                                break;
                        }
                    }
                }
                cliw += ora + ",1,0,1,";
                if (_DPI != 0)
                {
                    cliw += "1," + _DPI;
                }
                else
                {
                    cliw += "0,0";
                }
                cliw += ",0,0) /cmdexit";
            }
            return ora;
        }
        private bool NonJPGRotationString(ref int ora, int ic,ref string cliw)
        {
            if (_ApplyRotateTo == 2)
            {
                if (ic % 2 == 0)
                {
                    switch (ora)
                    {
                        case 90:
                            ora = 270;
                            break;
                        case 270:
                            ora = 90;
                            break;
                    }
                }
            }
            var changed = true;
            switch (ora)
            {
                case 90:
                    cliw += " /rotate_r";
                    break;
                case 180:
                    cliw += " /hflip /vflip";
                    break;
                case 270:
                    cliw += " /rotate_l";
                    break;
                default:
                    changed = false;
                    break;
            }
            if (changed)
            {
                if (_DPI != 0)
                {
                    cliw += " /dpi=(" + _DPI + "," + _DPI + ")";
                }
                cliw += " /convert=";
            }
            return changed;
        }
        private void ExecuteIW(string image, string cliw, int ora)
        {
            var sout = Path.GetFileName(image) + "(" + ora + ")";
            var book = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(image));
            sout = book + ">" + sout;
            if (_Verbose) BW_CL.ReportProgress(2, cliw);
            BW_CL.ReportProgress(3, sout);
            var pST_IW = Process.Start(_IrfanView, cliw);
            pST_IW.WaitForExit();            
        }
        private void ExecuteST(string project)
        {
            var book = Path.GetFileNameWithoutExtension(Path.GetDirectoryName(project + "\\"));
            var outdir = _OutputDirectory + "\\" + book + "\\";
            Directory.CreateDirectory(outdir);
            var cli = _CL + project + " " + outdir;
            if (_Verbose) BW_CL.ReportProgress(2, cli);
            BW_CL.ReportProgress(2, book);
            var pST_CLI = Process.Start(_ScanTailor_CLI, cli);
            pST_CLI.WaitForExit();
            
        }
        private void ExecuteSTP(string bookdir)
        {
            var book = Path.GetFileName(Path.GetDirectoryName(bookdir + "\\"));
            var outdir = _OutputDirectory + "\\" + book + "\\";
            Directory.CreateDirectory(outdir);
            var cli = _CL + "--output-project=" + _OutputDirectory + "\\" + book + ".ScanTailor " + bookdir + "\\ " + outdir + "";
            if (_Verbose) BW_CL.ReportProgress(2, cli);
            BW_CL.ReportProgress(2, book);
            var pST_CLI = Process.Start(_ScanTailor_CLI, cli);
            pST_CLI.WaitForExit();            
        }
        private void BW_CL_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    Text_Output.AppendText((string)e.UserState);
                    break;
                case 2:
                    Text_Output.AppendText("\r\n" + (string)e.UserState);
                    break;
                case 3:
                    //Interlocked.Increment(ref _ImgCounter); necessary ?
                    _ImgCounter++;
                    Text_Output.AppendText("\r\n" + _ImgCounter.ToString("D5") + ":" + (string)e.UserState);
                    break;
                case 4:
                    Text_CMD.AppendText("\r\n" + (string)e.UserState);
                    break;
            }
        }
        private void BW_CL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Text_Output.AppendText("\r\n...Completed!");
            Button_Start.Text = "Start";
        }
        #endregion
    }
}
