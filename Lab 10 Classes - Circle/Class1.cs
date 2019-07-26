using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_10_Classes___Circle
{
    class Circle
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
        public Circle(double radius)
        {

        }

        #endregion

        #region Methods
        public double CalculateCircumference()
        {
            radius = 6;
            double circumference = Math.PI * 2 * radius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            //extra credit
        }
        public double CalculateArea()
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public string CalculateFormattedArea()
        {
            //extra credit
        }


        #endregion
    }
}
