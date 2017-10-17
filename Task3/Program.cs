using System;
using ShapesLibrary;

namespace Task3
{
    class Program
    {
        static void DisplayInformationAboutTriangle(double a, double b, double c)
        {
            try
            {
                Console.WriteLine("Попытка создать треугольник с параметрами" +
                    " a = {0}, b = {1}, c = {2} и вывести информацию о нем ", a, b, c);
                var triangle = new Triangle(a, b, c);
                Console.WriteLine(triangle);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine();
        } 
        static void Main(string[] args)
        {
            // Interception of a message about an incorrect triangle
            DisplayInformationAboutTriangle(1, 1, 5);

            // The correct triangle. There is no exception here
            DisplayInformationAboutTriangle(3, 4, 5);

            Console.ReadKey();
        }
    }
}
