using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grand Circus Lab 2");
            Console.WriteLine("Room calculator");
            Console.WriteLine("");

            while (true)
            {
                //user input for length
                Console.Write("Please enter the length of the room: ");
                double length = double.Parse(Console.ReadLine());
                //user input for width
                Console.Write("Please enter the width of the room: ");
                double width = double.Parse(Console.ReadLine());
                //user input for hight
                Console.Write("Please enter the hight of the room: ");
                double hight = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                //calculate perimeter
                double perimeter = (length * 2) + (width * 2);
                //calculate area
                double area = length * width;
                //calculate volume
                double volume = length * width * hight;

                Console.WriteLine("The perimeter of the room is : " + perimeter);
                Console.WriteLine("The area of the room is: " + area);
                Console.WriteLine("The volume of the room is: " + volume);
                Console.WriteLine("\n");

                //calculate how much paint you will need
                //1 can per 5 sq feet
                double paint = perimeter / 5;
                Console.WriteLine("You will need {0} cans of paint", paint);

                //calculate how much title you will need
                //1 title per 5 sq feet
                double carpet = area / 5;
                Console.WriteLine("You will need {0} units of carpet", carpet);


                //ask the user to measure another room
                Console.WriteLine("Would you like to measure another room? (Yes or no)");
                string input = Console.ReadLine().ToLower();

                if (input == "yes" || input == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }
            }
        }
    }
}
