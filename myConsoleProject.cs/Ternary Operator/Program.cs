using System;

namespace Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary Operator: The ternary operator allows you to write a single line of code that will check for a condition and, depending on the outcome, execute another portion of code. In C#, the ternary operator is represented by the symbol "?:"

            int num1 = 7;
            int num2 = 12;

            string result = num1 > num2 ? "Number 1 is greater than Number 2" : "Number 2 is greater than Number 1";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
