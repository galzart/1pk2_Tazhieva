namespace Task_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Ввод размера массива с проверкой
                Console.WriteLine("Введите размер массива:");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Некорректный размер! Введите целое положительное число:");
                }

                // Создание и заполнение массива случайными числами
                int[] numbers = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(0, 10); // Числа от 0 до 9 включительно
                }

                // Ввод искомого числа
                Console.Clear();
                Console.WriteLine("Введите число для поиска:");
                int m;
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Ошибка! Введите целое число:");
                }

                // Поиск и вывод результата
                Console.Clear();
                int result = found(m, numbers);
                Console.WriteLine(result != -1
                    ? $"Первое вхождение числа {m} на позиции: {result}"
                    : $"Число {m} не найдено");
            }

            /// <summary>
            /// Поиск первого вхождения числа в массиве
            /// </summary>
            /// <param name="m">Искомое число</param>
            /// <param name="array">Массив для поиска</param>
            /// <returns>Индекс первого вхождения или -1</returns>
            static int found (int m, int[] array)
            {
                // Проход по всем элементам массива
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == m) // Сравнение текущего элемента с искомым
                {
                    return i; // Возврат индекса при совпадении
                    }
                }
                return -1; // Элемент не найден
            }
        }
    }