using System;

namespace Madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Let's play Madlibs!");

            while (!endApp)
            {

                string animal, ride, color, noun, foodPlural;

                Console.Write("Enter a Animal: ");
                animal = Console.ReadLine();

                Console.Write("Enter a Ride: ");
                ride = Console.ReadLine();

                Console.Write("Enter a color: ");
                color = Console.ReadLine();

                Console.Write("Enter a noun: ");//A noun is a person, place or thing
                noun = Console.ReadLine();

                Console.Write("Enter a food(Plural): ");
                foodPlural = Console.ReadLine();

                Console.WriteLine("Today I went to my favorite Taco Stand called the " + animal);
                Console.WriteLine("Unlike most food stands, they cook and prepare the food in a " + ride);
                Console.WriteLine("The best thing on the menu is the " + color + " " + noun);
                Console.WriteLine("Instead of ground beef they fill the taco with " + foodPlural);

                Console.Write("Press 'e' and Enter to close the app, or press any other key and Enter to continue: ");//User chooses if they want to play again
                if (Console.ReadLine() == "e") endApp = true;
            }
            Console.ReadLine();
        }
    }
}
