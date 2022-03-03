using System;
namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, number, noun, color;
            Console.Write("Enter a name: ");
            name = Console.ReadLine();

            Console.Write("Enter a number: ");
            number = Console.ReadLine();

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("I am " + number + " years old");
            Console.WriteLine("My favorite " + noun + " is " + color);

            Console.ReadLine();
        }
    }
}
