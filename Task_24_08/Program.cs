

namespace Task_24_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Поиск и замена текста в файле
            string filePath = "myFile.txt"; // Укажите путь к файлу

            // Создаем файл, если он не существует
            if (!File.Exists(filePath))
            {
                File.CreateText(filePath).Close(); // Создаем пустой файл и закрываем его
                Console.WriteLine($"Файл '{filePath}' создан.");
            }

            Console.WriteLine("Введите текст, который нужно найти:");
            string textToFind = Console.ReadLine();

            Console.WriteLine("Введите текст, на который нужно заменить:");
            string replacementText = Console.ReadLine();

            ReplaceTextInFile(filePath, textToFind, replacementText);
            Console.WriteLine($"Текст в файле '{filePath}' заменен.");
        }

        // 8. Метод для поиска и замены текста в файле
        static void ReplaceTextInFile(string filePath, string textToFind, string replacementText)
        {
            try
            {
                // Читаем все содержимое файла
                string fileContent = File.ReadAllText(filePath);

                // Заменяем текст
                string newContent = fileContent.Replace(textToFind, replacementText);

                // Записываем измененный текст обратно в файл
                File.WriteAllText(filePath, newContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}