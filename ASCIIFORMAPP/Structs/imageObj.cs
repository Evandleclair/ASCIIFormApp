struct imageObj
{

    internal int[,] imgIntArray; //an array of brightness values//
    internal Color[][] imgColorArray; //an array of RGB color values//
    internal string fileLoc; //the stored file location of the image//
    internal int imgH, imgW; //the stored height and width of the image//
     public imageObj(int[,] ImgIntArray, Color[][] ImgColorArray, string FileLoc, int ImgH, int ImhW)
    {
        imgIntArray = ImgIntArray;
        imgColorArray = ImgColorArray;
        imgH = ImgH;
        imgW = ImhW;   
        fileLoc = FileLoc;

    }
}