namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст. 
    * После каждого ввода консоль очищается. 
    * Когда пользователь вводить слово «exit» или пустую строку
    * – ввод останавливается и выводиться количество строк 
    * введенных пользователем.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Для прекращения ввода пропищите exit или пустую строку");
            string a = Console.ReadLine();
            int b = 0;
            while (true)

            {
                if (a == "exit" | a == "")
                    break;
                ++b;
                Console.Clear();
                a = Console.ReadLine();
                if (a == "exit" | a == "")
                    break;
            }

            Console.Clear();
            Console.WriteLine("Было введено " + b + " строк");
        }

    }

}