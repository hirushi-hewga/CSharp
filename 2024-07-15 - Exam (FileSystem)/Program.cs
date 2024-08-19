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
        static void ShowDir(string filePath, int choice)
        {
            DirectoryInfo desktop = new DirectoryInfo(filePath);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            IEnumerable<FileInfo> filesInfo = desktop.EnumerateFiles();
            int i = 0;
            foreach (DirectoryInfo info in dirsInfo)
            {
                if (choice == ++i)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("{1} - {0}", info.Name.Length > 80 ? info.Name.Substring(0, 78) + ".." : info.Name, i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            foreach (FileInfo info in filesInfo)
            {
                if (choice == ++i)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("{1} - {0}", info.Name.Length > 80 ? info.Name.Substring(0, 78) + ".." : info.Name, i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Path = $@"C:\";
            int choice = 1;
            string currentFile;
            DirectoryInfo desktop;
            IEnumerable<DirectoryInfo> dirsInfo;
            IEnumerable<FileInfo> filesInfo;
            while (true)
            {
                //Console.Clear();
                //Console.WriteLine("-------- {0} --------", Path);
                //ShowDir(Path);
                //Console.Write("\nChoice dir or file : ");
                //choice = int.Parse(Console.ReadLine());
                desktop = new DirectoryInfo(Path);
                dirsInfo = desktop.EnumerateDirectories();
                filesInfo = desktop.EnumerateFiles();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-------- {0} --------", Path);
                    ShowDir(Path, choice);
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.DownArrow && choice < dirsInfo.Count() + filesInfo.Count())
                        choice++;
                    if (key.Key == ConsoleKey.UpArrow && choice > 1)
                        choice--;
                    if (key.Key == ConsoleKey.Enter)
                        break;
                }
                if (choice > 0 && choice <= dirsInfo.Count())
                    Path = dirsInfo.ToArray()[choice - 1].FullName;
                else if (choice > dirsInfo.Count() && choice <= (dirsInfo.Count() + filesInfo.Count()))
                {
                    currentFile = filesInfo.ToArray()[choice - dirsInfo.Count() - 1].FullName;
                    Console.Clear();
                    Console.WriteLine(File.ReadAllText(currentFile));
                    Console.ReadKey();
                }
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