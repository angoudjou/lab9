using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double raduis;
        private const double PI = Math.PI;
        public static int NumberCircle; 

        // constructor
        public Circle( double r)
        {
            raduis = r;
            NumberCircle++;
        }
        public int getNumberCircle()
        {
            return NumberCircle;
        }
        public double GetCircumference()
        {
            return  2*PI * raduis;
        }
        public double CalculateArea()
        {
            return PI * raduis*raduis;
        }
        public string CalculateFormatedCircumference()
        {
            return FormatNumber( GetCircumference());
        }
        public string CalculateFormatedArea()
        {
            return FormatNumber(CalculateArea());
        }
        public string FormatNumber( double c)
        {
            return Math.Round(c, 2).ToString();
        }
        private double getRaduis()
        {
            return raduis;
        }
    }
}
