using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName, location;

            Console.WriteLine("Please enter your name");
            fullName = Console.ReadLine();
            Console.WriteLine("Please enter your location");
            location = Console.ReadLine();

            Console.WriteLine($"My name is {fullName}");
            Console.WriteLine($"I am from {location}");

            Console.WriteLine(DateTime.Now.ToString("d"));

            TimeSpan xmasDifference = new DateTime(2018, 12, 25, 0, 0, 0).Subtract(DateTime.Now);
            Console.WriteLine($"There are {xmasDifference.Days} until Christmas");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width of the window in feet?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height of the window in feet?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} metres");

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();
        }
    }
}
