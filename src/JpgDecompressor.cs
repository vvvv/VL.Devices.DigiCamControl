using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DigiCamControl
{
    public static class JpgDecompressor
    {
        public static byte[] DecompressJpeg(byte[] photoBytes)
        {
            byte[] result = photoBytes;
            if (photoBytes.Length > 4)
            {
                using (MemoryStream inStream = new MemoryStream(photoBytes))
                {
                    //using(var img = Image.FromStream(inStream))
                    using (Bitmap bmp = new Bitmap(inStream))
                    {
                        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

                        var data = bmp.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                        var arraySize = data.Stride * data.Height;
                        result = new byte[arraySize];

                        var lineSize = data.Width * 4;
                        //for (int i = 0; i < data.Height; i++)
                        {
                            Marshal.Copy(data.Scan0, result, 0, arraySize);
                        }

                        bmp.UnlockBits(data);
                    }
                } 
            }
            return result;
        }
    }
} 