using System;

namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[49];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            // Удаляем элементы меньше 15
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 16)
                {
                    array[i] = 0;
                }
                Console.Write(array[i] + " ");
            }
        }
        }
    }
