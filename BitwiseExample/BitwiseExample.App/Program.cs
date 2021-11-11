using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace BitmapFiles.App
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] logo = File.ReadAllBytes("sps.bmp");
            byte first = logo[0];
            byte second = logo[1];

            char b = 'B';
            char m = 'M';

            int res1 = first ^ (byte)b;
            int res2 = second ^ (byte)m;

            try
            {
                Debug.Assert(res1 == 0 && res2 == 0);

                // n.b. this bmp file seems to conform to the BITMAPV5HEADER format, as given on wikipedia: 
                // https://en.wikipedia.org/wiki/BMP_file_format 
                IList<byte> size = new List<byte>();
                int sizeOffset = 2;
                for (int i = 0; i < 4; ++i)
                    size.Add(logo[i+sizeOffset]);

                int sizeInBytes = 0;
                sizeInBytes += size[3] << 24;
                sizeInBytes += size[2] << 16;
                sizeInBytes += size[1] << 8;
                sizeInBytes += size[0] << 0;
                Console.WriteLine($"File size ~ {sizeInBytes}b (logo byte array has size {logo.GetUpperBound(0)+1})");
            } catch(Exception aex)
            {
                Console.WriteLine($"Exception caught: {aex.Message}");
            }
            Console.ReadKey();
        }
    }
}