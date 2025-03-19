namespace Task_11_07
{
    internal class Program
    {
        /*Передача массива по ссылке(ref): Напишите метод, который принимает массив целых чисел 
         * по ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
         * оригинальный массив вне метода.*/

        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Создаем массив с двумя случайными числами
            int[] numbers = { rnd.Next(1, 100), rnd.Next(1, 100) };

            Console.WriteLine($"До изменения:   numbers[0] = {numbers[0]}, numbers[1] = {numbers[1]}");

            // Вызываем метод с передачей массива по ссылке
            ModifyArray(ref numbers);

            Console.WriteLine($"После изменения: numbers[0] = {numbers[0]}, numbers[1] = {numbers[1]}");
        }

        // Метод изменяет элементы массива через ссылку
        static void ModifyArray(ref int[] arr)
        {
            // Изменяем оригинальный массив
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1; // Увеличиваем каждый элемент на 1
            }

            // Демонстрация работы с ссылкой (можно создать новый массив)
            arr = new int[] { 100, 200 }; // Это изменение также повлияет на оригинал
        }
    }
}
