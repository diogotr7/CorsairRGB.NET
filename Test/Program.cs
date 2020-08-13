using CorsairRGB.NET;
using CorsairRGB.NET.Enums;
using CorsairRGB.NET.Structures;
using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dets = CUE.PerformProtocolHandshake();

            if (CUE.RequestControl())
            {
                int a = CUE.GetDeviceCount();
                List<CorsairDeviceInfo> infos = new List<CorsairDeviceInfo>();
                for (int i = 0; i < a; i++)
                {
                    var info = CUE.GetDeviceInfo(i);
                    Console.WriteLine(info.Model);
                    infos.Add(info);
                }

                var colorbuffer = new CorsairLedColor[]
                {
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.K_W,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.K_A,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.K_S,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.K_D,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_1,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_2,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_3,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_4,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_5,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                    new CorsairLedColor()
                    {
                        LedId = CorsairLedId.M_6,
                        R = 0,
                        G = 0,
                        B = 255
                    },
                };
                CUE.SetLedColors(colorbuffer);
                CUE.Update();
            }

            Console.ReadLine();
            CUE.ReleaseControl();
            Console.ReadLine();
        }
    }
}
