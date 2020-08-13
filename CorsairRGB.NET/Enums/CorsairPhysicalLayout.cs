namespace CorsairRGB.NET.Enums
{
    /// <summary>
    /// Contains list of available physical layouts for keyboards
    /// </summary>
    public enum CorsairPhysicalLayout
    {
        Invalid = 0,        // dummy value.

        US = 1,
        UK = 2,
        BR = 3,
        JP = 4,
        KR = 5,             // valid values for keyboard.

        Zones1 = 6,
        Zones2 = 7,
        Zones3 = 8,
        Zones4 = 9          // valid values for mouse.
    };
}
