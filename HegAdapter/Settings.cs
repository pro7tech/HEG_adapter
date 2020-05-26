using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter {
    public partial class Settings : Form {
        private bool InEditMode = false;
        private BxAdapter BxAdapter;
        //private MappingGamepad MappingGamepad;
        private ProgramSelector ProgramSelector;
        //private CopyProtection CopyProtection;

        public Settings(BxAdapter bxAdapter, ProgramSelector programSelector) {
            InitializeComponent();
            BxAdapter = bxAdapter;
            //MappingGamepad = mappingGamepad;
            ProgramSelector = programSelector;
            this.StartPosition= FormStartPosition.CenterParent;
            C.LockFormSizeAndSetTopmost(this);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            CloseForm(true);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            CloseForm(false);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) {
            CloseForm(false);
        }

        private void CloseForm(bool saveSettings) {
            if (saveSettings) {
                SaveSettings();
            }
            this.Hide();
            InEditMode = false;
        }

        private void Settings_Activated(object sender, EventArgs e) {
            if (InEditMode) {
                //don't need to reload settings
            } else {
                LoadSettings();
                InEditMode = true;
            }

        }

        public void SetTopMostForCurrentWindows() {
            bool tm = Globals.WindowsAreTopmost;
            BxAdapter.TopMost = tm;
            BxAdapter.Refresh();

            BxAdapter.ProgramSelectorForm.TopMost = tm;
            BxAdapter.ProgramSelectorForm.Refresh();
        }

        private void SaveSettings() {
            
            SetTopMostForCurrentWindows();
            //Globals.AutoLoadProgramSelector = chkAutoloadProgramSelector.Checked;
            //BxAdapter.UpdateShowTooltips(chkShowTooltips.Checked);
        }

        private void LoadSettings() {
            
            //chkAutoloadProgramSelector.Checked = Globals.AutoLoadProgramSelector;
            //chkShowTooltips.Checked = Globals.ShowTooltips;
        }



    }
}
