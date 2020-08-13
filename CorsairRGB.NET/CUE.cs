using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CorsairRGB.NET
{
    /// <summary>
    /// CUE SDK Wrapper
    /// </summary>
    public static class CUE
    {
        /// <summary>
        /// Checks file and protocol version of CUE to understand which of
        /// SDK functions can be used with this version of CUE.
        /// </summary>
        public static CorsairProtocolDetails PerformProtocolHandshake()
        {
            var temp = Native.CorsairPerformProtocolHandshake();
            return new CorsairProtocolDetails()
            {
                SdkVersion = Marshal.PtrToStringAnsi(temp.sdkVersion),
                ServerVersion = Marshal.PtrToStringAnsi(temp.serverVersion),
                SdkProtocolVersion = temp.sdkProtocolVersion,
                ServerProtocolVersion = temp.serverProtocolVersion,
                BreakingChanges = temp.breakingChanges != 0,
            };
        }

        /// <summary>
        /// Returns information about a device based on provided index.
        /// </summary>
        /// <param name="index"></param>
        public static CorsairDeviceInfo GetDeviceInfo(int index)
        {
            var _devInfo = (_CorsairDeviceInfo)Marshal.PtrToStructure(Native.CorsairGetDeviceInfo(index), typeof(_CorsairDeviceInfo));
            var _channelsInfo = _devInfo.channels;
            var _channelsArray = GetArrayFromPointer<_CorsairChannelInfo>(_channelsInfo.channels, _channelsInfo.channelsCount);
            var _channelInfoDict = new List<(_CorsairChannelInfo channelInfo, CorsairChannelDeviceInfo[] deviceInfos)>();
            foreach (var _channel in _channelsArray)
            {
                var devices = GetArrayFromPointer<CorsairChannelDeviceInfo>(_channel.devices, _channel.devicesCount);
                _channelInfoDict.Add((_channel, devices));
            }

            var channelsList = new List<CorsairChannelInfo>();
            foreach(var kvp in _channelInfoDict)
            {
                var y = new List<CorsairChannelDeviceInfo>();
                foreach(var devinfo in kvp.deviceInfos)
                {
                    y.Add(new CorsairChannelDeviceInfo()
                    {
                        DeviceLedCount = devinfo.DeviceLedCount,
                        Type = devinfo.Type
                    });
                }
                channelsList.Add(new CorsairChannelInfo()
                {
                    DevicesCount = kvp.channelInfo.devicesCount,
                    TotalLedsCount = kvp.channelInfo.totalLedsCount,
                    Devices = y.ToArray()
                });
            }
            var channelsInfo = new CorsairChannelsInfo()
            {
                ChannelsCount = _channelsInfo.channelsCount,
                Channels = channelsList.ToArray()
            };

            return new CorsairDeviceInfo()
            {
                CapsMask = (CorsairDeviceCaps)_devInfo.capsMask,
                LedsCount = _devInfo.ledsCount,
                LogicalLayout = (CorsairLogicalLayout)_devInfo.logicalLayout,
                PhysicalLayout = (CorsairPhysicalLayout)_devInfo.physicalLayout,
                Model = Marshal.PtrToStringAnsi(_devInfo.model),
                Type = (CorsairDeviceType)_devInfo.type,
                Channels = channelsInfo
            };
        }

        /// <summary>
        /// Requests exclusive control of lighting
        /// </summary>
        public static bool RequestControl() => Native.CorsairRequestControl(CorsairAccessMode.ExclusiveLightingControl);

        /// <summary>
        /// Restores lighting control to iCue
        /// </summary>
        public static bool ReleaseControl() => Native.CorsairReleaseControl(CorsairAccessMode.ExclusiveLightingControl);

        /// <summary>
        /// Returns last error that occurred in this thread while using any Corsair Function functions.
        /// </summary>
        public static CorsairError GetLastError() => Native.CorsairGetLastError();

        /// <summary>
        /// Returns the number of devices found
        /// </summary>
        /// <returns></returns>
        public static int GetDeviceCount() => Native.CorsairGetDeviceCount();

        /// <summary>
        /// Sets the priority of the sdk app from 0-255. iCue itself has a priority of 127
        /// </summary>
        public static bool SetLayerPriority(int priority) => Native.CorsairSetLayerPriority(priority);

        /// <summary>
        /// Sets the given ledIds to the given colors
        /// </summary>
        public static bool SetLedColors(CorsairLedColor[] ledColors) => Native.CorsairSetLedsColors(ledColors.Length, ledColors);

        /// <summary>
        /// Sets the given ledIds of the given device to the given colors
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="ledColors"></param>
        /// <returns></returns>
        public static bool SetDeviceColors(int deviceId, CorsairLedColor[] ledColors) => Native.CorsairSetLedsColorsBufferByDeviceIndex(deviceId, ledColors.Length, ledColors);

        /// <summary>
        /// Writes the colors to the devices
        /// </summary>
        /// <returns></returns>
        public static bool Update() => Native.CorsairSetLedsColorsFlushBuffer();

        private static T[] GetArrayFromPointer<T>(IntPtr intPtr, int length)
        {
            var size = Marshal.SizeOf(typeof(T));
            var mangagedArray = new T[length];
            IntPtr ins = intPtr;

            for (int i = 0; i < length; i++)
            {
                mangagedArray[i] = Marshal.PtrToStructure<T>(ins);
                ins = new IntPtr(ins.ToInt64() + size);
            }
            return mangagedArray;
        }
    }
}
