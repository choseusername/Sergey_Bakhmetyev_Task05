using System;

namespace Task2
{
    class Program
    {
        static void DisplayInformationAboutRound(Point point, double radius)
        {
            try
            {
                Console.WriteLine("Попытка создать круг с параметрами" +
                    " c = {0}, r = {1} и вывести информацию о нем", point, radius);
                var round = new Round(point, radius);
                Console.WriteLine(round);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Interception of a message about an incorrect circle
            DisplayInformationAboutRound(new Point(-100.0, 10.0), radius: -5.0);

            // The correct circle. There is no exception here
            DisplayInformationAboutRound(new Point(-100.0, 10.0), radius: 5.0);

            Console.ReadKey();
        }
    }
}
