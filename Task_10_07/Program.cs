namespace Task_10_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Создайте метод с помощью которого можно сгенерировать и вернуть символьный двумерный массив
             * (состоящий из символов русского алфавита) 
             * и выведите на консоль данный массив с помощью другого метода
             * (который принимает данный массив в качестве параметра) */

            Console.WriteLine("Введите размер квадратного массива:"); // Запрос размера массива у пользователя

            int size = int.Parse(Console.ReadLine()); // Проверка ввода
            Console.Clear();


            char[,] alphabetArray = GenerateAlphabetArray(size); // Генерация и вывод массива
            PrintArray(alphabetArray);
        }

        /// <summary>
        /// Создает квадратный массив со случайными русскими буквами
        /// </summary>
        /// <param name="size">Размер стороны квадратного массива</param>
        static char[,] GenerateAlphabetArray(int size)
        {
            char[,] array = new char[size, size];
            Random rand = new Random();

            // Генерация русских букв от 'А' до 'Я' 
            // (33 буквы, но для упрощения возьмем 32)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // Генерируем случайную заглавную букву
                    // 'А' имеет код 1040 в Unicode
                    array[i, j] = (char)('А' + rand.Next(0, 32));
                }
            }
            return array;
        }

        /// <summary>
        /// Выводит двумерный массив в консоль
        /// </summary>
        /// <param name="array">Массив для вывода</param>
        static void PrintArray(char[,] array)
        {
            Console.WriteLine("Сгенерированный массив:");

            // Проход по строкам
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Проход по элементам строки
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                // Переход на новую строку после вывода всех элементов строки
                Console.WriteLine();
            }
        }
    }
}