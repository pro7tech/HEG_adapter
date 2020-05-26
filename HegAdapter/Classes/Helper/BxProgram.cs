using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BxAdapter {
    static class BxProgram {
        [STAThread]
        static void Main() {

            bool createdNew;
            System.Threading.Mutex m = new System.Threading.Mutex(true, "BxAdapterTodo", out createdNew);
            if (!createdNew) {
                Windows wndList = new Windows(false, false);
                foreach (Window wnd in wndList) {
                    if (wnd.Title == BxAdapter.BxAdapterTitle) {
                        wnd.Activate();
                    }
                }
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //MUST BE DONE THIS WAY SO HAVE PROPER DEBUGGING ABILITIES
#if DEBUG 
            Application.Run(new BxAdapter());
#else 
            try
            {
                Application.Run(new BxAdapter());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endif

            // keep the mutex reference alive until the normal termination of the program
            GC.KeepAlive(m);
        }
    }
}

