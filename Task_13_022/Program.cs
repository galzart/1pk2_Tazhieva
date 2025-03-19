namespace Task_13_022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Первая кошка
            Cat cat1 = new Cat();
            cat1.Name = "Сима";
            cat1.Age = 3;
            cat1.Weight = 5.5;
            cat1.HealthStatus = "Здорова";

            Console.WriteLine(cat1.GetCatInfo());
            Console.WriteLine();

            // Изменяем параметры
            cat1.ChangeWeight(7.3);
            cat1.ChangeHealth("Не здорова.Требуется вакцинация");
            Console.WriteLine("\n" + cat1.GetCatInfo());
            Console.WriteLine();

            // Вторая кошка с неполными данными
            Cat cat2 = new Cat();
            cat2.Name = "Муза";
            cat2.HealthStatus = "Здорова";

            Console.WriteLine(cat2.GetCatInfo());
        }
    }
}

       