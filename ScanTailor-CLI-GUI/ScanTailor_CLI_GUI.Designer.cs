namespace ScanTailor_CLI_GUI
{
    partial class Form_ScanTailor_CLI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ScanTailor_CLI));
            this.Label_InputDir = new System.Windows.Forms.Label();
            this.Label_OutputDir = new System.Windows.Forms.Label();
            this.Text_InputDir = new System.Windows.Forms.TextBox();
            this.Text_OutputDir = new System.Windows.Forms.TextBox();
            this.Button_InputDir = new System.Windows.Forms.Button();
            this.Button_OutputDir = new System.Windows.Forms.Button();
            this.FBD_InputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD_OutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.GB_FileANDControl = new System.Windows.Forms.GroupBox();
            this.Button_IrfanViewExe = new System.Windows.Forms.Button();
            this.Text_IrfanViewExe = new System.Windows.Forms.TextBox();
            this.Label_IrfanView = new System.Windows.Forms.Label();
            this.CheckB_ProjectORImageMode = new System.Windows.Forms.CheckBox();
            this.Label_DPI = new System.Windows.Forms.Label();
            this.UpDown_DPI = new System.Windows.Forms.NumericUpDown();
            this.Label_DPI_XY = new System.Windows.Forms.Label();
            this.UpDown_DPI_X = new System.Windows.Forms.NumericUpDown();
            this.UpDown_DPI_Y = new System.Windows.Forms.NumericUpDown();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Label_Profile = new System.Windows.Forms.Label();
            this.CB_Profile = new System.Windows.Forms.ComboBox();
            this.Button_ScanTailorExe = new System.Windows.Forms.Button();
            this.Text_ScanTailor_CLI = new System.Windows.Forms.TextBox();
            this.Label_ScanTailor_CLI = new System.Windows.Forms.Label();
            this.UpDown_EndFilter = new System.Windows.Forms.NumericUpDown();
            this.Label_EndFilter = new System.Windows.Forms.Label();
            this.Label_StartFilter = new System.Windows.Forms.Label();
            this.UpDown_StartFilter = new System.Windows.Forms.NumericUpDown();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Label_Layout = new System.Windows.Forms.Label();
            this.GB_CLs = new System.Windows.Forms.GroupBox();
            this.GB_04 = new System.Windows.Forms.GroupBox();
            this.Label_ContentDeviation = new System.Windows.Forms.Label();
            this.CheckB_DisableContentDetection = new System.Windows.Forms.CheckBox();
            this.CheckB_EnablePageDetection = new System.Windows.Forms.CheckBox();
            this.UpDown_ContentBox_W = new System.Windows.Forms.NumericUpDown();
            this.CheckB_EnableFineTuning = new System.Windows.Forms.CheckBox();
            this.UpDown_PageDetectionTolerance = new System.Windows.Forms.NumericUpDown();
            this.CheckB_ForceDisablePageDetection = new System.Windows.Forms.CheckBox();
            this.UpDown_ContentBox_H = new System.Windows.Forms.NumericUpDown();
            this.CheckB_DisableContentTextMask = new System.Windows.Forms.CheckBox();
            this.Label_ContentBoxWH = new System.Windows.Forms.Label();
            this.Label_PageDetectionTolerance = new System.Windows.Forms.Label();
            this.UpDown_ContentBox_T = new System.Windows.Forms.NumericUpDown();
            this.UpDown_ContentBox_L = new System.Windows.Forms.NumericUpDown();
            this.UpDown_PageDetectionBox_H = new System.Windows.Forms.NumericUpDown();
            this.Label_ContentBoxLT = new System.Windows.Forms.Label();
            this.UpDown_ContentDeviation = new System.Windows.Forms.NumericUpDown();
            this.UpDown_PageDetectionBox_W = new System.Windows.Forms.NumericUpDown();
            this.CB_ContentDetection = new System.Windows.Forms.ComboBox();
            this.Label_ContentDetection = new System.Windows.Forms.Label();
            this.Label_PageDetectionBox = new System.Windows.Forms.Label();
            this.GB_02 = new System.Windows.Forms.GroupBox();
            this.Label_LayoutDirection = new System.Windows.Forms.Label();
            this.CB_LayoutDirection = new System.Windows.Forms.ComboBox();
            this.MCCB_Layout = new ComboBoxMC.ComboBoxMC();
            this.Label_Orientation = new System.Windows.Forms.Label();
            this.CB_Orientation = new System.Windows.Forms.ComboBox();
            this.CheckB_MatchLayoutDefault = new System.Windows.Forms.CheckBox();
            this.CheckB_MatchLayout = new System.Windows.Forms.CheckBox();
            this.Label_MatchLayoutTolerance = new System.Windows.Forms.Label();
            this.UpDown_MatchLayoutTolerance = new System.Windows.Forms.NumericUpDown();
            this.GB_05 = new System.Windows.Forms.GroupBox();
            this.Label_Margins_LR = new System.Windows.Forms.Label();
            this.CheckB_EnableAutoMargins = new System.Windows.Forms.CheckBox();
            this.UpDown_AlignmentTolerance = new System.Windows.Forms.NumericUpDown();
            this.Label_Margins = new System.Windows.Forms.Label();
            this.Label_AlignmentTolerance = new System.Windows.Forms.Label();
            this.UpDown_Margins = new System.Windows.Forms.NumericUpDown();
            this.CB_AlignmentHorizontal = new System.Windows.Forms.ComboBox();
            this.UpDown_Margins_L = new System.Windows.Forms.NumericUpDown();
            this.UpDown_Margins_R = new System.Windows.Forms.NumericUpDown();
            this.Label_AlignmentHorizontal = new System.Windows.Forms.Label();
            this.Label_Margins_TB = new System.Windows.Forms.Label();
            this.CB_AlignmentVertical = new System.Windows.Forms.ComboBox();
            this.UpDown_Margins_T = new System.Windows.Forms.NumericUpDown();
            this.Label_AlignmentVertical = new System.Windows.Forms.Label();
            this.UpDown_Margins_B = new System.Windows.Forms.NumericUpDown();
            this.CB_Alignment = new System.Windows.Forms.ComboBox();
            this.Label_DefaultMargins = new System.Windows.Forms.Label();
            this.Label_Alignment = new System.Windows.Forms.Label();
            this.UpDown_DefaultMargins = new System.Windows.Forms.NumericUpDown();
            this.Label_DefaultMargins_LR = new System.Windows.Forms.Label();
            this.UpDown_DefaultMargins_L = new System.Windows.Forms.NumericUpDown();
            this.UpDown_DefaultMargins_R = new System.Windows.Forms.NumericUpDown();
            this.Label_DefaultMargins_TB = new System.Windows.Forms.Label();
            this.UpDown_DefaultMargins_T = new System.Windows.Forms.NumericUpDown();
            this.UpDown_DefaultMargins_B = new System.Windows.Forms.NumericUpDown();
            this.UpDown_Rotate = new System.Windows.Forms.NumericUpDown();
            this.CheckB_DisableCheckOutput = new System.Windows.Forms.CheckBox();
            this.CheckB_Verbose = new System.Windows.Forms.CheckBox();
            this.Label_Rotate = new System.Windows.Forms.Label();
            this.GB_01 = new System.Windows.Forms.GroupBox();
            this.Label_RotateApplyTo = new System.Windows.Forms.Label();
            this.CB_ApplyRotateTo = new System.Windows.Forms.ComboBox();
            this.CheckB_UseIrfanView = new System.Windows.Forms.CheckBox();
            this.GB_03 = new System.Windows.Forms.GroupBox();
            this.Label_SkewDeviation = new System.Windows.Forms.Label();
            this.UpDown_SkewDeviation = new System.Windows.Forms.NumericUpDown();
            this.CB_Deskew = new System.Windows.Forms.ComboBox();
            this.Label_Deskew = new System.Windows.Forms.Label();
            this.GB_06 = new System.Windows.Forms.GroupBox();
            this.Label_OutputDPI_XY = new System.Windows.Forms.Label();
            this.CB_TiffCompression = new System.Windows.Forms.ComboBox();
            this.Label_TiffCompression = new System.Windows.Forms.Label();
            this.CheckB_TiffForceKeepColorSpace = new System.Windows.Forms.CheckBox();
            this.CheckB_TiffForceGrayscale = new System.Windows.Forms.CheckBox();
            this.CheckB_TiffForceRGB = new System.Windows.Forms.CheckBox();
            this.Label_OutputDPI = new System.Windows.Forms.Label();
            this.UpDown_OutputDPI = new System.Windows.Forms.NumericUpDown();
            this.UpDown_OutputDPI_X = new System.Windows.Forms.NumericUpDown();
            this.UpDown_OutputDPI_Y = new System.Windows.Forms.NumericUpDown();
            this.Label_DefaultOutputDPI = new System.Windows.Forms.Label();
            this.UpDown_DepthPerception = new System.Windows.Forms.NumericUpDown();
            this.UpDown_DefaultOutputDPI = new System.Windows.Forms.NumericUpDown();
            this.Label_DepthPerception = new System.Windows.Forms.Label();
            this.Label_ColorMode = new System.Windows.Forms.Label();
            this.CB_Dewarping = new System.Windows.Forms.ComboBox();
            this.CB_ColorMode = new System.Windows.Forms.ComboBox();
            this.CheckB_WhiteMargins = new System.Windows.Forms.CheckBox();
            this.Label_Dewarping = new System.Windows.Forms.Label();
            this.Label_DefaultColorMode = new System.Windows.Forms.Label();
            this.CB_Despeckle = new System.Windows.Forms.ComboBox();
            this.CB_DefaultColorMode = new System.Windows.Forms.ComboBox();
            this.Label_Despeckle = new System.Windows.Forms.Label();
            this.Label_PictureShape = new System.Windows.Forms.Label();
            this.UpDown_Treshold = new System.Windows.Forms.NumericUpDown();
            this.CB_PictureShape = new System.Windows.Forms.ComboBox();
            this.Label_Threshold = new System.Windows.Forms.Label();
            this.CheckB_NormalizeIllumination = new System.Windows.Forms.CheckBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.TT_STCLI = new System.Windows.Forms.ToolTip(this.components);
            this.CheckB_Parallel = new System.Windows.Forms.CheckBox();
            this.OFD_ScanTailor_exe = new System.Windows.Forms.OpenFileDialog();
            this.GB_Output = new System.Windows.Forms.GroupBox();
            this.CheckB_VerboseGUI = new System.Windows.Forms.CheckBox();
            this.Text_CMD = new System.Windows.Forms.TextBox();
            this.Text_Output = new System.Windows.Forms.TextBox();
            this.Button_CopyCL = new System.Windows.Forms.Button();
            this.OFD_i_view32_exe = new System.Windows.Forms.OpenFileDialog();
            this.GB_FileANDControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_EndFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_StartFilter)).BeginInit();
            this.GB_CLs.SuspendLayout();
            this.GB_04.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionBox_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionBox_W)).BeginInit();
            this.GB_02.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_MatchLayoutTolerance)).BeginInit();
            this.GB_05.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_AlignmentTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Rotate)).BeginInit();
            this.GB_01.SuspendLayout();
            this.GB_03.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_SkewDeviation)).BeginInit();
            this.GB_06.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DepthPerception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultOutputDPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Treshold)).BeginInit();
            this.GB_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_InputDir
            // 
            this.Label_InputDir.AutoSize = true;
            this.Label_InputDir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InputDir.Location = new System.Drawing.Point(7, 15);
            this.Label_InputDir.Name = "Label_InputDir";
            this.Label_InputDir.Size = new System.Drawing.Size(109, 13);
            this.Label_InputDir.TabIndex = 0;
            this.Label_InputDir.Text = "Input Directory :";
            // 
            // Label_OutputDir
            // 
            this.Label_OutputDir.AutoSize = true;
            this.Label_OutputDir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OutputDir.Location = new System.Drawing.Point(7, 39);
            this.Label_OutputDir.Name = "Label_OutputDir";
            this.Label_OutputDir.Size = new System.Drawing.Size(109, 13);
            this.Label_OutputDir.TabIndex = 1;
            this.Label_OutputDir.Text = "Output Directory:";
            // 
            // Text_InputDir
            // 
            this.Text_InputDir.Location = new System.Drawing.Point(122, 12);
            this.Text_InputDir.Name = "Text_InputDir";
            this.Text_InputDir.ReadOnly = true;
            this.Text_InputDir.Size = new System.Drawing.Size(407, 20);
            this.Text_InputDir.TabIndex = 2;
            // 
            // Text_OutputDir
            // 
            this.Text_OutputDir.Location = new System.Drawing.Point(122, 36);
            this.Text_OutputDir.Name = "Text_OutputDir";
            this.Text_OutputDir.ReadOnly = true;
            this.Text_OutputDir.Size = new System.Drawing.Size(407, 20);
            this.Text_OutputDir.TabIndex = 3;
            // 
            // Button_InputDir
            // 
            this.Button_InputDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_InputDir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_InputDir.Location = new System.Drawing.Point(535, 11);
            this.Button_InputDir.Name = "Button_InputDir";
            this.Button_InputDir.Size = new System.Drawing.Size(38, 23);
            this.Button_InputDir.TabIndex = 4;
            this.Button_InputDir.Text = "...";
            this.Button_InputDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_InputDir.UseVisualStyleBackColor = true;
            this.Button_InputDir.Click += new System.EventHandler(this.Button_InputDir_Click);
            // 
            // Button_OutputDir
            // 
            this.Button_OutputDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_OutputDir.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_OutputDir.Location = new System.Drawing.Point(535, 34);
            this.Button_OutputDir.Name = "Button_OutputDir";
            this.Button_OutputDir.Size = new System.Drawing.Size(38, 23);
            this.Button_OutputDir.TabIndex = 5;
            this.Button_OutputDir.Text = "...";
            this.Button_OutputDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OutputDir.UseVisualStyleBackColor = true;
            this.Button_OutputDir.Click += new System.EventHandler(this.Button_OutputDir_Click);
            // 
            // FBD_InputDir
            // 
            this.FBD_InputDir.Description = "Select the input directory!";
            // 
            // FBD_OutputDir
            // 
            this.FBD_OutputDir.Description = "Select the output directory!";
            // 
            // GB_FileANDControl
            // 
            this.GB_FileANDControl.Controls.Add(this.Button_IrfanViewExe);
            this.GB_FileANDControl.Controls.Add(this.Text_IrfanViewExe);
            this.GB_FileANDControl.Controls.Add(this.Label_IrfanView);
            this.GB_FileANDControl.Controls.Add(this.CheckB_ProjectORImageMode);
            this.GB_FileANDControl.Controls.Add(this.Label_DPI);
            this.GB_FileANDControl.Controls.Add(this.UpDown_DPI);
            this.GB_FileANDControl.Controls.Add(this.Label_DPI_XY);
            this.GB_FileANDControl.Controls.Add(this.UpDown_DPI_X);
            this.GB_FileANDControl.Controls.Add(this.UpDown_DPI_Y);
            this.GB_FileANDControl.Controls.Add(this.Button_Delete);
            this.GB_FileANDControl.Controls.Add(this.Button_Save);
            this.GB_FileANDControl.Controls.Add(this.Label_Profile);
            this.GB_FileANDControl.Controls.Add(this.CB_Profile);
            this.GB_FileANDControl.Controls.Add(this.Button_ScanTailorExe);
            this.GB_FileANDControl.Controls.Add(this.Text_ScanTailor_CLI);
            this.GB_FileANDControl.Controls.Add(this.Label_ScanTailor_CLI);
            this.GB_FileANDControl.Controls.Add(this.Button_OutputDir);
            this.GB_FileANDControl.Controls.Add(this.Button_InputDir);
            this.GB_FileANDControl.Controls.Add(this.Text_OutputDir);
            this.GB_FileANDControl.Controls.Add(this.Text_InputDir);
            this.GB_FileANDControl.Controls.Add(this.UpDown_EndFilter);
            this.GB_FileANDControl.Controls.Add(this.Label_OutputDir);
            this.GB_FileANDControl.Controls.Add(this.Label_InputDir);
            this.GB_FileANDControl.Controls.Add(this.Label_EndFilter);
            this.GB_FileANDControl.Controls.Add(this.Label_StartFilter);
            this.GB_FileANDControl.Controls.Add(this.UpDown_StartFilter);
            this.GB_FileANDControl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FileANDControl.Location = new System.Drawing.Point(11, 9);
            this.GB_FileANDControl.Name = "GB_FileANDControl";
            this.GB_FileANDControl.Size = new System.Drawing.Size(592, 161);
            this.GB_FileANDControl.TabIndex = 6;
            this.GB_FileANDControl.TabStop = false;
            this.GB_FileANDControl.Text = "Data I/O";
            // 
            // Button_IrfanViewExe
            // 
            this.Button_IrfanViewExe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_IrfanViewExe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_IrfanViewExe.Location = new System.Drawing.Point(375, 80);
            this.Button_IrfanViewExe.Name = "Button_IrfanViewExe";
            this.Button_IrfanViewExe.Size = new System.Drawing.Size(38, 23);
            this.Button_IrfanViewExe.TabIndex = 113;
            this.Button_IrfanViewExe.Text = "...";
            this.Button_IrfanViewExe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_IrfanViewExe.UseVisualStyleBackColor = true;
            this.Button_IrfanViewExe.Click += new System.EventHandler(this.Button_IrfanViewExe_Click);
            // 
            // Text_IrfanViewExe
            // 
            this.Text_IrfanViewExe.Location = new System.Drawing.Point(122, 83);
            this.Text_IrfanViewExe.Name = "Text_IrfanViewExe";
            this.Text_IrfanViewExe.ReadOnly = true;
            this.Text_IrfanViewExe.Size = new System.Drawing.Size(247, 20);
            this.Text_IrfanViewExe.TabIndex = 112;
            // 
            // Label_IrfanView
            // 
            this.Label_IrfanView.AutoSize = true;
            this.Label_IrfanView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_IrfanView.Location = new System.Drawing.Point(7, 87);
            this.Label_IrfanView.Name = "Label_IrfanView";
            this.Label_IrfanView.Size = new System.Drawing.Size(109, 13);
            this.Label_IrfanView.TabIndex = 111;
            this.Label_IrfanView.Text = "IrfanView       :";
            // 
            // CheckB_ProjectORImageMode
            // 
            this.CheckB_ProjectORImageMode.AutoSize = true;
            this.CheckB_ProjectORImageMode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_ProjectORImageMode.Location = new System.Drawing.Point(419, 61);
            this.CheckB_ProjectORImageMode.Name = "CheckB_ProjectORImageMode";
            this.CheckB_ProjectORImageMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_ProjectORImageMode.Size = new System.Drawing.Size(152, 18);
            this.CheckB_ProjectORImageMode.TabIndex = 110;
            this.CheckB_ProjectORImageMode.Text = "Project/Image mode";
            this.TT_STCLI.SetToolTip(this.CheckB_ProjectORImageMode, "Image mode (unchecked) = Creates \"*.ScanTailor\" projects from images\r\nProject mod" +
        "e (checked) = Loads \"*.ScanTailor\" projects and creates images if filter 6 is gi" +
        "ven.");
            this.CheckB_ProjectORImageMode.UseVisualStyleBackColor = true;
            // 
            // Label_DPI
            // 
            this.Label_DPI.AutoSize = true;
            this.Label_DPI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DPI.Location = new System.Drawing.Point(215, 138);
            this.Label_DPI.Name = "Label_DPI";
            this.Label_DPI.Size = new System.Drawing.Size(31, 13);
            this.Label_DPI.TabIndex = 63;
            this.Label_DPI.Text = "DPI:";
            this.TT_STCLI.SetToolTip(this.Label_DPI, "If set the content detection is set to manual mode");
            // 
            // UpDown_DPI
            // 
            this.UpDown_DPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DPI.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DPI.Location = new System.Drawing.Point(250, 134);
            this.UpDown_DPI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_DPI.Name = "UpDown_DPI";
            this.UpDown_DPI.Size = new System.Drawing.Size(60, 20);
            this.UpDown_DPI.TabIndex = 64;
            this.TT_STCLI.SetToolTip(this.UpDown_DPI, "default : 600; Sets X and X dpi");
            this.UpDown_DPI.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DPI_XY
            // 
            this.Label_DPI_XY.AutoSize = true;
            this.Label_DPI_XY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DPI_XY.Location = new System.Drawing.Point(316, 137);
            this.Label_DPI_XY.Name = "Label_DPI_XY";
            this.Label_DPI_XY.Size = new System.Drawing.Size(67, 13);
            this.Label_DPI_XY.TabIndex = 65;
            this.Label_DPI_XY.Text = "DPI-(X&Y):";
            this.Label_DPI_XY.UseMnemonic = false;
            // 
            // UpDown_DPI_X
            // 
            this.UpDown_DPI_X.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DPI_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DPI_X.Location = new System.Drawing.Point(389, 133);
            this.UpDown_DPI_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_DPI_X.Name = "UpDown_DPI_X";
            this.UpDown_DPI_X.Size = new System.Drawing.Size(60, 20);
            this.UpDown_DPI_X.TabIndex = 66;
            this.TT_STCLI.SetToolTip(this.UpDown_DPI_X, "X-DPI");
            this.UpDown_DPI_X.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_DPI_Y
            // 
            this.UpDown_DPI_Y.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DPI_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DPI_Y.Location = new System.Drawing.Point(455, 133);
            this.UpDown_DPI_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_DPI_Y.Name = "UpDown_DPI_Y";
            this.UpDown_DPI_Y.Size = new System.Drawing.Size(60, 20);
            this.UpDown_DPI_Y.TabIndex = 67;
            this.TT_STCLI.SetToolTip(this.UpDown_DPI_Y, "Y-DPI");
            this.UpDown_DPI_Y.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Delete.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.Location = new System.Drawing.Point(535, 107);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(38, 23);
            this.Button_Delete.TabIndex = 11;
            this.Button_Delete.Text = "X";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Save.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(472, 107);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(57, 23);
            this.Button_Save.TabIndex = 10;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = false;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Label_Profile
            // 
            this.Label_Profile.AutoSize = true;
            this.Label_Profile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Profile.Location = new System.Drawing.Point(7, 112);
            this.Label_Profile.Name = "Label_Profile";
            this.Label_Profile.Size = new System.Drawing.Size(109, 13);
            this.Label_Profile.TabIndex = 10;
            this.Label_Profile.Text = "Profile         :";
            // 
            // CB_Profile
            // 
            this.CB_Profile.DropDownHeight = 300;
            this.CB_Profile.FormattingEnabled = true;
            this.CB_Profile.IntegralHeight = false;
            this.CB_Profile.Location = new System.Drawing.Point(122, 107);
            this.CB_Profile.Name = "CB_Profile";
            this.CB_Profile.Size = new System.Drawing.Size(344, 23);
            this.CB_Profile.TabIndex = 9;
            this.CB_Profile.SelectedValueChanged += new System.EventHandler(this.CB_Profile_SelectedValueChanged);
            // 
            // Button_ScanTailorExe
            // 
            this.Button_ScanTailorExe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_ScanTailorExe.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ScanTailorExe.Location = new System.Drawing.Point(375, 57);
            this.Button_ScanTailorExe.Name = "Button_ScanTailorExe";
            this.Button_ScanTailorExe.Size = new System.Drawing.Size(38, 23);
            this.Button_ScanTailorExe.TabIndex = 8;
            this.Button_ScanTailorExe.Text = "...";
            this.Button_ScanTailorExe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_ScanTailorExe.UseVisualStyleBackColor = true;
            this.Button_ScanTailorExe.Click += new System.EventHandler(this.Button_ScanTailorExe_Click);
            // 
            // Text_ScanTailor_CLI
            // 
            this.Text_ScanTailor_CLI.Location = new System.Drawing.Point(122, 59);
            this.Text_ScanTailor_CLI.Name = "Text_ScanTailor_CLI";
            this.Text_ScanTailor_CLI.ReadOnly = true;
            this.Text_ScanTailor_CLI.Size = new System.Drawing.Size(247, 20);
            this.Text_ScanTailor_CLI.TabIndex = 7;
            // 
            // Label_ScanTailor_CLI
            // 
            this.Label_ScanTailor_CLI.AutoSize = true;
            this.Label_ScanTailor_CLI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ScanTailor_CLI.Location = new System.Drawing.Point(7, 63);
            this.Label_ScanTailor_CLI.Name = "Label_ScanTailor_CLI";
            this.Label_ScanTailor_CLI.Size = new System.Drawing.Size(109, 13);
            this.Label_ScanTailor_CLI.TabIndex = 6;
            this.Label_ScanTailor_CLI.Text = "ScanTailor-CLI  :";
            // 
            // UpDown_EndFilter
            // 
            this.UpDown_EndFilter.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_EndFilter.Location = new System.Drawing.Point(179, 134);
            this.UpDown_EndFilter.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.UpDown_EndFilter.Name = "UpDown_EndFilter";
            this.UpDown_EndFilter.Size = new System.Drawing.Size(30, 20);
            this.UpDown_EndFilter.TabIndex = 94;
            this.TT_STCLI.SetToolTip(this.UpDown_EndFilter, "default : 6");
            this.UpDown_EndFilter.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_EndFilter
            // 
            this.Label_EndFilter.AutoSize = true;
            this.Label_EndFilter.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EndFilter.Location = new System.Drawing.Point(155, 137);
            this.Label_EndFilter.Name = "Label_EndFilter";
            this.Label_EndFilter.Size = new System.Drawing.Size(21, 14);
            this.Label_EndFilter.TabIndex = 93;
            this.Label_EndFilter.Text = "->";
            this.TT_STCLI.SetToolTip(this.Label_EndFilter, "If set the content detection is set to manual mode");
            // 
            // Label_StartFilter
            // 
            this.Label_StartFilter.AutoSize = true;
            this.Label_StartFilter.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StartFilter.Location = new System.Drawing.Point(7, 137);
            this.Label_StartFilter.Name = "Label_StartFilter";
            this.Label_StartFilter.Size = new System.Drawing.Size(109, 13);
            this.Label_StartFilter.TabIndex = 91;
            this.Label_StartFilter.Text = "Start-Filter    :";
            this.TT_STCLI.SetToolTip(this.Label_StartFilter, "If set the content detection is set to manual mode");
            // 
            // UpDown_StartFilter
            // 
            this.UpDown_StartFilter.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_StartFilter.Location = new System.Drawing.Point(122, 134);
            this.UpDown_StartFilter.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.UpDown_StartFilter.Name = "UpDown_StartFilter";
            this.UpDown_StartFilter.Size = new System.Drawing.Size(30, 20);
            this.UpDown_StartFilter.TabIndex = 92;
            this.TT_STCLI.SetToolTip(this.UpDown_StartFilter, "default : 4; To skip project creation steps after IrfanView rotation use 0.");
            this.UpDown_StartFilter.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.Lime;
            this.Button_Start.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start.Location = new System.Drawing.Point(258, 12);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(120, 23);
            this.Button_Start.TabIndex = 6;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Label_Layout
            // 
            this.Label_Layout.AutoSize = true;
            this.Label_Layout.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Layout.Location = new System.Drawing.Point(1, 16);
            this.Label_Layout.Name = "Label_Layout";
            this.Label_Layout.Size = new System.Drawing.Size(56, 14);
            this.Label_Layout.TabIndex = 7;
            this.Label_Layout.Text = "Layout:";
            // 
            // GB_CLs
            // 
            this.GB_CLs.Controls.Add(this.GB_04);
            this.GB_CLs.Controls.Add(this.GB_02);
            this.GB_CLs.Controls.Add(this.GB_05);
            this.GB_CLs.Controls.Add(this.UpDown_Rotate);
            this.GB_CLs.Controls.Add(this.CheckB_DisableCheckOutput);
            this.GB_CLs.Controls.Add(this.CheckB_Verbose);
            this.GB_CLs.Controls.Add(this.Label_Rotate);
            this.GB_CLs.Controls.Add(this.GB_01);
            this.GB_CLs.Controls.Add(this.GB_03);
            this.GB_CLs.Controls.Add(this.GB_06);
            this.GB_CLs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic);
            this.GB_CLs.Location = new System.Drawing.Point(11, 173);
            this.GB_CLs.Name = "GB_CLs";
            this.GB_CLs.Size = new System.Drawing.Size(592, 668);
            this.GB_CLs.TabIndex = 8;
            this.GB_CLs.TabStop = false;
            this.GB_CLs.Text = "CLs";
            // 
            // GB_04
            // 
            this.GB_04.Controls.Add(this.Label_ContentDeviation);
            this.GB_04.Controls.Add(this.CheckB_DisableContentDetection);
            this.GB_04.Controls.Add(this.CheckB_EnablePageDetection);
            this.GB_04.Controls.Add(this.UpDown_ContentBox_W);
            this.GB_04.Controls.Add(this.CheckB_EnableFineTuning);
            this.GB_04.Controls.Add(this.UpDown_PageDetectionTolerance);
            this.GB_04.Controls.Add(this.CheckB_ForceDisablePageDetection);
            this.GB_04.Controls.Add(this.UpDown_ContentBox_H);
            this.GB_04.Controls.Add(this.CheckB_DisableContentTextMask);
            this.GB_04.Controls.Add(this.Label_ContentBoxWH);
            this.GB_04.Controls.Add(this.Label_PageDetectionTolerance);
            this.GB_04.Controls.Add(this.UpDown_ContentBox_T);
            this.GB_04.Controls.Add(this.UpDown_ContentBox_L);
            this.GB_04.Controls.Add(this.UpDown_PageDetectionBox_H);
            this.GB_04.Controls.Add(this.Label_ContentBoxLT);
            this.GB_04.Controls.Add(this.UpDown_ContentDeviation);
            this.GB_04.Controls.Add(this.UpDown_PageDetectionBox_W);
            this.GB_04.Controls.Add(this.CB_ContentDetection);
            this.GB_04.Controls.Add(this.Label_ContentDetection);
            this.GB_04.Controls.Add(this.Label_PageDetectionBox);
            this.GB_04.Location = new System.Drawing.Point(5, 316);
            this.GB_04.Name = "GB_04";
            this.GB_04.Size = new System.Drawing.Size(276, 240);
            this.GB_04.TabIndex = 112;
            this.GB_04.TabStop = false;
            this.GB_04.Text = "(4)";
            // 
            // Label_ContentDeviation
            // 
            this.Label_ContentDeviation.AutoSize = true;
            this.Label_ContentDeviation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ContentDeviation.Location = new System.Drawing.Point(1, 128);
            this.Label_ContentDeviation.Name = "Label_ContentDeviation";
            this.Label_ContentDeviation.Size = new System.Drawing.Size(133, 14);
            this.Label_ContentDeviation.TabIndex = 26;
            this.Label_ContentDeviation.Text = "Content-Deviation:";
            // 
            // CheckB_DisableContentDetection
            // 
            this.CheckB_DisableContentDetection.AutoSize = true;
            this.CheckB_DisableContentDetection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_DisableContentDetection.Location = new System.Drawing.Point(1, 13);
            this.CheckB_DisableContentDetection.Name = "CheckB_DisableContentDetection";
            this.CheckB_DisableContentDetection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_DisableContentDetection.Size = new System.Drawing.Size(222, 18);
            this.CheckB_DisableContentDetection.TabIndex = 19;
            this.CheckB_DisableContentDetection.Text = "   Disable-Content-Detection";
            this.TT_STCLI.SetToolTip(this.CheckB_DisableContentDetection, "default: enabled");
            this.CheckB_DisableContentDetection.UseVisualStyleBackColor = true;
            this.CheckB_DisableContentDetection.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_EnablePageDetection
            // 
            this.CheckB_EnablePageDetection.AutoSize = true;
            this.CheckB_EnablePageDetection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_EnablePageDetection.Location = new System.Drawing.Point(1, 48);
            this.CheckB_EnablePageDetection.Name = "CheckB_EnablePageDetection";
            this.CheckB_EnablePageDetection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_EnablePageDetection.Size = new System.Drawing.Size(222, 18);
            this.CheckB_EnablePageDetection.TabIndex = 20;
            this.CheckB_EnablePageDetection.Text = "       Enable-Page-Detection";
            this.TT_STCLI.SetToolTip(this.CheckB_EnablePageDetection, "default : disabled");
            this.CheckB_EnablePageDetection.UseVisualStyleBackColor = true;
            this.CheckB_EnablePageDetection.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_ContentBox_W
            // 
            this.UpDown_ContentBox_W.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_ContentBox_W.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_ContentBox_W.Location = new System.Drawing.Point(134, 171);
            this.UpDown_ContentBox_W.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_ContentBox_W.Name = "UpDown_ContentBox_W";
            this.UpDown_ContentBox_W.Size = new System.Drawing.Size(66, 20);
            this.UpDown_ContentBox_W.TabIndex = 32;
            this.TT_STCLI.SetToolTip(this.UpDown_ContentBox_W, "Width");
            this.UpDown_ContentBox_W.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_EnableFineTuning
            // 
            this.CheckB_EnableFineTuning.AutoSize = true;
            this.CheckB_EnableFineTuning.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_EnableFineTuning.Location = new System.Drawing.Point(1, 82);
            this.CheckB_EnableFineTuning.Name = "CheckB_EnableFineTuning";
            this.CheckB_EnableFineTuning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_EnableFineTuning.Size = new System.Drawing.Size(222, 18);
            this.CheckB_EnableFineTuning.TabIndex = 21;
            this.CheckB_EnableFineTuning.Text = "          Enable-Fine-Tuning";
            this.TT_STCLI.SetToolTip(this.CheckB_EnableFineTuning, "default : disabled; If page detection enabled it moves edges while corners are in" +
        " black");
            this.CheckB_EnableFineTuning.UseVisualStyleBackColor = true;
            this.CheckB_EnableFineTuning.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_PageDetectionTolerance
            // 
            this.UpDown_PageDetectionTolerance.DecimalPlaces = 1;
            this.UpDown_PageDetectionTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_PageDetectionTolerance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UpDown_PageDetectionTolerance.Location = new System.Drawing.Point(189, 217);
            this.UpDown_PageDetectionTolerance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDown_PageDetectionTolerance.Name = "UpDown_PageDetectionTolerance";
            this.UpDown_PageDetectionTolerance.Size = new System.Drawing.Size(82, 20);
            this.UpDown_PageDetectionTolerance.TabIndex = 104;
            this.TT_STCLI.SetToolTip(this.UpDown_PageDetectionTolerance, "default : 0.1");
            this.UpDown_PageDetectionTolerance.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_ForceDisablePageDetection
            // 
            this.CheckB_ForceDisablePageDetection.AutoSize = true;
            this.CheckB_ForceDisablePageDetection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_ForceDisablePageDetection.Location = new System.Drawing.Point(1, 65);
            this.CheckB_ForceDisablePageDetection.Name = "CheckB_ForceDisablePageDetection";
            this.CheckB_ForceDisablePageDetection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_ForceDisablePageDetection.Size = new System.Drawing.Size(222, 18);
            this.CheckB_ForceDisablePageDetection.TabIndex = 22;
            this.CheckB_ForceDisablePageDetection.Text = "Force-Disable-Page-Detection";
            this.TT_STCLI.SetToolTip(this.CheckB_ForceDisablePageDetection, "Switch page detection from page project off if enabled and set content detection " +
        "to manual mode");
            this.CheckB_ForceDisablePageDetection.UseVisualStyleBackColor = true;
            this.CheckB_ForceDisablePageDetection.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_ContentBox_H
            // 
            this.UpDown_ContentBox_H.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_ContentBox_H.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_ContentBox_H.Location = new System.Drawing.Point(205, 171);
            this.UpDown_ContentBox_H.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_ContentBox_H.Name = "UpDown_ContentBox_H";
            this.UpDown_ContentBox_H.Size = new System.Drawing.Size(66, 20);
            this.UpDown_ContentBox_H.TabIndex = 33;
            this.TT_STCLI.SetToolTip(this.UpDown_ContentBox_H, "Height");
            this.UpDown_ContentBox_H.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_DisableContentTextMask
            // 
            this.CheckB_DisableContentTextMask.AutoSize = true;
            this.CheckB_DisableContentTextMask.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_DisableContentTextMask.Location = new System.Drawing.Point(1, 31);
            this.CheckB_DisableContentTextMask.Name = "CheckB_DisableContentTextMask";
            this.CheckB_DisableContentTextMask.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_DisableContentTextMask.Size = new System.Drawing.Size(222, 18);
            this.CheckB_DisableContentTextMask.TabIndex = 23;
            this.CheckB_DisableContentTextMask.Text = "   Disable-Content-Text-Mask";
            this.TT_STCLI.SetToolTip(this.CheckB_DisableContentTextMask, "Disable using text mask to estimate a content box");
            this.CheckB_DisableContentTextMask.UseVisualStyleBackColor = true;
            this.CheckB_DisableContentTextMask.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_ContentBoxWH
            // 
            this.Label_ContentBoxWH.AutoSize = true;
            this.Label_ContentBoxWH.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ContentBoxWH.Location = new System.Drawing.Point(1, 174);
            this.Label_ContentBoxWH.Name = "Label_ContentBoxWH";
            this.Label_ContentBoxWH.Size = new System.Drawing.Size(133, 14);
            this.Label_ContentBoxWH.TabIndex = 31;
            this.Label_ContentBoxWH.Text = "Content-Box(WxH) :";
            this.TT_STCLI.SetToolTip(this.Label_ContentBoxWH, "If set the content detection is set to manual mode");
            // 
            // Label_PageDetectionTolerance
            // 
            this.Label_PageDetectionTolerance.AutoSize = true;
            this.Label_PageDetectionTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PageDetectionTolerance.Location = new System.Drawing.Point(1, 220);
            this.Label_PageDetectionTolerance.Name = "Label_PageDetectionTolerance";
            this.Label_PageDetectionTolerance.Size = new System.Drawing.Size(182, 14);
            this.Label_PageDetectionTolerance.TabIndex = 103;
            this.Label_PageDetectionTolerance.Text = "Page-Detection-Tolerance:";
            // 
            // UpDown_ContentBox_T
            // 
            this.UpDown_ContentBox_T.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_ContentBox_T.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_ContentBox_T.Location = new System.Drawing.Point(205, 148);
            this.UpDown_ContentBox_T.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_ContentBox_T.Name = "UpDown_ContentBox_T";
            this.UpDown_ContentBox_T.Size = new System.Drawing.Size(66, 20);
            this.UpDown_ContentBox_T.TabIndex = 30;
            this.TT_STCLI.SetToolTip(this.UpDown_ContentBox_T, "Top");
            this.UpDown_ContentBox_T.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_ContentBox_L
            // 
            this.UpDown_ContentBox_L.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_ContentBox_L.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_ContentBox_L.Location = new System.Drawing.Point(134, 148);
            this.UpDown_ContentBox_L.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_ContentBox_L.Name = "UpDown_ContentBox_L";
            this.UpDown_ContentBox_L.Size = new System.Drawing.Size(66, 20);
            this.UpDown_ContentBox_L.TabIndex = 29;
            this.TT_STCLI.SetToolTip(this.UpDown_ContentBox_L, "Left");
            this.UpDown_ContentBox_L.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_PageDetectionBox_H
            // 
            this.UpDown_PageDetectionBox_H.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_PageDetectionBox_H.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_PageDetectionBox_H.Location = new System.Drawing.Point(222, 194);
            this.UpDown_PageDetectionBox_H.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_PageDetectionBox_H.Name = "UpDown_PageDetectionBox_H";
            this.UpDown_PageDetectionBox_H.Size = new System.Drawing.Size(49, 20);
            this.UpDown_PageDetectionBox_H.TabIndex = 102;
            this.TT_STCLI.SetToolTip(this.UpDown_PageDetectionBox_H, "Height (in mm)");
            this.UpDown_PageDetectionBox_H.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_ContentBoxLT
            // 
            this.Label_ContentBoxLT.AutoSize = true;
            this.Label_ContentBoxLT.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ContentBoxLT.Location = new System.Drawing.Point(1, 152);
            this.Label_ContentBoxLT.Name = "Label_ContentBoxLT";
            this.Label_ContentBoxLT.Size = new System.Drawing.Size(133, 14);
            this.Label_ContentBoxLT.TabIndex = 28;
            this.Label_ContentBoxLT.Text = "Content-Box(LxT) :";
            this.TT_STCLI.SetToolTip(this.Label_ContentBoxLT, "If set the content detection is set to manual mode");
            // 
            // UpDown_ContentDeviation
            // 
            this.UpDown_ContentDeviation.DecimalPlaces = 1;
            this.UpDown_ContentDeviation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_ContentDeviation.Location = new System.Drawing.Point(134, 125);
            this.UpDown_ContentDeviation.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_ContentDeviation.Name = "UpDown_ContentDeviation";
            this.UpDown_ContentDeviation.Size = new System.Drawing.Size(137, 20);
            this.UpDown_ContentDeviation.TabIndex = 27;
            this.TT_STCLI.SetToolTip(this.UpDown_ContentDeviation, "default : 1.0; pages with bigger content deviation will be painted in red");
            this.UpDown_ContentDeviation.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_PageDetectionBox_W
            // 
            this.UpDown_PageDetectionBox_W.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_PageDetectionBox_W.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_PageDetectionBox_W.Location = new System.Drawing.Point(171, 194);
            this.UpDown_PageDetectionBox_W.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_PageDetectionBox_W.Name = "UpDown_PageDetectionBox_W";
            this.UpDown_PageDetectionBox_W.Size = new System.Drawing.Size(48, 20);
            this.UpDown_PageDetectionBox_W.TabIndex = 101;
            this.TT_STCLI.SetToolTip(this.UpDown_PageDetectionBox_W, "Width (in mm)");
            this.UpDown_PageDetectionBox_W.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_ContentDetection
            // 
            this.CB_ContentDetection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ContentDetection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ContentDetection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ContentDetection.FormattingEnabled = true;
            this.CB_ContentDetection.Items.AddRange(new object[] {
            "",
            "cautious",
            "normal",
            "aggressive"});
            this.CB_ContentDetection.Location = new System.Drawing.Point(134, 100);
            this.CB_ContentDetection.Name = "CB_ContentDetection";
            this.CB_ContentDetection.Size = new System.Drawing.Size(137, 22);
            this.CB_ContentDetection.TabIndex = 25;
            this.TT_STCLI.SetToolTip(this.CB_ContentDetection, "default : normal");
            this.CB_ContentDetection.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_ContentDetection
            // 
            this.Label_ContentDetection.AutoSize = true;
            this.Label_ContentDetection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ContentDetection.Location = new System.Drawing.Point(1, 104);
            this.Label_ContentDetection.Name = "Label_ContentDetection";
            this.Label_ContentDetection.Size = new System.Drawing.Size(133, 14);
            this.Label_ContentDetection.TabIndex = 24;
            this.Label_ContentDetection.Text = "Content-Detection:";
            // 
            // Label_PageDetectionBox
            // 
            this.Label_PageDetectionBox.AutoSize = true;
            this.Label_PageDetectionBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PageDetectionBox.Location = new System.Drawing.Point(1, 197);
            this.Label_PageDetectionBox.Name = "Label_PageDetectionBox";
            this.Label_PageDetectionBox.Size = new System.Drawing.Size(175, 14);
            this.Label_PageDetectionBox.TabIndex = 100;
            this.Label_PageDetectionBox.Text = "Page-Detection-Box(WxH):";
            this.TT_STCLI.SetToolTip(this.Label_PageDetectionBox, "If set the content detection is set to manual mode");
            // 
            // GB_02
            // 
            this.GB_02.Controls.Add(this.Label_Layout);
            this.GB_02.Controls.Add(this.Label_LayoutDirection);
            this.GB_02.Controls.Add(this.CB_LayoutDirection);
            this.GB_02.Controls.Add(this.MCCB_Layout);
            this.GB_02.Controls.Add(this.Label_Orientation);
            this.GB_02.Controls.Add(this.CB_Orientation);
            this.GB_02.Controls.Add(this.CheckB_MatchLayoutDefault);
            this.GB_02.Controls.Add(this.CheckB_MatchLayout);
            this.GB_02.Controls.Add(this.Label_MatchLayoutTolerance);
            this.GB_02.Controls.Add(this.UpDown_MatchLayoutTolerance);
            this.GB_02.Location = new System.Drawing.Point(5, 95);
            this.GB_02.Name = "GB_02";
            this.GB_02.Size = new System.Drawing.Size(276, 156);
            this.GB_02.TabIndex = 111;
            this.GB_02.TabStop = false;
            this.GB_02.Text = "(2)";
            // 
            // Label_LayoutDirection
            // 
            this.Label_LayoutDirection.AutoSize = true;
            this.Label_LayoutDirection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LayoutDirection.Location = new System.Drawing.Point(1, 65);
            this.Label_LayoutDirection.Name = "Label_LayoutDirection";
            this.Label_LayoutDirection.Size = new System.Drawing.Size(126, 14);
            this.Label_LayoutDirection.TabIndex = 9;
            this.Label_LayoutDirection.Text = "Layout-Direction:";
            // 
            // CB_LayoutDirection
            // 
            this.CB_LayoutDirection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_LayoutDirection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_LayoutDirection.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LayoutDirection.FormattingEnabled = true;
            this.CB_LayoutDirection.Items.AddRange(new object[] {
            "",
            "lr",
            "rl"});
            this.CB_LayoutDirection.Location = new System.Drawing.Point(134, 62);
            this.CB_LayoutDirection.Name = "CB_LayoutDirection";
            this.CB_LayoutDirection.Size = new System.Drawing.Size(137, 22);
            this.CB_LayoutDirection.TabIndex = 10;
            this.TT_STCLI.SetToolTip(this.CB_LayoutDirection, "lr : default");
            this.CB_LayoutDirection.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // MCCB_Layout
            // 
            this.MCCB_Layout.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MCCB_Layout.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MCCB_Layout.ColumnHeaderFont = null;
            this.MCCB_Layout.ColumnHeaderHight = 0;
            this.MCCB_Layout.ColumnPadding = 5;
            this.MCCB_Layout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.MCCB_Layout.DropDownHeight = 100;
            this.MCCB_Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCCB_Layout.FormattingEnabled = true;
            this.MCCB_Layout.IntegralHeight = false;
            this.MCCB_Layout.Location = new System.Drawing.Point(64, 13);
            this.MCCB_Layout.Name = "MCCB_Layout";
            this.MCCB_Layout.SepLineWidth = 1;
            this.MCCB_Layout.Size = new System.Drawing.Size(207, 21);
            this.MCCB_Layout.TabIndex = 8;
            this.TT_STCLI.SetToolTip(this.MCCB_Layout, "default : 0");
            this.MCCB_Layout.ValueMemberBackColor = System.Drawing.SystemColors.Window;
            this.MCCB_Layout.ValueMemberFontStyle = System.Drawing.FontStyle.Regular;
            this.MCCB_Layout.ValueMemberForeColor = System.Drawing.SystemColors.WindowText;
            this.MCCB_Layout.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Orientation
            // 
            this.Label_Orientation.AutoSize = true;
            this.Label_Orientation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Orientation.Location = new System.Drawing.Point(1, 40);
            this.Label_Orientation.Name = "Label_Orientation";
            this.Label_Orientation.Size = new System.Drawing.Size(91, 14);
            this.Label_Orientation.TabIndex = 11;
            this.Label_Orientation.Text = "Orientation:";
            // 
            // CB_Orientation
            // 
            this.CB_Orientation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Orientation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Orientation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Orientation.FormattingEnabled = true;
            this.CB_Orientation.Items.AddRange(new object[] {
            "",
            "left",
            "right",
            "upsidedown"});
            this.CB_Orientation.Location = new System.Drawing.Point(134, 37);
            this.CB_Orientation.Name = "CB_Orientation";
            this.CB_Orientation.Size = new System.Drawing.Size(137, 22);
            this.CB_Orientation.TabIndex = 12;
            this.TT_STCLI.SetToolTip(this.CB_Orientation, "none : default");
            this.CB_Orientation.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_MatchLayoutDefault
            // 
            this.CheckB_MatchLayoutDefault.AutoSize = true;
            this.CheckB_MatchLayoutDefault.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_MatchLayoutDefault.Location = new System.Drawing.Point(1, 104);
            this.CheckB_MatchLayoutDefault.Name = "CheckB_MatchLayoutDefault";
            this.CheckB_MatchLayoutDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_MatchLayoutDefault.Size = new System.Drawing.Size(222, 18);
            this.CheckB_MatchLayoutDefault.TabIndex = 54;
            this.CheckB_MatchLayoutDefault.Text = "        Match-Layout-Default";
            this.TT_STCLI.SetToolTip(this.CheckB_MatchLayoutDefault, "default : true");
            this.CheckB_MatchLayoutDefault.UseVisualStyleBackColor = true;
            this.CheckB_MatchLayoutDefault.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_MatchLayout
            // 
            this.CheckB_MatchLayout.AutoSize = true;
            this.CheckB_MatchLayout.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_MatchLayout.Location = new System.Drawing.Point(1, 86);
            this.CheckB_MatchLayout.Name = "CheckB_MatchLayout";
            this.CheckB_MatchLayout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_MatchLayout.Size = new System.Drawing.Size(222, 18);
            this.CheckB_MatchLayout.TabIndex = 51;
            this.CheckB_MatchLayout.Text = "                Match-Layout";
            this.TT_STCLI.SetToolTip(this.CheckB_MatchLayout, "default : true");
            this.CheckB_MatchLayout.UseVisualStyleBackColor = true;
            this.CheckB_MatchLayout.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_MatchLayoutTolerance
            // 
            this.Label_MatchLayoutTolerance.AutoSize = true;
            this.Label_MatchLayoutTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MatchLayoutTolerance.Location = new System.Drawing.Point(1, 125);
            this.Label_MatchLayoutTolerance.Name = "Label_MatchLayoutTolerance";
            this.Label_MatchLayoutTolerance.Size = new System.Drawing.Size(168, 14);
            this.Label_MatchLayoutTolerance.TabIndex = 52;
            this.Label_MatchLayoutTolerance.Text = "Match-Layout-Tolerance:";
            // 
            // UpDown_MatchLayoutTolerance
            // 
            this.UpDown_MatchLayoutTolerance.DecimalPlaces = 1;
            this.UpDown_MatchLayoutTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_MatchLayoutTolerance.Location = new System.Drawing.Point(174, 123);
            this.UpDown_MatchLayoutTolerance.Name = "UpDown_MatchLayoutTolerance";
            this.UpDown_MatchLayoutTolerance.Size = new System.Drawing.Size(97, 20);
            this.UpDown_MatchLayoutTolerance.TabIndex = 53;
            this.TT_STCLI.SetToolTip(this.UpDown_MatchLayoutTolerance, "default : off");
            this.UpDown_MatchLayoutTolerance.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // GB_05
            // 
            this.GB_05.Controls.Add(this.Label_Margins_LR);
            this.GB_05.Controls.Add(this.CheckB_EnableAutoMargins);
            this.GB_05.Controls.Add(this.UpDown_AlignmentTolerance);
            this.GB_05.Controls.Add(this.Label_Margins);
            this.GB_05.Controls.Add(this.Label_AlignmentTolerance);
            this.GB_05.Controls.Add(this.UpDown_Margins);
            this.GB_05.Controls.Add(this.CB_AlignmentHorizontal);
            this.GB_05.Controls.Add(this.UpDown_Margins_L);
            this.GB_05.Controls.Add(this.UpDown_Margins_R);
            this.GB_05.Controls.Add(this.Label_AlignmentHorizontal);
            this.GB_05.Controls.Add(this.Label_Margins_TB);
            this.GB_05.Controls.Add(this.CB_AlignmentVertical);
            this.GB_05.Controls.Add(this.UpDown_Margins_T);
            this.GB_05.Controls.Add(this.Label_AlignmentVertical);
            this.GB_05.Controls.Add(this.UpDown_Margins_B);
            this.GB_05.Controls.Add(this.CB_Alignment);
            this.GB_05.Controls.Add(this.Label_DefaultMargins);
            this.GB_05.Controls.Add(this.Label_Alignment);
            this.GB_05.Controls.Add(this.UpDown_DefaultMargins);
            this.GB_05.Controls.Add(this.Label_DefaultMargins_LR);
            this.GB_05.Controls.Add(this.UpDown_DefaultMargins_L);
            this.GB_05.Controls.Add(this.UpDown_DefaultMargins_R);
            this.GB_05.Controls.Add(this.Label_DefaultMargins_TB);
            this.GB_05.Controls.Add(this.UpDown_DefaultMargins_T);
            this.GB_05.Controls.Add(this.UpDown_DefaultMargins_B);
            this.GB_05.Location = new System.Drawing.Point(294, 12);
            this.GB_05.Name = "GB_05";
            this.GB_05.Size = new System.Drawing.Size(288, 275);
            this.GB_05.TabIndex = 109;
            this.GB_05.TabStop = false;
            this.GB_05.Text = "(5)";
            // 
            // Label_Margins_LR
            // 
            this.Label_Margins_LR.AutoSize = true;
            this.Label_Margins_LR.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Margins_LR.Location = new System.Drawing.Point(1, 60);
            this.Label_Margins_LR.Name = "Label_Margins_LR";
            this.Label_Margins_LR.Size = new System.Drawing.Size(140, 14);
            this.Label_Margins_LR.TabIndex = 37;
            this.Label_Margins_LR.Text = "Margins-(L&R)     :";
            this.Label_Margins_LR.UseMnemonic = false;
            // 
            // CheckB_EnableAutoMargins
            // 
            this.CheckB_EnableAutoMargins.AutoSize = true;
            this.CheckB_EnableAutoMargins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_EnableAutoMargins.Location = new System.Drawing.Point(1, 15);
            this.CheckB_EnableAutoMargins.Name = "CheckB_EnableAutoMargins";
            this.CheckB_EnableAutoMargins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_EnableAutoMargins.Size = new System.Drawing.Size(222, 18);
            this.CheckB_EnableAutoMargins.TabIndex = 34;
            this.CheckB_EnableAutoMargins.Text = "         Enable-Auto-Margins";
            this.TT_STCLI.SetToolTip(this.CheckB_EnableAutoMargins, "Sets the margins to original ones (based on detected page or image size)");
            this.CheckB_EnableAutoMargins.UseVisualStyleBackColor = true;
            this.CheckB_EnableAutoMargins.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_AlignmentTolerance
            // 
            this.UpDown_AlignmentTolerance.DecimalPlaces = 1;
            this.UpDown_AlignmentTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_AlignmentTolerance.Location = new System.Drawing.Point(166, 251);
            this.UpDown_AlignmentTolerance.Name = "UpDown_AlignmentTolerance";
            this.UpDown_AlignmentTolerance.Size = new System.Drawing.Size(117, 20);
            this.UpDown_AlignmentTolerance.TabIndex = 62;
            this.TT_STCLI.SetToolTip(this.UpDown_AlignmentTolerance, "Sets tolerance for auto alignment");
            this.UpDown_AlignmentTolerance.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Margins
            // 
            this.Label_Margins.AutoSize = true;
            this.Label_Margins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Margins.Location = new System.Drawing.Point(1, 37);
            this.Label_Margins.Name = "Label_Margins";
            this.Label_Margins.Size = new System.Drawing.Size(140, 14);
            this.Label_Margins.TabIndex = 35;
            this.Label_Margins.Text = "Margins           :";
            this.TT_STCLI.SetToolTip(this.Label_Margins, "If set the content detection is set to manual mode");
            // 
            // Label_AlignmentTolerance
            // 
            this.Label_AlignmentTolerance.AutoSize = true;
            this.Label_AlignmentTolerance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AlignmentTolerance.Location = new System.Drawing.Point(1, 254);
            this.Label_AlignmentTolerance.Name = "Label_AlignmentTolerance";
            this.Label_AlignmentTolerance.Size = new System.Drawing.Size(168, 14);
            this.Label_AlignmentTolerance.TabIndex = 61;
            this.Label_AlignmentTolerance.Text = "Alignment-Tolerance   :";
            // 
            // UpDown_Margins
            // 
            this.UpDown_Margins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Margins.Location = new System.Drawing.Point(146, 34);
            this.UpDown_Margins.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_Margins.Name = "UpDown_Margins";
            this.UpDown_Margins.Size = new System.Drawing.Size(137, 20);
            this.UpDown_Margins.TabIndex = 36;
            this.TT_STCLI.SetToolTip(this.UpDown_Margins, "Sets left, top, right and bottom margins to same number");
            this.UpDown_Margins.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_AlignmentHorizontal
            // 
            this.CB_AlignmentHorizontal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_AlignmentHorizontal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_AlignmentHorizontal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AlignmentHorizontal.FormattingEnabled = true;
            this.CB_AlignmentHorizontal.Items.AddRange(new object[] {
            "",
            "original",
            "left",
            "center",
            "right"});
            this.CB_AlignmentHorizontal.Location = new System.Drawing.Point(166, 226);
            this.CB_AlignmentHorizontal.Name = "CB_AlignmentHorizontal";
            this.CB_AlignmentHorizontal.Size = new System.Drawing.Size(117, 22);
            this.CB_AlignmentHorizontal.TabIndex = 60;
            this.CB_AlignmentHorizontal.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_Margins_L
            // 
            this.UpDown_Margins_L.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Margins_L.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_Margins_L.Location = new System.Drawing.Point(146, 57);
            this.UpDown_Margins_L.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_Margins_L.Name = "UpDown_Margins_L";
            this.UpDown_Margins_L.Size = new System.Drawing.Size(66, 20);
            this.UpDown_Margins_L.TabIndex = 38;
            this.TT_STCLI.SetToolTip(this.UpDown_Margins_L, "Left");
            this.UpDown_Margins_L.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_Margins_R
            // 
            this.UpDown_Margins_R.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Margins_R.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_Margins_R.Location = new System.Drawing.Point(218, 57);
            this.UpDown_Margins_R.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_Margins_R.Name = "UpDown_Margins_R";
            this.UpDown_Margins_R.Size = new System.Drawing.Size(65, 20);
            this.UpDown_Margins_R.TabIndex = 39;
            this.TT_STCLI.SetToolTip(this.UpDown_Margins_R, "Right");
            this.UpDown_Margins_R.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_AlignmentHorizontal
            // 
            this.Label_AlignmentHorizontal.AutoSize = true;
            this.Label_AlignmentHorizontal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AlignmentHorizontal.Location = new System.Drawing.Point(1, 229);
            this.Label_AlignmentHorizontal.Name = "Label_AlignmentHorizontal";
            this.Label_AlignmentHorizontal.Size = new System.Drawing.Size(168, 14);
            this.Label_AlignmentHorizontal.TabIndex = 59;
            this.Label_AlignmentHorizontal.Text = "Alignment-Horizontal  :";
            // 
            // Label_Margins_TB
            // 
            this.Label_Margins_TB.AutoSize = true;
            this.Label_Margins_TB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Margins_TB.Location = new System.Drawing.Point(1, 82);
            this.Label_Margins_TB.Name = "Label_Margins_TB";
            this.Label_Margins_TB.Size = new System.Drawing.Size(140, 14);
            this.Label_Margins_TB.TabIndex = 40;
            this.Label_Margins_TB.Text = "Margins-(T&B)     :";
            this.Label_Margins_TB.UseMnemonic = false;
            // 
            // CB_AlignmentVertical
            // 
            this.CB_AlignmentVertical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_AlignmentVertical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_AlignmentVertical.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AlignmentVertical.FormattingEnabled = true;
            this.CB_AlignmentVertical.Items.AddRange(new object[] {
            "",
            "original",
            "top",
            "center",
            "bottom"});
            this.CB_AlignmentVertical.Location = new System.Drawing.Point(166, 201);
            this.CB_AlignmentVertical.Name = "CB_AlignmentVertical";
            this.CB_AlignmentVertical.Size = new System.Drawing.Size(117, 22);
            this.CB_AlignmentVertical.TabIndex = 58;
            this.CB_AlignmentVertical.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_Margins_T
            // 
            this.UpDown_Margins_T.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Margins_T.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_Margins_T.Location = new System.Drawing.Point(146, 80);
            this.UpDown_Margins_T.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_Margins_T.Name = "UpDown_Margins_T";
            this.UpDown_Margins_T.Size = new System.Drawing.Size(66, 20);
            this.UpDown_Margins_T.TabIndex = 41;
            this.TT_STCLI.SetToolTip(this.UpDown_Margins_T, "Top");
            this.UpDown_Margins_T.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_AlignmentVertical
            // 
            this.Label_AlignmentVertical.AutoSize = true;
            this.Label_AlignmentVertical.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_AlignmentVertical.Location = new System.Drawing.Point(1, 204);
            this.Label_AlignmentVertical.Name = "Label_AlignmentVertical";
            this.Label_AlignmentVertical.Size = new System.Drawing.Size(168, 14);
            this.Label_AlignmentVertical.TabIndex = 57;
            this.Label_AlignmentVertical.Text = "Alignment-Vertical    :";
            // 
            // UpDown_Margins_B
            // 
            this.UpDown_Margins_B.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Margins_B.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_Margins_B.Location = new System.Drawing.Point(218, 80);
            this.UpDown_Margins_B.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_Margins_B.Name = "UpDown_Margins_B";
            this.UpDown_Margins_B.Size = new System.Drawing.Size(65, 20);
            this.UpDown_Margins_B.TabIndex = 42;
            this.TT_STCLI.SetToolTip(this.UpDown_Margins_B, "Bottom");
            this.UpDown_Margins_B.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_Alignment
            // 
            this.CB_Alignment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Alignment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Alignment.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Alignment.FormattingEnabled = true;
            this.CB_Alignment.Items.AddRange(new object[] {
            "",
            "original",
            "auto",
            "center"});
            this.CB_Alignment.Location = new System.Drawing.Point(166, 176);
            this.CB_Alignment.Name = "CB_Alignment";
            this.CB_Alignment.Size = new System.Drawing.Size(117, 22);
            this.CB_Alignment.TabIndex = 56;
            this.TT_STCLI.SetToolTip(this.CB_Alignment, "Sets vertical to original and horizontal to center");
            this.CB_Alignment.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DefaultMargins
            // 
            this.Label_DefaultMargins.AutoSize = true;
            this.Label_DefaultMargins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DefaultMargins.Location = new System.Drawing.Point(1, 106);
            this.Label_DefaultMargins.Name = "Label_DefaultMargins";
            this.Label_DefaultMargins.Size = new System.Drawing.Size(140, 14);
            this.Label_DefaultMargins.TabIndex = 43;
            this.Label_DefaultMargins.Text = "Default-Margins   :";
            this.TT_STCLI.SetToolTip(this.Label_DefaultMargins, "If set the content detection is set to manual mode");
            // 
            // Label_Alignment
            // 
            this.Label_Alignment.AutoSize = true;
            this.Label_Alignment.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Alignment.Location = new System.Drawing.Point(1, 179);
            this.Label_Alignment.Name = "Label_Alignment";
            this.Label_Alignment.Size = new System.Drawing.Size(168, 14);
            this.Label_Alignment.TabIndex = 55;
            this.Label_Alignment.Text = "Alignment             :";
            // 
            // UpDown_DefaultMargins
            // 
            this.UpDown_DefaultMargins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultMargins.Location = new System.Drawing.Point(146, 103);
            this.UpDown_DefaultMargins.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_DefaultMargins.Name = "UpDown_DefaultMargins";
            this.UpDown_DefaultMargins.Size = new System.Drawing.Size(137, 20);
            this.UpDown_DefaultMargins.TabIndex = 44;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultMargins, "Sets left, top, right and bottom margins to same number");
            this.UpDown_DefaultMargins.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DefaultMargins_LR
            // 
            this.Label_DefaultMargins_LR.AutoSize = true;
            this.Label_DefaultMargins_LR.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DefaultMargins_LR.Location = new System.Drawing.Point(1, 129);
            this.Label_DefaultMargins_LR.Name = "Label_DefaultMargins_LR";
            this.Label_DefaultMargins_LR.Size = new System.Drawing.Size(140, 14);
            this.Label_DefaultMargins_LR.TabIndex = 45;
            this.Label_DefaultMargins_LR.Text = "Margins-(L&R)     :";
            this.Label_DefaultMargins_LR.UseMnemonic = false;
            // 
            // UpDown_DefaultMargins_L
            // 
            this.UpDown_DefaultMargins_L.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultMargins_L.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_L.Location = new System.Drawing.Point(146, 126);
            this.UpDown_DefaultMargins_L.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_L.Name = "UpDown_DefaultMargins_L";
            this.UpDown_DefaultMargins_L.Size = new System.Drawing.Size(66, 20);
            this.UpDown_DefaultMargins_L.TabIndex = 46;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultMargins_L, "Left");
            this.UpDown_DefaultMargins_L.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_DefaultMargins_R
            // 
            this.UpDown_DefaultMargins_R.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultMargins_R.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_R.Location = new System.Drawing.Point(217, 126);
            this.UpDown_DefaultMargins_R.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_R.Name = "UpDown_DefaultMargins_R";
            this.UpDown_DefaultMargins_R.Size = new System.Drawing.Size(66, 20);
            this.UpDown_DefaultMargins_R.TabIndex = 47;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultMargins_R, "Right");
            this.UpDown_DefaultMargins_R.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DefaultMargins_TB
            // 
            this.Label_DefaultMargins_TB.AutoSize = true;
            this.Label_DefaultMargins_TB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DefaultMargins_TB.Location = new System.Drawing.Point(1, 152);
            this.Label_DefaultMargins_TB.Name = "Label_DefaultMargins_TB";
            this.Label_DefaultMargins_TB.Size = new System.Drawing.Size(140, 14);
            this.Label_DefaultMargins_TB.TabIndex = 48;
            this.Label_DefaultMargins_TB.Text = "Margins-(T&B)     :";
            this.Label_DefaultMargins_TB.UseMnemonic = false;
            // 
            // UpDown_DefaultMargins_T
            // 
            this.UpDown_DefaultMargins_T.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultMargins_T.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_T.Location = new System.Drawing.Point(146, 149);
            this.UpDown_DefaultMargins_T.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_T.Name = "UpDown_DefaultMargins_T";
            this.UpDown_DefaultMargins_T.Size = new System.Drawing.Size(66, 20);
            this.UpDown_DefaultMargins_T.TabIndex = 49;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultMargins_T, "Top");
            this.UpDown_DefaultMargins_T.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_DefaultMargins_B
            // 
            this.UpDown_DefaultMargins_B.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultMargins_B.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_B.Location = new System.Drawing.Point(217, 149);
            this.UpDown_DefaultMargins_B.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDown_DefaultMargins_B.Name = "UpDown_DefaultMargins_B";
            this.UpDown_DefaultMargins_B.Size = new System.Drawing.Size(66, 20);
            this.UpDown_DefaultMargins_B.TabIndex = 50;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultMargins_B, "Bottom");
            this.UpDown_DefaultMargins_B.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_Rotate
            // 
            this.UpDown_Rotate.DecimalPlaces = 1;
            this.UpDown_Rotate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Rotate.Increment = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.UpDown_Rotate.Location = new System.Drawing.Point(179, 24);
            this.UpDown_Rotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.UpDown_Rotate.Name = "UpDown_Rotate";
            this.UpDown_Rotate.Size = new System.Drawing.Size(97, 20);
            this.UpDown_Rotate.TabIndex = 14;
            this.TT_STCLI.SetToolTip(this.UpDown_Rotate, "It also sets deskew to manual mode!");
            this.UpDown_Rotate.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_DisableCheckOutput
            // 
            this.CheckB_DisableCheckOutput.AutoSize = true;
            this.CheckB_DisableCheckOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_DisableCheckOutput.Location = new System.Drawing.Point(6, 586);
            this.CheckB_DisableCheckOutput.Name = "CheckB_DisableCheckOutput";
            this.CheckB_DisableCheckOutput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_DisableCheckOutput.Size = new System.Drawing.Size(215, 18);
            this.CheckB_DisableCheckOutput.TabIndex = 105;
            this.CheckB_DisableCheckOutput.Text = "       Disable-Check-Output";
            this.TT_STCLI.SetToolTip(this.CheckB_DisableCheckOutput, "Don\'t check if page is valid when switching to step 6");
            this.CheckB_DisableCheckOutput.UseVisualStyleBackColor = true;
            this.CheckB_DisableCheckOutput.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_Verbose
            // 
            this.CheckB_Verbose.AutoSize = true;
            this.CheckB_Verbose.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_Verbose.Location = new System.Drawing.Point(6, 606);
            this.CheckB_Verbose.Name = "CheckB_Verbose";
            this.CheckB_Verbose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_Verbose.Size = new System.Drawing.Size(215, 18);
            this.CheckB_Verbose.TabIndex = 106;
            this.CheckB_Verbose.Text = "                    Verbose";
            this.CheckB_Verbose.UseVisualStyleBackColor = true;
            this.CheckB_Verbose.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Rotate
            // 
            this.Label_Rotate.AutoSize = true;
            this.Label_Rotate.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rotate.Location = new System.Drawing.Point(7, 27);
            this.Label_Rotate.Name = "Label_Rotate";
            this.Label_Rotate.Size = new System.Drawing.Size(56, 14);
            this.Label_Rotate.TabIndex = 13;
            this.Label_Rotate.Text = "Rotate:";
            // 
            // GB_01
            // 
            this.GB_01.Controls.Add(this.Label_RotateApplyTo);
            this.GB_01.Controls.Add(this.CB_ApplyRotateTo);
            this.GB_01.Controls.Add(this.CheckB_UseIrfanView);
            this.GB_01.Location = new System.Drawing.Point(6, 12);
            this.GB_01.Name = "GB_01";
            this.GB_01.Size = new System.Drawing.Size(276, 83);
            this.GB_01.TabIndex = 107;
            this.GB_01.TabStop = false;
            this.GB_01.Text = "(1)";
            // 
            // Label_RotateApplyTo
            // 
            this.Label_RotateApplyTo.AutoSize = true;
            this.Label_RotateApplyTo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RotateApplyTo.Location = new System.Drawing.Point(2, 57);
            this.Label_RotateApplyTo.Name = "Label_RotateApplyTo";
            this.Label_RotateApplyTo.Size = new System.Drawing.Size(70, 14);
            this.Label_RotateApplyTo.TabIndex = 54;
            this.Label_RotateApplyTo.Text = "Apply to:";
            // 
            // CB_ApplyRotateTo
            // 
            this.CB_ApplyRotateTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ApplyRotateTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ApplyRotateTo.DropDownWidth = 290;
            this.CB_ApplyRotateTo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ApplyRotateTo.FormattingEnabled = true;
            this.CB_ApplyRotateTo.Items.AddRange(new object[] {
            "Ignore",
            "Every images",
            "Odd images(Rotates even images opposite)"});
            this.CB_ApplyRotateTo.Location = new System.Drawing.Point(78, 54);
            this.CB_ApplyRotateTo.Name = "CB_ApplyRotateTo";
            this.CB_ApplyRotateTo.Size = new System.Drawing.Size(192, 22);
            this.CB_ApplyRotateTo.TabIndex = 53;
            this.TT_STCLI.SetToolTip(this.CB_ApplyRotateTo, "Only aplicable if IrfanView is used for rotation");
            // 
            // CheckB_UseIrfanView
            // 
            this.CheckB_UseIrfanView.AutoSize = true;
            this.CheckB_UseIrfanView.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_UseIrfanView.Location = new System.Drawing.Point(1, 34);
            this.CheckB_UseIrfanView.Name = "CheckB_UseIrfanView";
            this.CheckB_UseIrfanView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_UseIrfanView.Size = new System.Drawing.Size(222, 18);
            this.CheckB_UseIrfanView.TabIndex = 52;
            this.CheckB_UseIrfanView.Text = "               Use IrfanView";
            this.TT_STCLI.SetToolTip(this.CheckB_UseIrfanView, "Uses external \"i_view32.exe\" for rotation.\r\nWarning!\r\nInput images will be overwr" +
        "itten.");
            this.CheckB_UseIrfanView.UseVisualStyleBackColor = true;
            this.CheckB_UseIrfanView.CheckedChanged += new System.EventHandler(this.CheckB_IrfanView_CheckedChanged);
            // 
            // GB_03
            // 
            this.GB_03.Controls.Add(this.Label_SkewDeviation);
            this.GB_03.Controls.Add(this.UpDown_SkewDeviation);
            this.GB_03.Controls.Add(this.CB_Deskew);
            this.GB_03.Controls.Add(this.Label_Deskew);
            this.GB_03.Location = new System.Drawing.Point(6, 250);
            this.GB_03.Name = "GB_03";
            this.GB_03.Size = new System.Drawing.Size(275, 66);
            this.GB_03.TabIndex = 108;
            this.GB_03.TabStop = false;
            this.GB_03.Text = "(3)";
            // 
            // Label_SkewDeviation
            // 
            this.Label_SkewDeviation.AutoSize = true;
            this.Label_SkewDeviation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SkewDeviation.Location = new System.Drawing.Point(1, 41);
            this.Label_SkewDeviation.Name = "Label_SkewDeviation";
            this.Label_SkewDeviation.Size = new System.Drawing.Size(112, 14);
            this.Label_SkewDeviation.TabIndex = 17;
            this.Label_SkewDeviation.Text = "Skew-Deviation:";
            // 
            // UpDown_SkewDeviation
            // 
            this.UpDown_SkewDeviation.DecimalPlaces = 1;
            this.UpDown_SkewDeviation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_SkewDeviation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UpDown_SkewDeviation.Location = new System.Drawing.Point(133, 39);
            this.UpDown_SkewDeviation.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_SkewDeviation.Name = "UpDown_SkewDeviation";
            this.UpDown_SkewDeviation.Size = new System.Drawing.Size(137, 20);
            this.UpDown_SkewDeviation.TabIndex = 18;
            this.TT_STCLI.SetToolTip(this.UpDown_SkewDeviation, "default : 5.0; pages with bigger skew deviation will be painted in red");
            this.UpDown_SkewDeviation.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_Deskew
            // 
            this.CB_Deskew.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Deskew.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Deskew.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Deskew.FormattingEnabled = true;
            this.CB_Deskew.Items.AddRange(new object[] {
            "",
            "auto",
            "manual"});
            this.CB_Deskew.Location = new System.Drawing.Point(133, 13);
            this.CB_Deskew.Name = "CB_Deskew";
            this.CB_Deskew.Size = new System.Drawing.Size(137, 22);
            this.CB_Deskew.TabIndex = 16;
            this.TT_STCLI.SetToolTip(this.CB_Deskew, "default : auto");
            this.CB_Deskew.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Deskew
            // 
            this.Label_Deskew.AutoSize = true;
            this.Label_Deskew.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Deskew.Location = new System.Drawing.Point(1, 16);
            this.Label_Deskew.Name = "Label_Deskew";
            this.Label_Deskew.Size = new System.Drawing.Size(56, 14);
            this.Label_Deskew.TabIndex = 15;
            this.Label_Deskew.Text = "Deskew:";
            // 
            // GB_06
            // 
            this.GB_06.Controls.Add(this.Label_OutputDPI_XY);
            this.GB_06.Controls.Add(this.CB_TiffCompression);
            this.GB_06.Controls.Add(this.Label_TiffCompression);
            this.GB_06.Controls.Add(this.CheckB_TiffForceKeepColorSpace);
            this.GB_06.Controls.Add(this.CheckB_TiffForceGrayscale);
            this.GB_06.Controls.Add(this.CheckB_TiffForceRGB);
            this.GB_06.Controls.Add(this.Label_OutputDPI);
            this.GB_06.Controls.Add(this.UpDown_OutputDPI);
            this.GB_06.Controls.Add(this.UpDown_OutputDPI_X);
            this.GB_06.Controls.Add(this.UpDown_OutputDPI_Y);
            this.GB_06.Controls.Add(this.Label_DefaultOutputDPI);
            this.GB_06.Controls.Add(this.UpDown_DepthPerception);
            this.GB_06.Controls.Add(this.UpDown_DefaultOutputDPI);
            this.GB_06.Controls.Add(this.Label_DepthPerception);
            this.GB_06.Controls.Add(this.Label_ColorMode);
            this.GB_06.Controls.Add(this.CB_Dewarping);
            this.GB_06.Controls.Add(this.CB_ColorMode);
            this.GB_06.Controls.Add(this.CheckB_WhiteMargins);
            this.GB_06.Controls.Add(this.Label_Dewarping);
            this.GB_06.Controls.Add(this.Label_DefaultColorMode);
            this.GB_06.Controls.Add(this.CB_Despeckle);
            this.GB_06.Controls.Add(this.CB_DefaultColorMode);
            this.GB_06.Controls.Add(this.Label_Despeckle);
            this.GB_06.Controls.Add(this.Label_PictureShape);
            this.GB_06.Controls.Add(this.UpDown_Treshold);
            this.GB_06.Controls.Add(this.CB_PictureShape);
            this.GB_06.Controls.Add(this.Label_Threshold);
            this.GB_06.Controls.Add(this.CheckB_NormalizeIllumination);
            this.GB_06.Location = new System.Drawing.Point(295, 288);
            this.GB_06.Name = "GB_06";
            this.GB_06.Size = new System.Drawing.Size(287, 370);
            this.GB_06.TabIndex = 110;
            this.GB_06.TabStop = false;
            this.GB_06.Text = "(6)";
            // 
            // Label_OutputDPI_XY
            // 
            this.Label_OutputDPI_XY.AutoSize = true;
            this.Label_OutputDPI_XY.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OutputDPI_XY.Location = new System.Drawing.Point(1, 196);
            this.Label_OutputDPI_XY.Name = "Label_OutputDPI_XY";
            this.Label_OutputDPI_XY.Size = new System.Drawing.Size(175, 14);
            this.Label_OutputDPI_XY.TabIndex = 70;
            this.Label_OutputDPI_XY.Text = "Output-DPI-(X&Y)       :";
            this.Label_OutputDPI_XY.UseMnemonic = false;
            // 
            // CB_TiffCompression
            // 
            this.CB_TiffCompression.AutoCompleteCustomSource.AddRange(new string[] {
            "off",
            "auto"});
            this.CB_TiffCompression.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_TiffCompression.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_TiffCompression.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TiffCompression.FormattingEnabled = true;
            this.CB_TiffCompression.Items.AddRange(new object[] {
            "",
            "lzw",
            "deflate",
            "packbits",
            "jpeg",
            "none"});
            this.CB_TiffCompression.Location = new System.Drawing.Point(145, 342);
            this.CB_TiffCompression.Name = "CB_TiffCompression";
            this.CB_TiffCompression.Size = new System.Drawing.Size(138, 22);
            this.CB_TiffCompression.TabIndex = 99;
            this.TT_STCLI.SetToolTip(this.CB_TiffCompression, "default : lzw");
            this.CB_TiffCompression.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_TiffCompression
            // 
            this.Label_TiffCompression.AutoSize = true;
            this.Label_TiffCompression.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TiffCompression.Location = new System.Drawing.Point(1, 345);
            this.Label_TiffCompression.Name = "Label_TiffCompression";
            this.Label_TiffCompression.Size = new System.Drawing.Size(140, 14);
            this.Label_TiffCompression.TabIndex = 98;
            this.Label_TiffCompression.Text = "Tiff-Compression  :";
            // 
            // CheckB_TiffForceKeepColorSpace
            // 
            this.CheckB_TiffForceKeepColorSpace.AutoSize = true;
            this.CheckB_TiffForceKeepColorSpace.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_TiffForceKeepColorSpace.Location = new System.Drawing.Point(1, 275);
            this.CheckB_TiffForceKeepColorSpace.Name = "CheckB_TiffForceKeepColorSpace";
            this.CheckB_TiffForceKeepColorSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_TiffForceKeepColorSpace.Size = new System.Drawing.Size(222, 18);
            this.CheckB_TiffForceKeepColorSpace.TabIndex = 97;
            this.CheckB_TiffForceKeepColorSpace.Text = " Tiff-Force-Keep-Color-Space";
            this.TT_STCLI.SetToolTip(this.CheckB_TiffForceKeepColorSpace, "Output tiffs will be in original color space");
            this.CheckB_TiffForceKeepColorSpace.UseVisualStyleBackColor = true;
            this.CheckB_TiffForceKeepColorSpace.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_TiffForceGrayscale
            // 
            this.CheckB_TiffForceGrayscale.AutoSize = true;
            this.CheckB_TiffForceGrayscale.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_TiffForceGrayscale.Location = new System.Drawing.Point(1, 257);
            this.CheckB_TiffForceGrayscale.Name = "CheckB_TiffForceGrayscale";
            this.CheckB_TiffForceGrayscale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_TiffForceGrayscale.Size = new System.Drawing.Size(222, 18);
            this.CheckB_TiffForceGrayscale.TabIndex = 96;
            this.CheckB_TiffForceGrayscale.Text = "        Tiff-Force-Grayscale";
            this.TT_STCLI.SetToolTip(this.CheckB_TiffForceGrayscale, "All output tiffs will be grayscale");
            this.CheckB_TiffForceGrayscale.UseVisualStyleBackColor = true;
            this.CheckB_TiffForceGrayscale.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_TiffForceRGB
            // 
            this.CheckB_TiffForceRGB.AutoSize = true;
            this.CheckB_TiffForceRGB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_TiffForceRGB.Location = new System.Drawing.Point(1, 239);
            this.CheckB_TiffForceRGB.Name = "CheckB_TiffForceRGB";
            this.CheckB_TiffForceRGB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_TiffForceRGB.Size = new System.Drawing.Size(222, 18);
            this.CheckB_TiffForceRGB.TabIndex = 95;
            this.CheckB_TiffForceRGB.Text = "              Tiff-Force-RGB";
            this.TT_STCLI.SetToolTip(this.CheckB_TiffForceRGB, "All output tiffs will be rgb");
            this.CheckB_TiffForceRGB.UseVisualStyleBackColor = true;
            this.CheckB_TiffForceRGB.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_OutputDPI
            // 
            this.Label_OutputDPI.AutoSize = true;
            this.Label_OutputDPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OutputDPI.Location = new System.Drawing.Point(1, 173);
            this.Label_OutputDPI.Name = "Label_OutputDPI";
            this.Label_OutputDPI.Size = new System.Drawing.Size(175, 14);
            this.Label_OutputDPI.TabIndex = 68;
            this.Label_OutputDPI.Text = "Output-DPI             :";
            this.TT_STCLI.SetToolTip(this.Label_OutputDPI, "If set the content detection is set to manual mode");
            // 
            // UpDown_OutputDPI
            // 
            this.UpDown_OutputDPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_OutputDPI.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_OutputDPI.Location = new System.Drawing.Point(177, 170);
            this.UpDown_OutputDPI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_OutputDPI.Name = "UpDown_OutputDPI";
            this.UpDown_OutputDPI.Size = new System.Drawing.Size(106, 20);
            this.UpDown_OutputDPI.TabIndex = 69;
            this.TT_STCLI.SetToolTip(this.UpDown_OutputDPI, "default : 600; Sets X and Y output dpi");
            this.UpDown_OutputDPI.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_OutputDPI_X
            // 
            this.UpDown_OutputDPI_X.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_OutputDPI_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_OutputDPI_X.Location = new System.Drawing.Point(177, 193);
            this.UpDown_OutputDPI_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_OutputDPI_X.Name = "UpDown_OutputDPI_X";
            this.UpDown_OutputDPI_X.Size = new System.Drawing.Size(50, 20);
            this.UpDown_OutputDPI_X.TabIndex = 71;
            this.TT_STCLI.SetToolTip(this.UpDown_OutputDPI_X, "X-DPI");
            this.UpDown_OutputDPI_X.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_OutputDPI_Y
            // 
            this.UpDown_OutputDPI_Y.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_OutputDPI_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_OutputDPI_Y.Location = new System.Drawing.Point(233, 193);
            this.UpDown_OutputDPI_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_OutputDPI_Y.Name = "UpDown_OutputDPI_Y";
            this.UpDown_OutputDPI_Y.Size = new System.Drawing.Size(50, 20);
            this.UpDown_OutputDPI_Y.TabIndex = 72;
            this.TT_STCLI.SetToolTip(this.UpDown_OutputDPI_Y, "Y-DPI");
            this.UpDown_OutputDPI_Y.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DefaultOutputDPI
            // 
            this.Label_DefaultOutputDPI.AutoSize = true;
            this.Label_DefaultOutputDPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DefaultOutputDPI.Location = new System.Drawing.Point(1, 219);
            this.Label_DefaultOutputDPI.Name = "Label_DefaultOutputDPI";
            this.Label_DefaultOutputDPI.Size = new System.Drawing.Size(175, 14);
            this.Label_DefaultOutputDPI.TabIndex = 73;
            this.Label_DefaultOutputDPI.Text = "Default-Output-DPI     :";
            this.TT_STCLI.SetToolTip(this.Label_DefaultOutputDPI, "If set the content detection is set to manual mode");
            // 
            // UpDown_DepthPerception
            // 
            this.UpDown_DepthPerception.DecimalPlaces = 1;
            this.UpDown_DepthPerception.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DepthPerception.Location = new System.Drawing.Point(177, 12);
            this.UpDown_DepthPerception.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.UpDown_DepthPerception.Name = "UpDown_DepthPerception";
            this.UpDown_DepthPerception.Size = new System.Drawing.Size(106, 20);
            this.UpDown_DepthPerception.TabIndex = 90;
            this.TT_STCLI.SetToolTip(this.UpDown_DepthPerception, "default : 2.0");
            this.UpDown_DepthPerception.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // UpDown_DefaultOutputDPI
            // 
            this.UpDown_DefaultOutputDPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_DefaultOutputDPI.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UpDown_DefaultOutputDPI.Location = new System.Drawing.Point(177, 216);
            this.UpDown_DefaultOutputDPI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_DefaultOutputDPI.Name = "UpDown_DefaultOutputDPI";
            this.UpDown_DefaultOutputDPI.Size = new System.Drawing.Size(106, 20);
            this.UpDown_DefaultOutputDPI.TabIndex = 74;
            this.TT_STCLI.SetToolTip(this.UpDown_DefaultOutputDPI, "Default output dpi for pages created by split filter in gui");
            this.UpDown_DefaultOutputDPI.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_DepthPerception
            // 
            this.Label_DepthPerception.AutoSize = true;
            this.Label_DepthPerception.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DepthPerception.Location = new System.Drawing.Point(1, 15);
            this.Label_DepthPerception.Name = "Label_DepthPerception";
            this.Label_DepthPerception.Size = new System.Drawing.Size(175, 14);
            this.Label_DepthPerception.TabIndex = 89;
            this.Label_DepthPerception.Text = "Depth-Perception       :";
            // 
            // Label_ColorMode
            // 
            this.Label_ColorMode.AutoSize = true;
            this.Label_ColorMode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ColorMode.Location = new System.Drawing.Point(1, 298);
            this.Label_ColorMode.Name = "Label_ColorMode";
            this.Label_ColorMode.Size = new System.Drawing.Size(140, 14);
            this.Label_ColorMode.TabIndex = 75;
            this.Label_ColorMode.Text = "Color-Mode        :";
            // 
            // CB_Dewarping
            // 
            this.CB_Dewarping.AutoCompleteCustomSource.AddRange(new string[] {
            "off",
            "auto"});
            this.CB_Dewarping.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Dewarping.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Dewarping.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Dewarping.FormattingEnabled = true;
            this.CB_Dewarping.Items.AddRange(new object[] {
            "",
            "off",
            "auto"});
            this.CB_Dewarping.Location = new System.Drawing.Point(177, 120);
            this.CB_Dewarping.Name = "CB_Dewarping";
            this.CB_Dewarping.Size = new System.Drawing.Size(106, 22);
            this.CB_Dewarping.TabIndex = 88;
            this.TT_STCLI.SetToolTip(this.CB_Dewarping, "default : off");
            this.CB_Dewarping.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_ColorMode
            // 
            this.CB_ColorMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ColorMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ColorMode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ColorMode.FormattingEnabled = true;
            this.CB_ColorMode.Items.AddRange(new object[] {
            "",
            "black_and_white",
            "color_grayscale",
            "mixed"});
            this.CB_ColorMode.Location = new System.Drawing.Point(145, 294);
            this.CB_ColorMode.Name = "CB_ColorMode";
            this.CB_ColorMode.Size = new System.Drawing.Size(138, 22);
            this.CB_ColorMode.TabIndex = 76;
            this.TT_STCLI.SetToolTip(this.CB_ColorMode, "default : black & white");
            this.CB_ColorMode.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CheckB_WhiteMargins
            // 
            this.CheckB_WhiteMargins.AutoSize = true;
            this.CheckB_WhiteMargins.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_WhiteMargins.Location = new System.Drawing.Point(1, 34);
            this.CheckB_WhiteMargins.Name = "CheckB_WhiteMargins";
            this.CheckB_WhiteMargins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_WhiteMargins.Size = new System.Drawing.Size(222, 18);
            this.CheckB_WhiteMargins.TabIndex = 81;
            this.CheckB_WhiteMargins.Text = "               White-Margins";
            this.TT_STCLI.SetToolTip(this.CheckB_WhiteMargins, "default : false");
            this.CheckB_WhiteMargins.UseVisualStyleBackColor = true;
            this.CheckB_WhiteMargins.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Dewarping
            // 
            this.Label_Dewarping.AutoSize = true;
            this.Label_Dewarping.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Dewarping.Location = new System.Drawing.Point(1, 124);
            this.Label_Dewarping.Name = "Label_Dewarping";
            this.Label_Dewarping.Size = new System.Drawing.Size(175, 14);
            this.Label_Dewarping.TabIndex = 87;
            this.Label_Dewarping.Text = "Dewarping              :";
            // 
            // Label_DefaultColorMode
            // 
            this.Label_DefaultColorMode.AutoSize = true;
            this.Label_DefaultColorMode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DefaultColorMode.Location = new System.Drawing.Point(1, 321);
            this.Label_DefaultColorMode.Name = "Label_DefaultColorMode";
            this.Label_DefaultColorMode.Size = new System.Drawing.Size(140, 14);
            this.Label_DefaultColorMode.TabIndex = 77;
            this.Label_DefaultColorMode.Text = "Default-Color-Mode:";
            // 
            // CB_Despeckle
            // 
            this.CB_Despeckle.AutoCompleteCustomSource.AddRange(new string[] {
            "off",
            "cautious",
            "normal",
            "aggressive"});
            this.CB_Despeckle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Despeckle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Despeckle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Despeckle.FormattingEnabled = true;
            this.CB_Despeckle.Items.AddRange(new object[] {
            "",
            "off",
            "cautious",
            "normal",
            "aggressive"});
            this.CB_Despeckle.Location = new System.Drawing.Point(177, 95);
            this.CB_Despeckle.Name = "CB_Despeckle";
            this.CB_Despeckle.Size = new System.Drawing.Size(106, 22);
            this.CB_Despeckle.TabIndex = 86;
            this.TT_STCLI.SetToolTip(this.CB_Despeckle, "default : normal");
            this.CB_Despeckle.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_DefaultColorMode
            // 
            this.CB_DefaultColorMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_DefaultColorMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_DefaultColorMode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_DefaultColorMode.FormattingEnabled = true;
            this.CB_DefaultColorMode.Items.AddRange(new object[] {
            "",
            "black_and_white",
            "color_grayscale",
            "mixed"});
            this.CB_DefaultColorMode.Location = new System.Drawing.Point(145, 318);
            this.CB_DefaultColorMode.Name = "CB_DefaultColorMode";
            this.CB_DefaultColorMode.Size = new System.Drawing.Size(138, 22);
            this.CB_DefaultColorMode.TabIndex = 78;
            this.TT_STCLI.SetToolTip(this.CB_DefaultColorMode, "Sets default value for new images created by split filter");
            this.CB_DefaultColorMode.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Despeckle
            // 
            this.Label_Despeckle.AutoSize = true;
            this.Label_Despeckle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Despeckle.Location = new System.Drawing.Point(1, 99);
            this.Label_Despeckle.Name = "Label_Despeckle";
            this.Label_Despeckle.Size = new System.Drawing.Size(175, 14);
            this.Label_Despeckle.TabIndex = 85;
            this.Label_Despeckle.Text = "Despeckle              :";
            // 
            // Label_PictureShape
            // 
            this.Label_PictureShape.AutoSize = true;
            this.Label_PictureShape.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_PictureShape.Location = new System.Drawing.Point(1, 149);
            this.Label_PictureShape.Name = "Label_PictureShape";
            this.Label_PictureShape.Size = new System.Drawing.Size(175, 14);
            this.Label_PictureShape.TabIndex = 79;
            this.Label_PictureShape.Text = "Picture-Shape          :";
            // 
            // UpDown_Treshold
            // 
            this.UpDown_Treshold.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDown_Treshold.Location = new System.Drawing.Point(177, 72);
            this.UpDown_Treshold.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UpDown_Treshold.Name = "UpDown_Treshold";
            this.UpDown_Treshold.Size = new System.Drawing.Size(106, 20);
            this.UpDown_Treshold.TabIndex = 84;
            this.TT_STCLI.SetToolTip(this.UpDown_Treshold, "default : 0; n<0 thinner, n>0 thicker");
            this.UpDown_Treshold.ValueChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // CB_PictureShape
            // 
            this.CB_PictureShape.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_PictureShape.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_PictureShape.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_PictureShape.FormattingEnabled = true;
            this.CB_PictureShape.Items.AddRange(new object[] {
            "",
            "free",
            "rectangular"});
            this.CB_PictureShape.Location = new System.Drawing.Point(177, 145);
            this.CB_PictureShape.Name = "CB_PictureShape";
            this.CB_PictureShape.Size = new System.Drawing.Size(106, 22);
            this.CB_PictureShape.TabIndex = 80;
            this.TT_STCLI.SetToolTip(this.CB_PictureShape, "default : free");
            this.CB_PictureShape.SelectedIndexChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Label_Threshold
            // 
            this.Label_Threshold.AutoSize = true;
            this.Label_Threshold.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Threshold.Location = new System.Drawing.Point(1, 76);
            this.Label_Threshold.Name = "Label_Threshold";
            this.Label_Threshold.Size = new System.Drawing.Size(175, 14);
            this.Label_Threshold.TabIndex = 83;
            this.Label_Threshold.Text = "Threshold              :";
            this.TT_STCLI.SetToolTip(this.Label_Threshold, "If set the content detection is set to manual mode");
            // 
            // CheckB_NormalizeIllumination
            // 
            this.CheckB_NormalizeIllumination.AutoSize = true;
            this.CheckB_NormalizeIllumination.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_NormalizeIllumination.Location = new System.Drawing.Point(1, 53);
            this.CheckB_NormalizeIllumination.Name = "CheckB_NormalizeIllumination";
            this.CheckB_NormalizeIllumination.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_NormalizeIllumination.Size = new System.Drawing.Size(222, 18);
            this.CheckB_NormalizeIllumination.TabIndex = 82;
            this.CheckB_NormalizeIllumination.Text = "      Normalize-Illumination";
            this.TT_STCLI.SetToolTip(this.CheckB_NormalizeIllumination, "default : false");
            this.CheckB_NormalizeIllumination.UseVisualStyleBackColor = true;
            this.CheckB_NormalizeIllumination.CheckedChanged += new System.EventHandler(this.CMDChanged_Changed);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Red;
            this.Button_Exit.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(882, 815);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(120, 23);
            this.Button_Exit.TabIndex = 9;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // TT_STCLI
            // 
            this.TT_STCLI.AutoPopDelay = 10000;
            this.TT_STCLI.InitialDelay = 500;
            this.TT_STCLI.ReshowDelay = 100;
            // 
            // CheckB_Parallel
            // 
            this.CheckB_Parallel.AutoSize = true;
            this.CheckB_Parallel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_Parallel.Location = new System.Drawing.Point(7, 39);
            this.CheckB_Parallel.Name = "CheckB_Parallel";
            this.CheckB_Parallel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_Parallel.Size = new System.Drawing.Size(117, 18);
            this.CheckB_Parallel.TabIndex = 109;
            this.CheckB_Parallel.Text = "     Parallel";
            this.TT_STCLI.SetToolTip(this.CheckB_Parallel, "Parallel execution");
            this.CheckB_Parallel.UseVisualStyleBackColor = true;
            // 
            // OFD_ScanTailor_exe
            // 
            this.OFD_ScanTailor_exe.DefaultExt = "exe";
            this.OFD_ScanTailor_exe.FileName = "ScanTailor_CLI.exe";
            this.OFD_ScanTailor_exe.Filter = "ScanTailor-CLI|ScanTailor-CLI.exe|All files|*.*";
            this.OFD_ScanTailor_exe.Title = "Select \"ScanTailor-CLI.exe\"!";
            // 
            // GB_Output
            // 
            this.GB_Output.Controls.Add(this.CheckB_VerboseGUI);
            this.GB_Output.Controls.Add(this.CheckB_Parallel);
            this.GB_Output.Controls.Add(this.Text_CMD);
            this.GB_Output.Controls.Add(this.Button_Start);
            this.GB_Output.Controls.Add(this.Text_Output);
            this.GB_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Output.Location = new System.Drawing.Point(618, 9);
            this.GB_Output.Name = "GB_Output";
            this.GB_Output.Size = new System.Drawing.Size(384, 801);
            this.GB_Output.TabIndex = 107;
            this.GB_Output.TabStop = false;
            this.GB_Output.Text = "Output:";
            // 
            // CheckB_VerboseGUI
            // 
            this.CheckB_VerboseGUI.AutoSize = true;
            this.CheckB_VerboseGUI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_VerboseGUI.Location = new System.Drawing.Point(7, 15);
            this.CheckB_VerboseGUI.Name = "CheckB_VerboseGUI";
            this.CheckB_VerboseGUI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckB_VerboseGUI.Size = new System.Drawing.Size(117, 18);
            this.CheckB_VerboseGUI.TabIndex = 110;
            this.CheckB_VerboseGUI.Text = "  Verbose GUI";
            this.CheckB_VerboseGUI.UseVisualStyleBackColor = true;
            // 
            // Text_CMD
            // 
            this.Text_CMD.BackColor = System.Drawing.Color.Black;
            this.Text_CMD.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_CMD.ForeColor = System.Drawing.Color.Yellow;
            this.Text_CMD.Location = new System.Drawing.Point(7, 63);
            this.Text_CMD.Multiline = true;
            this.Text_CMD.Name = "Text_CMD";
            this.Text_CMD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_CMD.Size = new System.Drawing.Size(371, 489);
            this.Text_CMD.TabIndex = 108;
            this.Text_CMD.WordWrap = false;
            // 
            // Text_Output
            // 
            this.Text_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text_Output.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Output.ForeColor = System.Drawing.Color.Lime;
            this.Text_Output.Location = new System.Drawing.Point(7, 558);
            this.Text_Output.Multiline = true;
            this.Text_Output.Name = "Text_Output";
            this.Text_Output.ReadOnly = true;
            this.Text_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text_Output.Size = new System.Drawing.Size(371, 237);
            this.Text_Output.TabIndex = 107;
            this.Text_Output.WordWrap = false;
            // 
            // Button_CopyCL
            // 
            this.Button_CopyCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_CopyCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CopyCL.Location = new System.Drawing.Point(618, 815);
            this.Button_CopyCL.Name = "Button_CopyCL";
            this.Button_CopyCL.Size = new System.Drawing.Size(120, 23);
            this.Button_CopyCL.TabIndex = 108;
            this.Button_CopyCL.Text = "Copy CL to Clipboard";
            this.Button_CopyCL.UseVisualStyleBackColor = false;
            this.Button_CopyCL.Click += new System.EventHandler(this.Button_CopyCL_Click);
            // 
            // OFD_i_view32_exe
            // 
            this.OFD_i_view32_exe.FileName = "i_view32.exe";
            this.OFD_i_view32_exe.Filter = "IrfanView|i_view32.exe|All files|*.*";
            this.OFD_i_view32_exe.Title = "Select \"i_view32.exe\"!";
            // 
            // Form_ScanTailor_CLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 846);
            this.Controls.Add(this.Button_CopyCL);
            this.Controls.Add(this.GB_Output);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.GB_CLs);
            this.Controls.Add(this.GB_FileANDControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ScanTailor_CLI";
            this.Load += new System.EventHandler(this.Form_ScanTailor_CLI_Load);
            this.Shown += new System.EventHandler(this.Form_ScanTailor_CLI_Shown);
            this.GB_FileANDControl.ResumeLayout(false);
            this.GB_FileANDControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DPI_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_EndFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_StartFilter)).EndInit();
            this.GB_CLs.ResumeLayout(false);
            this.GB_CLs.PerformLayout();
            this.GB_04.ResumeLayout(false);
            this.GB_04.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentBox_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionBox_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ContentDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_PageDetectionBox_W)).EndInit();
            this.GB_02.ResumeLayout(false);
            this.GB_02.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_MatchLayoutTolerance)).EndInit();
            this.GB_05.ResumeLayout(false);
            this.GB_05.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_AlignmentTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Margins_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultMargins_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Rotate)).EndInit();
            this.GB_01.ResumeLayout(false);
            this.GB_01.PerformLayout();
            this.GB_03.ResumeLayout(false);
            this.GB_03.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_SkewDeviation)).EndInit();
            this.GB_06.ResumeLayout(false);
            this.GB_06.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_OutputDPI_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DepthPerception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_DefaultOutputDPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Treshold)).EndInit();
            this.GB_Output.ResumeLayout(false);
            this.GB_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_InputDir;
        private System.Windows.Forms.Label Label_OutputDir;
        private System.Windows.Forms.TextBox Text_InputDir;
        private System.Windows.Forms.TextBox Text_OutputDir;
        private System.Windows.Forms.Button Button_InputDir;
        private System.Windows.Forms.Button Button_OutputDir;
        private System.Windows.Forms.FolderBrowserDialog FBD_InputDir;
        private System.Windows.Forms.FolderBrowserDialog FBD_OutputDir;
        private System.Windows.Forms.GroupBox GB_FileANDControl;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label Label_Layout;
        private System.Windows.Forms.GroupBox GB_CLs;
        private ComboBoxMC.ComboBoxMC MCCB_Layout;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Label Label_LayoutDirection;
        private System.Windows.Forms.ComboBox CB_LayoutDirection;
        private System.Windows.Forms.ComboBox CB_Orientation;
        private System.Windows.Forms.Label Label_Orientation;
        private System.Windows.Forms.NumericUpDown UpDown_Rotate;
        private System.Windows.Forms.Label Label_Rotate;
        private System.Windows.Forms.ToolTip TT_STCLI;
        private System.Windows.Forms.ComboBox CB_Deskew;
        private System.Windows.Forms.Label Label_Deskew;
        private System.Windows.Forms.NumericUpDown UpDown_SkewDeviation;
        private System.Windows.Forms.Label Label_SkewDeviation;
        private System.Windows.Forms.CheckBox CheckB_EnableFineTuning;
        private System.Windows.Forms.CheckBox CheckB_EnablePageDetection;
        private System.Windows.Forms.CheckBox CheckB_DisableContentDetection;
        private System.Windows.Forms.CheckBox CheckB_ForceDisablePageDetection;
        private System.Windows.Forms.CheckBox CheckB_DisableContentTextMask;
        private System.Windows.Forms.ComboBox CB_ContentDetection;
        private System.Windows.Forms.Label Label_ContentDetection;
        private System.Windows.Forms.NumericUpDown UpDown_ContentDeviation;
        private System.Windows.Forms.Label Label_ContentDeviation;
        private System.Windows.Forms.Button Button_ScanTailorExe;
        private System.Windows.Forms.TextBox Text_ScanTailor_CLI;
        private System.Windows.Forms.Label Label_ScanTailor_CLI;
        private System.Windows.Forms.OpenFileDialog OFD_ScanTailor_exe;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Label Label_Profile;
        private System.Windows.Forms.ComboBox CB_Profile;
        private System.Windows.Forms.CheckBox CheckB_MatchLayoutDefault;
        private System.Windows.Forms.NumericUpDown UpDown_MatchLayoutTolerance;
        private System.Windows.Forms.Label Label_MatchLayoutTolerance;
        private System.Windows.Forms.CheckBox CheckB_MatchLayout;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultMargins_B;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultMargins_T;
        private System.Windows.Forms.Label Label_DefaultMargins_TB;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultMargins_R;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultMargins_L;
        private System.Windows.Forms.Label Label_DefaultMargins_LR;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultMargins;
        private System.Windows.Forms.Label Label_DefaultMargins;
        private System.Windows.Forms.NumericUpDown UpDown_Margins_B;
        private System.Windows.Forms.NumericUpDown UpDown_Margins_T;
        private System.Windows.Forms.Label Label_Margins_TB;
        private System.Windows.Forms.NumericUpDown UpDown_Margins_R;
        private System.Windows.Forms.NumericUpDown UpDown_Margins_L;
        private System.Windows.Forms.Label Label_Margins_LR;
        private System.Windows.Forms.NumericUpDown UpDown_Margins;
        private System.Windows.Forms.Label Label_Margins;
        private System.Windows.Forms.CheckBox CheckB_EnableAutoMargins;
        private System.Windows.Forms.NumericUpDown UpDown_ContentBox_H;
        private System.Windows.Forms.NumericUpDown UpDown_ContentBox_W;
        private System.Windows.Forms.Label Label_ContentBoxWH;
        private System.Windows.Forms.NumericUpDown UpDown_ContentBox_T;
        private System.Windows.Forms.NumericUpDown UpDown_ContentBox_L;
        private System.Windows.Forms.Label Label_ContentBoxLT;
        private System.Windows.Forms.ComboBox CB_Alignment;
        private System.Windows.Forms.Label Label_Alignment;
        private System.Windows.Forms.ComboBox CB_AlignmentHorizontal;
        private System.Windows.Forms.Label Label_AlignmentHorizontal;
        private System.Windows.Forms.ComboBox CB_AlignmentVertical;
        private System.Windows.Forms.Label Label_AlignmentVertical;
        private System.Windows.Forms.NumericUpDown UpDown_DefaultOutputDPI;
        private System.Windows.Forms.Label Label_DefaultOutputDPI;
        private System.Windows.Forms.NumericUpDown UpDown_OutputDPI_Y;
        private System.Windows.Forms.NumericUpDown UpDown_OutputDPI_X;
        private System.Windows.Forms.Label Label_OutputDPI_XY;
        private System.Windows.Forms.NumericUpDown UpDown_OutputDPI;
        private System.Windows.Forms.Label Label_OutputDPI;
        private System.Windows.Forms.NumericUpDown UpDown_DPI_Y;
        private System.Windows.Forms.NumericUpDown UpDown_DPI_X;
        private System.Windows.Forms.Label Label_DPI_XY;
        private System.Windows.Forms.NumericUpDown UpDown_DPI;
        private System.Windows.Forms.Label Label_DPI;
        private System.Windows.Forms.NumericUpDown UpDown_AlignmentTolerance;
        private System.Windows.Forms.Label Label_AlignmentTolerance;
        private System.Windows.Forms.NumericUpDown UpDown_StartFilter;
        private System.Windows.Forms.Label Label_StartFilter;
        private System.Windows.Forms.NumericUpDown UpDown_DepthPerception;
        private System.Windows.Forms.Label Label_DepthPerception;
        private System.Windows.Forms.ComboBox CB_Dewarping;
        private System.Windows.Forms.Label Label_Dewarping;
        private System.Windows.Forms.ComboBox CB_Despeckle;
        private System.Windows.Forms.Label Label_Despeckle;
        private System.Windows.Forms.NumericUpDown UpDown_Treshold;
        private System.Windows.Forms.Label Label_Threshold;
        private System.Windows.Forms.CheckBox CheckB_NormalizeIllumination;
        private System.Windows.Forms.CheckBox CheckB_WhiteMargins;
        private System.Windows.Forms.ComboBox CB_PictureShape;
        private System.Windows.Forms.Label Label_PictureShape;
        private System.Windows.Forms.ComboBox CB_DefaultColorMode;
        private System.Windows.Forms.Label Label_DefaultColorMode;
        private System.Windows.Forms.ComboBox CB_ColorMode;
        private System.Windows.Forms.Label Label_ColorMode;
        private System.Windows.Forms.CheckBox CheckB_Verbose;
        private System.Windows.Forms.CheckBox CheckB_DisableCheckOutput;
        private System.Windows.Forms.NumericUpDown UpDown_PageDetectionTolerance;
        private System.Windows.Forms.Label Label_PageDetectionTolerance;
        private System.Windows.Forms.NumericUpDown UpDown_PageDetectionBox_H;
        private System.Windows.Forms.NumericUpDown UpDown_PageDetectionBox_W;
        private System.Windows.Forms.Label Label_PageDetectionBox;
        private System.Windows.Forms.ComboBox CB_TiffCompression;
        private System.Windows.Forms.Label Label_TiffCompression;
        private System.Windows.Forms.CheckBox CheckB_TiffForceKeepColorSpace;
        private System.Windows.Forms.CheckBox CheckB_TiffForceGrayscale;
        private System.Windows.Forms.CheckBox CheckB_TiffForceRGB;
        private System.Windows.Forms.NumericUpDown UpDown_EndFilter;
        private System.Windows.Forms.Label Label_EndFilter;
        private System.Windows.Forms.GroupBox GB_01;
        private System.Windows.Forms.GroupBox GB_03;
        private System.Windows.Forms.GroupBox GB_05;
        private System.Windows.Forms.GroupBox GB_06;
        private System.Windows.Forms.GroupBox GB_Output;
        private System.Windows.Forms.TextBox Text_CMD;
        private System.Windows.Forms.TextBox Text_Output;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.CheckBox CheckB_Parallel;
        private System.Windows.Forms.CheckBox CheckB_ProjectORImageMode;
        private System.Windows.Forms.Button Button_CopyCL;
        private System.Windows.Forms.GroupBox GB_02;
        private System.Windows.Forms.CheckBox CheckB_UseIrfanView;
        private System.Windows.Forms.Label Label_RotateApplyTo;
        private System.Windows.Forms.ComboBox CB_ApplyRotateTo;
        private System.Windows.Forms.GroupBox GB_04;
        private System.Windows.Forms.Label Label_IrfanView;
        private System.Windows.Forms.Button Button_IrfanViewExe;
        private System.Windows.Forms.TextBox Text_IrfanViewExe;
        private System.Windows.Forms.OpenFileDialog OFD_i_view32_exe;
        private System.Windows.Forms.CheckBox CheckB_VerboseGUI;
    }
}

