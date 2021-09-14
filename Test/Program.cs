using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr1 = { 1, 2 };
            int[] arr2 = { 1, 3, 5 };
            Array[] test = DecProduct(arr1, arr2);
            
        }
        static Array[] DecProduct(int[] array, int[] array2)
        {
            Array[] result = new Array[array.Length * array2.Length];// 6 масивів
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[2] { 1,2};
            }
            return result;
        }
    }
}
