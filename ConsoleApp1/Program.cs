﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[11] { 3, 4, 5, 6, 7, 14, 18, 19, 20, 24, 25 };
            array[1] = new int[11] { 1, 2,3, 4, 5, 6, 7, 14, 16, 21, 22 };
            array[2] = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 16, 17, 23, 24};
            int[] universal = new int[25];

            for (int i = 0; i < universal.Length; i++)
            {
                universal[i] = i + 1;
            }

            int[] arr = Difference(array[1], array[2]);
            if(isNull(arr))
            {
                Console.WriteLine("Array = 0\n");
            }
            else
            {
            ShowArray(arr);
            }


            //int[] arr = Decussation(array[2], array[1]);
            //ShowArray(arr);
            //DelByValue(ref array[0], 25);
            //DelByValue(ref array[0], 24);
            //DelByValue(ref array[0], 20);
            //DelByValue(ref array[0], 19);
            //DelByValue(ref array[0], 18);
            //DelByValue(ref array[0], 14);
            //DelByValue(ref array[0], 7);
            //DelByValue(ref array[0], 6);
            //DelByValue(ref array[0], 5);
            //int[] result = Decussation(array[0], array[1]);
            //ShowArray(result);
            //Провірка роботи функції доповнення до множини

            //ShowArray(array[0]);
            //int[] additionArray = Addition(array[0], universal);
            //ShowArray(additionArray);
            //int[] DadditionArray = Addition(additionArray, universal);
            //ShowArray(DadditionArray);

            //Accociation(array[0], array[1]);
        }
        static int[] Difference(int[] array1, int[] array2)
        {
            int[] result = array1[..];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if(array1[i] == array2[j])
                    {
                        DelByValue(ref result, array2[j]);
                    }
                }
            }
           
            return result;
        }
        static int[] Decussation(int[]array1, int[] array2)
        {
            int[] result = null;
            int amount = 0;
            for(int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if(array1[i] == array2[j])
                    {
                        amount++;
                    }
                }
            }
            bool check = false;
            result = new int[amount];
            for (int i = 0 , k = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        result[k] = array1[i];
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    k++;
                    check = false;
                }
            }
            return result;
        }   
        static int[] Accociation(int[]array1, int[] array2)
        {
            int[] result = new int[(array1.Length+array2.Length)] ;
            array1.CopyTo(result, 0);
            ShowArray(result);
            array2.CopyTo(result, array1.Length);
            ShowArray(result);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    else if(result[i] == result[j])
                    {
                        DelByValue(ref result, result[i]);
                        break;
                    }
                }
            }
            Array.Sort(result);
            return result;
        }
        static int[] Addition(int[] array , int[] universal)
        {
            int[] result = universal[..];//створюємо масив , в якого копіюємо універсум 
            for (int i = 0; i < array.Length; i++)//, який потім після операцій над ним стане доповненням множини
            {
                DelByValue(ref result, array[i]);
            }
            return result;//повертаємо уже готове доповнення до множини
        }
        static void DelByValue(ref int[]array , int value)
        {
            if (array == null || Array.FindIndex(array, 0, array.Length, x => x == value) == -1)//дивимось валідність даних що приходять у ф-цію
            {
                Console.WriteLine("Smth went wrong with DelByValue function, please check input values!\n");
            }
            else
            {
                int[] arr = new int[array.Length - 1];//створюємо новий масив , котрий буде резульатом даної ф-ції
                bool check = false;//створюємо чек для провірки чи знайшли ми вже потрібний елемент для видалення чи ні
                for (int i = 0; i < arr.Length; i++)
                {
                    if (array[i] == value && check == false)//якщо елем = значенню і ще до цього ми його не видаляли то виконується тіло if
                    {
                        arr[i] = array[i + 1];
            
                        check = true;
                        continue;
                    }
                    else if (check == true)//якщо чек = тру , тобто ми уже видалили елем , то присвоєння в масив буде елементами + 1 індексів
                    {
                        arr[i] = array[i + 1];
                        continue;
                    }
                    arr[i] = array[i];//поки не виконались два if ми просто копіюємо масив
                }
                array = arr;
            }
        }
        static bool isNull(int[] array)
        {
            return array == null ? true : false;
        }
        static void ShowArray(int[] array)//ф-ція просто виводить масив
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Elem {(i+1)} = {array[i]}\t");
                if(i % 4 == 0 && i!= 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
