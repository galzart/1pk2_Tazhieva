
namespace Task_21_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это простой пример текста. В этом примере текст повторяется несколько раз.  Текст очень простой.";

            Dictionary<string, int> wordCounts = CountWordOccurrences(text);

            // Выводим результат на экран
            foreach (var pair in wordCounts)
            {
                Console.WriteLine($"Слово: \"{pair.Key}\", Количество: {pair.Value}");
            }

            Console.ReadKey();
        }

        // Метод для подсчета вхождений слов в тексте
        static Dictionary<string, int> CountWordOccurrences(string text)
        {
            // 1. Создаем словарь для хранения результатов (слово -> количество)
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // 2. Подготавливаем текст (удаляем знаки препинания, приводим к нижнему регистру)
            string cleanedText = text.ToLower(); // Приводим к нижнему регистру, чтобы "Текст" и "текст" считались одним словом

            // Удаляем знаки препинания (заменяем их на пробелы). Это упрощает разделение текста на слова.
            cleanedText = cleanedText.Replace(".", "");
            cleanedText = cleanedText.Replace(",", "");
            cleanedText = cleanedText.Replace("!", "");
            cleanedText = cleanedText.Replace("?", "");

            // 3. Разделяем текст на слова (используем пробелы как разделители)
            string[] words = cleanedText.Split(' '); // Split возвращает массив строк, разделенных пробелами

            // 4. Перебираем слова и подсчитываем их вхождения
            foreach (string word in words)
            {
                // Пропускаем пустые слова (после удаления знаков препинания могут образоваться)
                if (string.IsNullOrEmpty(word)) // Проверяем, не является ли слово пустой строкой
                {
                    continue; // Переходим к следующему слову
                }

                // Если слово уже есть в словаре, увеличиваем его счетчик
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++; // Увеличиваем значение по ключу word на 1
                }
                // Если слова еще нет в словаре, добавляем его со счетчиком 1
                else
                {
                    wordCounts.Add(word, 1); // Добавляем новое слово (ключ) со значением 1
                }
            }

            // 5. Возвращаем словарь с подсчитанными вхождениями слов
            return wordCounts;
        }
    }
}