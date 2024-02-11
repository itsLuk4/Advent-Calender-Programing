using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RectangularPrismPresent
{
    /* 
     * The elves are running low on wrapping paper, and so they need to submit an order for more. 
     * They have a list of the dimensions (length l, width w, and height h) of each present, 
     * and only want to order exactly as much as they need.
     * Fortunately, every present is a box (a perfect right rectangular prism), 
     * which makes calculating the required wrapping paper for each gift a little easier: 
     * find the surface area of the box, which is 2*l*w + 2*w*h + 2*h*l. 
     * The elves also need a little extra paper for each present: the area of the smallest side.
     * 
     * For example:
     * 
     * A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of 
     * wrapping paper plus 6 square feet of slack, for a total of 58 square feet.
     * A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of 
     * wrapping paper plus 1 square foot of slack, for a total of 43 square feet.
     * 
     * All numbers in the elves' list are in feet. How many total square feet of wrapping paper should they order?
     */

    //The class example
    class rectangularPrism
    {
        public double lenght { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        //public rectangularPrism(double lenght, double width, double height)
        //{
        //    this.lenght = lenght;
        //    this.width = width;
        //    this.height = height;
        //}

        public double rectFormula(double l, double w, double h)
        {
            this.lenght = l;
            this.width = w;
            this.height = h;

            return 2 * (l * w) + 2 * (w * h) + 2 * (h * l) + (l * w);
        }

       
       
    }

    internal class Program
    {
        //Method example
        public static double rectPrism(double l, double w, double h)
        {
            return 2 * (l * w) + 2 * (w * h) + 2 * (h * l) + (l * w);
        }

        static void Main(string[] args)
        {
            

            //The class example
            rectangularPrism rectangularPrism = new rectangularPrism();

            Console.WriteLine("Enter the lenght: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double height = double.Parse(Console.ReadLine());

            double result1 = rectangularPrism.rectFormula(lenght, width, height);
            Console.WriteLine("\nThe elves need for a total of {0} square feet of wrapping paper!", result1);
            Console.WriteLine("The elves need for a total of " + result1 + " square feet of wrapping paper!\n");

            //Method example
            double result2 = rectPrism(lenght, width, height);
            Console.WriteLine("The elves need for a total of {0} square feet of wrapping paper!", result2);
            Console.WriteLine("The elves need for a total of " + result2 + " square feet of wrapping paper!");
            //------------------------------------//


        }
    }
}
