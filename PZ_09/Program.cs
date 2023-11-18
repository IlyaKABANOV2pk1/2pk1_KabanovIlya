namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку слов, разделенных пробелами:"); // сообщение о вводе строки
            string stroka = Console.ReadLine(); // ввод 

            string[] words = stroka.Split(' ');  // строка разбивается на отдельные слова

            int shortest = int.MaxValue; // переменную буду сравнивать с длинной слов, изначально даю ей максимально возможное значение

            foreach (string i in words) // цикл проверяющий и сравнивающий длину     
            {
                int dlinasl = i.Length;  //переменной передаю длину слова

                if (dlinasl < shortest)
                {
                    shortest = dlinasl;
                }
            }

            Console.WriteLine($"Самое короткое слово имеет длину: {shortest}");

            string newstroka = "";

            foreach (string word in words)
            {
                string newword = word.Substring(0, shortest); //извлекаем количество символов самого короткого из других слов
                newstroka += newword + " ";
            }

            Console.WriteLine($"новая строка: {newstroka.Trim()}");
        }
    }
}