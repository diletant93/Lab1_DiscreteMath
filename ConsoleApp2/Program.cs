using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2};
            int[] arr2 = { 1, 3, 5 };
            int[][] DecProd = GetDecProduct(arr1, arr2);
            ShowArray(DecProd);
        }
        static int[][] GetDecProduct(int[] array, int[] array2)
        {
            int[][] result = new int[array.Length * array2.Length][];
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++, k++)
                {
                    result[k] = new int[2] { array[i], array2[j] };
                }
            }
            return result;
        }
        static bool IsNull(int[][] arr)
        {
            if(arr == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void ShowArray(int[][]array)
        {
            if(IsNull(array))
            {
                Console.WriteLine("Geg , Error!\n");
            }
            else
            {
                Console.Write("{ ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{" + array[i][0] + "," + array[i][1] + "}");
                }
                Console.Write(" }");
            }
        }
        
    }
}
