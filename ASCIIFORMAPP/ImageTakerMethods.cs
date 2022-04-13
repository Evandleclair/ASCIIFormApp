using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMapApp
{
     internal class ImageTakerMethods
    {
       
        

        internal imageArray LoadAndConvertImage()
        {
           return ConverterClass.loadImage(LoadImageDialog());

        }
        internal rawTextFile LoadImageDialog()
        {
            string retFilePath = retFilePath = "";
            rawTextFile retVal = new rawTextFile(retFilePath, "");

            using (OpenFileDialog fileDlog = new OpenFileDialog())
            {
                fileDlog.InitialDirectory = "c:\\";
                fileDlog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDlog.FilterIndex = 2;
                fileDlog.RestoreDirectory = true;

                if (fileDlog.ShowDialog() == DialogResult.OK)
                {
                    retVal.rawFilePath = fileDlog.FileName;
                }//end if//
            }//end using//
            return retVal;
        }//end load image dialog//

    }
}
