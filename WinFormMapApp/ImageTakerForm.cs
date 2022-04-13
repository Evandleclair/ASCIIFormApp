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

namespace WinFormMapApp
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
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
           myHandler.heldImageArray=myMethodBank.LoadAndConvertImage();
           
        }

        private void openWebcamButton_Click(object sender, EventArgs e)
        {

        }

        private void ImageTakerForm_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}
