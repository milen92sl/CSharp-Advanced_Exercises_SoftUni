using System;
using System.IO;
using System.IO.Compression;

namespace _06.Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "copyMe.png";
            //ZipFile.CreateFromDirectory("./","../../../myZip.zip");

            using ZipArchive zipArchive = ZipFile.Open("../../../archive2.zip", ZipArchiveMode.Create);

            zipArchive.CreateEntryFromFile(filePath, "newName.png");
            string archivePath = "../../";
            string destinationDirectoryName = "../../../archive2.zip";
            ZipFile.ExtractToDirectory(archivePath, destinationDirectoryName);
        }
    }
}
