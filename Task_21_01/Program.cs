

namespace Task_21_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем исходный список чисел
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2. Используем LINQ для фильтрации и преобразования списка
            //    (а) Фильтруем список, оставляя только четные числа (number % 2 == 0)
            //    (б) Умножаем каждое четное число на 10 (number * 10)
            List<int> evenNumbersMultiplied = numbers
                .Where(number => number % 2 == 0) // Фильтрация: выбираем только четные числа
                .Select(number => number * 10)  // Преобразование: умножаем каждое число на 10
                .ToList();                     // Преобразуем результат обратно в список

            // 3. Выводим новый список на экран
            Console.WriteLine("Исходный список: " + string.Join(", ", numbers)); // string.Join склеивает элементы списка в строку
            Console.WriteLine("Список четных чисел, умноженных на 10: " + string.Join(", ", evenNumbersMultiplied));

            Console.ReadKey(); // Чтобы консоль не закрылась сразу
        }
    }
}