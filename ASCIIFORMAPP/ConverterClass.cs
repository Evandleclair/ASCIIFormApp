using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
namespace WinFormMapApp
{
    internal static class ConverterClass
    {
        internal static imageArray loadImage(rawTextFile rt)
        {
            imageArray imgArray;
            using (var image = new MagickImage(rt.rawFilePath))
            {
                Console.WriteLine(image.FileName + " " + image.Width.ToString() + " " + image.Height.ToString());
                
                imgArray.imgByteArray = image.ToByteArray();
                imgArray.fileLoc = image.FileName;
            }
            return imgArray;
        }
    }//end class//
}//end namespace//
