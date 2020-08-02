using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _05.Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedExtension = ".";
            string path = "./";
            Dictionary<string, Dictionary<string, double>> data = new Dictionary<string, Dictionary<string, double>>();

          string[] fileNames =  Directory.GetFiles(path,$"*{searchedExtension}*");

          foreach (var filePath in fileNames)
          {
           FileInfo fileInfo = new FileInfo(filePath);
           string extension = fileInfo.Extension;
           string fileName = fileInfo.Name;
           double length = fileInfo.Length / 1024.0;

           if (!data.ContainsKey(extension))
           {
               data.Add(extension, new Dictionary<string, double>());
           }
           data[extension].Add(fileName,length);
          }

          StringBuilder sb = new StringBuilder();

          foreach ((string extension,Dictionary<string, double > filesData) in data
              .OrderByDescending(x=>x.Value.Count)
              .ThenBy(x=>x.Key))
          {
              sb.Append(extension);
              foreach ((string fileName,double length) in filesData.OrderByDescending(x=>x.Value))
              {
                  Console.WriteLine($"--{fileName} - {length:F3}kb");
              }
          }

          string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
          string resPath = Path.Combine(desktopPath,"./report.txt");
            File.WriteAllText(resPath, sb.ToString());
        }
    }
}
