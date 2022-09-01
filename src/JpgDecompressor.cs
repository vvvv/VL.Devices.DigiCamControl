using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System;

namespace DigiCamControl
{
    public static class JpgDecompressor
    {
        public static byte[] DecompressJpeg(ArraySegment<byte> jpgEncodedBytes)
        {
            if (jpgEncodedBytes.Count > 4)
            {
                using (MemoryStream inStream = new MemoryStream(jpgEncodedBytes.Array))
                {
                    using (Bitmap bmp = new Bitmap(inStream))
                    {
                        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

                        var data = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                        var arraySize = data.Stride * data.Height;
                        var result = new byte[arraySize];

                        //var lineSize = data.Width * 4;
                        //for (int i = 0; i < data.Height; i++)
                        {
                            Marshal.Copy(data.Scan0, result, 0, arraySize);
                        }

                        bmp.UnlockBits(data);

                        return result;
                    }
                } 
            }
            return new byte[0];
        }
    }
} 