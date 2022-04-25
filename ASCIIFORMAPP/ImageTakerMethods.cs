using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIFormApp
{
     internal class ImageTakerMethods
    {
        internal void LoadAndConvertImage(DataHandler dataHandler)
        {
            rawTextFile rawText = new rawTextFile();
            rawText=LoadImageDialog(dataHandler);
            if (rawText.rawFileContent !="failure")
            { 
                dataHandler.heldImageArray=ConverterClass.loadImage(rawText);
            }//end if//
            else
            {
                Console.WriteLine("Failed to load image. Please try again");
            }
        }//end LoadAndConvertImage//
        internal Font GetScaledFont(Graphics g, Font f, float scale)
        {
            return new Font(f.FontFamily,
                            f.SizeInPoints * scale,
                            f.Style,
                            GraphicsUnit.Point,
                            f.GdiCharSet,
                            f.GdiVerticalFont);
        }
      
        internal rawTextFile LoadImageDialog(DataHandler dataHandler)
        {
            try{
                string retFilePath = retFilePath = "";
                rawTextFile retVal = new rawTextFile(retFilePath, "");

                using (OpenFileDialog fileDlog = new OpenFileDialog())
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
