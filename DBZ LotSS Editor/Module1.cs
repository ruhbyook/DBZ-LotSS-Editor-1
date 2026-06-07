using System;
using System.IO;
using System.IO.Compression;

namespace DBZ_LotSS_Editor
{

    static class Module1
    {

        public static void Main()
        {
            string directoryPath = @"C:\Users\Mesiah\Documents\DBZ LotSS\Tools\Compressor\Sprites\Test";

            var directorySelected = new DirectoryInfo(directoryPath);

            foreach (FileInfo fileToCompress in directorySelected.GetFiles())
                Compress(fileToCompress);

            foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.gz"))
                Decompress(fileToDecompress);
        }

        private static void Compress(FileInfo fileToCompress)
        {
            using (var originalFileStream = fileToCompress.OpenRead())
            {
                if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
                {
                    using (var compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                    {
                        using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                        {
                            originalFileStream.CopyTo(compressionStream);
                            Console.WriteLine("Compressed {0} from {1} to {2} bytes.", fileToCompress.Name, fileToCompress.Length.ToString(), compressedFileStream.Length.ToString());
                        }
                    }
                }
            }
        }

        private static void Decompress(FileInfo fileToDecompress)
        {
            using (var originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                using (var decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
                    }
                }
            }
        }
    }
}