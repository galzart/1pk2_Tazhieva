namespace Task_05_08
{
    internal class Program
    {
        /* Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл
         * .Создать новый массив, который будет произведением двух предыдущих(перемножить элементы первых двух массивов,
         * стоящие на одинаковых позициях и записать их в результирующий массив)
 Вывести результирующий массив*/

        static void Main(string[] args)
        {
            // Создаем два массива размером 10 * 10
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];

            // Генератор случайных чисел
            Random random = new Random();

            // Заполняем оба массива случайными числами от 1 до 9
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array1[i, j] = random.Next(1, 10); // Случайное число от 1 до 9
                    array2[i, j] = random.Next(1, 10); // Случайное число от 1 до 9
                }
            }

            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            int[,] resultArray = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    resultArray[i, j] = array1[i, j] * array2[i, j];
                }
            }

            // Выводим результирующий массив
            Console.WriteLine("Результирующий массив:");
            PrintArray(resultArray);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

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

