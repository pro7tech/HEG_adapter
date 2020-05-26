using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    public class LinkedProgram : IVisibilityChanger
    {
        private Program CurrentLinkedProgram;

        public void SetBrightness(int level) {
            if (CurrentLinkedProgram != null) {
                if(IsNewLinkedProgram()) {
                    SetFullBrightness();
                    CurrentLinkedProgram = Globals.LinkedProgram;
                } 
                CurrentLinkedProgram.SetOpacity(level);
            }
        }

        public bool IsNewLinkedProgram() {
            if (Globals.LinkedProgram == CurrentLinkedProgram) {
                return false;
            } else {
                return true;
            }
        }

        public void SetFullBrightness() {
            if (CurrentLinkedProgram != null) {
                CurrentLinkedProgram.MakeFullyVisible();
            }
        }
    }
}


