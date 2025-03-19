using System.Reflection;

namespace Task_11_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Передача массива по значению: Напишите метод, который принимает массив целых чисел и
изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный
массив вне метода.*/


            Random rnd = new Random();
            int[] numbers = { rnd.Next(1, 100), rnd.Next(1, 100), rnd.Next(1, 100) };

            Console.WriteLine("До вызова метода:");
            PrintArray(numbers);

            ModifyArray(numbers); // Передаем массив по значению

            Console.WriteLine("\nПосле вызова метода:");
            PrintArray(numbers);
        }

        // Метод изменяет элементы массива
        static void ModifyArray(int[] arr)
        {
            Console.WriteLine("\nВнутри метода (до изменения):");
            PrintArray(arr);

            // Изменяем каждый элемент массива
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1; // Увеличиваем элемент на 1
            }

            Console.WriteLine("\nВнутри метода (после изменения):");
            PrintArray(arr);
        }

        // Вспомогательный метод для вывода массива
        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
