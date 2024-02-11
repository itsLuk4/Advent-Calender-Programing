using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Calender_Programing
{
    internal class Program
    {
        /* Santa is trying to deliver presents in a large apartment building, 
         * but he can't find the right floor - the directions he got are a little confusing. 
         * He starts on the ground floor (floor 0) and then follows the instructions one character at a time.
         * An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), 
         * means he should go down one floor.
         * The apartment building is very tall, and the basement is very deep; 
         * he will never find the top or bottom floors.
         * 
         * For example:
         * 
         * (()) and ()() both result in floor 0.
         * ((( and (()(()( both result in floor 3.
         * ))((((( also results in floor 3.
         * ()) and ))( both result in floor -1 (the first basement level).
         * ))) and )())()) both result in floor -3.
         * 
         * To what floor do the instructions take Santa?
         */

        static void Main(string[] args)
        {

            int startingFloor = 0;
            int positiveValue = 0;
            int negativeValue = 0;

            Console.WriteLine("Santa is trying to deliver presents in a large apartment building, " +
                "\nbut he can't find the right floor - the directions he got are a little confusing. " +
                "\nHe starts on the ground floor (floor 0) and then follows the instructions one character at a time.");

            Console.WriteLine("\nWrite a random number of paranthesis where " +
                "'(' equals 1 and ')' equals -1 to bring the end result!\n");

            Console.Write("Enter here:");
            string paranthesis = Console.ReadLine();
            foreach (char s in paranthesis)
            {
                if (s == '(')
                {
                    positiveValue += 1;
                }
                else if (s == ')')
                {
                    negativeValue += -1;
                }

                startingFloor = positiveValue + negativeValue;
            }
            Console.WriteLine("\nSanta is on floor {0}!", startingFloor);
        }
    }
}
