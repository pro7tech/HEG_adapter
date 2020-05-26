using System;
using System.Collections.Generic;
using System.Text;
using CoreAudioApi;

namespace BxAdapter
{
    class VistaVolumeChanger : IVolumeChanger
    {
        private MMDevice device;

        BxAdapter bx;
        public VistaVolumeChanger(BxAdapter bx) {
            this.bx = bx;
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            try {
                device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            } catch (Exception ex) {
                string s = ex.ToString();
            }
        }

        public void SetToNormalVolume() {
            SetVolumeLevel(bx.MaximumVolume);
        }

        public void SetVolumeLevel(int level) {
            if (device != null) {
                device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)level / 255.0f);
            }
        }

        public int GetVolumeLevel() {
            if (device != null) {
                return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 255.0);
            } else {
                return 1;
            }
        }
    }
}
