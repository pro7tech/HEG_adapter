using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;

namespace BxAdapter {
    public class SendKey {
        IntPtr hWnd;
        public RichTextBox LogWindow;
        
        [DllImport("user32.dll")]
        public static extern void PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public class WinDefs {
            public const int WM_KEYDOWN = 0x0100;
            public const int WM_KEYUP = 0x0101;
        }

        public SendKey(IntPtr hWnd, RichTextBox logWindow) {
            this.hWnd = hWnd;
            LogWindow = logWindow;
        }

        public SendKey(RichTextBox logWindow)
            : this(new IntPtr(0), logWindow) { }

        private void AddKeyStateInfo(string state, KeyInfo key) {
            if (LogWindow != null) {
                LogWindow.Text +=
                    string.Format(
                    "{0}: {1} {2} {3}",
                    DateTime.Now.ToString("ss.fff"), key.Name, state, Environment.NewLine);
                LogWindow.Focus();
                LogWindow.Select(LogWindow.Text.Length, 0);
            }
        }

        public void KeyDown(KeyInfo key) {
            AddKeyStateInfo("{Pressed}", key);
            if (hWnd.ToInt32() > 0) {
                PostMessage(hWnd, WinDefs.WM_KEYDOWN, key.Value, 0x014D0001);
            }
        }

        public void KeyUp(KeyInfo key) {
            AddKeyStateInfo("{Released}", key);
            if (hWnd.ToInt32() > 0) {
                PostMessage(hWnd, WinDefs.WM_KEYUP, key.Value, 0);
            }
        }
    }
}
