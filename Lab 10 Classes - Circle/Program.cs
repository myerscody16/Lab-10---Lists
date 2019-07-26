using System;

namespace Lab_10_Classes___Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            double usrInput = 0;
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("What is the radius of the circle?");
                bool cont1 = true;
                while (cont1)
                {
                    try
                    {
                        usrInput = double.Parse(Console.ReadLine());
                        cont1 = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input, please give a valid radius and then press enter");
                        continue;
                    }
                }
                double circumference = Circle.CalculateCircumference(usrInput);
                double area = Circle.CalculateArea(usrInput);
                Console.WriteLine($"The circumference of the circle is {circumference}");
                Console.WriteLine($"The area of the circle is {area}");
                bool repeat = Circle.AskRepeat("Would you like to run the program again?(y/n)");
                if (repeat == true)
                {
                    continue;
                }
                else if (repeat == false)
                {
                    Console.WriteLine("Goodbye.");
                    cont = false;
                }
            }
        }
    }
}//add a counter that prints at the end of every rotation and have each value printed to only show to the second decimal place
