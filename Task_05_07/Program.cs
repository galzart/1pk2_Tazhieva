namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
числами в диапазоне от 10 до 99 включительно.
Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве*/

        static void Main(string[] args)
        {
            // Запрашиваем у пользователя размерность матрицы
            Console.WriteLine("Введите размерность матрицы (n):");
            int n = int.Parse(Console.ReadLine());

            // Создаем квадратную матрицу размером n * n
            int[,] square = new int[n, n];

            Random random = new Random();

            // Заполняем матрицу случайными числами от 10 до 99
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square[i, j] = random.Next(10, 100); // Случайное число от 10 до 99
                }
            }

            // Выводим исходную матрицу
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(square);

            // Находим минимальный элемент в матрице
            int minElement = FindMinElement(square);
            Console.WriteLine($"Минимальный элемент в матрице: {minElement}");

            // Умножаем матрицу на минимальный элемент
            int[,] multipliedMatrix = MultiplyMatrixByScalar(square, minElement);

            // Выводим результат умножения с выделением пяти максимальных значений
            Console.WriteLine("Матрица после умножения на минимальный элемент:");
            PrintMatrixWithHighlight(multipliedMatrix);
        }

        // Метод для поиска минимального элемента в матрице
        static int FindMinElement(int[,] square)
        {
            int min = square[0, 0]; // Предполагаем, что первый элемент минимальный
            int n = square.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (square[i, j] < min) // Если текущий элемент меньше минимального
                    {
                        min = square[i, j]; // Обновляем минимальный элемент
                    }
                }
            }

            return min;
        }

        // Метод для умножения матрицы на скаляр (минимальный элемент)
        static int[,] MultiplyMatrixByScalar(int[,] square, int scalar)
        {
            int n = square.GetLength(0);
            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = square[i, j] * scalar;
                }
            }

            return result;
        }

        static void PrintMatrix(int[,] square)
        {
            int n = square.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(square[i, j] + "\t"); 
                }
                Console.WriteLine(); 
            }
        }

        // Метод для вывода матрицы с выделением пяти максимальных значений
        static void PrintMatrixWithHighlight(int[,] square)
        {
            int n = square.GetLength(0);

            // Находим пять максимальных значений в матрице
            int[] topFiveMax = FindTopFiveMaxValues(square);

            // Выводим матрицу с выделением
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Array.Exists(topFiveMax, value => value == square[i, j])) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write(square[i, j] + "\t"); 
                    Console.ResetColor(); 
                }
                Console.WriteLine(); 
            }
        }

        // Метод для поиска пяти максимальных значений в матрице
        static int[] FindTopFiveMaxValues(int[,] square)
        {
            int n = square.GetLength(0);
            int[] maxValues = new int[5]; // Массив для хранения пяти максимальных значений

            // Инициализируем массив минимальными значениями
            for (int i = 0; i < 5; i++)
            {
                maxValues[i] = int.MinValue;
            }

            // Проходимся по всем элементам матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Если текущий элемент больше минимального значения в массиве maxValues
                    if (square[i, j] > maxValues[0])
                    {
                        // Обновляем массив maxValues
                        maxValues[0] = square[i, j];
                        Array.Sort(maxValues); // Сортируем массив
                    }
                }
            }

            return maxValues;
        }
    }
}
