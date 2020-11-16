using System;
using System.IO;
using System.Collections.Generic;


namespace FileProparties
{
    class Program
    {
        static void Main(string[] args)
        {
            //to get the file names only 
            string rootPath = @"C:\Users\opilane\Samples";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>(); 
            foreach(string file in files)
            {
                //Console.WriteLine(file);
                //get file objects
                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length;

                //Console.WriteLine($"File name: {fileName}; Location: {fileDirectory}; Size: {fileSize}");

                string line = $"File name: {fileName}; Location: {fileDirectory}; Size: {fileSize} bytes";
                lines.Add(line);

            }

            string fileDataPath = @"C:\Users\opilane\Samples\FileData.txt";
            File.WriteAllLines(fileDataPath, lines);

        }
    }
}
