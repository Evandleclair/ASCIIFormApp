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
        /// Sets the failure flag to false, then attempts to load an image. //
        /// </summary>
        /// <param name="dataHandler"></param>
        #pragma warning disable CA1822 // Cannot mark as static due to outside references//
        internal void LoadImage(DataHandler dataHandler)
        #pragma warning restore CA1822 // Cannot mark as static due to outside references//
        {
            dataHandler.failureFlag = false; //resets the failure flag of our data handler//
            dataHandler.heldImagePath = LoadImageDialog(dataHandler);
        }//end LoadAndConvertImage//

        /// <summary>
        /// Conversion method used by the main form. Can only be used when there is an image loaded
        /// </summary>
        /// <param name="dataHandler">the DataHandler to reference</param>
        internal void ConvertImage(DataHandler dataHandler)
        {
            string imgPath = dataHandler.heldImagePath;
            if ((dataHandler.failureFlag == false)&&(imgPath != ""))
            {
                dataHandler.heldImageObj = ConverterClass.ResizeAndStoreImage(imgPath);
                ConverterClass.ConvertToASCII(dataHandler);
            }//end if//
            else
            {
                MessageBox.Show("WARNING: Either no image has been loaded, or an invalid file path was provided. Please choose another image and try again.");
            }//end else//
        }//end ConvertImage//

        /// <summary>
        /// Resizes the font according to our scale ratio
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
        /// Opens a file dialog so you can select and load an image. Then stores the image in our DataHandler//
        /// </summary>
        /// <param name="dataHandler"></param>
        /// <returns></returns>
        internal static String LoadImageDialog(DataHandler dataHandler)
        {
            try
            {
                string retFilePath = retFilePath = "";

                using (OpenFileDialog fileDlog = new())
                {
                    fileDlog.InitialDirectory = "c:\\";
                    fileDlog.Filter = "Image Files|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
                    fileDlog.FilterIndex = 1;
                    fileDlog.RestoreDirectory = true;

                    if (fileDlog.ShowDialog() == DialogResult.OK)
                    {
                        retFilePath = fileDlog.FileName;
                    }//end if//
                }//end using//
                return retFilePath;
            }//end try//
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                dataHandler.failureFlag = true; //
                return "";
            }//end catch//
        }//end load image dialog//
    }//end class//
}//end namespace//
