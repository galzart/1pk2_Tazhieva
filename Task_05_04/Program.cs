namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагональной.*/
        static void Main(string[] args)
        {
            // Переменная для размера матрицы
            int n;

            // Генератор случайных чисел
            Random random = new Random();

            // Запрашиваем у пользователя размер матрицы
            Console.WriteLine("Введите размер матрицы (n):");
            while (!int.TryParse(Console.ReadLine(), out n))

            {
                Console.WriteLine("Ошибка ввода.");
            }

            // Создаем квадратную матрицу размером n x n
            int[,] square = new int[n, n];

            // Заполняем матрицу случайными числами 0 или 1
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square[i, j] = random.Next(0, 2); // Случайное число 0 или 1
                }
            }

            // Выводим исходную матрицу
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(square);

            // Проверяем, является ли матрица диагональной
            bool isDiagonal = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Если элемент не на главной диагонали и не равен нулю
                    if (i != j && square[i, j] != 0)
                    {
                        isDiagonal = false; // Матрица не диагональная
                        break;
                    }
                }
                if (!isDiagonal) break; // Если нашли недиагональный элемент, выходим
            }

            // Выводим результат
            if (isDiagonal)
            {
                Console.WriteLine("Матрица является диагональной. Вывод с цветовым выделением главной диагонали:");
                PrintMatrixWithDiagonalHighlight(square);
            }
            else
            {
                Console.WriteLine("Матрица не является диагональной.");
            }
        }

        // Метод для вывода матрицы
        static void PrintMatrix(int[,] square)
        {
            int n = square.GetLength(0); // Получаем размерность матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(square[i, j] + " "); // Вывод элемента
                }
                Console.WriteLine();
            }
        }

        // Метод для вывода матрицы с выделением главной диагонали
        static void PrintMatrixWithDiagonalHighlight(int[,] matrix)
        {
            int n = matrix.GetLength(0); // Получаем размерность матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) // Если элемент на главной диагонали
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor(); // Сброс цвета
                    }
                    Console.Write(matrix[i, j] + " "); // Вывод элемента
                    Console.ResetColor(); 
                }
                Console.WriteLine();
            }
        }
    }
}

