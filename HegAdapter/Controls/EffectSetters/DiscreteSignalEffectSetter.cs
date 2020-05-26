using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter {

    public partial class DiscreteSignalEffectSetter : UserControl
    {
        public DiscreteSignalEffectSetter()
        {
            InitializeComponent();
        }

        public int PassChange {
            get {
                return (int)updnPass.Value;
            }

            set {
                updnPass.Value = value;
            }
        }

        public int FailChange {
            get {
                return (int)updnFail.Value;
            }

            set {
                updnFail.Value = value;
            }
        }
    }
}
