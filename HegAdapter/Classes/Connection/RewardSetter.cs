using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BxAdapter
{
    public class RewardSetter
    {
        BxAdapter bx;
        public RewardSetter(BxAdapter bxAdapter) {
            bx = bxAdapter;
        }

        public void SetValueForPassSignal(TrackBar track, int change) {
            int newValue = track.Value + change;
            if (newValue <= track.Maximum) {
                track.Value = newValue;
            }
        }

        public void SetValueForFailSignal(TrackBar track, int change) {
            int newValue = track.Value - change;
            if (newValue >= track.Minimum) {
                track.Value = newValue;
            }
        }

        #region visibility changes
        public void MinVisLevelChanged() {
            if (Visibility < MinVisibility) {
                Visibility = MinVisibility;
            }
            bx.TxtVisMin.Text = MinVisibility.ToString();
        }

        public void VisibilityValueChanged() {
            if (Visibility < MinVisibility) {
                Visibility = MinVisibility;
            } else {
                bx.TxtVis.Text = Visibility.ToString();
                bx.VisManager.SetBrightness(Visibility);
            }
        }
        #endregion

        #region Volume Changes

        public void MinVolLevelChanged() {
            if (Volume < MinVolume) {
                Volume = MinVolume;
            }
            bx.TxtVolMin.Text = MinVolume.ToString();
        }

        public void MaxVolChanged() {
            if (Volume > MaxVolume) {
                Volume = MaxVolume;
            }
        }

        public void VolLevelChanged() {
            if (VolumeRangeIsValid()) {
                if (Volume > MaxVolume) {
                    Volume = MaxVolume;
                } else if (Volume < MinVolume) {
                    Volume = MinVolume;
                } else {
                    if (bx.VolManager != null) {  //TODO: hack and dependency
                        bx.VolManager.Level = Volume;
                    }
                    bx.TxtVol.Text = Volume.ToString();
                }
            } else {
                MakeVolumeRangeValid();
            }
        }

        private bool VolumeRangeIsValid() {
            if ((MaxVolume >= MinVolume) &&
               (Volume <= MaxVolume) &&
               (Volume >= MinVolume)) {
                return true;
            } else {
                return false;
            }
        }

        private void MakeVolumeRangeValid() {
            if (MinVolume > MaxVolume) {
                MinVolume = MaxVolume;
            }

            if (Volume > MaxVolume) {
                Volume = MaxVolume;
            }

            if (Volume < MinVolume) {
                Volume = MinVolume;
            }
        }

        #endregion

        #region properties
        private int MinVisibility {
            get { return bx.TrackVisMin.Value; }
        }

        private int Visibility {
            get { return bx.TrackVis.Value; }
            set { bx.TrackVis.Value = value; }
        }

        private int MaxVolume {
            get { return (int)bx.UpdnVolMax.Value; }
            set { bx.UpdnVolMax.Value = value; }
        }

        private int Volume {
            get { return bx.TrackVol.Value; }
            set { bx.TrackVol.Value = value; }
        }

        private int MinVolume {
            get { return bx.TrackVolMin.Value; }
            set { bx.TrackVolMin.Value = value; }
        }
        #endregion

    }
}

//     private KeyInteractType GetKeyInteractType() {
//    if (radioTapKey.Checked) {
//        return KeyInteractType.TapKey;
//    } else if (radioHoldKey.Checked) {
//        return KeyInteractType.HoldKey;
//    }
//    return KeyInteractType.NotSet;
//}


