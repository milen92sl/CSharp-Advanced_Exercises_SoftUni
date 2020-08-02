using System;
using System.IO;

namespace _04.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream readFileStream = new FileStream("copyMe.png", FileMode.Open);
            using FileStream writeFileStream = new FileStream("SoftUniLogoTwo.png", FileMode.Create);

            byte[] buffer = new byte[4096];

            while (readFileStream.CanRead)
            {

                int counter = readFileStream.Read(buffer, 0, buffer.Length);
                if (counter == 0)
                {
                    break;
                }
                
                writeFileStream.Write(buffer);
            }
            
        }
    }
}
