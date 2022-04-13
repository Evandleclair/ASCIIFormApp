struct imageArray
{

    internal byte[] imgByteArray;
    internal string fileLoc;
     public imageArray(byte[] ImgByteArray, string FileLoc)
    {
        imgByteArray = ImgByteArray;
        fileLoc = FileLoc;
    }
}