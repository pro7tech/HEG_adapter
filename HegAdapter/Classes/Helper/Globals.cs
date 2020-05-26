using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BxAdapter {
    public enum KeyMessageFormat { Send, Post }
    public enum SignalType { Discrete, Variable, None }

    public static class Globals {
        public static int RepeatRate = 30;
        public static int RepeatDelay = 200;
        public static Color BackgroundColor;
        public static BackgroundColorForm BackgroundColorForm;
        public static ForegroundColorForm ForegroundColorForm;
        public static Programs AllPrograms;
        public static Program SelectedProgram;
        public static Settings Settings;
        public static Program LinkedProgram;
        public static bool WindowsAreTopmost;
        public static bool ShowTooltips;
//        public static CopyProtection CopyProtection;
        public static bool DemoDisplayed;
        public static SendKey GameWindow = null;
        public static VariableSamples VariableVisSamples = new VariableSamples();
        public static VariableSamples VariableVolSamples = new VariableSamples();
        public static BxAdapter BxAdapter;
    }
}
