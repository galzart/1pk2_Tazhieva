namespace Task_14_04
{
    internal class Program
    {
        /*Определите класс User, который будет иметь статическое свойство CurrentUser, 
       * представляющее текущего пользователя, и метод для его установки.*/
        static void Main(string[] args)
        {
            User user1 = new User();
            User user2 = new User();

            // Устанавливаем и выводим первого пользователя
            User.SetCurrentUser("Джексон");
            Console.WriteLine("Текущий пользователь: " + User.CurrentUserName);

            User.SetCurrentUser("Чонгук");
            Console.WriteLine("Теперь пользователь: " + User.CurrentUserName);
        }
    }
}


           