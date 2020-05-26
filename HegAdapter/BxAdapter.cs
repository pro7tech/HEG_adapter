using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;


namespace BxAdapter {
    public partial class BxAdapter : Form {
        public static string BxAdapterTitle = "Focus Adapter";

        #region setup
        private ColorPicker MyColorPicker;
        private Settings MySettings;
        private DateTime BxAdapterLoadTime;
        //private RewardKeySender RewardKeySender;
        //private SystemHotkey hotkeySelectActiveWindow;
        //private SystemHotkey hotkeyOpenProgramSelector;
        //private SystemHotkey hotkeyChangeToScreenBrightnessFeedback;
        //private SystemHotkey hotkeyChangeToScreenColorFeedback;
        
        private BxClientHost BxClientHost;

        public ProgramSelector ProgramSelectorForm;
        public VolumeManager VolManager;
        public VisibilityManager VisManager;
        public DiscreteSignalEffectSetter discreteVisibility;
        public DiscreteSignalEffectSetter discreteVolume;
        public VariableSignalEffectSetter variableVisibility;
        public VariableSignalEffectSetter variableVolume;
        public VariableFeedbackNotAvailable variableVisFeedbackNotAvailable;
        public VariableFeedbackNotAvailable variableVolFeedbackNotAvailable;

        public Connection Connection;
        public SignalProcessor SignalProcessor;
        public SignalSimulator SignalSimulator;
        public RewardSetter RewardSetter;
        public Channels AllChanels;
        public ProgramLinker ProgramLinker;
        
        

        public bool ControlVisibility { get { return chkEnableVis.Checked; } }
        public bool ControlVolume { get { return chkEnableVol.Checked; } }
        public bool ControlSendKey { get { return this.chkEnableKeys.Checked; } }
        public Panel VisibilityPanel { get { return this.pnlVisibility; } }
        public Panel VolumePanel { get { return this.pnlVolume; } }
        public LinkLabel SignalStatusButton { get { return this.btnSignalStatus; } }
        public TrackBar TrackVis { get { return this.trackVis; } }
        public TrackBar TrackVol { get { return this.trackVol; } }
        public TrackBar TrackVisMin { get { return this.trackVisMin; } }
        public TrackBar TrackVolMin { get { return this.trackVolMin; } }
        public NumericUpDown UpdnVolMax { get { return this.updnVolMax ; } }
        public TextBox TxtVisMin { get { return this.txtVisMin; } }
        public TextBox TxtVolMin { get { return this.txtVolMin; } }
        public TextBox TxtVis { get { return this.txtVis; } }
        public TextBox TxtVol { get { return this.txtVol; } }
        public ComboBox CmbVisFeedbackType { get { return this.cmbVisFeedbackType; } }
        public Label LblVisControlTypeExplanation { get { return this.lblVisControlTypeExplanation; } }
//        public LinkLabel BtnShowSelectedWindow { get { return this.btnShowSelectedWindow; } }
        public LinkLabel BtnStopSimulation { get { return this.btnStopSimulation; } }
        public System.Windows.Forms.Timer TmrSimulation { get { return this.tmrSimulation; } }
        public int MaximumVolume { get { return (int) this.updnVolMax.Value; } }
        
        public BxAdapter() {
            SetupOnlyNeedingInitializedComponents();
            SetupNeedingPersistentSettings();
            SetupNeedingAfterTrialModeCheck();


            tabMain.TabPages.Remove(tabMore);
            tabMain.SelectedTab = tabHelp;


        }

        private void SetupNeedingPersistentSettings() {
            LoadPersistentSettings();
          
            Globals.Settings = new Settings(this, ProgramSelectorForm);
            ProgramSelectorForm = new ProgramSelector(this);
            C.LockFormSizeAndSetTopmost(this);
            if (Globals.ShowTooltips) {
                SetupToolTips();
            }


            groupConnectionStatus.Visible = true;

            SignalProcessor.ActivateVisEffectSetter(SignalType.Discrete);
            SignalProcessor.ActivateVolEffectSetter(SignalType.Discrete);
            //RewardKeySender = new RewardKeySender(txtKeyToSend, null, GetKeyInteractType());
        }

