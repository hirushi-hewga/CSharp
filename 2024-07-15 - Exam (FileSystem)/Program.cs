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
        static void ShowDir(string filePath)
        {
            DirectoryInfo desktop = new DirectoryInfo(filePath);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            IEnumerable<FileInfo> filesInfo = desktop.EnumerateFiles();
            int i = 0;
            foreach (DirectoryInfo info in dirsInfo)
            {
                Console.WriteLine("{1} - {0}", info.Name.Length > 50 ? info.Name.Substring(0, 48) + ".." : info.Name, ++i);
            }
            foreach (FileInfo info in filesInfo)
            {
                Console.WriteLine("{1} - {0}", info.Name.Length > 50 ? info.Name.Substring(0, 48) + ".." : info.Name, ++i);
            }
        }
        static void Main(string[] args)
        {
            //string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            //ShowDir(filePath);
            string Path = $@"C:\";
            string fileToRead;
            DirectoryInfo desktop;
            IEnumerable<DirectoryInfo> dirsInfo;
            IEnumerable<FileInfo> filesInfo;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------- {0} --------", Path);
                ShowDir(Path);
                Console.Write("\nChoice dir or file : ");
                int choice = int.Parse(Console.ReadLine());
                desktop = new DirectoryInfo(Path);
                dirsInfo = desktop.EnumerateDirectories();
                filesInfo = desktop.EnumerateFiles();
                if (choice > 0 && choice <= dirsInfo.Count())
                    Path = dirsInfo.ToArray()[choice - 1].FullName;
                else if (choice > dirsInfo.Count() && choice <= (dirsInfo.Count() + filesInfo.Count()))
                {
                    fileToRead = filesInfo.ToArray()[choice - dirsInfo.Count() - 1].FullName;
                    Console.WriteLine(File.ReadAllText(fileToRead));
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("Invalid choice");
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