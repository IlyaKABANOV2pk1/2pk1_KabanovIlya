namespace PZ_12
{
    internal class Program
    {
       static double[,] Masiv(int a , int b)
        {
            Random rnd = new Random();
            double[,] array = new double[a,b]; 
            for(int i = 0; i < a; i++) 
            {
               for (int j = 0; j < b; j++)
                {
                    array[i,j] = (rnd.NextDouble() * 20 - 10);
                    Console.Write($"{Math.Round(array[i,j],2)} \t");
                }
                Console.WriteLine();
            }
            return array;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double[,] arr = Masiv(a, b);
        }
    }
}