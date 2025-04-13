

namespace Task_20_06
{
    // Перечисление цветов светофора
    public enum TrafficLightColor
    {
        Red,
        Yellow,
        Green
    }

    class Program
    {
        // Переменная для хранения текущего цвета
        static TrafficLightColor currentColor = TrafficLightColor.Red;
        static object lockObject = new object(); // Объект для синхронизации потоков

        // Метод для вывода текущего цвета в консоль
        static void DisplayColor()
        {
            lock (lockObject) // Блокируем доступ к консоли, чтобы избежать проблем многопоточности
            {
                Console.Clear(); // Очищаем консоль
                Console.WriteLine($"Текущий цвет: {currentColor}");
            }
        }

        // Метод для автоматического переключения цветов в отдельном потоке
        static void AutomaticMode()
        {
            while (true)
            {
                // Переключаем цвет
                switch (currentColor)
                {
                    case TrafficLightColor.Red:
                        currentColor = TrafficLightColor.Green;
                        break;
            }
            }

            // Метод для ручного переключения цветов
            static void ManualMode()
            {
                Console.WriteLine("Нажмите R для красного, Y для жёлтого, G для зелёного.");

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // Читаем нажатие клавиши, не отображая её в консоли

                    lock (lockObject) // Блокируем доступ к currentColor, чтобы избежать проблем с многопоточностью
                    {
                        switch (key.KeyChar)
                        {
                            case 'r':
                            case 'R':
                                currentColor = TrafficLightColor.Red;
                                break;
                            case 'y':
                            case 'Y':
                                currentColor = TrafficLightColor.Yellow;
                                break;
                            case 'g':
                            case 'G':
                                currentColor = TrafficLightColor.Green;
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод. Используйте R, Y или G.");
                                continue; // Переходим к следующей итерации цикла
                        }
                    }
                    DisplayColor();
                }
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Автоматический");
                Console.WriteLine("2 - Ручной");

                string choice = Console.ReadLine();

                // Запускаем автоматический режим в отдельном потоке, чтобы он не блокировал главный поток
                Thread autoThread = new Thread(AutomaticMode);

                switch (choice)
                {
                    case "1":
                        autoThread.Start(); // Запускаем автоматический режим
                        ManualMode();  // Ручной режим продолжает работать, но цвета будут меняться автоматически
                        break;
                    case "2":
                        autoThread.Start(); // Запускаем автоматический режим, чтобы можно было переключать вручную
                        ManualMode();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Запуск в автоматическом режиме.");
                        autoThread.Start(); // Запускаем автоматический режим
                        ManualMode();
                        break;
                }

                Console.ReadKey(); // Чтобы приложение не закрывалось сразу (для ручного режима)
                                   //  Приложение закроется, когда пользователь закроет консольное окно.
            }
        }
    }
}
