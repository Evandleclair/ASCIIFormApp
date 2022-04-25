using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIFormApp
{
     internal class ImageTakerMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataHandler"></param>
        #pragma warning disable CA1822 // Cannot mark as static due to outside references//
        internal void LoadAndConvertImage(DataHandler dataHandler)
        #pragma warning restore CA1822 // Cannot mark as static due to outside references//
        {
            // _ = new rawTextFile();
            rawTextFile rawText = LoadImageDialog(dataHandler);
            if (rawText.rawFileContent !="failure")
            { 
                dataHandler.heldImageArray=ConverterClass.LoadImage(rawText);
            }//end if//
            else
            {
                Console.WriteLine("Failed to load image. Please try again");
            }
        }//end LoadAndConvertImage//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="f"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
#pragma warning disable CA1822 // Mark members as static
        internal Font GetScaledFont( Font f, float scale) 
#pragma warning restore CA1822 // Mark members as static
        {
            return new Font(f.FontFamily,
                            f.SizeInPoints * scale,
                            f.Style,
                            GraphicsUnit.Pixel,
                            f.GdiCharSet,
                            f.GdiVerticalFont);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataHandler"></param>
        /// <returns></returns>
        internal static rawTextFile LoadImageDialog(DataHandler dataHandler)
        {
            try{
                string retFilePath = retFilePath = "";
                rawTextFile retVal = new(retFilePath, "");

                using (OpenFileDialog fileDlog = new())
                {
                    fileDlog.InitialDirectory = "c:\\";
                    fileDlog.Filter = "Image Files|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
                    fileDlog.FilterIndex = 1;
                    fileDlog.RestoreDirectory = true;

                    if (fileDlog.ShowDialog() == DialogResult.OK)
                    {
                       retVal.rawFilePath = fileDlog.FileName;
                    }//end if//
                }//end using//
                return retVal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                dataHandler.failureFlag = true;
                return new rawTextFile("","");
            }//end catch
        }//end load image dialog//
    }
}
