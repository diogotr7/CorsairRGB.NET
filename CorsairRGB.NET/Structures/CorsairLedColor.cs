using CorsairRGB.NET.Enums;
using System.Runtime.InteropServices;

namespace CorsairRGB.NET.Structures
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
}