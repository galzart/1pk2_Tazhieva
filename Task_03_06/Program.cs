namespace Task_03_06
{
    internal class Program
    {
        /*Написать программу, которая выводит
         * таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, 
          с шагом h = 0,5.*/

        static void Main(string[] args)
        {
            double start = -4.0;
            double end = 4.0;
            double step = 0.5;

            Console.WriteLine(" x    |    y");
            Console.WriteLine("---------------");

            for (double x = start; x <= end; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x,5:F2} | {y,5:F2}");
            }
        }
    }
}