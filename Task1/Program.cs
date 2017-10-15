using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User Alexander_Pushkin = new User("Пушкин", "Александр", "Сергеевич", new DateTime(1799, 6, 6));
            Console.WriteLine(Alexander_Pushkin);

            User Barack_Obama = new User("Obama II", "Barack", "Hussein", new DateTime(1961, 8, 4));
            Console.WriteLine(Barack_Obama);

            Console.ReadKey();
        }
    }
}
