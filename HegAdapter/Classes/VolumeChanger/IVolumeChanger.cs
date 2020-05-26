using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    interface IVolumeChanger
    {
        void SetToNormalVolume();
        void SetVolumeLevel(int level);
        int GetVolumeLevel();
    }
}
