namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            double ag;

            if (age % 10 == 1)
                ag = 1;


            else if (1 < age && age < 5)
                ag = 2;
            else if (age > 4 && age < 21)
                ag = 3;
            else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
                ag = 4;
            else
                ag = 5;
            switch (ag)
            {
                case 1:
                    Console.Write("возраст -" + age + "год");
                    break;
                case 2:
                    Console.Write("возраст -" + age + "года");
                    break;
                case 3:
                    Console.Write("возраст " + age + "лет");
                    break;
                case 4:
                    goto case 2;
                case 5:
                    goto case 3;
            }


            
        }
    }
}