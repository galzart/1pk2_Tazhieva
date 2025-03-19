namespace Task_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
выходной параметр количество гласных и согласных букв в этой строке. */

            Console.WriteLine("Введите строку:");
            string a = Console.ReadLine(); // Получаем строку от пользователя

            int glasnye, soglasnye; // Объявляем переменные для подсчета

            // Вызываем метод с out-параметрами
            CountOfChar(a, out glasnye, out soglasnye);

            // Выводим результаты
            Console.WriteLine($"Кол-во гласных - {glasnye}\nКол-во согласных - {soglasnye}");
        }

        /// <summary>
        /// Метод подсчета гласных и согласных
        /// </summary>
        static void CountOfChar(string a, out int glasnye, out int soglasnye)
        {
            glasnye = 0;
            soglasnye = 0;

            // Массив всех рассматриваемых гласных (русские и английские)
            char[] chars = {
                'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я',
                'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'Y', 'y'
            };

            // Проход по каждому символу в строке
            for (int i = 0; i < a.Length; i++)
            {
                // Пропускаем пробелы
                if (a[i] == ' ') continue;

                bool flagglsn = false; // Флаг для определения гласной

                // Проверяем, есть ли символ в массиве гласных
                for (int j = 0; j < chars.Length; j++)
                {
                    if (a[i] == chars[j])
                    {
                        flagglsn = true;
                        break; // Выходим из цикла при совпадении
                    }
                }

                // Увеличиваем соответствующий счетчик
                if (flagglsn) glasnye++;
                else soglasnye++;

            }
        }
    }
}
