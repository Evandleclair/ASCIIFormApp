struct imageArray
{

    internal int[,] imgIntArray;
    internal Color[][] imgColorArray;
    internal string fileLoc;
    internal int imgH, imgW;
     public imageArray(int[,] ImgIntArray, Color[][] ImgColorArray, string FileLoc, int ImgH, int ImhW)
    {
        imgIntArray = ImgIntArray;
        imgColorArray = ImgColorArray;
        imgH = ImgH;
        imgW = ImhW;   
        fileLoc = FileLoc;

    }
}