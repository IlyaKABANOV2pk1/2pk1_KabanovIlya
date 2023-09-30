namespace PZ_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; 
            int[,] array = new int[n, n]; 

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Math.Abs(i - j) + 1;
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}