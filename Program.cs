using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "@c:\somefile.jpg";
            // File.Copy(source file name, destination file name, if file exists override with boolean true); 
            File.Copy("c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true);
            File.Delete(path)
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}