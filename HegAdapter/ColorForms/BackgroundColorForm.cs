using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter {
    public partial class BackgroundColorForm : Form {
        public BackgroundColorForm() {
            InitializeComponent();
        }

        public void PutBackgroundWindowBehindSelectedWindow(SelectedWindow selWindow) {
            IntPtr selWindowHandle = selWindow.hWnd;

            if (!Window.IsWindow(selWindowHandle)) {
                this.Hide();
                return;
            }

            IntPtr windowBelow = Window.GetWindowBelowGivenWindow(selWindowHandle);
            IntPtr backgroundWindowHandle = this.Handle;

            if (windowBelow != backgroundWindowHandle) {
                bool success = Window.SetWindowBelowGivenWindow(backgroundWindowHandle, selWindowHandle);
            }
        }

        public void UpdateFormBackgroundColor(SelectedWindow selWindow) {
            if (selWindow == null || Globals.BackgroundColor == Color.Transparent || Globals.BackgroundColor.IsEmpty) {
                this.Visible = false;
                return;
            }

            PutBackgroundWindowBehindSelectedWindow(selWindow);

            if (this.BackColor != Globals.BackgroundColor) {
                this.BackColor = Globals.BackgroundColor;
            }

            SelectedWindow.RECT rect = new SelectedWindow.RECT();
            if (SelectedWindow.GetWindowRect(selWindow.hWnd, out rect)) {
                Point correctLocation = new Point(rect.X, rect.Y);
                if (this.Location != correctLocation) {
                    this.Location = correctLocation;
                }

                Size correctSize = new Size(rect.Width - rect.X, rect.Height - rect.Y);
                if (this.Size != correctSize) {
                    this.Size = correctSize;
                }

                if (!this.Visible) {
                    this.Visible = true;
                }
            }
        }
    }
}
