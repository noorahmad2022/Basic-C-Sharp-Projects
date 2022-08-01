using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods_Assignment;

namespace Methods_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to do the math opertion on it");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Methods_Assignment.Methods methode = new Methods();
            methode.sumFuntion(userInput);

            Methods_Assignment.Methods method = new Methods();
            method.multiplyFunction(userInput);

            minusFunction(userInput);

            Console.ReadLine();
        }


        static void minusFunction(int userData)
        {
            int result = 1000 - userData;
            Console.WriteLine(userData + " - 1000 = " + result);

        }
    }
}
