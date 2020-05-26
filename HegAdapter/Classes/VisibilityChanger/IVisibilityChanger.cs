using System;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter
{
    public interface IVisibilityChanger
    {
        void SetBrightness(int level);
        void SetFullBrightness();
    }
}
