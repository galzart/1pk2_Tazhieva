

namespace Task_20_05
{
    // Перечисление уровней доступа
    public enum AccessLevel
    {
        Guest,       // Только чтение
        User,        // Чтение + Комментарии
        Moderator,   // Удаление контента
        Admin        // Полный доступ
    }

    // Класс, представляющий пользователя
    public class User
    {
        public string Username { get; set; }
        public AccessLevel AccessLevel { get; set; }

        public User(string username, AccessLevel accessLevel)
        {
            Username = username;
            AccessLevel = accessLevel;
        }

        // Метод для проверки, может ли пользователь выполнить действие
        public bool CanPerformAction(string action)
        {
            switch (action.ToLower()) // Используем ToLower() для регистронезависимого сравнения
            {
                case "read":
                    return true; // Все пользователи могут читать
                case "comment":
                    return AccessLevel >= AccessLevel.User; // User, Moderator и Admin могут комментировать
                case "delete":
                    return AccessLevel >= AccessLevel.Moderator; // Moderator и Admin могут удалять
                case "admin":
                    return AccessLevel == AccessLevel.Admin; // Только Admin может выполнять административные действия
                default:
                    Console.WriteLine("Неизвестное действие.");
                    return false;
            }
        }

        // Метод для попытки выполнения действия и вывода сообщения
        public void TryPerformAction(string action)
        {
            if (CanPerformAction(action))
            {
                Console.WriteLine($"{Username} выполнил действие: {action}");
            }
            else
            {
                Console.WriteLine($"Ошибка: Недостаточно прав у {Username} для выполнения действия: {action}!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем несколько пользователей с разными уровнями доступа
            User guestUser = new User("Guest123", AccessLevel.Guest);
            User regularUser = new User("User456", AccessLevel.User);
            User moderatorUser = new User("Mod789", AccessLevel.Moderator);
            User adminUser = new User("Admin007", AccessLevel.Admin);

            // Проверяем, какие действия они могут выполнять
            Console.WriteLine("Проверка действий:");

            guestUser.TryPerformAction("read");       // Гость может читать
            guestUser.TryPerformAction("comment");    // Гость не может комментировать
            guestUser.TryPerformAction("delete");     // Гость не может удалять

            regularUser.TryPerformAction("comment");   // Пользователь может комментировать
            regularUser.TryPerformAction("delete");    // Пользователь не может удалять

            moderatorUser.TryPerformAction("delete");  // Модератор может удалять
            adminUser.TryPerformAction("admin");   // Админ может выполнять админ действия
            regularUser.TryPerformAction("admin");  // обычный юзер не может выполнять админ действия

            Console.ReadKey();
        }
    }
}