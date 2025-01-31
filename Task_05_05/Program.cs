namespace Task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный
         * массив целых числе [n*m]. Заполнение случайными числами в диапазоне 
         * от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
       по следующему правилу:
       • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
       • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом */

        static void Main(string[] args)
        {
            // Запрашиваем у пользователя размеры массива

            Console.WriteLine("Введите количество строк (n):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов (m):");
            int m = int.Parse(Console.ReadLine());

            // Создаем прямоугольный массив размером n * m
            int[,] array = new int[n, m];

            // Генератор случайных чисел
            Random random = new Random();

            // Заполняем массив случайными числами от -99 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = random.Next(-99, 100); // Случайное число от -99 до 99
                }
            }

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Преобразуем массив по заданным правилам
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0) // Если элемент меньше нуля
                    {
                        array[i, j] = Math.Abs(array[i, j]); // Отбрасываем знак
                    }
                    else if (array[i, j] == 0) // Если элемент равен нулю
                    {
                        array[i, j] = 1; // Перезаписываем единицей
                    }
                }
            }

            Console.WriteLine("Преобразованный массив:");
            PrintArrayWithColor(array);
        }

        // Метод для вывода массива без цветовой индикации
        static void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Вывод элемента с табуляцией
                }
                Console.WriteLine();
            }
        }

        static void PrintArrayWithColor(int[,] array)
        {
            int n = array.GetLength(0); // Количество строк
            int m = array.GetLength(1); // Количество столбцов

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] < 0) // Этот блок не выполнится, так как мы уже преобразовали массив
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет
                        Console.Write(array[i, j] + "\t");
                    }
                    else if (array[i, j] == 1) // Если элемент был нулем и заменен на 1
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Красный цвет
                        Console.Write(array[i, j] + "\t");
                    }
                    else
                    {
                        Console.ResetColor(); // Сброс цвета
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.ResetColor(); // Сброс цвета после вывода элемента
                }
                Console.WriteLine();
            }
        }
    }
}


