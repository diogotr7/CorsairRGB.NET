using System;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
{
    /// <summary>
    /// Contains information about separate channel of the DIY-device.
    /// </summary>
    public struct CorsairChannelInfo
    {
        /// <summary>
        /// Total number of LEDs connected to the channel.
        /// </summary>
        public int TotalLedsCount;

        /// <summary>
        /// Number of LED-devices (fans, strips, etc.) connected to the channel which is controlled by the DIY device.
        /// </summary>
        public int DevicesCount;

        /// <summary>
        /// Array containing information about each separate LED-device connected to the channel controlled by the DIY device.
        /// Index of the LED-device in array is same as the index of the LED-device connected to the DIY-device.
        /// </summary>
        public CorsairChannelDeviceInfo[] Devices;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairChannelInfo
    {
        internal int totalLedsCount;
        internal int devicesCount;
        internal IntPtr devices;
    }
}