        private void SetupOnlyNeedingInitializedComponents() {
            InitializeComponent();
#if DEBUG
            //btnGetMoreGames.Text += " (DEBUG)";
#endif
            RewardSetter = new RewardSetter(this);
            VolManager = new VolumeManager(updnVolMax, this);
            if (VolManager.MissingSpeaker) {
                btnNoSpeakerError.Visible = true;
            }

            Globals.BxAdapter = this;

            UpdateSightOrSoundControlVisibility(tabSound, chkEnableVol);
            //UpdateSendKeyControlVisibility();

            
            //Connection = new Connection(lblConnectionStatus, BioexplorerConnectionForm, this);
            //Connection.ShowStatus(ConnectionStatus.NotConnected);
            
            MySettings = new Settings(this, ProgramSelectorForm);

            txtKeyToSend.Text = C.BlankKeyPressText;
            this.Text = BxAdapterTitle;
            BxAdapterLoadTime = DateTime.Now;
            tabMain.SelectedTab = tabHelp;
         
            SignalProcessor = new SignalProcessor(this);
            SignalSimulator = new SignalSimulator(this);
            ProgramLinker = new ProgramLinker(this);
        }

        private void SetupNeedingAfterTrialModeCheck() {

            SetupHotkeys(); //hotkeys - only setup after trial mode displayed so can't skip it

        }

        public void SetHasConnectionToBioExplorer() {
            tabMain.SelectedTab = tabSight;
            Properties.Settings.Default.HasConnectedToBioExplorer = true;
            Properties.Settings.Default.Save();


        }

        private void SetupHotkeys() {
            this.components = new System.ComponentModel.Container();
            //this.hotkeySelectActiveWindow = new SystemHotkey(this.components);
            //this.hotkeySelectActiveWindow.Shortcut = System.Windows.Forms.Shortcut.AltF1;
            //this.hotkeySelectActiveWindow.Pressed += new System.EventHandler(this.selectActiveWindowHotkey_Pressed);
            //this.hotkeyOpenProgramSelector = new SystemHotkey(this.components);
            //this.hotkeyOpenProgramSelector.Shortcut = System.Windows.Forms.Shortcut.AltF2;
            //this.hotkeyOpenProgramSelector.Pressed += new EventHandler();

            //this.hotkeyChangeToScreenBrightnessFeedback = new SystemHotkey(this.components);
            //this.hotkeyChangeToScreenBrightnessFeedback.Shortcut = System.Windows.Forms.Shortcut.AltF2;
            //this.hotkeyChangeToScreenBrightnessFeedback.Pressed += new EventHandler(hotkeyChangeToScreenBrightnessFeedback_Pressed);
            
            //this.hotkeyChangeToScreenColorFeedback = new SystemHotkey(this.components);
            //this.hotkeyChangeToScreenColorFeedback.Shortcut = Shortcut.AltF3;
            //this.hotkeyChangeToScreenColorFeedback.Pressed += new EventHandler(hotkeyChangeToScreenColorFeedback_Pressed);

        }

        void hotkeyChangeToScreenColorFeedback_Pressed(object sender, EventArgs e) {
            VisManager.SetVisFeedbackModeDropdownSelection(VisFeedbackMode.ScreenColor);
        }

        void hotkeyChangeToScreenBrightnessFeedback_Pressed(object sender, EventArgs e) {
            VisManager.SetVisFeedbackModeDropdownSelection(VisFeedbackMode.GammaWholeScreen);
        }

        public void ShowNoBioexplorer() {
            this.btnNoBioexplorerInstalled.Visible = true;
        }


        #endregion

