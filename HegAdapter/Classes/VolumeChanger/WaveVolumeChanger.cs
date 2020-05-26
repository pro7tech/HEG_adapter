using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BxAdapter
{
    class WaveVolumeChanger : IVolumeChanger
    {
        [DllImport("Winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr HWAVEOUT, int dwVolume);

        public void SetToNormalVolume() {
            SetVolumeLevel(VolumeManager.MaxVol);
        }

        public void SetVolumeLevel(int level) {
            int volConverted = (0x1000000 * level) + (0x100 * level);
            waveOutSetVolume(IntPtr.Zero, volConverted);
        }

        public int GetVolumeLevel() {
            return Int32.MinValue;
        }
    }
}
