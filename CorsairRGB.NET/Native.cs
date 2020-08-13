using CorsairRGB.NET.Enums;
using CorsairRGB.NET.Structures;
using System;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET
{
    /// <summary>
    /// Native DLL methods
    /// </summary>
    internal static class Native
    {
        internal const string dllpath = "CUESDK.x64_2017.dll";

        /// <summary>
        /// checks file and protocol version of CUE to understand which of SDK functions can be used with this version of CUE.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern _CorsairProtocolDetails CorsairPerformProtocolHandshake();

        /// <summary>
        /// requestes control using specified access mode. By default client has shared control over lighting so there is no need to call CorsairRequestControl unless client requires exclusive control.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairRequestControl(CorsairAccessMode accessMode);

        /// <summary>
        /// releases previously requested control for specified access mode.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairReleaseControl(CorsairAccessMode accessMode);

        /// <summary>
        /// returns last error that occured while using any of Corsair* functions.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern CorsairError CorsairGetLastError();

        /// <summary>
        /// returns information about device at provided index.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr CorsairGetDeviceInfo(int deviceIndex);

        /// <summary>
        /// returns number of connected Corsair devices that support lighting control.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int CorsairGetDeviceCount();

        /// <summary>
        /// set layer priority for this shared client.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairSetLayerPriority(int priority);

        /// <summary>
        /// set specified leds to some colors. The color is retained until changed by successive calls. This function does not take logical layout into account.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairSetLedsColors(int size, CorsairLedColor[] ledsColors);

        /// <summary>
        /// Set specified LEDs to some colors. This function set LEDs colors in the buffer which is written to the devices via CorsairSetLedsColorsFlushBuffer or CorsairSetLedsColorsFlushBufferAsync.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairSetLedsColorsBufferByDeviceIndex(int deviceIndex, int size, CorsairLedColor[] ledsColors);

        /// <summary>
        /// writes to the devices LEDs colors buffer which is previously filled by the CorsairSetLedsColorsBufferByDeviceIndex function.
        /// </summary>
        [DllImport(dllpath, CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool CorsairSetLedsColorsFlushBuffer();
    }
}
