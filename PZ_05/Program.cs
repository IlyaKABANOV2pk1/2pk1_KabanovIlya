namespace PZ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число n:");
            int n = int.Parse(Console.ReadLine());

            int m = n % 2 == 0 ? n + 1 : n;

            int sum = 0;
            int num = m;

            while (num <= m * 2)
            {
                sum += num;
                num += 2;
            }

            Console.WriteLine($"Сумма всех нечетных чисел диапазона от {m} до {m*2} равна {sum}");
        }
    }
}