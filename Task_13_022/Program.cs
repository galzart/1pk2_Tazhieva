namespace Task_13_022
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            // Вот наши данные про питомца
            public string Name;    // Как зовут
            public string Type;    // Кот или собака
            public string Age;     // Сколько лет
            public string Weight;  // Сколько весит
            public string Health;  // Здоров или нет
             
            // Конструктор пустой чтобы можно было потом заполнить
            public Pet()
            {
            }

            // Метод чтобы показать информацию
            public string GetInfo()
            {
                string info = "";
                info += "Имя: " + Name + "\n";
                info += "Вид: " + Type + "\n";
                info += "Возраст: " + (Age ?? "неизвестен") + "\n";
                info += "Вес: " + (Weight ?? "неизвестен") + "\n";
                info += "Здоровье: " + Health;
                return info;
            }

            // Поменять вес
            public void ChangeWeight(string newWeight)
            {
                Weight = newWeight;
                Console.WriteLine("Новый вес: " + newWeight);
            }

            // Поменять здоровье
            public void ChangeHealth(string newHealth)
            {
                Health = newHealth;
                Console.WriteLine("Новое состояние: " + newHealth);
            }
         }

        class Program
        {
            static void Main(string[] args)
            {
                // Первый питомец
                Pet cat = new Pet();
                cat.Name = "Сима";
                cat.Type = "Кошка";
                cat.Age = "3";
                cat.Weight = "5.4";
                cat.Health = "Здорова";

                Console.WriteLine(cat.GetInfo());
                Console.WriteLine();

                cat.ChangeWeight("7.2");
                cat.ChangeHealth("Требуется вакцинация");
                Console.WriteLine(cat.GetInfo());
                Console.WriteLine();

                // Второй питомец с пропущенными данными
                Pet dog = new Pet();
                dog.Name = "Багира";
                dog.Type = "Собака";
                dog.Health = "Здорова";

                Console.WriteLine(dog.GetInfo());
            }
        }
    }