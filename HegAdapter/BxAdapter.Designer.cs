namespace BxAdapter {
    partial class BxAdapter {

        private void SetupToolTips() {
            //toolTipMain.SetToolTip(this.chkEnableVis, "If checked, BxAdapter controls the linked program\'s visibility.");
            //toolTipMain.SetToolTip(this.chkEnableVol, "If checked, BxAdapter controls the computer\'s volume.");

            //toolTipMain.SetToolTip(this.trackVis, "Linked programs\'s visibility level. \r\n\r\nValue 255 = Fully Visible\r\nValue 1 = Invisible\r\n");
            //toolTipMain.SetToolTip(this.trackVol, "Computer\'s volume level. \r\n\r\nValue 255 = Full Volume\r\nValue 0 = Mute\r\n");

            //toolTipMain.SetToolTip(this.trackVisMin, "Minimum visibility for the linked program.");
            //toolTipMain.SetToolTip(this.trackVolMin, "Minimum volume for the computer.");

            //toolTipMain.SetToolTip(this.updnVisPass, "During a pass signal, visibility is increased by this amount.");
            //toolTipMain.SetToolTip(this.updnVolPass, "During a pass signal, volume is increased by this amount.");

            //toolTipMain.SetToolTip(this.updnVisFail, "During a fail signal, visibility is decreased by this amount.");
            //toolTipMain.SetToolTip(this.updnVolFail, "During a fail signal, volume is decreased by this amount.");

//            toolTipMain.SetToolTip(this.btnBackgroundColor, "Set the background color for the linked program.");
//            toolTipMain.SetToolTip(this.updnVolMax, "Maximum volume level BxAdapter can set (cannot be below the minimum).");

////            toolTipMain.SetToolTip(this.btnShowSelectedWindow, "Clicking activates the linked program.");
////            toolTipMain.SetToolTip(this.btnChooseProgram, "Clicking opens menu for loading new and previously linked programs.");
////            toolTipMain.SetToolTip(this.btnSignalStatus, "Shows pass/fail signal or question markes when there is no signal.\r\nClicking starts signal simulation.");

//            toolTipMain.SetToolTip(this.chkEnableKeys, "If checked, sends indicate keystroke to linked program during pass signal.\r\n" +
//                "(Works mostly with arcade games-not apps like notepad).");

//            toolTipMain.SetToolTip(this.radioTapKey, "During a pass signal, simulated key is tapped repeatedly.");
//            toolTipMain.SetToolTip(this.radioHoldKey, "Simulated key is held for duration of pass signal.");

//            toolTipMain.SetToolTip(this.txtKeyToSend, "In this box, type the key which will be simulated.");
//            //toolTipMain.SetToolTip(this.btnChangeSettings, "Adjust BxAdapter settings and view registration information.");
//            toolTipMain.SetToolTip(this.btnSetMiniMode, "Toggle mini-mode\r\n (ALT-F3 hotkey also toggles mini-mode)");
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BxAdapter));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackVol = new System.Windows.Forms.TrackBar();
            this.chkEnableVol = new System.Windows.Forms.CheckBox();
            this.pnlBackgroundColor = new System.Windows.Forms.Panel();
            this.btnBackgroundColor = new System.Windows.Forms.LinkLabel();
            this.chkEnableVis = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackVisMin = new System.Windows.Forms.TrackBar();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSight = new System.Windows.Forms.TabPage();
            this.ddlVisChannel = new System.Windows.Forms.ComboBox();
            this.pnlVisibility = new System.Windows.Forms.Panel();
            this.trackVis = new System.Windows.Forms.TrackBar();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.ddlVolChannel = new System.Windows.Forms.ComboBox();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.updnVolMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trackVolMin = new System.Windows.Forms.TrackBar();
            this.tabMore = new System.Windows.Forms.TabPage();
            this.txtVolMin = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.btnStopSimulation = new System.Windows.Forms.LinkLabel();
            this.btnSignalStatus = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVisMin = new System.Windows.Forms.TextBox();
            this.cmbVisFeedbackType = new System.Windows.Forms.ComboBox();
            this.txtVis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlKeyChannel = new System.Windows.Forms.ComboBox();
            this.btnSendKeyHelp = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtKeyPressStat = new System.Windows.Forms.TextBox();
            this.txtKeyToSend = new System.Windows.Forms.TextBox();
            this.chkEnableKeys = new System.Windows.Forms.CheckBox();
            this.radioHoldKey = new System.Windows.Forms.RadioButton();
            this.radioTapKey = new System.Windows.Forms.RadioButton();
            this.btnSetMiniMode = new System.Windows.Forms.LinkLabel();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.groupConnectionStatus = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnNoSpeakerError = new System.Windows.Forms.LinkLabel();
            this.btnNoBioexplorerInstalled = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            this.label37 = new System.Windows.Forms.Label();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.trackBar13 = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.trackBar14 = new System.Windows.Forms.TrackBar();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.trackBar15 = new System.Windows.Forms.TrackBar();
            this.label47 = new System.Windows.Forms.Label();
            this.trackBar16 = new System.Windows.Forms.TrackBar();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.tmrRegistration = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label53 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.helpProviderMain = new System.Windows.Forms.HelpProvider();
            this.lblVisControlTypeExplanation = new System.Windows.Forms.Label();
            this.tmrSimulation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVisMin)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabSight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVis)).BeginInit();
            this.tabSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnVolMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolMin)).BeginInit();
            this.tabMore.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.groupConnectionStatus.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            this.tabPage12.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Volume";
            // 
            // trackVol
            // 
            this.trackVol.BackColor = System.Drawing.Color.Thistle;
            this.trackVol.Location = new System.Drawing.Point(105, 28);
            this.trackVol.Maximum = 255;
            this.trackVol.Name = "trackVol";
            this.trackVol.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVol.Size = new System.Drawing.Size(45, 119);
            this.trackVol.TabIndex = 9;
            this.trackVol.TickFrequency = 0;
            this.trackVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVol.Value = 255;
            this.trackVol.ValueChanged += new System.EventHandler(this.trackVol_ValueChanged);
            // 
            // chkEnableVol
            // 
            this.chkEnableVol.AutoSize = true;
            this.chkEnableVol.Checked = true;
            this.chkEnableVol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableVol.Location = new System.Drawing.Point(6, 6);
            this.chkEnableVol.Name = "chkEnableVol";
            this.chkEnableVol.Size = new System.Drawing.Size(61, 17);
            this.chkEnableVol.TabIndex = 0;
            this.chkEnableVol.Text = "Control";
            this.chkEnableVol.UseVisualStyleBackColor = true;
            this.chkEnableVol.CheckedChanged += new System.EventHandler(this.chkEnableVol_CheckedChanged_1);
            // 
            // pnlBackgroundColor
            // 
            this.pnlBackgroundColor.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackgroundColor.Location = new System.Drawing.Point(54, 143);
            this.pnlBackgroundColor.Name = "pnlBackgroundColor";
            this.pnlBackgroundColor.Size = new System.Drawing.Size(20, 20);
            this.pnlBackgroundColor.TabIndex = 33;
            this.pnlBackgroundColor.Click += new System.EventHandler(this.pnlBackgroundColor_Click);
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.AutoSize = true;
            this.btnBackgroundColor.LinkColor = System.Drawing.Color.Black;
            this.btnBackgroundColor.Location = new System.Drawing.Point(17, 145);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(32, 13);
            this.btnBackgroundColor.TabIndex = 32;
            this.btnBackgroundColor.TabStop = true;
            this.btnBackgroundColor.Text = "Color";
            this.btnBackgroundColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBackgroundColor_LinkClicked);
            // 
            // chkEnableVis
            // 
            this.chkEnableVis.AutoSize = true;
            this.chkEnableVis.Checked = true;
            this.chkEnableVis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableVis.Location = new System.Drawing.Point(6, 6);
            this.chkEnableVis.Name = "chkEnableVis";
            this.chkEnableVis.Size = new System.Drawing.Size(61, 17);
            this.chkEnableVis.TabIndex = 28;
            this.chkEnableVis.Text = "Control";
            this.chkEnableVis.UseVisualStyleBackColor = true;
            this.chkEnableVis.CheckedChanged += new System.EventHandler(this.chkEnableVis_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Visibility";
            // 
            // trackVisMin
            // 
            this.trackVisMin.Location = new System.Drawing.Point(142, 28);
            this.trackVisMin.Maximum = 255;
            this.trackVisMin.Name = "trackVisMin";
            this.trackVisMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVisMin.Size = new System.Drawing.Size(45, 119);
            this.trackVisMin.TabIndex = 23;
            this.trackVisMin.TabStop = false;
            this.trackVisMin.TickFrequency = 0;
            this.trackVisMin.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVisMin.ValueChanged += new System.EventHandler(this.trackVisMin_ValueChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSight);
            this.tabMain.Controls.Add(this.tabSound);
            this.tabMain.Controls.Add(this.tabMore);
            this.tabMain.Controls.Add(this.tabHelp);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(196, 198);
            this.tabMain.TabIndex = 28;
            // 
            // tabSight
            // 
            this.tabSight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabSight.Controls.Add(this.ddlVisChannel);
            this.tabSight.Controls.Add(this.pnlVisibility);
            this.tabSight.Controls.Add(this.chkEnableVis);
            this.tabSight.Controls.Add(this.trackVisMin);
            this.tabSight.Controls.Add(this.pnlBackgroundColor);
            this.tabSight.Controls.Add(this.trackVis);
            this.tabSight.Controls.Add(this.btnBackgroundColor);
            this.tabSight.Controls.Add(this.label3);
            this.tabSight.Controls.Add(this.label4);
            this.tabSight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSight.Location = new System.Drawing.Point(4, 22);
            this.tabSight.Name = "tabSight";
            this.tabSight.Padding = new System.Windows.Forms.Padding(3);
            this.tabSight.Size = new System.Drawing.Size(188, 172);
            this.tabSight.TabIndex = 0;
            this.tabSight.Text = "Visibility";
            // 
            // ddlVisChannel
            // 
            this.ddlVisChannel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ddlVisChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVisChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlVisChannel.FormattingEnabled = true;
            this.ddlVisChannel.Location = new System.Drawing.Point(98, 7);
            this.ddlVisChannel.Name = "ddlVisChannel";
            this.ddlVisChannel.Size = new System.Drawing.Size(81, 21);
            this.ddlVisChannel.Sorted = true;
            this.ddlVisChannel.TabIndex = 51;
            this.ddlVisChannel.SelectedIndexChanged += new System.EventHandler(this.ddlVisChannel_SelectedIndexChanged);
            // 
            // pnlVisibility
            // 
            this.pnlVisibility.Location = new System.Drawing.Point(6, 36);
            this.pnlVisibility.Name = "pnlVisibility";
            this.pnlVisibility.Size = new System.Drawing.Size(83, 101);
            this.pnlVisibility.TabIndex = 49;
            // 
            // trackVis
            // 
            this.trackVis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.trackVis.Location = new System.Drawing.Point(105, 28);
            this.trackVis.Maximum = 255;
            this.trackVis.Minimum = 1;
            this.trackVis.Name = "trackVis";
            this.trackVis.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVis.Size = new System.Drawing.Size(45, 119);
            this.trackVis.TabIndex = 22;
            this.trackVis.TabStop = false;
            this.trackVis.TickFrequency = 0;
            this.trackVis.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVis.Value = 255;
            this.trackVis.ValueChanged += new System.EventHandler(this.trackVis_ValueChanged);
            // 
            // tabSound
            // 
            this.tabSound.BackColor = System.Drawing.Color.Thistle;
            this.tabSound.Controls.Add(this.ddlVolChannel);
            this.tabSound.Controls.Add(this.pnlVolume);
            this.tabSound.Controls.Add(this.updnVolMax);
            this.tabSound.Controls.Add(this.label1);
            this.tabSound.Controls.Add(this.chkEnableVol);
            this.tabSound.Controls.Add(this.trackVolMin);
            this.tabSound.Controls.Add(this.label7);
            this.tabSound.Controls.Add(this.trackVol);
            this.tabSound.Controls.Add(this.label6);
            this.tabSound.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSound.Location = new System.Drawing.Point(4, 22);
            this.tabSound.Name = "tabSound";
            this.tabSound.Padding = new System.Windows.Forms.Padding(3);
            this.tabSound.Size = new System.Drawing.Size(188, 172);
            this.tabSound.TabIndex = 1;
            this.tabSound.Text = "Volume";
            // 
            // ddlVolChannel
            // 
            this.ddlVolChannel.BackColor = System.Drawing.Color.Thistle;
            this.ddlVolChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVolChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlVolChannel.FormattingEnabled = true;
            this.ddlVolChannel.Location = new System.Drawing.Point(98, 7);
            this.ddlVolChannel.Name = "ddlVolChannel";
            this.ddlVolChannel.Size = new System.Drawing.Size(81, 21);
            this.ddlVolChannel.Sorted = true;
            this.ddlVolChannel.TabIndex = 49;
            this.ddlVolChannel.SelectedIndexChanged += new System.EventHandler(this.ddlVolChannel_SelectedIndexChanged);
            // 
            // pnlVolume
            // 
            this.pnlVolume.Location = new System.Drawing.Point(6, 36);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(83, 101);
            this.pnlVolume.TabIndex = 48;
            // 
            // updnVolMax
            // 
            this.updnVolMax.Location = new System.Drawing.Point(48, 143);
            this.updnVolMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updnVolMax.Name = "updnVolMax";
            this.updnVolMax.Size = new System.Drawing.Size(41, 21);
            this.updnVolMax.TabIndex = 47;
            this.updnVolMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updnVolMax.ValueChanged += new System.EventHandler(this.updnVolMax_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Max Vol:";
            // 
            // trackVolMin
            // 
            this.trackVolMin.Location = new System.Drawing.Point(142, 28);
            this.trackVolMin.Maximum = 255;
            this.trackVolMin.Name = "trackVolMin";
            this.trackVolMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolMin.Size = new System.Drawing.Size(45, 119);
            this.trackVolMin.TabIndex = 7;
            this.trackVolMin.TickFrequency = 0;
            this.trackVolMin.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolMin.ValueChanged += new System.EventHandler(this.trackVolMin_ValueChanged);
            // 
            // tabMore
            // 
            this.tabMore.Controls.Add(this.txtVolMin);
            this.tabMore.Controls.Add(this.txtVol);
            this.tabMore.Controls.Add(this.btnStopSimulation);
            this.tabMore.Controls.Add(this.btnSignalStatus);
            this.tabMore.Controls.Add(this.panel3);
            this.tabMore.Controls.Add(this.panel1);
            this.tabMore.Controls.Add(this.btnSetMiniMode);
            this.tabMore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMore.Location = new System.Drawing.Point(4, 22);
            this.tabMore.Name = "tabMore";
            this.tabMore.Padding = new System.Windows.Forms.Padding(3);
            this.tabMore.Size = new System.Drawing.Size(188, 172);
            this.tabMore.TabIndex = 4;
            this.tabMore.Text = "More";
            this.tabMore.UseVisualStyleBackColor = true;
            // 
            // txtVolMin
            // 
            this.txtVolMin.Enabled = false;
            this.txtVolMin.Location = new System.Drawing.Point(125, 169);
            this.txtVolMin.Name = "txtVolMin";
            this.txtVolMin.ReadOnly = true;
            this.txtVolMin.Size = new System.Drawing.Size(31, 21);
            this.txtVolMin.TabIndex = 67;
            this.txtVolMin.Text = "0";
            this.txtVolMin.Visible = false;
            // 
            // txtVol
            // 
            this.txtVol.Enabled = false;
            this.txtVol.Location = new System.Drawing.Point(85, 169);
            this.txtVol.Name = "txtVol";
            this.txtVol.ReadOnly = true;
            this.txtVol.Size = new System.Drawing.Size(31, 21);
            this.txtVol.TabIndex = 66;
            this.txtVol.Text = "255";
            this.txtVol.Visible = false;
            // 
            // btnStopSimulation
            // 
            this.btnStopSimulation.AutoSize = true;
            this.btnStopSimulation.LinkColor = System.Drawing.Color.Black;
            this.btnStopSimulation.Location = new System.Drawing.Point(54, 81);
            this.btnStopSimulation.Name = "btnStopSimulation";
            this.btnStopSimulation.Size = new System.Drawing.Size(80, 13);
            this.btnStopSimulation.TabIndex = 65;
            this.btnStopSimulation.TabStop = true;
            this.btnStopSimulation.Text = "Stop Simulation";
            this.btnStopSimulation.Visible = false;
            // 
            // btnSignalStatus
            // 
            this.btnSignalStatus.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignalStatus.LinkColor = System.Drawing.Color.Black;
            this.btnSignalStatus.Location = new System.Drawing.Point(54, 100);
            this.btnSignalStatus.Name = "btnSignalStatus";
            this.btnSignalStatus.Size = new System.Drawing.Size(39, 13);
            this.btnSignalStatus.TabIndex = 64;
            this.btnSignalStatus.TabStop = true;
            this.btnSignalStatus.Text = "none";
            this.btnSignalStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.txtVisMin);
            this.panel3.Controls.Add(this.cmbVisFeedbackType);
            this.panel3.Controls.Add(this.txtVis);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 154);
            this.panel3.TabIndex = 62;
            // 
            // txtVisMin
            // 
            this.txtVisMin.Enabled = false;
            this.txtVisMin.Location = new System.Drawing.Point(62, 134);
            this.txtVisMin.Name = "txtVisMin";
            this.txtVisMin.ReadOnly = true;
            this.txtVisMin.Size = new System.Drawing.Size(31, 21);
            this.txtVisMin.TabIndex = 11;
            this.txtVisMin.TabStop = false;
            this.txtVisMin.Text = "0";
            this.txtVisMin.Visible = false;
            // 
            // cmbVisFeedbackType
            // 
            this.cmbVisFeedbackType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmbVisFeedbackType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisFeedbackType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVisFeedbackType.FormattingEnabled = true;
            this.cmbVisFeedbackType.Location = new System.Drawing.Point(21, 49);
            this.cmbVisFeedbackType.Name = "cmbVisFeedbackType";
            this.cmbVisFeedbackType.Size = new System.Drawing.Size(125, 21);
            this.cmbVisFeedbackType.Sorted = true;
            this.cmbVisFeedbackType.TabIndex = 52;
            this.cmbVisFeedbackType.Visible = false;
            this.cmbVisFeedbackType.SelectedIndexChanged += new System.EventHandler(this.cmbVisFeedbackType_SelectedIndexChanged);
            // 
            // txtVis
            // 
            this.txtVis.Enabled = false;
            this.txtVis.Location = new System.Drawing.Point(18, 134);
            this.txtVis.Name = "txtVis";
            this.txtVis.ReadOnly = true;
            this.txtVis.Size = new System.Drawing.Size(31, 21);
            this.txtVis.TabIndex = 10;
            this.txtVis.TabStop = false;
            this.txtVis.Text = "255";
            this.txtVis.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "BioExplorer Connection:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.ddlKeyChannel);
            this.panel1.Controls.Add(this.btnSendKeyHelp);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.txtKeyPressStat);
            this.panel1.Controls.Add(this.txtKeyToSend);
            this.panel1.Controls.Add(this.chkEnableKeys);
            this.panel1.Controls.Add(this.radioHoldKey);
            this.panel1.Controls.Add(this.radioTapKey);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 109);
            this.panel1.TabIndex = 58;
            // 
            // ddlKeyChannel
            // 
            this.ddlKeyChannel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ddlKeyChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKeyChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlKeyChannel.FormattingEnabled = true;
            this.ddlKeyChannel.Location = new System.Drawing.Point(142, 4);
            this.ddlKeyChannel.Name = "ddlKeyChannel";
            this.ddlKeyChannel.Size = new System.Drawing.Size(42, 21);
            this.ddlKeyChannel.Sorted = true;
            this.ddlKeyChannel.TabIndex = 63;
            this.ddlKeyChannel.SelectedIndexChanged += new System.EventHandler(this.ddlKeyChannel_SelectedIndexChanged);
            // 
            // btnSendKeyHelp
            // 
            this.btnSendKeyHelp.AutoSize = true;
            this.btnSendKeyHelp.LinkColor = System.Drawing.SystemColors.WindowText;
            this.btnSendKeyHelp.Location = new System.Drawing.Point(23, 28);
            this.btnSendKeyHelp.Name = "btnSendKeyHelp";
            this.btnSendKeyHelp.Size = new System.Drawing.Size(28, 13);
            this.btnSendKeyHelp.TabIndex = 62;
            this.btnSendKeyHelp.TabStop = true;
            this.btnSendKeyHelp.Text = "Help";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel2.Location = new System.Drawing.Point(23, 41);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 61;
            // 
            // txtKeyPressStat
            // 
            this.txtKeyPressStat.Enabled = false;
            this.txtKeyPressStat.Location = new System.Drawing.Point(78, 58);
            this.txtKeyPressStat.Name = "txtKeyPressStat";
            this.txtKeyPressStat.ReadOnly = true;
            this.txtKeyPressStat.Size = new System.Drawing.Size(58, 21);
            this.txtKeyPressStat.TabIndex = 60;
            this.txtKeyPressStat.TabStop = false;
            // 
            // txtKeyToSend
            // 
            this.txtKeyToSend.Location = new System.Drawing.Point(78, 4);
            this.txtKeyToSend.Name = "txtKeyToSend";
            this.txtKeyToSend.Size = new System.Drawing.Size(58, 21);
            this.txtKeyToSend.TabIndex = 36;
            this.txtKeyToSend.TabStop = false;
            this.txtKeyToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyToSend_KeyDown);
            this.txtKeyToSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyToSend_KeyUp);
            // 
            // chkEnableKeys
            // 
            this.chkEnableKeys.AutoSize = true;
            this.chkEnableKeys.Location = new System.Drawing.Point(6, 6);
            this.chkEnableKeys.Name = "chkEnableKeys";
            this.chkEnableKeys.Size = new System.Drawing.Size(75, 17);
            this.chkEnableKeys.TabIndex = 29;
            this.chkEnableKeys.TabStop = false;
            this.chkEnableKeys.Text = "Send Key:";
            this.chkEnableKeys.UseVisualStyleBackColor = true;
            this.chkEnableKeys.CheckedChanged += new System.EventHandler(this.chkEnableKeys_CheckedChanged);
            // 
            // radioHoldKey
            // 
            this.radioHoldKey.AutoSize = true;
            this.radioHoldKey.Location = new System.Drawing.Point(78, 41);
            this.radioHoldKey.Name = "radioHoldKey";
            this.radioHoldKey.Size = new System.Drawing.Size(67, 17);
            this.radioHoldKey.TabIndex = 43;
            this.radioHoldKey.Text = "Hold Key";
            this.radioHoldKey.UseVisualStyleBackColor = true;
            this.radioHoldKey.CheckedChanged += new System.EventHandler(this.radioHoldKey_CheckedChanged);
            // 
            // radioTapKey
            // 
            this.radioTapKey.AutoSize = true;
            this.radioTapKey.Checked = true;
            this.radioTapKey.Location = new System.Drawing.Point(78, 26);
            this.radioTapKey.Name = "radioTapKey";
            this.radioTapKey.Size = new System.Drawing.Size(64, 17);
            this.radioTapKey.TabIndex = 42;
            this.radioTapKey.TabStop = true;
            this.radioTapKey.Text = "Tap Key";
            this.radioTapKey.UseVisualStyleBackColor = true;
            this.radioTapKey.CheckedChanged += new System.EventHandler(this.radioTapKey_CheckedChanged);
            // 
            // btnSetMiniMode
            // 
            this.btnSetMiniMode.Location = new System.Drawing.Point(0, 0);
            this.btnSetMiniMode.Name = "btnSetMiniMode";
            this.btnSetMiniMode.Size = new System.Drawing.Size(100, 23);
            this.btnSetMiniMode.TabIndex = 63;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.groupConnectionStatus);
            this.tabHelp.Controls.Add(this.btnNoSpeakerError);
            this.tabHelp.Controls.Add(this.btnNoBioexplorerInstalled);
            this.tabHelp.Controls.Add(this.linkLabel8);
            this.tabHelp.Controls.Add(this.linkLabel1);
            this.tabHelp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(188, 172);
            this.tabHelp.TabIndex = 2;
            this.tabHelp.Text = "Setup";
            this.tabHelp.UseVisualStyleBackColor = true;
            this.tabHelp.Click += new System.EventHandler(this.tabHelp_Click);
            // 
            // groupConnectionStatus
            // 
            this.groupConnectionStatus.Controls.Add(this.lblConnectionStatus);
            this.groupConnectionStatus.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupConnectionStatus.Location = new System.Drawing.Point(23, 26);
            this.groupConnectionStatus.Name = "groupConnectionStatus";
            this.groupConnectionStatus.Size = new System.Drawing.Size(134, 37);
            this.groupConnectionStatus.TabIndex = 79;
            this.groupConnectionStatus.TabStop = false;
            this.groupConnectionStatus.Text = "Brain Focus Connection";
            this.groupConnectionStatus.Visible = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblConnectionStatus.Location = new System.Drawing.Point(5, 14);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(123, 19);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "NOT CONNECTED";
            this.lblConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNoSpeakerError
            // 
            this.btnNoSpeakerError.AutoSize = true;
            this.btnNoSpeakerError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSpeakerError.LinkColor = System.Drawing.Color.Red;
            this.btnNoSpeakerError.Location = new System.Drawing.Point(3, 3);
            this.btnNoSpeakerError.Name = "btnNoSpeakerError";
            this.btnNoSpeakerError.Size = new System.Drawing.Size(66, 13);
            this.btnNoSpeakerError.TabIndex = 74;
            this.btnNoSpeakerError.TabStop = true;
            this.btnNoSpeakerError.Text = "No speakers";
            this.btnNoSpeakerError.Visible = false;
            // 
            // btnNoBioexplorerInstalled
            // 
            this.btnNoBioexplorerInstalled.Location = new System.Drawing.Point(0, 0);
            this.btnNoBioexplorerInstalled.Name = "btnNoBioexplorerInstalled";
            this.btnNoBioexplorerInstalled.Size = new System.Drawing.Size(100, 23);
            this.btnNoBioexplorerInstalled.TabIndex = 81;
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel8.Location = new System.Drawing.Point(8, 158);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(0, 13);
            this.linkLabel8.TabIndex = 62;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(5, 92);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 58;
            this.linkLabel1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Controls.Add(this.trackBar2);
            this.tabPage1.Controls.Add(this.linkLabel3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(172, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pass";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Enable";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 88);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(110, 3);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 133);
            this.trackBar1.TabIndex = 23;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fail";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 43);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(69, 3);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 133);
            this.trackBar2.TabIndex = 22;
            this.trackBar2.TickFrequency = 0;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 255;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(3, 134);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(52, 13);
            this.linkLabel3.TabIndex = 32;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "BG Color:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(123, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Visibility";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Min";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(69, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "255";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Thistle;
            this.tabPage2.Controls.Add(this.numericUpDown3);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.numericUpDown4);
            this.tabPage2.Controls.Add(this.trackBar3);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.trackBar4);
            this.tabPage2.Controls.Add(this.numericUpDown5);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(172, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sound";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(6, 150);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown3.TabIndex = 47;
            this.numericUpDown3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Pass";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 6);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(6, 86);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown4.TabIndex = 45;
            this.numericUpDown4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(110, 3);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 133);
            this.trackBar3.TabIndex = 37;
            this.trackBar3.TickFrequency = 0;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(67, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Volume";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(70, 2);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 133);
            this.trackBar4.TabIndex = 36;
            this.trackBar4.TickFrequency = 0;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Value = 255;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(6, 41);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown5.TabIndex = 44;
            this.numericUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Min";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(121, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(31, 20);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Fail";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(70, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(31, 20);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "255";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel4);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.linkLabel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(172, 177);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(7, 76);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(101, 13);
            this.linkLabel4.TabIndex = 56;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Demo with Notepad";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(9, 155);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(99, 17);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.Text = "Enable Tooltips";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 52);
            this.label20.TabIndex = 53;
            this.label20.Text = "BxAdapter is a powerful tool to \r\nconnect BioExplorer to games, \r\nDVDs and more f" +
    "or an engaing \r\nneurofeedback experience.\r\n";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(6, 100);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(93, 13);
            this.linkLabel5.TabIndex = 52;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Tutorial with Tetris";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage7.Controls.Add(this.label31);
            this.tabPage7.Controls.Add(this.checkBox8);
            this.tabPage7.Controls.Add(this.numericUpDown11);
            this.tabPage7.Controls.Add(this.trackBar9);
            this.tabPage7.Controls.Add(this.panel4);
            this.tabPage7.Controls.Add(this.label32);
            this.tabPage7.Controls.Add(this.numericUpDown12);
            this.tabPage7.Controls.Add(this.trackBar10);
            this.tabPage7.Controls.Add(this.linkLabel9);
            this.tabPage7.Controls.Add(this.textBox9);
            this.tabPage7.Controls.Add(this.label33);
            this.tabPage7.Controls.Add(this.label34);
            this.tabPage7.Controls.Add(this.textBox10);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(172, 177);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Sight";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(30, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "Pass";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(6, 6);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(59, 17);
            this.checkBox8.TabIndex = 28;
            this.checkBox8.Text = "Enable";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(6, 88);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown11.TabIndex = 31;
            this.numericUpDown11.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(110, 3);
            this.trackBar9.Maximum = 255;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar9.Size = new System.Drawing.Size(45, 133);
            this.trackBar9.TabIndex = 23;
            this.trackBar9.TickFrequency = 0;
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(6, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 33;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "Fail";
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(6, 43);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown12.TabIndex = 30;
            this.numericUpDown12.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar10
            // 
            this.trackBar10.Location = new System.Drawing.Point(69, 3);
            this.trackBar10.Maximum = 255;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar10.Size = new System.Drawing.Size(45, 133);
            this.trackBar10.TabIndex = 22;
            this.trackBar10.TickFrequency = 0;
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar10.Value = 255;
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.LinkColor = System.Drawing.Color.Black;
            this.linkLabel9.Location = new System.Drawing.Point(3, 134);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(52, 13);
            this.linkLabel9.TabIndex = 32;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "BG Color:";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(123, 151);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(31, 20);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(66, 135);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 13);
            this.label33.TabIndex = 26;
            this.label33.Text = "Visibility";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(120, 135);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(24, 13);
            this.label34.TabIndex = 27;
            this.label34.Text = "Min";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(69, 151);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(31, 20);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "255";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Thistle;
            this.tabPage8.Controls.Add(this.numericUpDown13);
            this.tabPage8.Controls.Add(this.label35);
            this.tabPage8.Controls.Add(this.label36);
            this.tabPage8.Controls.Add(this.checkBox9);
            this.tabPage8.Controls.Add(this.numericUpDown14);
            this.tabPage8.Controls.Add(this.trackBar11);
            this.tabPage8.Controls.Add(this.label37);
            this.tabPage8.Controls.Add(this.trackBar12);
            this.tabPage8.Controls.Add(this.numericUpDown15);
            this.tabPage8.Controls.Add(this.label38);
            this.tabPage8.Controls.Add(this.textBox11);
            this.tabPage8.Controls.Add(this.label39);
            this.tabPage8.Controls.Add(this.textBox12);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(172, 177);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Sound";
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(6, 150);
            this.numericUpDown13.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown13.TabIndex = 47;
            this.numericUpDown13.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 136);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 46;
            this.label35.Text = "Max";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(30, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "Pass";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(6, 6);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(59, 17);
            this.checkBox9.TabIndex = 29;
            this.checkBox9.Text = "Enable";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(6, 86);
            this.numericUpDown14.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown14.TabIndex = 45;
            this.numericUpDown14.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // trackBar11
            // 
            this.trackBar11.Location = new System.Drawing.Point(110, 3);
            this.trackBar11.Maximum = 255;
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar11.Size = new System.Drawing.Size(45, 133);
            this.trackBar11.TabIndex = 37;
            this.trackBar11.TickFrequency = 0;
            this.trackBar11.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(67, 136);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 13);
            this.label37.TabIndex = 40;
            this.label37.Text = "Volume";
            // 
            // trackBar12
            // 
            this.trackBar12.Location = new System.Drawing.Point(70, 2);
            this.trackBar12.Maximum = 255;
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar12.Size = new System.Drawing.Size(45, 133);
            this.trackBar12.TabIndex = 36;
            this.trackBar12.TickFrequency = 0;
            this.trackBar12.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar12.Value = 255;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(6, 41);
            this.numericUpDown15.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown15.TabIndex = 44;
            this.numericUpDown15.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(118, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(24, 13);
            this.label38.TabIndex = 41;
            this.label38.Text = "Min";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(121, 150);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(31, 20);
            this.textBox11.TabIndex = 33;
            this.textBox11.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 70);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 13);
            this.label39.TabIndex = 42;
            this.label39.Text = "Fail";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(70, 150);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(31, 20);
            this.textBox12.TabIndex = 32;
            this.textBox12.Text = "255";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.linkLabel10);
            this.tabPage9.Controls.Add(this.checkBox10);
            this.tabPage9.Controls.Add(this.label40);
            this.tabPage9.Controls.Add(this.linkLabel11);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(172, 177);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Help";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(7, 76);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(101, 13);
            this.linkLabel10.TabIndex = 56;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Demo with Notepad";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(9, 155);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(99, 17);
            this.checkBox10.TabIndex = 55;
            this.checkBox10.Text = "Enable Tooltips";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(7, 11);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(156, 52);
            this.label40.TabIndex = 53;
            this.label40.Text = "BxAdapter is a powerful tool to \r\nconnect BioExplorer to games, \r\nDVDs and more f" +
    "or an engaing \r\nneurofeedback experience.\r\n";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(6, 100);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(93, 13);
            this.linkLabel11.TabIndex = 52;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "Tutorial with Tetris";
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage10.Controls.Add(this.label41);
            this.tabPage10.Controls.Add(this.checkBox11);
            this.tabPage10.Controls.Add(this.numericUpDown16);
            this.tabPage10.Controls.Add(this.trackBar13);
            this.tabPage10.Controls.Add(this.panel5);
            this.tabPage10.Controls.Add(this.label42);
            this.tabPage10.Controls.Add(this.numericUpDown17);
            this.tabPage10.Controls.Add(this.trackBar14);
            this.tabPage10.Controls.Add(this.linkLabel12);
            this.tabPage10.Controls.Add(this.textBox13);
            this.tabPage10.Controls.Add(this.label43);
            this.tabPage10.Controls.Add(this.label44);
            this.tabPage10.Controls.Add(this.textBox14);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(172, 177);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Sight";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 26);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 34;
            this.label41.Text = "Pass";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(6, 6);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(59, 17);
            this.checkBox11.TabIndex = 28;
            this.checkBox11.Text = "Enable";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(6, 88);
            this.numericUpDown16.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown16.TabIndex = 31;
            this.numericUpDown16.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar13
            // 
            this.trackBar13.Location = new System.Drawing.Point(110, 3);
            this.trackBar13.Maximum = 255;
            this.trackBar13.Name = "trackBar13";
            this.trackBar13.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar13.Size = new System.Drawing.Size(45, 133);
            this.trackBar13.TabIndex = 23;
            this.trackBar13.TickFrequency = 0;
            this.trackBar13.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(6, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 20);
            this.panel5.TabIndex = 33;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 72);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(23, 13);
            this.label42.TabIndex = 24;
            this.label42.Text = "Fail";
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(6, 43);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown17.TabIndex = 30;
            this.numericUpDown17.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // trackBar14
            // 
            this.trackBar14.Location = new System.Drawing.Point(69, 3);
            this.trackBar14.Maximum = 255;
            this.trackBar14.Name = "trackBar14";
            this.trackBar14.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar14.Size = new System.Drawing.Size(45, 133);
            this.trackBar14.TabIndex = 22;
            this.trackBar14.TickFrequency = 0;
            this.trackBar14.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar14.Value = 255;
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.LinkColor = System.Drawing.Color.Black;
            this.linkLabel12.Location = new System.Drawing.Point(3, 134);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(52, 13);
            this.linkLabel12.TabIndex = 32;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "BG Color:";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(123, 151);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(31, 20);
            this.textBox13.TabIndex = 9;
            this.textBox13.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(66, 135);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(43, 13);
            this.label43.TabIndex = 26;
            this.label43.Text = "Visibility";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(120, 135);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(24, 13);
            this.label44.TabIndex = 27;
            this.label44.Text = "Min";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(69, 151);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(31, 20);
            this.textBox14.TabIndex = 8;
            this.textBox14.Text = "255";
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.Thistle;
            this.tabPage11.Controls.Add(this.numericUpDown18);
            this.tabPage11.Controls.Add(this.label45);
            this.tabPage11.Controls.Add(this.label46);
            this.tabPage11.Controls.Add(this.checkBox12);
            this.tabPage11.Controls.Add(this.numericUpDown19);
            this.tabPage11.Controls.Add(this.trackBar15);
            this.tabPage11.Controls.Add(this.label47);
            this.tabPage11.Controls.Add(this.trackBar16);
            this.tabPage11.Controls.Add(this.numericUpDown20);
            this.tabPage11.Controls.Add(this.label48);
            this.tabPage11.Controls.Add(this.textBox15);
            this.tabPage11.Controls.Add(this.label49);
            this.tabPage11.Controls.Add(this.textBox16);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(172, 177);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Sound";
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(6, 150);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown18.TabIndex = 47;
            this.numericUpDown18.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(6, 136);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(27, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Max";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 25);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(30, 13);
            this.label46.TabIndex = 35;
            this.label46.Text = "Pass";
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(6, 6);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(59, 17);
            this.checkBox12.TabIndex = 29;
            this.checkBox12.Text = "Enable";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(6, 86);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown19.TabIndex = 45;
            this.numericUpDown19.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // trackBar15
            // 
            this.trackBar15.Location = new System.Drawing.Point(110, 3);
            this.trackBar15.Maximum = 255;
            this.trackBar15.Name = "trackBar15";
            this.trackBar15.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar15.Size = new System.Drawing.Size(45, 133);
            this.trackBar15.TabIndex = 37;
            this.trackBar15.TickFrequency = 0;
            this.trackBar15.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(67, 136);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(42, 13);
            this.label47.TabIndex = 40;
            this.label47.Text = "Volume";
            // 
            // trackBar16
            // 
            this.trackBar16.Location = new System.Drawing.Point(70, 2);
            this.trackBar16.Maximum = 255;
            this.trackBar16.Name = "trackBar16";
            this.trackBar16.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar16.Size = new System.Drawing.Size(45, 133);
            this.trackBar16.TabIndex = 36;
            this.trackBar16.TickFrequency = 0;
            this.trackBar16.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar16.Value = 255;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(6, 41);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown20.TabIndex = 44;
            this.numericUpDown20.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(118, 136);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(24, 13);
            this.label48.TabIndex = 41;
            this.label48.Text = "Min";
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(121, 150);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(31, 20);
            this.textBox15.TabIndex = 33;
            this.textBox15.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(3, 70);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(23, 13);
            this.label49.TabIndex = 42;
            this.label49.Text = "Fail";
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(70, 150);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(31, 20);
            this.textBox16.TabIndex = 32;
            this.textBox16.Text = "255";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.linkLabel13);
            this.tabPage12.Controls.Add(this.checkBox13);
            this.tabPage12.Controls.Add(this.label50);
            this.tabPage12.Controls.Add(this.linkLabel14);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(172, 177);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Help";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Location = new System.Drawing.Point(7, 76);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(101, 13);
            this.linkLabel13.TabIndex = 56;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Demo with Notepad";
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Location = new System.Drawing.Point(9, 155);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(99, 17);
            this.checkBox13.TabIndex = 55;
            this.checkBox13.Text = "Enable Tooltips";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(7, 11);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(156, 52);
            this.label50.TabIndex = 53;
            this.label50.Text = "BxAdapter is a powerful tool to \r\nconnect BioExplorer to games, \r\nDVDs and more f" +
    "or an engaing \r\nneurofeedback experience.\r\n";
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Location = new System.Drawing.Point(6, 100);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(93, 13);
            this.linkLabel14.TabIndex = 52;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Tutorial with Tetris";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label53);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(153, 110);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Step 1";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(6, 11);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(141, 96);
            this.label53.TabIndex = 0;
            this.label53.Text = "BxAdapter receives PASS/FAIL signals from BioExplorer (they are simulated in the " +
    "demo).  You can see the signal flash green for pass and red for fail in this pro" +
    "gram.";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label54);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(153, 110);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Step 2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(6, 11);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(144, 96);
            this.label54.TabIndex = 1;
            this.label54.Text = "A. You load up any other pogram to link to BioExplorer (Clickomania loaded for de" +
    "mo).  \r\nB. Then press ALT-F1 while program is active to link it (automatically d" +
    "one in demo).";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(153, 110);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Step 3";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // helpProviderMain
            // 
            this.helpProviderMain.HelpNamespace = "BxAdapterHelp.chm";
            // 
            // lblVisControlTypeExplanation
            // 
            this.lblVisControlTypeExplanation.AutoSize = true;
            this.lblVisControlTypeExplanation.Location = new System.Drawing.Point(1, 20);
            this.lblVisControlTypeExplanation.Name = "lblVisControlTypeExplanation";
            this.lblVisControlTypeExplanation.Size = new System.Drawing.Size(0, 13);
            this.lblVisControlTypeExplanation.TabIndex = 57;
            this.lblVisControlTypeExplanation.Visible = false;
            // 
            // tmrSimulation
            // 
            this.tmrSimulation.Tick += new System.EventHandler(this.tmrSimulation_Tick);
            // 
            // BxAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 197);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblVisControlTypeExplanation);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BxAdapter";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set in code";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BxTrans_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.BxAdapter_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVisMin)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabSight.ResumeLayout(false);
            this.tabSight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVis)).EndInit();
            this.tabSound.ResumeLayout(false);
            this.tabSound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updnVolMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolMin)).EndInit();
            this.tabMore.ResumeLayout(false);
            this.tabMore.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.groupConnectionStatus.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackVisMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEnableVol;
        private System.Windows.Forms.CheckBox chkEnableVis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackVol;
        private System.Windows.Forms.LinkLabel btnBackgroundColor;
        private System.Windows.Forms.Panel pnlBackgroundColor;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSight;
        private System.Windows.Forms.TabPage tabSound;
        private System.Windows.Forms.NumericUpDown updnVolMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.TrackBar trackBar13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.TrackBar trackBar14;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.NumericUpDown numericUpDown19;
        private System.Windows.Forms.TrackBar trackBar15;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TrackBar trackBar16;
        private System.Windows.Forms.NumericUpDown numericUpDown20;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.TrackBar trackVolMin;
        private System.Windows.Forms.TabPage tabMore;
        private System.Windows.Forms.TrackBar trackVis;
        private System.Windows.Forms.LinkLabel btnSetMiniMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKeyToSend;
        private System.Windows.Forms.CheckBox chkEnableKeys;
        private System.Windows.Forms.RadioButton radioTapKey;
        private System.Windows.Forms.TextBox txtKeyPressStat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tmrRegistration;
        private System.Windows.Forms.LinkLabel btnNoBioexplorerInstalled;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.HelpProvider helpProviderMain;
        private System.Windows.Forms.LinkLabel btnSendKeyHelp;
        private System.Windows.Forms.Label lblVisControlTypeExplanation;
        private System.Windows.Forms.Panel pnlVolume;
        private System.Windows.Forms.Panel pnlVisibility;
        private System.Windows.Forms.ComboBox ddlVolChannel;
        private System.Windows.Forms.ComboBox ddlVisChannel;
        private System.Windows.Forms.ComboBox ddlKeyChannel;
        private System.Windows.Forms.RadioButton radioHoldKey;
        private System.Windows.Forms.ComboBox cmbVisFeedbackType;
        private System.Windows.Forms.Timer tmrSimulation;
        private System.Windows.Forms.LinkLabel btnStopSimulation;
        private System.Windows.Forms.LinkLabel btnSignalStatus;
        private System.Windows.Forms.LinkLabel btnNoSpeakerError;
        private System.Windows.Forms.TextBox txtVolMin;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.TextBox txtVisMin;
        private System.Windows.Forms.TextBox txtVis;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox groupConnectionStatus;
    }
}

