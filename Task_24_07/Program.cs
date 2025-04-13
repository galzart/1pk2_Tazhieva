

namespace Task_24_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Пример использования метода
            string filePath = "example.txt";  // Укажите путь к вашему файлу
            string wordToFind = "пример";     // Укажите слово для поиска

            // Проверяем, существует ли файл
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден!");
                return; // Завершаем выполнение, так как файл не найден
            }

            List<string> matchingLines = FindLinesContainingWord(filePath, wordToFind);

            Console.WriteLine($"Строки, содержащие слово \"{wordToFind}\" (регистронезависимо):");
            foreach (string line in matchingLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }

        // 7. Метод для поиска слова в файле и возврата строк, содержащих это слово (регистронезависимо)
        static List<string> FindLinesContainingWord(string filePath, string wordToFind)
        {
            List<string> matchingLines = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Читаем файл построчно
                    {
                        // Выполняем регистронезависимый поиск слова в строке
                        if (line.ToLower().Contains(wordToFind.ToLower()))
                        {
                            matchingLines.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при чтении файла: {ex.Message}");
                // В случае ошибки возвращаем пустой список
                return new List<string>(); // Возвращаем пустой список, чтобы избежать NullReferenceException
            }

            return matchingLines;
        }
    }
}