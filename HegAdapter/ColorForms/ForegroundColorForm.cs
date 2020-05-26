using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace BxAdapter
{

    public partial class ForegroundColorForm : Form
    {

        [DllImport("user32.dll")]
        protected static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        protected static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        protected static extern IntPtr GetWindow(IntPtr hWnd, int wCmd);

        [DllImport("user32.dll")]
        protected static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        protected static extern void SetActiveWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern long GetWindowThreadProcessId (IntPtr hWnd, out long lpdwProcessId);

        const int GW_HWNDFIRST = 0;
        const int GW_HWNDNEXT = 2;
        const int GW_CHILD = 5;
        long BxAdapterProcessId;
        BxAdapter bx;
        
        public ForegroundColorForm(BxAdapter bx) {
            this.bx = bx;
            InitializeComponent();
            long threadId = GetWindowThreadProcessId(bx.Handle, out BxAdapterProcessId);
        }

        public void SetColor(Color c) {
            this.BackColor = c;
        }

        public void SetBrightness(int level) {
            int maxLevel = 255;
            int minLevel = 10; //7 before
            int newLevel = maxLevel - level - minLevel;
            this.Opacity = newLevel / (maxLevel * 1.0);
        }

        protected override CreateParams CreateParams {
            [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
            get {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x20;
                return createParams;
            }
        }

        private void tmrTopMost_Tick(object sender, EventArgs e) {
            IntPtr foregroundWindowPtr = GetForegroundWindow();
            long activeWindowProcessId;
            long threadId = GetWindowThreadProcessId(foregroundWindowPtr, out activeWindowProcessId);

            if (BxAdapterProcessId != activeWindowProcessId && this.Visible) {
                this.TopMost = true;
            }
        }

        //protected IntPtr GetTopMostVisibleWindow() {
        //    IntPtr hWndTopMostWindow, hWndOldActive, hWndNewActive;

        //    hWndTopMostWindow = GetWindow(this.Handle, GW_HWNDFIRST);

        //}


    }
}


/*
#SingleInstance,Force
SetWinDelay,0

Create Top Window:
Gui,+ToolWindow -Disabled -SysMenu -Caption +E0x20 +AlwaysOnTop 
Gui,Show,% "X0 Y0 W" . A_ScreenWidth "H" . A_ScreenHeight
Gui,Color,000000

LOOP:
WinSet,AlwaysOnTop,On,ahk_id %guiid%
WinWaitNotActive,ahk_id %id%
Goto,LOOP

CHANGE: WinSet,Transparent,% dimming*255/10,ahk_id %guiid%

 * 
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;

        private void Form1_Load(object sender, EventArgs e) {
            //SetWithoutSecurityChanges();
        }

        private void SetWithoutSecurityChanges() {
            // Add WS_EX_TRANSPARENT style so that mouse, keyboard etc. events pass thru us
            int exstyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exstyle |= WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exstyle);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.TopMost = true;
        }
 * 
 */
