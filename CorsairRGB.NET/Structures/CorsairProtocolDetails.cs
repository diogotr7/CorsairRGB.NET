using System;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
{
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
    {
        internal IntPtr sdkVersion;
        internal IntPtr serverVersion;
        internal int sdkProtocolVersion;
        internal int serverProtocolVersion;
        internal byte breakingChanges;
    }
}