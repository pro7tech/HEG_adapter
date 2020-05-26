using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace BxAdapter {
    public class SelectedWindow : Window, IVisibilityChanger {
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT rect);
        [DllImport("user32.dll")]
        static extern Rectangle GetWindowRect(IntPtr hWnd, Rectangle lpRect);
        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey,
           byte bAlpha, uint dwFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        private void SetWindowOpacity(byte opacityLevel) {
            // Set WS_EX_LAYERED on this window 
            SetWindowLong(hWnd, GWL_EXSTYLE, GetWindowLong(hWnd, GWL_EXSTYLE) | WS_EX_LAYERED);
            SetLayeredWindowAttributes(hWnd, 0, opacityLevel, LWA_ALPHA);
        }

        public void SetOpacity(int n) {
            byte opacityLevel = (byte) n;
            SetWindowOpacity(opacityLevel);
        }

        public SelectedWindow(Window win)
            : base(win.Title, win.hWnd, win.Process) {
        }

        public SelectedWindow(IntPtr hWnd)
            : base(hWnd) {
        }

        public bool IsWindow() {
            return Window.IsWindow(this.hWnd);
        }

        public void SetFullVisibility() {
            SetWindowOpacity(255);
        }

        public bool IsGivenWindowBeneathMe(IntPtr hWnd) {
            IntPtr hWndForWindowBeneathMe = GetWindow(this.hWnd, GW_HWNDNEXT);
            if (hWnd == hWndForWindowBeneathMe) {
                return true;
            }
            return false;
        }

        public bool IsForegroundWindow() {
            IntPtr hWndForgroundWindow = GetForegroundWindow();
            if (this.hWnd == hWndForgroundWindow) return true;
            return false;
        }

        public void SetBrightness(int level) {
            //SetWindowOpacity(
        }

        public void SetFullBrightness() {
            SetFullVisibility();
        }
    }
}
