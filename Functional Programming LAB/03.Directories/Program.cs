using System;
using System.IO;

namespace _03.Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("D:\\Games\\APEX\\Apex");

            double size = 0;

            foreach (var file in files)
            {
                var info = new FileInfo(file);

                size += info.Length;
            }

            Console.WriteLine($"Directory size is {size / 1024 / 1024} MB");
        }
    }
}
