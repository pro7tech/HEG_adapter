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


namespace BxAdapter
{
    public class Programs : System.Collections.ICollection
    {
        private ArrayList progArray = new ArrayList();
        public bool DirtyFlagForAllProgramsDisplay = false;

        [DllImport("user32.dll")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        public Programs() {

        }

        private static Process GetProcessForWindow(IntPtr hWnd) {
            Process[] processes = Process.GetProcesses();
            int processId = Int32.MinValue;
            GetWindowThreadProcessId(hWnd, out processId);

            foreach (Process p in processes) {
                if (p.Id == processId) {
                    return p;
                }
            }
            return null;
        }

        public static IntPtr GetWindowPtrForModulePathWithNoFileLoad(string modulePath) {
            Process[] processes = Process.GetProcesses();

            //note generate security exceptions when accessing certain processes, this slowed downloading significantly
            //it seems like if they all have a main window handle then there are no security exceptions
            foreach (Process p in processes) {
                if (p.MainWindowHandle.ToInt32() > 0 && p.MainModule.FileName == modulePath) {
                    return p.MainWindowHandle;
                }
            }
            return IntPtr.Zero;
        }

        public Program GetProgram(string modulePath) {
            IntPtr hWnd = FindProcessAndWindowByModulePath(modulePath);
            int progIndex = GetProgIndex(modulePath);
            if (progIndex < 0) {
                return null;
            }
            Program prog;
            prog = this[progIndex];
            prog.SetSelWin(hWnd);
            return prog;
        }

        public Program GetProgram(IntPtr winodowPtr) {
            //check if the program settings already exists
            Process aProcess = Programs.GetProcessForWindow(winodowPtr);
            string modulePath = GetModulePathForProcess(aProcess);

            if (modulePath == null) {
                return null; //we cannot determine the module path, so we must exit since that info is crucial
            }

            int progIndex = GetProgIndex(modulePath);

            Program prog;
            if (progIndex < 0) {
                //create a new program entry
                prog = new Program(winodowPtr, aProcess);
                Add(prog);
                return prog;
            } else {
                //use current program data, but update with the latest window information
                prog = this[progIndex];
                prog.SetSelWin(winodowPtr);
                return prog;
            }
        }

        private string GetModulePathForProcess(Process p) {
            if (p != null) {
                ProcessModule pm = p.MainModule;
                if (pm != null) {
                    if (pm.FileName != null) {
                        string modulePath = pm.FileName;
                        if (modulePath != null && modulePath.Trim() != "") {
                            return modulePath;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Some programs don't load properly if the working directory is not set
        /// here we determine based on the path to the main module name
        /// </summary>
        private static string GetWorkingDirectoryFromPath(string path) {
            string wd = path.Substring(0, path.LastIndexOf("\\"));
            return wd;
        }

        private IntPtr FindProcessAndWindowByModulePath(string modulePath) {
            IntPtr mainWindowHandle = GetWindowPtrForModulePathWithNoFileLoad(modulePath);
            if (mainWindowHandle != IntPtr.Zero) return mainWindowHandle;

            //process did not already exist - so we must create it
            Process pr = new Process();
            pr.StartInfo.FileName = modulePath;
            pr.StartInfo.WorkingDirectory = GetWorkingDirectoryFromPath(modulePath);
            pr.StartInfo.UseShellExecute = true;

            try {
                pr.Start();

                int numTries = 0, maxTries = 10;

                while (pr.MainWindowHandle.ToInt32() <= 0 && numTries < maxTries) {
                    Thread.Sleep(20);
                    pr.Refresh();
                    numTries++;
                }

                return pr.MainWindowHandle;

            } catch {
                Globals.AllPrograms.Remove(modulePath);
                MessageBox.Show(string.Format("Unable to load program at: \"{0}\"", modulePath), "Error Loading Program");
                return IntPtr.Zero;
            }
        }

        #region custom ICollection Members
        public Program this[int index] {
            get { return (Program)progArray[index]; }
        }

        /// <summary>
        /// Searchs arraylist of program and returns index of
        /// entry if it encounters it or int32.minvalue if cannot
        /// find it
        /// </summary>
        private int GetProgIndex(string modulePath) {
            int i = 0, match = Int32.MinValue;

            foreach (Program prog in progArray) {
                if (modulePath == prog.FilePath) {
                    //update items for exsting program
                    match = i;
                }
                i++;
            }
            return match;
        }

        public void Remove(Program p) {
            Remove(p.FilePath);
        }

        private void Remove(string filepath) {
            int match = GetProgIndex(filepath);

            if (match >= 0) {
                progArray.Remove(progArray[match]);
                DirtyFlagForAllProgramsDisplay = true;
            }
        }

        public void Update(Program p) {
            int progIndex = GetProgIndex(p.FilePath);
            if (progIndex >= 0) {
                this[progIndex].UpdateConfigurationSettings(p);
            }
        }

        public Program Add(Program newProg) {
            if (newProg.FilePath == null || newProg.FilePath.Trim() == "") {
                return null;
            }
            int progIndex = GetProgIndex(newProg.FilePath);
            if (progIndex >= 0) {
                return null; //already in the array don't add it
            }

            progArray.Add(newProg);
            DirtyFlagForAllProgramsDisplay = true;
            return newProg;
        }
#endregion

        #region boilerplate icollection members
        public void CopyTo(Array array, int index) {
            progArray.CopyTo(array, index);
        }

        public int Count {
            get { return progArray.Count; }
        }

        public object SyncRoot {
            get { return this; }
        }
        public bool IsSynchronized {
            get { return false; }
        }
        #endregion

        #region IEnumerable Members

        public System.Collections.IEnumerator GetEnumerator() {
            return progArray.GetEnumerator();
        }

        #endregion

    }

    #region program list sortering
    public class FrequentProgramComparer : IComparer<Program>
    {
        public int Compare(Program x, Program y) {
            return y.ProgramSelectedCount.CompareTo(x.ProgramSelectedCount);
        }
    }

    public class ProgramNameComparer : IComparer<Program>
    {
        public int Compare(Program x, Program y) {
            return x.FriendlyTitle.CompareTo(y.FriendlyTitle);
        }
    }

    public class RecentProgramComparer : IComparer<Program>
    {
        public int Compare(Program x, Program y) {
            return y.ProgramLastUsed.CompareTo(x.ProgramLastUsed);
        }
    }
    #endregion
}
