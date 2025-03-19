namespace Task_11_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Передача по ссылке (ref): Напишите метод, который принимает два целых числа 
             * по ссылке и меняет их местами. Проверьте, изменились ли значения переменных вне метода.*/
            Random rnd = new Random();

            // Генерация случайных чисел
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);

            Console.WriteLine($"До обмена:   a = {a}, b = {b}");

            // Вызов метода с передачей по ссылке
            Swap(ref a, ref b);

            Console.WriteLine($"После обмена: a = {a}, b = {b}");
        }

        // Метод для обмена значений через ссылки
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"Внутри метода: x = {x}, y = {y}");
        }
    }
}
