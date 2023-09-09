namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а:");
            double a = double.Parse(Console.ReadLine());  //объявление переменной а
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine()); //объявление переменной b
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            
            double firstpart = Math.Abs(Math.Pow(a,2)- Math.Pow(b,2))/Math.Sin(b); //делаю части отдельно, в первой использую  модуль и степени
            
            double secondpart = Math.Pow(10,4) * Math.Pow(Math.Abs(Math.Sin(a + b) - b * c), 1/5); //вторая часть, корень в n степени, поэтому сделал через степень 1/5
            
            double thirdpart = (4 - Math.Tan(a)) / Math.Pow(Math.E, 3); //третья часть, использую math tan, а также math e в степени  
            
            double result; // объявляю переменную в которой соберу все части примера 
            
            result = firstpart - secondpart - thirdpart;
            
            Console.WriteLine(result); //вывожу результат


        }
    }
}