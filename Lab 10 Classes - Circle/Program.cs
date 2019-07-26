using System;

namespace Lab_10_Classes___Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("What is the radius of the circle?");
            bool cont = true;
            while(cont)
            {
                try
                {
                    double usrInput = double.Parse(Console.ReadLine());
                    cont = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input, please give a valid radius and then press enter");
                    continue;
                }
            }
            Circle circumference = Circle.CalculateCircumference();
            Console.WriteLine(circumference);

        }
    }
}
