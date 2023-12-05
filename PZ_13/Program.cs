namespace PZ_13
{
    internal class Program
    {
        //метод для первой задачи
        static int Arifm(int n, int firstel, int step)
        {
            if (n == 1)
                return firstel;
            else
                return Arifm(n - 1, firstel, step) + step;
        }
        // метод для второй задачи
        static double Geom(int n, double firstel, double step)
        {
            if (n == 1)
                return firstel;
            else
                return Geom(n - 1, firstel, step) * step;
        }
        // метод для третьей задачи 
        static void Poryadok(int a, int b)
        {
            if (a < b)
            {
                Console.Write(a + " ");
                Poryadok(a + 1, b);
            }
            else if (b < a)
            {
                Console.Write(a + " ");
                Poryadok(a - 1, b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
        // задание на 5, номер 1 
        static int Summ(int x)
        {
            if (x == 1)
                return x;
            return x + Summ(x - 1);

        }

        static void Main(string[] args)
        {
            // первая задача 
            Console.WriteLine("Первая задача");
            int n1 = 2; int firstel1 = 55; int step1 = -5;
            int res = Arifm(n1, firstel1, step1);
            Console.WriteLine(res);
            // вторая
            Console.WriteLine("Вторая задача");
            int n2 = 2; double firstel2 = 8; double step2 = 0.3;
            double res2 = Geom(n2, firstel2, step2);
            Console.WriteLine(res2);
            //третья
            Console.WriteLine("Третья задача");
            int a = 7; int b = 12; int a1 = 12; int b1 = 7;
            Poryadok(a, b);
            Poryadok(a1, b1);
            //четвертая 
            Console.WriteLine("Четвертая задача");
            int x = 5;
            int sum = Summ(x);
            Console.WriteLine(sum);
        }
    }
}