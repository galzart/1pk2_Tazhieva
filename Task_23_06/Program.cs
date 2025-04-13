

namespace Task_23_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Вывод информации о дисках
            Console.WriteLine("Информация о дисках:");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                try
                {
                    Console.WriteLine($"  Диск: {drive.Name}");
                    Console.WriteLine($"    Тип: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"    Объем: {drive.TotalSize / (1024 * 1024 * 1024):N2} GB"); // Преобразуем в GB
                        Console.WriteLine($"    Свободно: {drive.AvailableFreeSpace / (1024 * 1024 * 1024):N2} GB");
                        Console.WriteLine($"    Формат: {drive.DriveFormat}");
                    }
                    else
                    {
                        Console.WriteLine("    Диск не готов.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"    Ошибка при получении информации о диске: {ex.Message}");
                }
            }

            // 2. Вывод содержимого каталога C:\Users (папки)
            Console.WriteLine("\nСодержимое каталога C:\\Users:");
            try
            {
                string[] userDirectories = Directory.GetDirectories(@"C:\Users");
                foreach (string directory in userDirectories)
                {
                    Console.WriteLine($"  - {Path.GetFileName(directory)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Ошибка при получении списка каталогов: {ex.Message}");
            }

            // 3. Работа с папкой "work" на диске D:
            string workDirectoryPath = @"D:\work";
            try
            {
                // a) Создание папки "work" (если она еще не существует)
                if (!Directory.Exists(workDirectoryPath))
                {
                    Directory.CreateDirectory(workDirectoryPath);
                    Console.WriteLine($"\nПапка \"{workDirectoryPath}\" создана.");
                }
                else
                {
                    Console.WriteLine($"\nПапка \"{workDirectoryPath}\" уже существует.");
                }

                // b) Создание вложенного каталога "temp"
                string tempDirectoryPath = Path.Combine(workDirectoryPath, "temp");
                if (!Directory.Exists(tempDirectoryPath))
                {
                    Directory.CreateDirectory(tempDirectoryPath);
                    Console.WriteLine($"  Вложенный каталог \"{tempDirectoryPath}\" создан.");
                }
                else
                {
                    Console.WriteLine($"  Вложенный каталог \"{tempDirectoryPath}\" уже существует.");
                }

                // c) Вывод информации о текущем каталоге "work"
                Console.WriteLine("\nИнформация о каталоге \"work\":");
                DirectoryInfo workDirectoryInfo = new DirectoryInfo(workDirectoryPath);
                Console.WriteLine($"  Имя: {workDirectoryInfo.Name}");
                Console.WriteLine($"  Родительский каталог: {workDirectoryInfo.Parent?.FullName ?? "Нет родительского каталога"}"); // null-conditional operator
                Console.WriteLine($"  Полный путь: {workDirectoryInfo.FullName}");
                Console.WriteLine($"  Дата создания: {workDirectoryInfo.CreationTime}");

                // d) Вывод информации о вложенном каталоге "temp"
                Console.WriteLine("\nИнформация о вложенном каталоге \"temp\":");
                DirectoryInfo tempDirectoryInfo = new DirectoryInfo(tempDirectoryPath);
                Console.WriteLine($"  Имя: {tempDirectoryInfo.Name}");
                Console.WriteLine($"  Родительский каталог: {tempDirectoryInfo.Parent?.FullName ?? "Нет родительского каталога"}"); // null-conditional operator
                Console.WriteLine($"  Полный путь: {tempDirectoryInfo.FullName}");
                Console.WriteLine($"  Дата создания: {tempDirectoryInfo.CreationTime}");

                // 4. Перемещение каталога "temp"
                string newTempDirectoryPath = Path.Combine(workDirectoryPath, "newTemp");
                try
                {
                    Directory.Move(tempDirectoryPath, newTempDirectoryPath);
                    Console.WriteLine($"\nКаталог \"{tempDirectoryPath}\" успешно перемещен в \"{newTempDirectoryPath}\".");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Ошибка при перемещении каталога: {ex.Message}");
                }

                // 5. Удаление каталога "newTemp"
                try
                {
                    if (Directory.Exists(newTempDirectoryPath)) // Проверяем наличие каталога перед удалением
                    {
                        Directory.Delete(newTempDirectoryPath, true); // true - удалять рекурсивно (с файлами и подкаталогами)
                        Console.WriteLine($"\nКаталог \"{newTempDirectoryPath}\" успешно удален.");
                    }
                    else
                    {
                        Console.WriteLine($"\nКаталог \"{newTempDirectoryPath}\" не существует, поэтому не был удален.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"  Ошибка при удалении каталога: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОбщая ошибка: {ex.Message}"); // Обработка общих ошибок
            }

            Console.ReadKey(); // Чтобы консоль не закрывалась сразу
        }
    }
}