namespace CorsairRGB.NET.Enums
{
    /// <summary>
    /// Contains list of device capabilities
    /// </summary>
    public enum CorsairDeviceCaps
    {
        None = 0x0000, // for devices that do not support any SDK functions.
        Lighting = 0x0001, // for devices that has controlled lighting.
        PropertyLookup = 0x0002  // for devices that provide current state through set of properties.
    };
}
