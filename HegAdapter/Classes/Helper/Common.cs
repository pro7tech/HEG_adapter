using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

namespace BxAdapter {
    class C {
        public static string nl = Environment.NewLine;
        public static Color PassColor = Color.Green;
        public static Color FailColor = Color.Red;
        public static Color SimPassColor = Color.Black;
        public static Color SimFailColor = Color.Black;
        public const string BlankKeyPressText = "- press key -";

        public static void LockFormSizeAndSetTopmost(Form form) {
            Size curSize = form.Size;
            form.MaximumSize = curSize;
            form.MinimumSize = curSize;
            form.MaximizeBox = false;
            form.TopMost = Globals.WindowsAreTopmost;
        }

        public static string Pluralize(int num, string nounSingular, string nounPlural) {
            if (num == 1) {
                return nounSingular;
            }
            return nounPlural;
        }

        public static void ShowDialog(Form form, Form parentForm) {
            form.TopMost = Globals.WindowsAreTopmost; 
            form.WindowState = FormWindowState.Normal;
            form.ShowDialog();
        }

        public static void ShowForm(Form form, Form parentForm) {
            form.WindowState = FormWindowState.Normal;
            form.Show();
        }

        public static bool IsVistaOperatingSystem() {
            if (Environment.OSVersion.Version.Major >= 6) {
                return true;
            }
            return false;
        }

        public static string LoadFile(string file) {
            Process pr = new Process();
            pr.StartInfo.FileName = Application.StartupPath + "\\" + file;
            pr.StartInfo.WorkingDirectory = Application.StartupPath;
            pr.StartInfo.UseShellExecute = true;
            string filePath = "";
            try {
                pr.Start();
            } catch (Exception e) {
                MessageBox.Show(e.Message + Environment.NewLine + "Location: " + filePath, "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return filePath;
        }

        [DllImport("dwmapi.dll")]
        public static extern IntPtr DwmIsCompositionEnabled(out bool pfEnabled);
        static bool glassEnabled = false;

        public static bool IsAeroGlassRunning() {
            try {
                //if (DwmIsCompositionEnabled(out glassEnabled) == IntPtr.Zero)
                DwmIsCompositionEnabled(out glassEnabled);
            } catch (DllNotFoundException ex) {
                glassEnabled = false;
                string string_to_supress_warning = ex.Message;
            }

            return glassEnabled;
        }

        private static string VersionString = "";
        public static string GetVerionString() {
            if(VersionString == "") {

            } 
            return VersionString;
        }


        #region Assembly Attribute Accessors

        public static string AssemblyTitle {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0) {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "") {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion {
            get {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

    }
}
