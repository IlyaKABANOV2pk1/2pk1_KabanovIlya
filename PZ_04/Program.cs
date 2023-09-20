namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k; 
            for (k = 20; k <= 70; k += 4)
            {
                Console.WriteLine(k);
            }
          
            Console.ReadLine();


            //
            //
            Console.WriteLine("задание 2");
            char sim = 'K';
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                Console.Write((char)(sim+i));
            }
            Console.ReadLine();
            //
            //

            Console.WriteLine("задание 3");
            
            int rows = 4;  // Количество строк
            int symbols = 3;  // Количество символов в каждой строке

            // Вывод символов
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < symbols; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
             Console.ReadLine();

                //
                //
            Console.WriteLine("задание 4");
            for (int i = -300; i <= 200; i += 10)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            //
            //
            Console.WriteLine("задание 5");
            int f = 4;
            int l = 40;

            while (Math.Abs(l - f ) >= 25)
            {
                Console.WriteLine($"переменная 1: {f}, переменная 2: {l}");

                // инкрементировать переменную 1 и декрементировать переменную 2
                f++;
                l--;
            }

            Console.WriteLine($"разница стала равной или меньше 25. Переменная 1: {f}, Переменная 2: {l}");

        }
    }
 }