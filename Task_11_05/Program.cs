namespace Task_11_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref)
             * и возвращает их сумму и произведение через выходные параметры (out).*/

                // Обязательная инициализация переменных для ref параметров
                int a = 0;
                int b = 0;

                // Ввод первого числа
                Console.Write("Введите первое число: ");
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Ошибка! Введите целое число:");

                // Ввод второго числа
                Console.Write("Введите второе число: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Ошибка! Введите целое число:");

                // Вызов метода с передачей по ссылке (ref) и получение результатов через out
                CalculateResults(ref a, ref b, out int sum, out int product);

                // Вывод результатов
                Console.WriteLine($"\nИсходные числа: {a} и {b}");
                Console.WriteLine($"Сумма чисел: {sum}");
                Console.WriteLine($"Произведение чисел: {product}");
            }

            /// <summary>
            /// Вычисляет сумму и произведение двух чисел
            /// </summary>
            /// <param name="a">Первое число (ref)</param>
            /// <param name="b">Второе число (ref)</param>
            /// <param name="sum">Сумма (out)</param>
            /// <param name="product">Произведение (out)</param>
            static void CalculateResults(ref int a, ref int b, out int sum, out int product)
            {
                // Простые вычисления
                sum = a + b;
                product = a * b;

                // Ref параметры можно менять (но в этой задаче не требуется)
                // a = 10;
                // b = 20;
            }
        }
    }