        #region saving and loading settings
        private void LoadPersistentSettings() {
            this.discreteVisibility = new DiscreteSignalEffectSetter();
            this.discreteVolume = new DiscreteSignalEffectSetter();
            this.variableVisibility = new VariableSignalEffectSetter(Color.LightSteelBlue);
            this.variableVolume = new VariableSignalEffectSetter(Color.Thistle);
            this.variableVisFeedbackNotAvailable = new VariableFeedbackNotAvailable();
            this.variableVolFeedbackNotAvailable = new VariableFeedbackNotAvailable();

            VisManager = new VisibilityManager(this);
            VisManager.SetVisFeedbackModeWithStringOrUseDefault(Properties.Settings.Default.VisFeedbackModeDescription);
            discreteVisibility.PassChange = Properties.Settings.Default.VisPassIncrement;
            discreteVisibility.FailChange = Properties.Settings.Default.VisFailDecrement;
            trackVisMin.Value = Properties.Settings.Default.VisMinThreshold;

            discreteVolume.PassChange = Properties.Settings.Default.VolPassIncrement;
            discreteVolume.FailChange = Properties.Settings.Default.VolFailDecrement;
            trackVolMin.Value = Properties.Settings.Default.VolMinThreshold;

            chkEnableVis.Checked = Properties.Settings.Default.EnableVisibilityChecked;
            chkEnableVol.Checked = Properties.Settings.Default.EnableVolumeChecked;
            chkEnableKeys.Checked = Properties.Settings.Default.EnableKeysChecked;

            //Globals.AllPrograms = ProgramsSerializer.LoadSerializedObjectFromFile(Application.StartupPath);
            Globals.WindowsAreTopmost = Properties.Settings.Default.WindowsAreTopmost;
            Globals.ShowTooltips = Properties.Settings.Default.ShowTooltips;
            Globals.DemoDisplayed = Properties.Settings.Default.DemoDisplayed;
            Globals.BackgroundColor = Properties.Settings.Default.BackgroundColor;

            Globals.BackgroundColorForm = new BackgroundColorForm();
            Globals.ForegroundColorForm = new ForegroundColorForm(this);
            SetBackgroundColor(Globals.BackgroundColor);
            MyColorPicker = new ColorPicker(this);

            AllChanels = new Channels(ddlVisChannel, ddlVolChannel, ddlKeyChannel);
        }

