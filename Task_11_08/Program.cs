namespace Task_11_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Использование params и out: Напишите метод, который принимает переменное количество чисел и
             * возвращает их сумму и максимальное значение через выходные параметры (out).*/

            Random rnd = new Random();
            int[] numbers = new int[5];

            // Генерируем 5 случайных чисел от 1 до 100
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }

            // Вызываем метод и получаем результаты
            SumAndMax(out int totalSum, out int maxValue, numbers);

            Console.WriteLine($"Случайные числа: {string.Join(", ", numbers)}");
            Console.WriteLine($"Сумма: {totalSum}");
            Console.WriteLine($"Максимум: {maxValue}");
        }

        /// <summary>
        /// Вычисляет сумму и максимальное значение из набора чисел
        /// </summary>
        /// <param name="sum">Сумма чисел (выходной параметр)</param>
        /// <param name="max">Максимальное значение (выходной параметр)</param>
        /// <param name="numbers">Переменное количество чисел</param>
        static void SumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0;
            max = int.MinValue; // Начальное значение для поиска максимума

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max) max = num;
            }

            // Если массив пустой, устанавливаем max в 0
            if (numbers.Length == 0) max = 0;
        }
    }
}
