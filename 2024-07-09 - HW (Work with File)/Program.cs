using System.Collections;
using System.Text;

namespace _2024_07_09___HW__Work_with_File_
{
    internal class Program
    {
        static int GetCountVowels(char[] array)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char item in array)
            {
                if (Array.Exists(vowels, vowel => vowel == item))
                    count++;
            }
            return count;
        }
        static int GetCountConsonants(char[] array)
        {
            int vowelsCount = GetCountVowels(array);
            int letterCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char item in array)
            {
                if (char.IsLetter(item))
                    letterCount++;
            }
            return letterCount - vowelsCount;
        }
        static void Main(string[] args)
        {
            #region 1

            /*
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file1.bin";
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream file = File.Create(filePath);
            BinaryWriter bw = new BinaryWriter(file);

            string str = "Hello, World!!!";
            bw.Write(str);
            bw.Close();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                Console.WriteLine(br.ReadString());
            }
            */

            #endregion

            #region 2,3

            /*
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file2.bin";
            if (File.Exists(filePath))
                File.Delete(filePath);

            int[] arr = new int[5];
            Console.WriteLine("Enter array elements to store in file");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} : ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            using (FileStream write = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(write))
            {
                for (int i = 0; i < arr.Length; i++)
                    bw.Write(arr[i]);
            }

            Console.WriteLine("Array is saved to file2.bin on Desktop");

            int[] arr2 = new int[(int)(new FileInfo(filePath).Length / sizeof(int))];
            using (FileStream read = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(read))
            {
                for (int i = 0; i < arr2.Length; i++)
                    arr2[i] = br.ReadInt32();
            }

            Console.WriteLine("\n------------- file2.bin -------------");
            foreach (int item in arr2)
            {
                Console.Write($"{item} ");
            }
            */

            #endregion

            #region 4

            /*
            string filePathEven = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\even.bin";
            string filePathOdd = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\odd.bin";
            if (File.Exists(filePathEven))
                File.Delete(filePathEven);
            if (File.Exists(filePathOdd))
                File.Delete(filePathOdd);
            FileStream file1 = File.Create(filePathEven);
            FileStream file2 = File.Create(filePathOdd);
            BinaryWriter even = new BinaryWriter(file1);
            BinaryWriter odd = new BinaryWriter(file2);
            Random r = new Random();
            int num;
            for (int i = 0; i < 10000; i++)
            {
                num = r.Next(300);
                if (num % 2 == 0)
                    even.Write(num);
                else
                    odd.Write(num);
            }
            even.Close();
            odd.Close();

            Console.WriteLine("Count of even numbers : " + (int)(new FileInfo(filePathEven).Length / sizeof(int)));
            Console.WriteLine("Count of odd numbers : " + (int)(new FileInfo(filePathOdd).Length / sizeof(int)));
            */

            #endregion

            #region 5

            /*
            Console.OutputEncoding = Encoding.UTF8;
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file3.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fstream = File.Create(filePath);
            using (StreamWriter sw = new StreamWriter(fstream))
            {
                sw.Write("Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    " Ut scelerisque ex ac nisl elementum tincidunt?" +
                    " Nullam porta odio eget tempor maximus." +
                    " Nunc aliquam nulla nulla, vitae hendrerit urna ullamcorper eu?" +
                    " Vestibulum tempor aliquet tellus!");
            }
            string file;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                file = sr.ReadToEnd();
            }
            Console.WriteLine(file);
            string[] words = file.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            Console.Write("\n1 - Пошук заданого слова" +
                "\n2 - Пошук кількості входження слова у файл" +
                "\n3 - Пошук заданого слова у зворотному порядку" +
                "\nВиберіть пошук : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("\n\nВведіть слово : ");
            string wordToFind = Console.ReadLine();
            char[] charArray = wordToFind.ToCharArray();
            Array.Reverse(charArray);
            string ReverseWord = new string(charArray);
            if (Array.Exists(words, v => v == wordToFind) || (choice == 3 && Array.Exists(words, v => v != ReverseWord)))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write($"\n\nСлово \"{wordToFind}\" знайдено за індексом : {Array.IndexOf(words, wordToFind)}"); break;
                    case 2:
                        Console.Write($"\n\nКількість входження слова \"{wordToFind}\" у файл : {words.Count(word => word == wordToFind)}"); break;
                    case 3:
                        Console.Write($"\n\nКількість входження слова \"{ReverseWord}\" у файл : {words.Count(word => word == ReverseWord)}"); break;
                    default:
                        Console.Write("\n\nInvalid choice"); break;
                }
            }
            else
                Console.Write("\n\nCлово не знайдено");
            */

            #endregion

            #region 6

            /*
            Console.OutputEncoding = Encoding.UTF8;
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file4.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fstream = File.Create(filePath);
            using (StreamWriter sw = new StreamWriter(fstream))
            {
                sw.Write("Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                    " Ut scelerisque ex ac nisl elementum tincidunt?" +
                    " Nullam porta odio eget tempor maximus." +
                    " Nunc aliquam nulla nulla, vitae hendrerit urna ullamcorper eu?" +
                    " Vestibulum tempor aliquet tellus!");
            }
            string file;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fs))
            {
                file = sr.ReadToEnd();
            }
            Console.WriteLine(file);
            char[] charArray = file.ToCharArray();
            string[] sentences = file.Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"\nКількість речень : {sentences.Length}");
            int UpperLettersCount = 0;
            foreach (char item in charArray)
                if (char.IsLetter(item) && char.IsUpper(item))
                    UpperLettersCount++;
            Console.WriteLine($"Кількість великих літер : {UpperLettersCount}");
            int LowerLettersCount = 0;
            foreach (char item in charArray)
                if (char.IsLetter(item) && char.IsLower(item))
                    LowerLettersCount++;
            Console.WriteLine($"Кількість маленьких літер : {LowerLettersCount}");
            Console.WriteLine($"Кількість голосних літер : {GetCountVowels(charArray)}");
            Console.WriteLine($"Кількість приголосних літер : {GetCountConsonants(charArray)}");
            int digitCount = 0;
            foreach (char item in charArray)
                if (char.IsDigit(item))
                    digitCount++;
            Console.WriteLine($"Кількість цифр : {digitCount}");
            */

            #endregion
        }
    }
}
