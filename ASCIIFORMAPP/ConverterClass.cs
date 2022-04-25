using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ImageMagick;
namespace ASCIIFormApp
{
    /// <summary>
    /// This class handles conversion methods, such as from image to color array, or color array to ASCII//
    /// </summary>
    internal static class ConverterClass
    {
        static readonly char[] charKey = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrieuxnuvczXYUJCLQ0OZnmwqpdbkhcao*#NMW&8%B@@$".ToCharArray();
        /// <summary>
        /// Takes an image, resizes it to account for how ASCII is naturally skewed taller, and then saves the details into an image object type
        /// </summary>
        /// <param name="rt"></param>
        /// <returns></returns>
        internal static imageObj ResizeAndStoreImage(string imgPath)
        {
            imageObj myImgObj;
            
            using (Bitmap image = new(imgPath))
            {
                Size imageScale = new((int)(image.Width*0.80), (int)(image.Height*0.4));
                using Bitmap resizedImage = new(image, imageScale);
                Console.WriteLine("SIZE IS " + resizedImage.Width.ToString() + " " + resizedImage.Height.ToString());
                myImgObj.imgColorArray = ToColorArray(resizedImage);
                myImgObj.imgIntArray = ColorToBrightness(myImgObj.imgColorArray);
                myImgObj.fileLoc = imgPath;
                myImgObj.imgH = resizedImage.Height;
                myImgObj.imgW = resizedImage.Width;
            }//end using//
            return myImgObj;
        }//end ResizeAndStoreImage//

        /// <summary>
        /// Takes the array held by the data handler, and turns it into an ASCII string using a string builder. the DataHandler then stores this resulting string// 
        /// </summary>
        /// <param name="myHandler">the instance of DataHandler that is being used</param>
        internal static void ConvertToASCII(DataHandler myHandler)
        {
            StringBuilder sb = new();
            
            for (int h = 0; h < myHandler.heldImageObj.imgH; h++)
            {
                for (int w = 0; w < myHandler.heldImageObj.imgW; w++)
                {
                    double brightValue = myHandler.heldImageObj.imgIntArray[h,w]; //get the brightness value from the held array
                    int charIndex = (int)((brightValue / 255) * 70); //turn it into a fraction, and then use that fraction to select from our ASCII character bank//
                    char drawValue = charKey[charIndex]; 
                    sb.Append(drawValue); //append our resulting character to the ASCII string/
                }//end width for loop//
                sb.Append("\r\n"); //linebreak//
            }//end height for loop//
            myHandler.heldASCIIString=sb.ToString(); //give the ASCII image to the DataHandler to hold.//
        }//end ConvertToASCII class//

        /// <summary>
        /// Takes a bitmap image and returns a color array. We can convert a color array's values into an ASCII image//
        /// </summary>
        /// <param name="image">the bitmap image to be converted</param>
        /// <returns>a color matrix</returns>
        internal static Color[][] ToColorArray(Bitmap image)
        {
            Color[][] myMatrix = new Color[image.Height][]; //create a new matrix to hold the color values//
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
        /// <summary>
        /// takes an array of colors and returns a matrix the brightness value of every pixel.
        /// </summary>
        /// <param name="cArray">an array of color data, derived from a bitmap</param>
        /// <returns> a matrix of the brightness values of pixels</returns>
        internal static int[,] ColorToBrightness(Color[][] cArray)
        {
            int arrayHeight = cArray.Length;
            int arrayWidth = cArray[0].Length;
            int[,] brightness = new int[arrayHeight,arrayWidth];
            for (int h = 0; h < arrayHeight; h++)
            {
                for (int w = 0; w < arrayWidth; w++)
                {
                    //we can get the brightness by taking the three color values of the pixel and averaging them//
                    brightness[h,w] = (cArray[h][w].R + cArray[h][w].G + cArray[h][w].B) / 3; 
                } //end width for loop//
            }//end height for loop
            return brightness;
        }//end ColorToBrightness
    }//end class//
}//end namespace//
