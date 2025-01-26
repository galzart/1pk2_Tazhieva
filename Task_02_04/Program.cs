namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц рождения:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день рождения:");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;

            if (age >= 18)
            {
                Console.WriteLine("Вы являтесь совершеннолетним.");
            }
            else
            {
                Console.WriteLine("Вы не являтесь совершеннолетним.");
            }
        }
    }
}

          