using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BxAdapter {

    [XmlRootAttribute("Program", IsNullable = false)]
    public class Program {
        //volatile (non-preserved) information
        public IntPtr SelWindowHandle {
            get { return MySelectedWindow.hWnd; }
        }
        SelectedWindow MySelectedWindow;

        //persisted (preserved) information
        public string FilePath;
        public DateTime ProgramLastUsed;
        public int ProgramSelectedCount;
        public string FriendlyTitle;

        //empty constructor needed for XML serialization
        public Program() {}

        public void UpdateConfigurationSettings(Program p) {
            FriendlyTitle = p.FriendlyTitle;
        }

        public Program(IntPtr hWnd, Process p) {
            SetSelWin(hWnd);
            FilePath = p.MainModule.FileName;
            FriendlyTitle = MySelectedWindow.Title;
            ProgramLastUsed = DateTime.Now;
            ProgramSelectedCount = 1;
        }

        public void UpdateLoadStats() {
            this.ProgramLastUsed = DateTime.Now;
            this.ProgramSelectedCount++;
        }

        public void MakeFullyVisible() {
            MySelectedWindow.SetFullVisibility();
        }

        public void Activate() {
            Globals.BackgroundColorForm.UpdateFormBackgroundColor(MySelectedWindow);
            MySelectedWindow.Activate();
        }

        public void SetOpacity(int n) {
            MySelectedWindow.SetOpacity(n);
        }

        public SelectedWindow GetSelectedWindow() {
            return this.MySelectedWindow;
        }

        public void SetSelWin(IntPtr hWnd) {
            MySelectedWindow = new SelectedWindow(hWnd);
        }

        public bool IsValidProgramWindowSelected() {
            if (MySelectedWindow == null) {
                return false;
            }
            return MySelectedWindow.IsWindow();
        }

        public void AttemptSelectingProgramWindow() {
            IntPtr mainWindowPtr = Programs.GetWindowPtrForModulePathWithNoFileLoad(FilePath);
            if (mainWindowPtr != IntPtr.Zero) {
                SetSelWin(mainWindowPtr);
            }
        }

    }
}