using System;

namespace Lab02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the room detail generator!");
            string continueInput;

            do
            {
                Console.Write("Please enter the length of your room: ");
                var lengthInput = Console.ReadLine();
                var length = double.Parse(lengthInput);

                Console.Write("Please enter the width of your room: ");
                var widthInput = Console.ReadLine();
                var width = double.Parse(widthInput);

                Console.Write("Please enter the height of your room: ");
                var heightInput = Console.ReadLine();
                var height = double.Parse(heightInput);

                var area = width * length;
                var perimeter = 2 * (width + length);
                var volume = width * length * height;
                var surfaceArea = 2 * (width * length + width * height + height * length);

                Console.WriteLine();
                Console.WriteLine($"The area of your room is {area}");
                Console.WriteLine($"The perimeter of your room is {perimeter} ");
                Console.WriteLine($"The volume of your room is {volume}");
                Console.WriteLine($"The surface of your room is {surfaceArea}");
                Console.WriteLine();
                Console.Write("Would you like to measure another room? (y/n): ");
                continueInput = Console.ReadLine();

            } while (continueInput == "y");

            Console.WriteLine("Thanks for visiting. Goodbye!");
    {

            }

        }
    }
}
