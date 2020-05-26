using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter {
    public partial class ProgramLoaderItem : UserControl {
        Program Prog;
        ProgramSelector ProgSelector;
        BxAdapter BxAdapter;

        public ProgramLoaderItem(Program prog, ProgramSelector progSelector, BxAdapter bxAdapter) {
            Prog = prog;
            ProgSelector = progSelector;
            BxAdapter = bxAdapter;
            InitializeComponent();
            btnProgramName.Text = Prog.FriendlyTitle;
        }

        private void btnProgramName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProgSelector.ActivateProgram(Prog);
        }

        private void btnRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProgSelector.RemoveProgram(Prog);
        }
    }
}
