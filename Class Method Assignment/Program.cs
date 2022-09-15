using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int defaultValue = 2;
            int dividResult;
            double multipleResult;
            int addResult;
            Console.WriteLine("Enter any integer Number: ");
            int userIntData = Convert.ToInt32(Console.ReadLine());

            Math.Function(userIntData,defaultValue,out dividResult, out addResult);
            Math.Function(userIntData, defaultValue, out multipleResult);

            Console.WriteLine("Division of number is = " + dividResult);
            Console.WriteLine("Addition of number is = " +addResult);
            Console.WriteLine("Multiplication of number is = " + multipleResult);


            Console.ReadLine();

        }
    }
}
