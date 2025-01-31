namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
(это матрица, где все недиагональные элементы меньше нуля)
Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
вывести сообщение что данная матрица не является Z-матрицей*/

        static void Main(string[] args)
        {
            // Запрашиваем у пользователя размерность матрицы
            Console.WriteLine("Введите размерность матрицы (n):");
            int n = int.Parse(Console.ReadLine());

            // Создаем квадратную матрицу размером n * n
            int[,] square = new int[n, n];

            // Генератор случайных чисел
            Random random = new Random();

            // Заполняем матрицу случайными числами от -10 до 10
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square[i, j] = random.Next(-10, 11); // Случайное число от -10 до 10
                }
            }

            // Выводим исходную матрицу
            Console.WriteLine("Исходная матрица:");
            PrintMatrix(square);

            // Проверяем, является ли матрица Z-матрицей
            bool b = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   
                    if (i != j && square[i, j] >= 0)
                    {
                        b = false; 
                        break;
                    }
                }
                if (!b) break; 
            }

            // Выводим результат
            if (b)
            {
                Console.WriteLine("Матрица является Z-матрице.");
                PrintMatrixWithDiagonalHighlight(square);
            }
            else
            {
                Console.WriteLine("Матрица не является Z-матрицей.");
            }
        }

       
        static void PrintMatrix(int[,] square)
        {
            int n = square.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(square [i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintMatrixWithDiagonalHighlight(int[,] square)
        {
            int n = square.GetLength(0); 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) // Если элемент на главной диагонали
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
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
    }
}
