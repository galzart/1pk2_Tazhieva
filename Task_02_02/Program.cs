namespace Task_02_02
{
    internal class Program
    {
        /* Найти значение значение выражения
         * при a = 8; b = 14; c = PI/4
         * 
         */
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double part1 = b + Math.Pow(a - 1, 1.0 / 3.0);
            double part2 = Math.Pow(part1, 1.0 / 4.0);
            double part3 = Math.Pow(Math.Sin(c), 2) + Math.Tan(c);
            double part4 = Math.Abs(a - b) * part3;
            double result = part2 / part4;

            Console.WriteLine(Math.Round(result, 2));
            if (result == 0) ;

        }
    }
}