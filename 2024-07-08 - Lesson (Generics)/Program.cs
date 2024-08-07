using System.Security.Cryptography.X509Certificates;

namespace _2024_07_08___Lesson__Generics_
{
    /*
     * Generics
     *----------------------
    Classes
    Structures
    Collections
    Methods 
    Interface
    Delegate
    */

    public delegate void VoidDelegate(int[] arr);
    // template<typename T>
    public delegate void VoidDelegate<T>(T[] arr);

    public delegate bool CompareDelegate<T1, T2>(T1 elem1, T2 elem2);

    public delegate Type OperationDelegate<Type>(Type a, Type b);

    public delegate float SummaDelegate2(float a, float b);
    public delegate int SummaDelegate(int a, int b);



internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
