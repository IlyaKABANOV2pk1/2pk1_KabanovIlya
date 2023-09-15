namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            double c, x, y, t;
            a = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (c > 7.1)
            {
                x = Math.Cos(c + Math.Sqrt(a + Math.Pow(c, 2)) / 1.5);
                
            }
            else
            {
                x = Math.Sin(2 * c + a) + 14 * a;
                
            }
            if (x <= 0)
            {
                y = Math.Abs(c) * a + 2.4 * Math.Cos(3 + a * x) + x;
                
            }
            else
            {
                y = a * Math.Pow(x, 2) - 2 * c * x;
                
            }
            t =(int) c + 11.2 * Math.Pow(a, 3) / 2.7 * Math.Pow(x, 2) + 1.7 * a * a + 3;

            Console.Write("результат =" + Math.Round(t, 2));
        }
    }
}