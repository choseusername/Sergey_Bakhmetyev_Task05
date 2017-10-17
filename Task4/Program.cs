using System;
using MyStringLibrary;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString hello = new MyString("Hello,");
            Console.WriteLine(hello);

            MyString world = new MyString(" World!");
            MyString helloWorld = hello + world;
            Console.WriteLine(helloWorld);

            MyString helloWorldWorldWorld = hello + world + world + world;
            MyString helloWithoutWorlButWithPunktuation = helloWorldWorldWorld - new MyString("World");
            Console.WriteLine(helloWithoutWorlButWithPunktuation.ToString());

            MyString helloFromCharrArray = new MyString("Hello,".ToCharArray());
            Console.WriteLine(helloFromCharrArray);

            Console.WriteLine("Equals two string hello(first from string, second from char array: {0}",
                hello == helloFromCharrArray);

            Console.WriteLine("Equals two string hello and world(first from string, second from char array: {0}",
                hello == world);


            Console.ReadKey();
        }
    }
}
