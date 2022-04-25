using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace ASCIIFormApp
{
    public partial class ImageTakerForm : Form
    {
        DataHandler myHandler;
        ImageTakerMethods myMethodBank;
        public ImageTakerForm()
        {
            InitializeComponent();
           myHandler = new DataHandler();
        myMethodBank = new ImageTakerMethods();
            myHandler.CanvasPanelBounds = canvasBox1.Bounds;
            canvasBox1.Paint += new System.Windows.Forms.PaintEventHandler(CanvasBox1_Paint);
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            myHandler.failureFlag = false;
           myMethodBank.LoadAndConvertImage(myHandler);
           if (myHandler.failureFlag!=true)
           {
                ConverterClass.ConvertToASCII(myHandler);
                canvasBox1.Refresh();
            }
           else
           {
                Console.WriteLine("Unable to convert image to ASCII due to an error. Please try again");
           }
        }

        private void OpenWebcamButton_Click(object sender, EventArgs e)
        {

        }

        private void ImageTakerForm_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();



        private void CanvasBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (myHandler.heldASCIIImage != null)
            {
                Graphics g = e.Graphics;
                Font myFont = new(FontFamily.GenericMonospace, 12, FontStyle.Regular);

                //Size canvasSize = Bounds.Size;
                Size canvasSize = canvasBox1.Size;
                SizeF RealSize = TextRenderer.MeasureText(myHandler.heldASCIIImage, myFont, canvasSize);

                float hScaleRatio = canvasSize.Height / RealSize.Height;
                float wScaleRatio;
                if (canvasSize.Width < RealSize.Width)
                {
                    wScaleRatio = canvasSize.Width / RealSize.Width;
                } 
                else
                {
                     wScaleRatio = RealSize.Width / canvasSize.Width;
                }
                
                float ScaleRatio = wScaleRatio;
                if (hScaleRatio<wScaleRatio)
                {
                    ScaleRatio = hScaleRatio;
                }
                float translate = 200F;
                var mx = new Matrix();
                var flags = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix;

                mx.Scale(wScaleRatio, hScaleRatio);

                mx.Translate(translate,translate);
                g.Clip = new Region(Bounds);
                g.Transform = mx;
               

                //RectangleF rendererRect = new RectangleF(0, 0, RealSize.Width, RealSize.Height);
                Point picBoxCoordinates = PointToScreen(canvasBox1.Location);
                Console.WriteLine("canvas xy is " + picBoxCoordinates.X + " " + picBoxCoordinates.Y);
                Console.WriteLine("canvas width height is " + canvasBox1.Width + " " + canvasBox1.Height);
                RectangleF rendererRect = new RectangleF(picBoxCoordinates.X, picBoxCoordinates.Y, RealSize.Width, RealSize.Height);
                RectangleF r = myMethodBank.GetScaledRect(g, rendererRect, wScaleRatio,hScaleRatio);
                Rectangle rSimp = Rectangle.Round(r);
                Console.WriteLine("Canvas H ratio " + hScaleRatio + " canvas W  ratio" + wScaleRatio + " and the dimensions were CANVAS HW " + canvasBox1.Height + " " + canvasBox1.Width + " Text HW real " + RealSize.Height + " " + RealSize.Width + " rezied HW " + r.Height + " " + r.Width);

                TextRenderer.DrawText(g, myHandler.heldASCIIImage, myMethodBank.GetScaledFont(g,myFont, ScaleRatio), rSimp, Color.White, Color.Black, flags);
            }
        }
    }
}
