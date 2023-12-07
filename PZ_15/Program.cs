namespace PZ_15
{
    internal class Program
    {
       
        
   
       static long CalcSize(string dirpath) // метод для вычисления размера файла
        {
            long size = 0;
            DirectoryInfo directoryInfo = new DirectoryInfo(dirpath);
            FileInfo[] files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo file in files) //просматриваем все файлы и добавляем их размеры к общему размеру
            {
                size += file.Length;
            }
            return size;
        }
        static FileInfo LargFile(string dirpath) // метод для поиска самого большого файла в указанном каталоге и его подкаталогах
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirpath);
            FileInfo[] files = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            FileInfo largfile = null;
            long largsize = 0;
            foreach (FileInfo file in files)
            {
                if (file.Length > largsize)
                {
                    largfile = file;
                    largsize = file.Length;
                }
            }
            return largfile;
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("введите путь к каталогу");
                string dirpath = Console.ReadLine();
                if (!Directory.Exists(dirpath))//проверяем существует ли 
                {
                    Console.WriteLine("такого каталога не существует");
                    return;

                }
                long size = CalcSize(dirpath);
                Console.WriteLine($"размер в мегабайтах {size / 1024 / 1024} мбайт");
                if (size > 10 * 1024 * 1024)
                {
                    FileInfo largfile = LargFile(dirpath);
                    if (largfile != null)
                    {
                        Console.WriteLine($"{largfile} будет удален");
                        largfile.Delete();
                    }
                    else { Console.WriteLine("в каталоге нет файлов"); }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка: {ex.Message}");
            }
        }
    }
}   
        
    
