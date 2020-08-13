using System;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
{
    /// <summary>
    /// contains information about channels of the DIY-devices.
    /// </summary>
    public struct CorsairChannelsInfo
    {
        /// <summary>
        /// number of channels controlled by the device.
        /// </summary>
        public int ChannelsCount;

        /// <summary>
        /// array containing information about each separate channel of the DIY-device. 
        /// Index of the channel in the array is same as index of the channel on the DIY-device.
        /// </summary>
        public CorsairChannelInfo[] Channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairChannelsInfo
    {
        internal int channelsCount;
        internal IntPtr channels;
    }
}