using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter
{
    public partial class VariableSignalEffectSetter : UserControl
    {
        public VariableSignalEffectSetter(Color backgroundColor)
        {
            InitializeComponent();
            this.BackColor = backgroundColor;
        }

        public void ProcessSample(double sample, TrackBar trackerbar, VariableSamples variableSamples) {
            float percentReward = variableSamples.GetRewardLevelForSample(sample, 
                5, 
                (int) updnMaximumThresholdPercent.Value, 
                (int) updnMinimumThresholdPercent.Value,
                chkReverse.Checked, false);

            int scale = trackerbar.Maximum - trackerbar.Minimum;
            int reward = (int) Math.Ceiling(scale * percentReward);
            trackerbar.Value = trackerbar.Minimum + reward;
        }
    }
}
