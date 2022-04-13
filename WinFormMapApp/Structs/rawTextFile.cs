using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Takes the path to an image, and optionally the contents, and stores them as strings//
/// <para></para>
/// </summary>
struct rawTextFile
{
    internal string rawFilePath;
    internal string rawFileContent;

    internal rawTextFile(string path, string cont)
    {
        rawFilePath = path;
        rawFileContent = cont;
    }
}