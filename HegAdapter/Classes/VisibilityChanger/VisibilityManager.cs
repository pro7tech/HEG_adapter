using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    public enum VisFeedbackMode { ScreenColor, LinkedProgram, GammaWholeScreen }

    public class VisibilityManager : IVisibilityChanger
    {
        IVisibilityChanger VisibilityChanger;
        
        BxAdapter bx;
        
        LinkedProgram LinkedProgram;
        WholeScreen WholeScreen;

        public VisibilityManager(BxAdapter bxAdapter) {
            bx = bxAdapter;
            SetupVisFeedbackDropdown();
        
            LinkedProgram = new LinkedProgram();
            WholeScreen = new WholeScreen();
        }

        public VisFeedbackMode CurrentVisFeedbackMode {
            get { return GetCurrentVisFeedbackMode(); }
        }

        public string CurrentVisFeedbackModeAbbreviation {
            get {
                VisFeedbackMode vfm = CurrentVisFeedbackMode;
                switch (vfm) {
                    case VisFeedbackMode.GammaWholeScreen: return "b";
                    case VisFeedbackMode.LinkedProgram: return "l";
                    case VisFeedbackMode.ScreenColor: return "c";
                    default: return "o";
                }
            }
        }

        public void SetBrightness(int level) {
            VisibilityChanger.SetBrightness(level);
        }

        public void SetFullBrightness() {
            VisibilityChanger.SetFullBrightness();
        }

        public void ChangeMode(IVisibilityChanger newMode) {
            if (VisibilityChanger != null) {
                if (VisibilityChanger.GetType() == newMode.GetType()) {
                    return;
                }
                VisibilityChanger.SetFullBrightness();
            }
            VisibilityChanger = newMode;
        }

        public class VisFeedbackType {
            public VisFeedbackMode mode;
            public VisFeedbackType(VisFeedbackMode mode) {
                this.mode = mode;
            }
            public override string ToString() {
                switch (mode) {
                    case VisFeedbackMode.LinkedProgram: return "Linked Program";
                    case VisFeedbackMode.GammaWholeScreen: return "Screen Dimming";
                    case VisFeedbackMode.ScreenColor: return "Screen Color";
                    default: throw new Exception("Not Implemented");
                }
            }
        }

        public void SetVisFeedbackModeWithStringOrUseDefault(string feedbackModeString) {
            foreach (VisFeedbackType feedbackType in bx.CmbVisFeedbackType.Items) {
                if (feedbackType.mode.ToString() == feedbackModeString) {
                    SetVisFeedbackModeDropdownSelection(feedbackType.mode);
                    return;
                }
            }
            //default mode - may change for xp
            SetVisFeedbackModeDropdownSelection(VisFeedbackMode.ScreenColor);
        }

        public void SetVisFeedbackModeDropdownSelection(VisFeedbackMode mode) {
            foreach (VisFeedbackType type in bx.CmbVisFeedbackType.Items) {
                if (type.mode == mode) {
                    bx.CmbVisFeedbackType.SelectedItem = type;
                    return;
                }
            }
            throw new Exception("No such mode");
        }

        private void SetupVisFeedbackDropdown() {
            VisFeedbackType[] visFeedbackTypes = new VisFeedbackType[]{
                new VisFeedbackType(VisFeedbackMode.ScreenColor),
         //       new VisFeedbackType(VisFeedbackMode.LinkedProgram),
                new VisFeedbackType(VisFeedbackMode.GammaWholeScreen)
            };
            bx.CmbVisFeedbackType.Items.AddRange(visFeedbackTypes);
        }

        private VisFeedbackMode GetCurrentVisFeedbackMode() {
            VisFeedbackType type = (VisFeedbackType)bx.CmbVisFeedbackType.SelectedItem;
            return type.mode;
        }

        public void SetVisFeedbackModeWithCurrentDropdownOption() {
            switch (GetCurrentVisFeedbackMode()) {
                case VisFeedbackMode.ScreenColor: SetupWholeScreenMode(); break;
                case VisFeedbackMode.LinkedProgram: SetupLinkedProgramMode(); break;
                case VisFeedbackMode.GammaWholeScreen: SetupGammaWholeScreenMode(); break;
            }
        }

        private void SetupGammaWholeScreenMode() {
            
            SetupVisibilityControlExplanation(""); //"Control Dimming of Screen");
        }

        private void SetupLinkedProgramMode() {
            ChangeMode(LinkedProgram);
            bx.LblVisControlTypeExplanation.Visible = false;

            if (Globals.LinkedProgram != null) {
//                bx.BtnShowSelectedWindow.Visible = true;
            }
        }

        private void SetupWholeScreenMode() {
            ChangeMode(WholeScreen);
            SetupVisibilityControlExplanation(""); //Control Dimming Color for Screen");
        }

        private void SetupVisibilityControlExplanation(string message) {
            bx.LblVisControlTypeExplanation.Text = message;
            bx.LblVisControlTypeExplanation.Visible = true;
            //bx.BtnShowSelectedWindow.Visible = false;
        }
    }
}
