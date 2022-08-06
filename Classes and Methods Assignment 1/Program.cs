using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to do the math opertion on it (Addition and Subtraction): " + "\n");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Math math = new Math();
            math.mathOperation(userInput);

            Console.WriteLine("Enter a dicemale number to do the math opertion on it: " + "\n");
            decimal decimaleInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            math.mathOperationDecimal(decimaleInput);


            Console.ReadLine();


        }
    }
}
