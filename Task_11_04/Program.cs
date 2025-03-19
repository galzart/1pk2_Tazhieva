namespace Task_11_04
{
    internal class Program
    {
            static void Main(string[] args)
            {

            /* Массив параметров (params): Напишите метод, который принимает массив чисел и возвращает
их среднее значение. Используйте ключевое слово params. */

                int n; // Размер массива
                Console.WriteLine("Введите размер массива:");

               
                while (!int.TryParse(Console.ReadLine(), out n))  // Проверка корректности ввода размера массива
            {
                    Console.WriteLine("Ошибка ввода! Введите целое число:");
                }

                int[] numbers = new int[n]; // Создание массива заданного размера

                
                for (int i = 0; i < numbers.Length; i++) // Заполнение массива числами, введенными пользователем
            {
                    Console.WriteLine($"Введите число {i + 1}:"); // Нумерация элементов начинается с 1
                    numbers[i] = int.Parse(Console.ReadLine()); // Ввод без дополнительной проверки (по условию задачи)
                }

                // Вызов метода и вывод результата
                Console.WriteLine("Среднее значение: " + Value(numbers));
            }

            /// <summary>
            /// Вычисляет среднее значение для набора целых чисел
            /// </summary>
            /// <param name="array">Массив чисел (используется params)</param>
            /// <returns>Среднее арифметическое</returns>
            static double Value(params int[] array)
            {
                double summ = 0; // Переменная для накопления суммы

                
                for (int i = 0; i < array.Length; i++) // Суммирование всех элементов массива
            {
                    summ += array[i];
                }

                // Расчет и возврат среднего значения
                return array.Length == 0 ? 0 : summ / array.Length; // Защита от деления на ноль
            }
        }
    }