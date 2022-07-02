using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number to multiply by 50");
            int num = Convert.ToInt32(Console.ReadLine());
            int numResult = num * 50;
            Console.WriteLine("Result = " + numResult);
            Console.ReadLine();

            Console.WriteLine("Enter any number to add by 25");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num1Result = num1 + 25;
            Console.WriteLine("Result = " + num1Result);
            Console.ReadLine();

            Console.WriteLine("Enter any number to divid it by 12.5");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num2Result = num2 / 12.5;
            Console.WriteLine("Result = " + num2Result);
            Console.ReadLine();

            Console.WriteLine("Enter any number greater than 50");
            int userNum = Convert.ToInt32(Console.ReadLine());
            bool userResult = userNum > 50;
            Console.WriteLine(userResult);
            Console.ReadLine();

            Console.WriteLine("Enter any number to divides by 7 and find the remainder");
            int user5Num = Convert.ToInt32(Console.ReadLine());
            int dividResult = user5Num / 7;
            Console.WriteLine("division result = " + dividResult);
            int remainder = dividResult % 2;
            Console.WriteLine("Remider result = " + remainder);
            Console.ReadLine();

        }
    }
}
