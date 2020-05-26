using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter {
    public class VolumeManager {
        IVolumeChanger VolumeChanger;

        public int Level {
            get {
                if (VolumeChanger != null) {
                    return VolumeChanger.GetVolumeLevel();
                } else {
                    return 0;
                }
            }
            set {
                if (VolumeChanger != null) {
                    VolumeChanger.SetVolumeLevel(value);
                }
            }
        }

        public const int MaxVol = 255;
        public const int MinVol = 0;

        private bool missingSpeaker;
        public bool MissingSpeaker {
            get { return missingSpeaker; }
            set { missingSpeaker = value; }
        }

        public VolumeManager(NumericUpDown updnVolMax, BxAdapter bx) {

            if (C.IsVistaOperatingSystem()) {
                try {
                    VolumeChanger = new VistaVolumeChanger(bx);
                    updnVolMax.Value = Level;
                    updnVolMax.Visible = true;
                } catch (ArgumentException e) {
                    string variableToSupressCompilerWarning = e.ToString();
                    missingSpeaker = true;
                } 
            } else {
                VolumeChanger = new WaveVolumeChanger();
                updnVolMax.Visible = false;
            }
        }

        ~VolumeManager() {
            SetToNormal();
        }

        public void SetToNormal() {
            if (VolumeChanger != null) {
                VolumeChanger.SetToNormalVolume();
            }
        }
    }
}
