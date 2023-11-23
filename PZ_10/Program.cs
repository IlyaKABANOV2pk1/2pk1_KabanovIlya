namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "cтрока для переворота"; //не знаю как с любой вводимой строкой
            string[] words = str.Split(' ');//делим строку на слова
            string newStr = "";
            foreach (var word in words)  //проверяем каждое слово
            {
                for (int i = word.Length; i != 0; i--) //каждое слово с обратной стороны
                {
                    newStr += word[i - 1];  // запись перевернутого слова в новую строку
                }
                newStr += " ";
               
            }
            Console.WriteLine(newStr);
        }
    }
}