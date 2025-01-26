namespace Task_04_07
{
    internal class Program
    {
        /*В массиве на 30 элементов содержатся данные по росту учеников в классе.
         * Рост мальчиков условно задан отрицательными значениями.
         * Вычислить и вывести количество мальчиков и девочек в классе
         и средний рост для мальчиков и девочек. При выводе избавиться от отрицательных значений.*/

        static void Main(string[] args)
        {

            int[] classf = new int[30];
            int m = 0, d = 0, srd = 0, srm = 0;
            Random rnd = new Random();
            for (int i = 0; i < classf.Length; i++)

            {
                if (i % rnd.Next(1, 5) == 0)

                {
                    classf[i] = rnd.Next(140, 200);
                    ++d; srd += classf[i];
                }

                else

                {
                    classf[i] = -rnd.Next(150, 200);
                    ++m; srm += classf[i];
                }

            }
            Console.WriteLine($"Количество мальчиков - {m}\nКоличество девочек - {d}\n" +
                $"Средний рост мальчиков - {(-srm) / m}\n" +
                $"Средний рост девочек - {srd / d}");
        }
    }
}
