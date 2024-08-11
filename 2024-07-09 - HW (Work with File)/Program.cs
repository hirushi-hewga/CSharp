namespace _2024_07_09___HW__Work_with_File_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            /*
            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file1.bin";
            FileStream file = File.Create(filePath);
            BinaryWriter bw = new BinaryWriter(file);

            bw.Write("Hello, World!!!");
            bw.Close();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                Console.WriteLine(br.ReadString());
            }
            */

            #endregion

            #region 2


            string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file2.bin";
            FileStream write = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

            int[] arr = new int[5];
            Console.WriteLine("Enter array elements to store in file");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} : ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            using (BinaryWriter bw = new BinaryWriter(write))
            {
            for (int i = 0; i < arr.Length; i++)
                bw.Write($"{arr[i]} ");
            }

            Console.WriteLine("Array is saved to file2.bin on Desktop");


            #endregion
        }
    }
}
