using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter {
    public class ProgramLinker
    {
        // Ways to attach to a process
        // Selecting running process: via foreground window, via window title selection list
        // via hotlink button - may or may not be loaded

        // if no window handle
        // search based on module
        // if module not loaded, load module
        // if module cannot be loaded - delete from file list ?

        BxAdapter bx;
        public ProgramLinker(BxAdapter bxAdapter) {
            bx = bxAdapter;
        }

        public void LinkViaModulePath(string path) {
            SetSelectedProgram(Globals.AllPrograms.GetProgram(path));
        }

        public void LinkViaWindowPtr(IntPtr windowPtr) {
            SetSelectedProgram(Globals.AllPrograms.GetProgram(windowPtr));
        }

        private void SetSelectedProgram(Program program) {
            //    if (selprogram == null) { //such as if error loading program and is removed from list
            //        bx.btnshowselectedwindow.visible = false;
            //        return;
            //    }

            Program currentSelectedProgram = Globals.SelectedProgram;
            if (currentSelectedProgram != null && currentSelectedProgram != program) {
                currentSelectedProgram.GetSelectedWindow().SetFullBrightness();
            }
            Globals.SelectedProgram = program;

            
            //bx.BtnShowSelectedWindow.Visible = true;
            //bx.BtnShowSelectedWindow.Text = string.Format("Linked: {0}", program.FriendlyTitle);
            bx.ShowVisibilityTab();
            bx.LblVisControlTypeExplanation.Visible = false;
            //activateselectedprogram(preselprogram);
        }

        public void ActivateSelectedProgram(Program prevProgram) {
            Program selectedProgram = Globals.SelectedProgram;
            if (selectedProgram != null) {
                selectedProgram.Activate();
                if (prevProgram == null || (prevProgram.FilePath != selectedProgram.FilePath)) {
                    selectedProgram.UpdateLoadStats();
                    bx.ProgramSelectorForm.RefreshAllLists();
                }
            }
        }
    }
}
