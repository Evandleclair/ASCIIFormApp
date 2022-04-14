using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ImageMagick;
namespace ASCIIFormApp
{
    internal static class ConverterClass
    {
        static readonly char[] charKey = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrieuxnuvczXYUJCLQ0OZnmwqpdbkhcao*#NMW&8%B@@$".ToCharArray();

        internal static imageArray loadImage(rawTextFile rt)
        {
            imageArray imgArray;
            
            using (Bitmap image = new Bitmap(rt.rawFilePath))
            {
                Console.WriteLine("SIZE IS " + image.Width.ToString() + " " + image.Height.ToString());
                imgArray.imgColorArray = ToColorArray(image);
                imgArray.imgIntArray = colorToBrightness(imgArray.imgColorArray);
                imgArray.fileLoc = rt.rawFilePath;
                imgArray.imgH = image.Height;
                imgArray.imgW = image.Width;
            }
            //Console.WriteLine(ToReadByteArray(imgArray.imgByteArray));
            //Console.WriteLine(imgArray.imgByteArray[0].ToString());
            return imgArray;
        }

        internal static void ConvertToASCII(DataHandler myHandler)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int h = 0; h < myHandler.heldImageArray.imgH; h++)
            {
                for (int w = 0; w < myHandler.heldImageArray.imgW; w++)
                {
                   
                    double brightValue = myHandler.heldImageArray.imgIntArray[h,w];
                    Console.WriteLine("Bright value was" + brightValue + " and so divided by 255 it is" + (brightValue / 255));
                    int charIndex = (int)((brightValue / 255) * 70);
                    Console.WriteLine("brightness was " + brightValue + " so character will be picked from " + charIndex);
                    char drawValue = charKey[charIndex];
                    sb.Append(drawValue);
                }
                sb.Append("\r\n");
            }
            Console.WriteLine(sb.ToString());
            // foreach (byte b in myHandler.heldImageArray.imgByteArray)
            // {
            //     Console.WriteLine(b.ToString());
            // }
        }
        internal static string ToReadByteArray(byte[] bytes)
        {
            return string.Join(", ", bytes);
        }
        internal static string ListBits(byte[] byteArray)
        {
            string s = System.Text.Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
            return s;
        }
        internal static Color[][] ToColorArray(Bitmap image)
        {
            Color[][] myMatrix = new Color[image.Height][];
            for (int h = 0; h < image.Height; h++)
            {
                Color[] rowArray = new Color[image.Width];
                for (int w = 0; w < image.Width; w++)
                {
                    rowArray[w] = image.GetPixel(w, h);
                }
                myMatrix[h] = rowArray;
            }
            return myMatrix;
        }
        internal static int[,] colorToBrightness(Color[][] cArray)
        {
            int arrayHeight = cArray.Length;
            int arrayWidth = cArray[0].Length;
            int[,] brightness = new int[arrayHeight,arrayWidth];
            Console.WriteLine("Array is " + arrayHeight + " + tall and is " + arrayWidth + " long");
            for (int h = 0; h < arrayHeight; h++)
            {
                for (int w = 0; w < arrayWidth; w++)
                {
                    brightness[h,w] = (cArray[h][w].R + cArray[h][w].G + cArray[h][w].B) / 3;
                }
            }
            return brightness;
        }
    }//end class//
}//end namespace//
