using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RectangularPrismPresent
{
    class rectangularPrism
    {
        double lenght { get; set; }
        double width { get; set; }
        double height { get; set; }

        public rectangularPrism(double  lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }


       
    }

    internal class Program
    {
        public static double rectPrism(double l, double w, double h)
        {
            return 2 * (l * w) + 2 * (w * h) + 2 * (h * l) + (l * w);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The elves need for a total of {0} square feet of wrapping paper!", rectPrism(2, 3, 4));
            Console.WriteLine("The elves need for a total of {0} square feet of wrapping paper!", rectPrism(1, 1, 10));
        }
    }
}
