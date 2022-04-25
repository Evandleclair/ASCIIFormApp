﻿using System;
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
        internal RectangleF GetScaledRect(Graphics g, RectangleF r, float xScale, float yScale)
        {
            Console.WriteLine((float)r.X);
            Console.WriteLine((float)r.Y);
            Console.WriteLine((float)r.Width);
            Console.WriteLine((float)r.Height);
            Console.WriteLine((float)(r.X * xScale));
            Console.WriteLine((float)(r.Y * yScale));
            Console.WriteLine((float)(r.Width * xScale));
            Console.WriteLine((float)(r.Height * yScale));

            return new RectangleF((float)(r.X * xScale),
                                (float)(r.Y * yScale),
                                (float)(r.Width * xScale),
                                (float)(r.Height * yScale));
            /*
             *  return new Rectangle((int)Math.Ceiling(r.X * xScale),
                                (int)Math.Ceiling(r.Y * yScale),
                                (int)Math.Ceiling(r.Width * xScale),
                                (int)Math.Ceiling(r.Height * yScale));
             */
        }
        internal Font GenerateFont (DataHandler myHandler, Graphics g, float hScaleRatio, float wScaleRatio)
        {
            //string firstlineofASCII = myHandler.heldASCIIImage.Substring(0, myHandler.heldASCIIImage.IndexOf(Environment.NewLine));


            /*
            float ScaleRatio = (hScaleRatio < wScaleRatio)
                ? ScaleRatio = hScaleRatio
                : ScaleRatio = wScaleRatio;


            float ScaleFontSize = 12 * ScaleRatio;
            return new Font(FontFamily.GenericMonospace, ScaleFontSize);
            */
            return new Font(FontFamily.GenericMonospace, 12, FontStyle.Regular);

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
