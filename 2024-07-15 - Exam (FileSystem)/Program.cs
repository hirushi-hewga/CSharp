using System;
using System.Diagnostics;
using System.Text;

namespace _2024_07_15___Exam__FileSystem_
{
    internal class Program
    {
        static void ShowDirs(string filePath, int choice)
        {
            DirectoryInfo desktop = new DirectoryInfo(filePath);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            if (dirsInfo.Count() == 0)
                Console.WriteLine("Directory is empty");
            int i = 0;
            foreach (DirectoryInfo info in dirsInfo)
            {
                if (choice == ++i)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(" {0} ", info.Name.Length > 80 ? info.Name.Substring(0, 78) + ".." : info.Name, i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static void ShowDir(string filePath, int choice)
        {
            DirectoryInfo desktop = new DirectoryInfo(filePath);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            IEnumerable<FileInfo> filesInfo = desktop.EnumerateFiles();
            if (dirsInfo.Count() + filesInfo.Count() == 0)
                Console.WriteLine("Directory is empty");
            int i = 0;
            foreach (DirectoryInfo info in dirsInfo)
            {
                if (choice == ++i)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(" {0} ", info.Name.Length > 80 ? info.Name.Substring(0, 78) + ".." : info.Name, i);
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
                Console.WriteLine(" {0} ", info.Name.Length > 80 ? info.Name.Substring(0, 78) + ".." : info.Name, i);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static void FileChoice(string filePath, int choice)
        {
            int i = 0;
            if (choice == ++i)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(" Delete ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            if (choice == ++i)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(" Move ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            if (choice == ++i)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(" Open ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void MakeDir(string path)
        {
            Console.Clear();
            Console.Write("Enter dir name : ");
            string dirName = Console.ReadLine();
            if (!Directory.Exists(path + @"\" + dirName))
            {
                Directory.CreateDirectory(path + @"\" + dirName);
            }
        }
        static void RemoveDir(string path, int choice)
        {
            DirectoryInfo desktop = new DirectoryInfo(path);
            IEnumerable<DirectoryInfo> dirsInfo = desktop.EnumerateDirectories();
            if (dirsInfo.Count() >= choice)
            {
                string dirPath = dirsInfo.ToArray()[choice - 1].FullName;
                Directory.Delete(dirPath);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string firstPath;
            string secondPath;
            string path = $@"C:\";
            int choice = 1;
            int fileChoice;
            string currentFile;
            DirectoryInfo desktop;
            bool isMove;
            bool isCreate;
            IEnumerable<DirectoryInfo> dirsInfo;
            IEnumerable<FileInfo> filesInfo;
            while (true)
            {
                firstPath = null;
                secondPath = null;
                isMove = false;
                isCreate = false;
                string currentPath = path;
                desktop = new DirectoryInfo(path);
                dirsInfo = desktop.EnumerateDirectories();
                filesInfo = desktop.EnumerateFiles();
                choice = 1;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-------- {0} --------", path);
                    ShowDir(path, choice);
                    Console.WriteLine("\n| Back - F1 | Choice - F2 | Make dir - F3 | Remove dir - F4 | Prev - UpArrow | Next - DownArrow |");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.DownArrow && choice < dirsInfo.Count() + filesInfo.Count())
                        choice++;
                    if (key.Key == ConsoleKey.UpArrow && choice > 1)
                        choice--;
                    if (key.Key == ConsoleKey.F1 && path != $@"C:\")
                    {
                        path = Path.GetDirectoryName(path);
                        break;
                    }
                    if (key.Key == ConsoleKey.F2)
                        break;
                    if (key.Key == ConsoleKey.F3)
                    {
                        MakeDir(path);
                        isCreate = true;
                        break;
                    }
                    if (key.Key == ConsoleKey.F4)
                        RemoveDir(path, choice);
                }
                if (path == currentPath && !isCreate)
                {
                    if (choice > 0 && choice <= dirsInfo.Count())
                        path = dirsInfo.ToArray()[choice - 1].FullName;
                    else if (choice > dirsInfo.Count() && choice <= (dirsInfo.Count() + filesInfo.Count()))
                    {
                        currentFile = filesInfo.ToArray()[choice - dirsInfo.Count() - 1].FullName;
                        fileChoice = 1;
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("-------- {0} --------", filesInfo.ToArray()[choice - dirsInfo.Count() - 1].FullName);
                            FileChoice(currentFile, fileChoice);
                            Console.WriteLine("\n| Choice - F2 | Prev - UpArrow | Next - DownArrow |");
                            ConsoleKeyInfo key = Console.ReadKey();
                            if (key.Key == ConsoleKey.DownArrow && fileChoice < 3)
                                fileChoice++;
                            if (key.Key == ConsoleKey.UpArrow && fileChoice > 1)
                                fileChoice--;
                            if (key.Key == ConsoleKey.F2)
                                break;
                        }
                        if (fileChoice == 1)
                        {
                            File.Delete(currentFile);
                        }
                        if (fileChoice == 2)
                        {
                            firstPath = currentFile;
                            string temp_path = $@"C:\";
                            int temp_choice = 1;
                            DirectoryInfo temp_desktop;
                            IEnumerable<DirectoryInfo> temp_dirsInfo;
                            while (true)
                            {
                                string temp_currentPath = temp_path;
                                temp_desktop = new DirectoryInfo(temp_path);
                                temp_dirsInfo = temp_desktop.EnumerateDirectories();
                                temp_choice = 1;
                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine("-------- {0} --------", temp_path);
                                    ShowDirs(temp_path, temp_choice);
                                    Console.WriteLine("\n| Back - F1 | Choice - F2 | Move - F5 | Prev - UpArrow | Next - DownArrow |");
                                    ConsoleKeyInfo key = Console.ReadKey();
                                    if (key.Key == ConsoleKey.DownArrow && temp_choice < temp_dirsInfo.Count())
                                        temp_choice++;
                                    if (key.Key == ConsoleKey.UpArrow && temp_choice > 1)
                                        temp_choice--;
                                    if (key.Key == ConsoleKey.F1 && temp_path != $@"C:\")
                                    {
                                        temp_path = Path.GetDirectoryName(temp_path);
                                        break;
                                    }
                                    if (key.Key == ConsoleKey.F2)
                                        break;
                                    if (key.Key == ConsoleKey.F5)
                                    {
                                        secondPath = temp_path + $@"\" + filesInfo.ToArray()[choice - dirsInfo.Count() - 1].Name;
                                        File.Move(firstPath, secondPath);
                                        path = $@"C:\";
                                        isMove = true;
                                        break;
                                    }
                                }
                                if (temp_path == temp_currentPath && temp_choice > 0 && temp_choice <= temp_dirsInfo.Count())
                                    temp_path = temp_dirsInfo.ToArray()[temp_choice - 1].FullName;
                                if (isMove)
                                    break;
                            }
                        }
                        if (fileChoice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(File.ReadAllText(currentFile));
                            Console.ReadKey();
                            //Process.Start(new ProcessStartInfo(currentFile) { UseShellExecute = true });
                        }
                    }
                }
            }
        }
    }
}