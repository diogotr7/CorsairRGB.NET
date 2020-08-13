using CorsairRGB.NET.Enums;
using System;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
{
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
}