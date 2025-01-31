namespace Task_05_03
{
    internal class Program
    {
        /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
       да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
       элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
       Пример: 
       f h h   f c h
       w g k   m g z
       a f j   a o d
       =>
       f h h   f c h
       w g k   m g z
       a f j   a o d*/

        static void Main(string[] args)
        {
                // Создаем две матрицы размером 3x3
                char[,] alphabet1 = new char[3, 3];
                char[,] alphabet2 = new char[3, 3];

                // Генератор случайных чисел
                Random random = new Random();

                // Заполняем матрицы случайными буквами английского алфавита
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                    alphabet1[i, j] = (char)('a' + random.Next(0, 26)); // Случайная буква от 'a' до 'z'
                    alphabet2[i, j] = (char)('a' + random.Next(0, 26)); // Случайная буква от 'a' до 'z'
                    }
                }

                // Выводим обе матрицы на экран
             
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(alphabet1[i, j] + " "); // Вывод элемента первой матрицы
                    }
                    Console.Write("   "); // Разделитель между матрицами
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(alphabet2[i, j] + " "); // Вывод элемента второй матрицы
                    }
                    Console.WriteLine(); // Переход на новую строку
                }

                // Проверяем, равны ли матрицы
                bool rav = true; // Пусть матрицы равны
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (alphabet1[i, j] != alphabet2[i, j]) // Если элементы не равны
                        {
                            rav = false; // Если матрицы не равны
                            break; // Выходим из цикла
                        }
                    }
                    if (!rav) break; // Если нашли несовпадение, выходим из внешнего цикла
                }

                // Выводим результат
                if (rav)
                {
                    Console.WriteLine("Матрицы равны.");
                }
                else
                {
                    Console.WriteLine("Матрицы не равны. Вывод с цветовой индикацией:");

                    // Выводим матрицы с цветовой индикацией совпадающих элементов
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (alphabet1[i, j] == alphabet2[i, j]) // Если элементы совпадают
                            {
                                Console.BackgroundColor = ConsoleColor.Red; // Красный фон для совпадающих элементов
                            }
                            Console.Write(alphabet1[i, j] + " "); // Вывод элемента первой матрицы
                            Console.ResetColor(); // Сброс цвета
                        }
                        Console.Write("   "); // Разделитель между матрицами
                        for (int j = 0; j < 3; j++)
                        {
                            if (alphabet1[i, j] == alphabet2[i, j]) // Если элементы совпадают
                            {
                                Console.BackgroundColor = ConsoleColor.Red; // Красный фон для совпадающих элементов
                            }
                            Console.Write(alphabet2[i, j] + " "); // Вывод элемента второй матрицы
                            Console.ResetColor(); // Сброс цвета
                        }
                        Console.WriteLine(); // Переход на новую строку
                    }
                }
            }
        }
    }