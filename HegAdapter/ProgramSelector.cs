using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BxAdapter {
    public partial class ProgramSelector : Form {
        Windows Windows;
        BxAdapter BxAdapter;
        List<Window> AllWindows;
        List<Program> RecentPrograms = new List<Program>();
        List<Program> FrequentPrograms = new List<Program>();

        public ProgramSelector(BxAdapter bxAdapter) {
            InitializeComponent();
            BxAdapter = bxAdapter;
            this.StartPosition= FormStartPosition.CenterScreen;
            C.LockFormSizeAndSetTopmost(this);
        }

        public void ActivateProgram(Program p) {
            //BxAdapter.SetSelectedProgram(new ProgramCreationInfo(new IntPtr(0), p.FilePath));
            this.Hide();
        }

        public void RemoveProgram(Program p) {
            Globals.AllPrograms.Remove(p);
            RefreshAllLists();
        }

        private void RefreshProgramStats(IComparer<Program> comparer, ListBox listBox, List<Program> programLoadList) {
            List<Program> allPrograms = new List<Program>();
            foreach (Program p in Globals.AllPrograms) {
                allPrograms.Add(p);
            }

            allPrograms.Sort(comparer);
            listBox.Items.Clear();

            int programInStatBox = 0;
            programLoadList.Clear();
            foreach (Program p in allPrograms) {
                if (programInStatBox < 8) {
                    listBox.Items.Add(p.FriendlyTitle);
                    programInStatBox++;
                    programLoadList.Add(p);
                }
            }
        }

        private void RefreshRecentPrograms() {
            RefreshProgramStats(new RecentProgramComparer(), listRecentPrograms, RecentPrograms);
        }

        private void RefreshFavoritePrograms() {
            RefreshProgramStats(new FrequentProgramComparer(), listFrequentPrograms, FrequentPrograms);
        }

        public void RefreshAllLists() {
            if (Globals.AllPrograms.DirtyFlagForAllProgramsDisplay) {
                flowAllPrograms.Controls.Clear();
                int width = flowAllPrograms.Width - 25; //to avoid scrollbars
                ProgramLoaderItem apc;
                List<Program> allProgs = new List<Program>();
                foreach (Program p in Globals.AllPrograms) {
                    allProgs.Add(p);
                }
                allProgs.Sort(new ProgramNameComparer());
                foreach (Program p in allProgs) {
                    apc = new ProgramLoaderItem(p, this, BxAdapter);
                    apc.Width = width;
                    flowAllPrograms.Controls.Add(apc);
                }
                Globals.AllPrograms.DirtyFlagForAllProgramsDisplay = false;
            }
            RefreshRecentPrograms();
            RefreshFavoritePrograms();
            RefreshWindowList();
        }

        private void listFrequentPrograms_SelectedIndexChanged(object sender, EventArgs e) {
            ActivateProgram(FrequentPrograms[listFrequentPrograms.SelectedIndex]);
        }

        private void listRecentPrograms_SelectedIndexChanged(object sender, EventArgs e) {
            ActivateProgram(RecentPrograms[listRecentPrograms.SelectedIndex]);
        }

        private void ProgramSelector_Activated(object sender, EventArgs e) {
            RefreshAllLists();
        }


        private void RefreshWindowList() {
            Windows = new Windows(false, false);
            AllWindows = new List<Window>();
            listWindows.Items.Clear();

            foreach (Window win in Windows) {
                string process = win.Process;
                string title = win.Title.ToLower();

                if (Regex.Match(process, "BxAdapter.*exe").Success
                    || title == "start"
                    || title == "program manager"
                    || title == "<???>"
                    ) {
                    continue;
                }

                listWindows.Items.Add(win.ToString());
                AllWindows.Add(win);
            }
        }

        private void listWindows_SelectedIndexChanged(object sender, EventArgs e) {
            if (listWindows.SelectedIndex >= 0) {
                Window selWin = AllWindows[listWindows.SelectedIndex];
                if (selWin != null) {
                    //BxAdapter.SetSelectedProgram(new ProgramCreationInfo(selWin.hWnd, null));
                }
            }

            if (listWindows.SelectedIndex >= 0) {
                this.Close();
            }
        }

        private void btnRefreshList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RefreshAllLists();
        }

        private void ProgramSelector_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void ProgramSelector_VisibleChanged(object sender, EventArgs e) {
            if (this.Visible) {
                RefreshWindowList();
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void cmbCategoryFilter_Enter(object sender, EventArgs e) {
            //Globals.Categories.PopulateComboBox(cmbCategoryFilter, 0);
        }

        
        private void btnloaderHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //VisitLocalLink.LoaderHelp(btnLoaderHelp);
        }
    }
}
