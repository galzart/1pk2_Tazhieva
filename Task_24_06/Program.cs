

namespace Task_24_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "myFile.txt"; // Укажите путь к вашему файлу
                                            // Проверяем, существует ли файл, прежде чем пытаться его прочитать
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не существует. Создайте его и добавьте несколько строк.");
                // Чтобы программа работала, здесь нужно создать файл. Но это выходит за рамки этой задачи.
                Console.ReadKey();
                return;
            }

            int lineCount = CountLinesInFile(filePath);
            Console.WriteLine($"Количество строк в файле {filePath}: {lineCount}");

            Console.ReadKey();
        }

        // Метод для подсчета строк в файле, используя StreamReader
        static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            try
            {
                // StreamReader reader = new StreamReader(filePath);
                // Использование "using" гарантирует, что файл будет закрыт после использования
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Читаем файл построчно, пока не достигнем конца файла
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Увеличиваем счетчик строк для каждой прочитанной строки
                        lineCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываем возможные ошибки при чтении файла
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return -1; // Возвращаем -1 в случае ошибки, чтобы показать, что возникла проблема
            }

            // Возвращаем общее количество строк в файле
            return lineCount;
        }
    }
}