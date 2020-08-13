using CorsairRGB.NET.Enums;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
{
    /// <summary>
    /// Contains information about separate LED-device connected to the channel controlled by the DIY-device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairChannelDeviceInfo
    {
        /// <summary>
        /// Type of the LED Device.
        /// </summary>
        public CorsairChannelDeviceType Type;

        /// <summary>
        /// Number of LEDs controlled by LED-device.
        /// </summary>
        public int DeviceLedCount;
    };
}