using System;
using System.Collections.Generic;
using System.Text;

namespace CorsairRGB.NET.Enums
{
    /// <summary>
    /// Contains list of the LED-devices which can be connected to the DIY-device.
    /// </summary>
    public enum CorsairChannelDeviceType
    {
        Invalid = 0,
        HD_Fan = 1,
        SP_Fan = 2,
        LL_Fan = 3,
        ML_Fan = 4,
        Strip = 5,
        DAP = 6,
        Pump = 7
    };
}
