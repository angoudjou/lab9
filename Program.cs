using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] spect=  {'@','>','<','-','\\'};
            //string word = "angoudjou@gmail.com";
            //if (word.Contains(spect.ToString()))
            //{
            //    Console.WriteLine(  "contient special chars");
            //}
            Circle circle = null ;
            Console.WriteLine("welcome to Circle Tester");
            bool run = true;
            while (run)
            {
                Console.WriteLine();
                Console.Write("Enter the Radius: ");
                double r;
                if(Double.TryParse(Console.ReadLine(), out r))
                {
                    circle = new Circle(r);
                    Console.WriteLine("Circumference =" + circle.CalculateFormatedCircumference());

                    Console.WriteLine("Area =" + circle.CalculateFormatedArea());

                    Console.WriteLine();
                    Console.Write("Continue (y/n): ");
                    run = Console.ReadKey().Key == ConsoleKey.Y;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            Console.WriteLine("Good Bye");
            Console.WriteLine("You created  = " + circle.getNumberCircle() + " Circles");

            //Circle circle = new Circle(10);
            //Console.WriteLine( circle.FormatNumber( circle.GetCircumference()));
          
            Console.ReadKey();
        }
    }
}