        public void SaveSettings() {
            //ProgramsSerializer.SaveSerializedObjectToFile(Globals.AllPrograms, Application.StartupPath);

            Properties.Settings.Default.VisFeedbackModeDescription = this.VisManager.CurrentVisFeedbackMode.ToString();

            Properties.Settings.Default.BackgroundColor = Globals.BackgroundColor;

            Properties.Settings.Default.VisPassIncrement = discreteVisibility.PassChange;
            Properties.Settings.Default.VisFailDecrement = discreteVisibility.FailChange;
            Properties.Settings.Default.VisMinThreshold = trackVisMin.Value;

            Properties.Settings.Default.VolPassIncrement = discreteVolume.PassChange;
            Properties.Settings.Default.VolFailDecrement = discreteVolume.FailChange;
            Properties.Settings.Default.VolMinThreshold = trackVolMin.Value;

            Properties.Settings.Default.EnableVisibilityChecked = chkEnableVis.Checked;
            Properties.Settings.Default.EnableVolumeChecked = chkEnableVol.Checked;
            Properties.Settings.Default.EnableKeysChecked = chkEnableKeys.Checked;

            Properties.Settings.Default.WindowsAreTopmost = Globals.WindowsAreTopmost;
            Properties.Settings.Default.ShowTooltips = Globals.ShowTooltips;
            Properties.Settings.Default.DemoDisplayed = Globals.DemoDisplayed;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region combo channel events
        private void ddlVisChannel_SelectedIndexChanged(object sender, EventArgs e) {
            AllChanels.UpdateSelectedVisChannelId();
        }

        private void ddlVolChannel_SelectedIndexChanged(object sender, EventArgs e) {
            AllChanels.UpdateSelectedVolChannelId();
        }

        private void ddlKeyChannel_SelectedIndexChanged(object sender, EventArgs e) {
            AllChanels.UpdateSelectedKeyChannelId();
        }
        #endregion

        #region events for visibility and volume changes
        
        private void trackVis_ValueChanged(object sender, EventArgs e) {
            if (chkEnableVis.Checked) {
                RewardSetter.VisibilityValueChanged();
            }
        }

        private void trackVisMin_ValueChanged(object sender, EventArgs e) {
            RewardSetter.MinVisLevelChanged();
        }

        private void trackVol_ValueChanged(object sender, EventArgs e) {
            if (chkEnableVol.Checked) {
                RewardSetter.VolLevelChanged();
            }
        }

        private void trackVolMin_ValueChanged(object sender, EventArgs e) {
            RewardSetter.MinVolLevelChanged();
        }

        private void updnVolMax_ValueChanged(object sender, EventArgs e) {
            RewardSetter.MaxVolChanged();
        }

        #endregion

        #region other events

        private void BxTrans_FormClosing(object sender, FormClosingEventArgs e) {
            SetConditionsBackToNormal();
            // BxClientHost.Shutdown();
            SaveSettings();
        }

        public void SetConditionsBackToNormal()
        {
            VolManager.SetToNormal();
            VisManager.SetFullBrightness();
        }

        private void selectActiveWindowHotkey_Pressed(object sender, System.EventArgs e) {
            ProgramLinker.LinkViaWindowPtr(Window.GetForegroundWindow());
        }

        private void btnShowSelectedWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        //void openProgramSelectorHotkey_Pressed(object sender, EventArgs e) {
        //    if (ProgramSelectorForm.Visible) {
        //        ProgramSelectorForm.Hide();
        //    } else {
        //        C.ShowForm(ProgramSelectorForm, this);
        //    }
        //}

        private void pnlBackgroundColor_Click(object sender, EventArgs e) {
            ShowColorPicker();
        }

        private void btnBackgroundColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ShowColorPicker();
        }

        private void btnChooseProgram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            C.ShowForm(ProgramSelectorForm, this);
        }

        private void txtKeyToSend_KeyDown(object sender, KeyEventArgs e) {
            e.Handled = true;
            //RewardKeySender.SetKey(e);
        }

        public void SetKeyInteractType() {
            //RewardKeySender.KeyInteractType = GetKeyInteractType();
        }

        private void radioTapKey_CheckedChanged(object sender, EventArgs e) {
            SetKeyInteractType();
        }

        private void radioHoldKey_CheckedChanged(object sender, EventArgs e) {
            SetKeyInteractType();
        }

