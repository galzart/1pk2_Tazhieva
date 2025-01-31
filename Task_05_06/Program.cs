namespace Task_05_06
{
    internal class Program
    {
      /* Осуществить генерация двумерного[10 * 5] массива по следующему правилу:
• 1 столбец содержит нули
• 2 столбце содержит числа кратные 2
• 3 столбец содержит числа кратные 3
• 4 столбец содержит числа кратные 4
• 5 столбец содержит числа кратные 5
Осуществить переворот массива(поменять строки и столбцы местами) вывести обновленный массив*/

        static void Main(string[] args)
        {
            // Создаем двумерный массив размером 10 * 5
            int[,] array = new int[10, 5];

            // Генератор случайных чисел
            Random random = new Random();

            // Заполняем массив по заданным правилам
            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0) // 1 столбец содержит нули
                    {
                        array[i, j] = 0;
                    }
                    else if (j == 1) // 2 столбец содержит числа, кратные 2
                    {
                        array[i, j] = random.Next(0, 100) * 2; // Случайное число, кратное 2
                    }
                    else if (j == 2) // 3 столбец содержит числа, кратные 3
                    {
                        array[i, j] = random.Next(0, 100) * 3; // Случайное число, кратное 3
                    }
                    else if (j == 3) // 4 столбец содержит числа, кратные 4
                    {
                        array[i, j] = random.Next(0, 100) * 4; // Случайное число, кратное 4
                    }
                    else if (j == 4) // 5 столбец содержит числа, кратные 5
                    {
                        array[i, j] = random.Next(0, 100) * 5; // Случайное число, кратное 5
                    }
                }
            }

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Создаем новый массив для перевернутой версии (5 * 10)
            int[,] transposedArray = new int[5, 10];

            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    transposedArray[j, i] = array[i, j]; // Заполняем перевернутый массив
                }
            }

            // Выводим перевернутый массив
            Console.WriteLine("Перевернутый массив:");
            PrintArray(transposedArray);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0); // Количество строк
            int cols = array.GetLength(1); // Количество столбцов

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}




       