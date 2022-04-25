using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIFormApp
{
    internal class DataHandler
    {
        internal imageObj heldImageObj;
        internal string heldImagePath;
        internal string heldASCIIString;
        internal bool failureFlag = false; //this should prevent the loading of a bad image. is set to true if the program encounters an exception while loading an image//
        internal Rectangle CanvasPanelBounds;
    }
}
