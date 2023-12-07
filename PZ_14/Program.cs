using System.Text;

namespace PZ_14
{
    internal class Program
    {
        static int CountNumbers(string fileName)
        {
            int count = 0;
            bool inNumber = false;

            //  файл для чтения
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        int charCode = reader.Read();

                        if (charCode >= '0' && charCode <= '9')
                        {
                            // если символ - цифра, начинаем новое число
                            if (!inNumber)
                            {
                                inNumber = true;
                                count++;
                            }
                        }
                        else
                        {
                            // если символ не цифра, завершаем текущее число
                            inNumber = false;
                        }
                    }
                }
            }

            return count;
        }

        static void CreateFile(string fileName)
        {
            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Console.WriteLine("Введите данные. Введите пустую строку для завершения ввода.");

               
                while (true)
                {
                    string input = Console.ReadLine();

                    // если введена пустая строка, завершаем цикл
                    if (string.IsNullOrWhiteSpace(input))
                        break;

                    // Записываем строку в файл
                    writer.WriteLine(input);
                }
            }
        }

        static void Main()
        {
            string fileName = "inFile.txt";

            
            CreateFile(fileName);

            // Анализируем текст на наличие чисел (не цифр)
            int numberOfNumbers = CountNumbers(fileName);

            
            Console.WriteLine($"\nКоличество чисел в тексте: {numberOfNumbers}");
        }
    }
}

