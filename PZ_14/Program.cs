using System.Text;

namespace PZ_14
{
    internal class Program
    {
        static int CountNumbers(string fileName)
        {
            int count = 0;
            bool inNumber = false;

            // Открываем файл для чтения
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        int charCode = reader.Read();

                        if (charCode >= '0' && charCode <= '9')
                        {
                            // Если символ - цифра и мы не находимся внутри числа, начинаем новое число
                            if (!inNumber)
                            {
                                inNumber = true;
                                count++;
                            }
                        }
                        else
                        {
                            // Если символ не цифра, завершаем текущее число
                            inNumber = false;
                        }
                    }
                }
            }

            return count;
        }

        static void CreateFile(string fileName)
        {
            // Создаем или перезаписываем файл
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Console.WriteLine("Введите данные. Введите пустую строку для завершения ввода.");

                // Цикл ввода данных и записи их в файл
                while (true)
                {
                    string input = Console.ReadLine();

                    // Если введена пустая строка, завершаем цикл
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

            // Создаем файл и записываем данные в него
            CreateFile(fileName);

            // Анализируем текст на наличие чисел (не цифр)
            int numberOfNumbers = CountNumbers(fileName);

            // Выводим количество чисел на консоль
            Console.WriteLine($"\nКоличество чисел в тексте: {numberOfNumbers}");
        }
    }
}




