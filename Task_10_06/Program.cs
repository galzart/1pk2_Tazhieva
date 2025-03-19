namespace Task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения, 
         * принимает целое число n, выводит наконсольсгенерированный 
         * массив размерности n*n.*/
        static void Main()
        {
            ArrayGeneration(3); // Пример вызова метода
        }

        static void ArrayGeneration(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("n должно быть положительным числом.");
                return;
            }

            int[,] array = new int[n, n];
            Random rnd = new Random();   // Заполнение массива случайными числами

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(1, 100); // Числа от 1 до 99
                }
            }

            Console.WriteLine($"Массив {n}x{n}:"); // Вывод массива на консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Элементы разделены табуляцией
                }
                Console.WriteLine(); // Переход на новую строку
            }
        }
    }
}
