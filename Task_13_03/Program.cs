namespace Task_13_03
{
    internal class Program
    {
        /*создайте класс автомобиля
свойства:
номер авто, марка, цвет, текущая скорость
методы:
езда (симитировать равномерное ускорение скорости автомобиля)
торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
конструторы
предусмотрите разные варианты инициализации объектов*/
        #if
        static void Main(string[] args)
        {
  
            // Поля
            public string Number;
            public string Model;
            public string Color;
            public int Speed;

            // Основной конструктор
            public Car(string number, string model, string color, int speed)
            {
                Number = number;
                Model = model;
                Color = color;
                Speed = speed;
            }

            // Конструктор без цвета
            public Car(string number, string model, int speed)
            {
                Number = number;
                Model = model;
                Speed = speed;
            }

            // Пустой конструктор
            public Car() { }

            // Метод для ускорения
            public void Go()
            {
                Console.WriteLine($"Скорость была: {Speed}");

                while (Speed < 80)
                {
                    Speed += 5;
                    Console.WriteLine($"Ускоряемся! Скорость: {Speed}");
                }
            }

            // Метод для торможения
            public void Stop()
            {
                Console.WriteLine($"Скорость была: {Speed}");

                while (Speed > 0)
                {
                    Speed -= 20;
                    if (Speed < 0) Speed = 0;
                    Console.WriteLine($"Тормозим! Скорость: {Speed}");
                }
            }

            // Информация о машине
            public void PrintInfo()
            {
                Console.WriteLine(
                    $"Машина {Number}\n" +
                    $"Модель: {Model ?? "Неизвестна"}\n" +
                    $"Цвет: {Color ?? "Неизвестен"}\n" +
                    $"Скорость: {Speed} Км/ч\n");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car myCar = new Car("A123BC", "BMW", "Черный", 90);
                myCar.PrintInfo();

                myCar.Go();
                myCar.Stop();

                Car unknownCar = new Car("B456DE", "Mercedes", 70);
                unknownCar.PrintInfo();
            }
        }
    }