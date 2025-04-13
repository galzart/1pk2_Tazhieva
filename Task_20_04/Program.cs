

namespace Task_20_04
{
    // Перечисление типов транспортных средств
    public enum VehicleType
    {
        Car,
        Bike,
        Bus,
        Truck,
        Motorcycle
    }

    // Класс для управления списком транспортных средств
    public class VehicleManager
    {
        private List<VehicleType> vehicles;

        public VehicleManager()
        {
            vehicles = new List<VehicleType>();
        }

        // Метод для добавления транспортного средства
        public void AddVehicle(VehicleType type)
        {
            vehicles.Add(type);
            Console.WriteLine($"Добавлено транспортное средство типа: {type}");
        }

        // Метод для подсчёта транспортных средств определённого типа
        public int CountVehiclesByType(VehicleType type)
        {
            return vehicles.Count(v => v == type);
        }

        // Метод для поиска транспортных средств определённого типа и вывода информации
        public void SearchAndPrintVehiclesByType(VehicleType type)
        {
            Console.WriteLine($"\nСписок транспортных средств типа {type}:");
            var foundVehicles = vehicles.Where(v => v == type);
            if (foundVehicles.Any())
            {
                foreach (var vehicle in foundVehicles)
                {
                    Console.WriteLine($"- {vehicle}");
                }
            }
            else
            {
                Console.WriteLine("Транспортные средства данного типа не найдены.");
            }
        }


        // Метод для вывода общего списка транспортных средств
        public void PrintAllVehicles()
        {
            Console.WriteLine("\nОбщий список транспортных средств:");
            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"- {vehicle}");
                }
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
        }
    }

    // Пример использования
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            // Добавление транспортных средств
            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Truck);
            manager.AddVehicle(VehicleType.Bike);
            manager.AddVehicle(VehicleType.Car);
            manager.AddVehicle(VehicleType.Bus);
            manager.AddVehicle(VehicleType.Truck);

            // Вывод общего списка
            manager.PrintAllVehicles();

            // Подсчет грузовиков
            int truckCount = manager.CountVehiclesByType(VehicleType.Truck);
            Console.WriteLine($"\nКоличество грузовиков: {truckCount}");

            // Поиск и вывод информации о машинах
            manager.SearchAndPrintVehiclesByType(VehicleType.Car);

            // Поиск и вывод информации о мотоциклах
            manager.SearchAndPrintVehiclesByType(VehicleType.Motorcycle);

            Console.ReadKey();
        }
    }
}