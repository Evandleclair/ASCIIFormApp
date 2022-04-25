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
        //static readonly char[] charKey = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrieuxnuvczXYUJCLQ0OZnmwqpdbkhcao*#NMW&8%B@@$".ToCharArray();
        static readonly char[] charKey = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrieuxnuvczXYUJCLQ0OZnmwqpdbkhcao*#NMW&8%B@@$".ToCharArray();

        internal static imageArray LoadImage(rawTextFile rt)
        {
            imageArray imgArray;
            
            using (Bitmap image = new(rt.rawFilePath))
            {
                Size imageScale = new((int)(image.Width*0.80), (int)(image.Height*0.4));
                using Bitmap resizedImage = new(image, imageScale);
                Console.WriteLine("SIZE IS " + resizedImage.Width.ToString() + " " + resizedImage.Height.ToString());
                imgArray.imgColorArray = ToColorArray(resizedImage);
                imgArray.imgIntArray = ColorToBrightness(imgArray.imgColorArray);
                imgArray.fileLoc = rt.rawFilePath;
                imgArray.imgH = resizedImage.Height;
                imgArray.imgW = resizedImage.Width;
            }
            return imgArray;
        }

        internal static void ConvertToASCII(DataHandler myHandler)
        {
            StringBuilder sb = new();
            
            for (int h = 0; h < myHandler.heldImageArray.imgH; h++)
            {
                for (int w = 0; w < myHandler.heldImageArray.imgW; w++)
                {
                   
                    double brightValue = myHandler.heldImageArray.imgIntArray[h,w];
                    //Console.WriteLine("Bright value was" + brightValue + " and so divided by 255 it is" + (brightValue / 255));
                    int charIndex = (int)((brightValue / 255) * 70);
                    //Console.WriteLine("brightness was " + brightValue + " so character will be picked from " + charIndex);
                    char drawValue = charKey[charIndex];
                    sb.Append(drawValue);
                }
                sb.Append("\r\n");
            }
            myHandler.heldASCIIImage=sb.ToString();
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
        internal static int[,] ColorToBrightness(Color[][] cArray)
        {
            int arrayHeight = cArray.Length;
            int arrayWidth = cArray[0].Length;
            int[,] brightness = new int[arrayHeight,arrayWidth];
            //Console.WriteLine("Array is " + arrayHeight + " + tall and is " + arrayWidth + " long");
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
