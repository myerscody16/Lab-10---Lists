using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_10_Classes___Circle
{
    public class Circle
    {
        #region Fields
        private double radius;
        private double circumference;
        private double area;
        #endregion

        #region Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public double Circumference
        {
            get
            {
                return circumference;
            }
            set
            {
                circumference = value;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        #endregion

        #region Constructors
        public Circle(double _radius, double _circumference, double _area)
        {
            radius = _radius;
            circumference = _circumference;
            area = _area;
        }

        #endregion

        #region Methods
        public static double CalculateCircumference(double radius)
        {
            double circumference = Math.Round(Math.PI * 2 * radius,2);
            return circumference;
        }
        public static double CalculateArea(double radius)
        {
            double area = Math.Round(Math.PI * radius * radius,2);
            return area;
        }
        public static bool AskRepeat(string message)
        {
            Console.WriteLine(message);

            bool repeat = true;
            bool cont = true;
            while (cont)
            {
                string usrInput = Console.ReadLine().ToLower();
                try
                {
                    if (usrInput == "y")
                    {
                        repeat = true;
                        cont = false;
                    }
                    else if (usrInput == "n")
                    {
                        repeat = false;
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, please respond with y or n, then press enter.");
                        continue;
                    }

                }
                catch
                {
                    Console.WriteLine("Invalid response, please respond with y or n, then press enter.");
                    continue;
                }
            }
            return repeat;
        }
        #endregion
    }
}
