namespace Task_14_03
{
    internal class Program
    {
        /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.
         * Сделайте так, чтобы метод работал только для неотрицательных чисел.*/
        static void Main(string[] args)
        {
            long n;
            Console.WriteLine("Введите число");

            while (!long.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }

            if (n < 0)   // Простая проверка без лишних условий
            {
                Console.WriteLine("Факториал числа определен только для положительных чисел");
            }
            else
            {

                Console.WriteLine("Факториал числа " + n + " = " + Factorial(n)); // Вывод без форматирования строк
            }
        }

        // Метод без проверок внутри, новичок мог забыть обработать 0 или 1
        static long Factorial(long a)
        {
            long factorial = 1;

            // Цикл с лишней переменной
            int i = 1;
            while (i <= a) // Новичок мог использовать while вместо for
            {
                factorial = factorial * i;
                i++; // Инкремент в теле цикла
            }

            return factorial;
        }
    }
}

