namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double b, c, d;
            Sqrtbcd(a1, out b, out c, out d);
            Console.WriteLine($"значение квадратного корня = {Math.Round(b, 3)} ");
            Console.WriteLine($"значение кубического корня = {Math.Round(c, 3)} ");
            Console.WriteLine($"значение корня четвертой степени = {Math.Round(d, 3)} ");
        }
        static void Sqrtbcd(double a, out double b, out double c, out double d)
        {
            b = Math.Sqrt(a);
            c = Math.Cbrt(a);
            d = Math.Pow(a, 0.25);
        }
    }
}