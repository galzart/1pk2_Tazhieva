namespace Task_11_01
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*Передача по значению: Напишите метод, который принимает два целых числа и меняет их
местами. Проверьте, изменились ли значения переменных вне метода*/

            Random rnd = new Random();

            // Генерируем два случайных числа
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);

            Console.WriteLine($"До вызова метода:  a = {a}, b = {b}");

            // Вызываем метод для обмена значений
            Swap(a, b);

            Console.WriteLine($"После вызова метода: a = {a}, b = {b}");
        }

        // Метод пытается поменять значения местами
        static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;

            // Эти изменения останутся только внутри метода
            Console.WriteLine($"Внутри метода:     x = {x}, y = {y}");
        }
    }
}
