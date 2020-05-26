using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    class WholeScreen : IVisibilityChanger
    {
        public void SetBrightness(int level) {
            if (Globals.ForegroundColorForm.Visible == false) {
                Globals.ForegroundColorForm.Show();
            }
            Globals.ForegroundColorForm.SetBrightness(level);
        }

        public void SetFullBrightness() {
            if (Globals.ForegroundColorForm != null) {
                Globals.ForegroundColorForm.Visible = false;
            }
        }
    }
}
