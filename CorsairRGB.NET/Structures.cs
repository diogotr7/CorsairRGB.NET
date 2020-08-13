using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CorsairRGB.NET
{
    /// <summary>
    /// Contains information about led and its color
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairLedColor
    {
        /// <summary>
        /// identifier of LED to set.
        /// </summary>
        public CorsairLedId LedId;

        /// <summary>
        /// Red Value [0..255]
        /// </summary>
        public int R;

        /// <summary>
        /// Green Value [0..255]
        /// </summary>
        public int G;

        /// <summary>
        /// Blue Value [0..255]
        /// </summary>
        public int B;
    };

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

#pragma warning disable IDE1006 // Naming Styles
    #region CorsairProtocolDetails

    /// <summary>
    /// contains information about SDK and CUE versions.
    /// </summary>
    public struct CorsairProtocolDetails
    {
        /// <summary>
        /// Version of SDK(like “1.0.0.1”). Always contains valid value even if there was no CUE found.
        /// </summary>
        public string SdkVersion;

        /// <summary>
        /// Version of CUE(like “1.0.0.1”) or NULL if CUE was not found.
        /// </summary>
        public string ServerVersion;

        /// <summary>
        /// integer number that specifies version of protocol that is implemented by current SDK.
        /// Numbering starts from 1. Always contains valid value even if there was no CUE found.
        /// </summary>
        public int SdkProtocolVersion;

        /// <summary>
        /// integer number that specifies version of protocol that is implemented by CUE. 
        /// Numbering starts from 1. If CUE was not found then this value will be 0.
        /// </summary>
        public int ServerProtocolVersion;

        /// <summary>
        /// Boolean value that specifies if there were breaking changes between version of protocol implemented by server and client.
        /// </summary>
        public bool BreakingChanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairProtocolDetails
#pragma warning restore IDE1006 // Naming Styles
    {
        internal IntPtr sdkVersion;
        internal IntPtr serverVersion;
        internal int sdkProtocolVersion;
        internal int serverProtocolVersion;
        internal byte breakingChanges;
    }
    #endregion

    #region CorsairDeviceInfo
    /// <summary>
    /// Contains information about device.
    /// </summary>
    public struct CorsairDeviceInfo
    {
        /// <summary>
        /// Enum describing device type.
        /// </summary>
        public CorsairDeviceType Type;

        /// <summary>
        /// Device model(like “K95RGB”).
        /// </summary>
        public string Model;

        /// <summary>
        /// Enum describing physical layout of the keyboard or mouse.
        /// </summary>
        public CorsairPhysicalLayout PhysicalLayout;

        /// <summary>
        /// enum describing logical layout of the keyboard as set in CUE settings.
        /// </summary>
        public CorsairLogicalLayout LogicalLayout;

        /// <summary>
        /// Mask that describes device capabilities, formed as logical “or” of CorsairDeviceCaps enum values.
        /// </summary>
        public CorsairDeviceCaps CapsMask;

        /// <summary>
        /// Number of controllable LEDs on the device.
        /// </summary>
        public int LedsCount;

        /// <summary>
        /// Structure that describes channels of the DIY-devices.
        /// </summary>
        public CorsairChannelsInfo Channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairDeviceInfo
    {
        internal int type;
        internal IntPtr model;
        internal int physicalLayout;
        internal int logicalLayout;
        internal int capsMask;
        internal int ledsCount;
        internal _CorsairChannelsInfo channels;
    }
    #endregion

    #region CorsairChannelsInfo
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
    #endregion

    #region CorsairChannelInfo
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
    #endregion
}