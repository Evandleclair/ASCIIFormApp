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
        private readonly DataHandler myHandler = new();
        private readonly ImageTakerMethods myMethodBank = new();
       
        public ImageTakerForm()
        {
            InitializeComponent();
            myHandler.CanvasPanelBounds = canvasBox1.Bounds;
            canvasBox1.Paint += new System.Windows.Forms.PaintEventHandler(CanvasBox1_Paint);
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            myMethodBank.LoadImage(myHandler);
            if (myHandler.failureFlag==false)
            {
                filenameBox.Text = myHandler.heldImagePath;
            }
        }
        private void convertImageButton_Click(object sender, EventArgs e)
        {
            myMethodBank.ConvertImage(myHandler);
            canvasBox1.Refresh();
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
            if (myHandler.heldASCIIString != null)
            {
                Graphics g = e.Graphics;
                Font myFont = new(FontFamily.GenericMonospace, 12, FontStyle.Regular, GraphicsUnit.Pixel);
                g.SetClip(Bounds);
                Size canvasSize = canvasBox1.Size;
                SizeF realSize = TextRenderer.MeasureText(myHandler.heldASCIIString, myFont, canvasSize);

                float hScaleRatio = canvasSize.Height / realSize.Height;
                float wScaleRatio = canvasSize.Width / realSize.Width;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
                float scaleRatio = (hScaleRatio < wScaleRatio)
                   ? scaleRatio = hScaleRatio
                   : scaleRatio = wScaleRatio;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
  
                var flags = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix;
                TextRenderer.DrawText(g, myHandler.heldASCIIString, myMethodBank.GetScaledFont(myFont, scaleRatio), canvasBox1.Bounds, Color.White, Color.Black, flags);
                //TextRenderer.DrawText(g, myHandler.heldASCIIImage, myMethodBank.GetScaledFont(g,myFont, scaleRatio), rSimp, Color.White, Color.Black, flags);
            }
        }

       
    }
}