        private void btnBxAdapterSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            C.ShowDialog(Globals.Settings, this);
        }

        private void txtKeyToSend_KeyUp(object sender, KeyEventArgs e) {
            //txtKeyToSend.Text = RewardKeySender.GetReadableKeyName();
        }

        private void lblNoSpeakerError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            MessageBox.Show("Plug speakers in and restart the program to control the computer's volume.", "No Speakers!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chkEnableKeys_CheckedChanged(object sender, EventArgs e) {
            UpdateSendKeyControlVisibility();
        }

        private void chkEnableVis_CheckedChanged_1(object sender, EventArgs e) {
            UpdateSightOrSoundControlVisibility(tabSight, chkEnableVis);
            if (chkEnableVis.Checked) {
                RewardSetter.VisibilityValueChanged();
            } else {
                VisManager.SetFullBrightness();
            }
        }

        private void chkEnableVol_CheckedChanged_1(object sender, EventArgs e) {
            UpdateSightOrSoundControlVisibility(tabSound, chkEnableVol);
            if (chkEnableVol.Checked) {
                RewardSetter.VolLevelChanged();
            } else {
                VolManager.SetToNormal();
            }
        }


        #endregion

        #region helper methods
        public void ShowVisibilityTab() {
            tabMain.SelectedTab = tabSight;
        }

        private void ChangeSendKeyControlVisibility(bool showKeyControls) {
            txtKeyToSend.Visible = showKeyControls;
            radioTapKey.Visible = showKeyControls;
            radioHoldKey.Visible = showKeyControls;
            txtKeyPressStat.Visible = showKeyControls;
            ddlKeyChannel.Visible = showKeyControls;
        }

        private void UpdateSendKeyControlVisibility() {
            if (chkEnableKeys.Checked) {
                ChangeSendKeyControlVisibility(true);
            } else {
                ChangeSendKeyControlVisibility(false);
            }
        }

        private static string GetBxAdapterProgramFilePath(string filename) {
            string path = Directory.GetCurrentDirectory() + "\\" + filename;
            return path;
        }

        public void SetBackgroundColor(Color newBackgroundColor) {
            if (newBackgroundColor != Color.Transparent)
            {
                Globals.BackgroundColor = newBackgroundColor;
                Globals.ForegroundColorForm.BackColor = newBackgroundColor;
            }

            pnlBackgroundColor.BackColor = newBackgroundColor;
            //if(SelProgram != null) SelProgram.Activate();
        }

        private void ShowColorPicker() {
            C.ShowDialog(MyColorPicker, this);
            //ActivateSelectedProgram();
        }

        public void UpdateShowTooltips(bool showtooltips) {
            toolTipMain.RemoveAll();
            Globals.ShowTooltips = showtooltips;
            if (Globals.ShowTooltips) {
                SetupToolTips();
            }
        }
  
        public void UpdateSightOrSoundControlVisibility(TabPage tabPage, CheckBox chkVisibility) {
            foreach (Control c in tabPage.Controls) {
                if (c != chkVisibility) {
                    c.Visible = chkVisibility.Checked;
                }
            }
        }

        #endregion

        private void btnSignalStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignalSimulator.ToggleSimulation();
        }

        private void tmrSimulation_Tick(object sender, EventArgs e) {
            SignalSimulator.SimulationTick();
        }

        private void btnStopSimulation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            SignalSimulator.DisableSimulation();
        }

        private void cmbVisFeedbackType_SelectedIndexChanged(object sender, EventArgs e) {
            this.VisManager.SetVisFeedbackModeWithCurrentDropdownOption();
        }

        private void btnTopMostWholeWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Globals.ForegroundColorForm.TopMost = true;
        }

        private void tabHelp_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        bool AppHasBeenShown = false;
        private void BxAdapter_VisibleChanged(object sender, EventArgs e)
        {
            if (!AppHasBeenShown && this.Visible)
            {
                AppHasBeenShown = true;
                RunDeferredLoadingAfterMainFormIsShown();
            }
        }

        private void RunDeferredLoadingAfterMainFormIsShown()
        {

            if (Properties.Settings.Default.IsFirstRun)
            {
             
                // VisitOnlineLink.FirstRunPage();
                Properties.Settings.Default.IsFirstRun = false;
                Properties.Settings.Default.Save();
            }

#if DEBUG
            //todo fix connection code
#else
            compilorerror
#endif
            BxClientHost = new BxClientHost(this);
            if (Properties.Settings.Default.HasConnectedToBioExplorer) {
                ConnectToBioexplorer();
            } else {


                //C.ShowDialog(bioExplorerConnectionForm, this);
                //                btnSetupBioExplorerConnection.Visible = true;
            }
         
            
        }

        public void ConnectToBioexplorer()
        {
            BxClientHost.LoadBxClient();
        }

        public void SetTopMost(bool topmost)
        {
            this.TopMost = topmost;

        }        
    }
}



