using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Calender_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startingFloor = 0;
            int positiveValue = 0;
            int negativeValue = 0;
            Console.WriteLine("Write a random number of paranthesis where " +
                "'(' equals 1 and ')' equals -1 to bring the end result!\n" +
                "Enter here:");
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
            Console.WriteLine(startingFloor);
        }
    }
}
