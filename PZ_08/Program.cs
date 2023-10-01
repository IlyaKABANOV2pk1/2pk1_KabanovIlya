namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[][] array = new int[15][];
            int[] maximum = new int[15];


            for (int i = 0; i < 15; i++)
            {
                int rndLength = rnd.Next(2, 16); // случайная длина второго измерения
                array[i] = new int[rndLength];

                for (int j = 0; j < rndLength; j++)
                {
                    array[i][j] = rnd.Next(1, 101); //   числа от 1 до 100
                }
                int max = int.MinValue;
                foreach (int element in array[i])
                {
                    if (element > max)
                    {
                        max = element;
                    }
                }
                maximum[i] = max;
            }


            for (int i = 0; i < 15; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            int[] last = new int[15];
            for (int i = 0; i < 15; i++)
            {
                if (array[i].Length > 0)
                {
                    last[i] = array[i][array[i].Length - 1];
                }

            }

            //вывод одномерного массива
            Console.WriteLine("последние элементы строчек:");
            foreach (int element in last)

            {
                Console.Write(element + " ");

            }
            Console.WriteLine();

            Console.WriteLine("максимальные элементы в каждой строке:");
            foreach (int element in maximum)
            {
                Console.Write(element + " ");

            }
            Console.WriteLine();
            double[] averages = new double[15];
            for (int i = 0; i < array.Length; i++)
            {
                averages[i] = array[i].Average();
            }
            Console.WriteLine("среднее значение в каждой строке:");
            foreach (double elem in averages)

            {
                Console.WriteLine(Math.Round(elem,2) + "   ");

            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int total = 0;

                for (int j = 0; j < array[i].Length; j++)
                {
                    total += array[i][j].ToString().Length;
                }

                Console.WriteLine($"строка {i + 1}: Общее количество символов = {total}");
            }
        }

    }
    }
