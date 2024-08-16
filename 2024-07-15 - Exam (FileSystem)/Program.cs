using System;
using System.Text;

namespace _2024_07_15___Exam__FileSystem_
{
    internal class Program
    {
        //static void WriteFile(FileInfo f)
        //{
        //    using (FileStream fs = f.Open(FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        Console.WriteLine("\nEnter the data to write to the file:");
        //        string writeText = Console.ReadLine();
        //        byte[] writeBytes = Encoding.Default.GetBytes(writeText);
        //        fs.Write(writeBytes, 0, writeBytes.Length);
        //        Console.WriteLine("\nData recorded!\n");
        //    }
        //}
        //static string ReadFile(FileInfo f)
        //{
        //    using (FileStream fs = f.OpenRead())
        //    {
        //        byte[] readBytes = new byte[(int)fs.Length];
        //        fs.Read(readBytes, 0, readBytes.Length);
        //        return Encoding.Default.GetString(readBytes);
        //    }
        //}
        //static void FileOpenTxt(string filePath)
        //{

        //}
        //static void FileOpenBin(string filePath)
        //{

        //}
        static void Main(string[] args)
        {
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            DirectoryInfo desktop = new DirectoryInfo(filePath);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            Console.WriteLine("------------------------ Dirs ------------------------");
            foreach (DirectoryInfo info in dirsInfo)
            {
                Console.WriteLine("{0} - {1}", info.Name.Length > 25 ? info.Name.Substring(0, 23) + ".." : info.Name, info.Name.Length);
            }
            IEnumerable<FileInfo> filesInfo = desktop.EnumerateFiles();
            Console.WriteLine("------------------------ Files ------------------------");
            foreach (FileInfo info in filesInfo)
            {
                Console.WriteLine("{0} - {1}", info.Name.Length > 25 ? info.Name.Substring(0, 23) + ".." : info.Name, info.Name.Length);
            }





            //DirectoryInfo dir = new DirectoryInfo(@"C:\Test");
            //if (!dir.Exists) // если каталог не существует
            //{
            //    dir.Create(); // создаем каталог
            //}

            //Console.WriteLine($"Last access time to the directory:{dir.LastAccessTime}");

            //// создаем подкаталог
            //DirectoryInfo dir1 = dir.CreateSubdirectory("Subdir1");

            //Console.WriteLine($"Full path to the directory:\n{dir1.FullName}");

            //FileInfo fInfo = new FileInfo(dir1 + @"\Test.bin");
            //WriteFile(fInfo);

            //Console.WriteLine(ReadFile(fInfo));

            //Console.WriteLine($"\n\tOnly files with the extension '.bin':");
            //FileInfo[] files = dir1.GetFiles("*.bin");
            //foreach (FileInfo f in files)
            //{
            //    Console.WriteLine(f.Name);
            //}
            //Console.WriteLine();
        }
    }
}