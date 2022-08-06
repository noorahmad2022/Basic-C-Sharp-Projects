using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    public class Math
    {
        public void mathOperation(int userData)
        {
            int sum = 10;
            int sub = 20;
            int sumResult;
            int subResult;

            sumResult = sum + userData;
            subResult = userData - sub;

            Console.WriteLine(userData + " + " + sum + " = "+sumResult);
            Console.WriteLine(userData + " - " + sub + " = " + subResult + "\n");
        }

        public void mathOperationDecimal(decimal userData)
        {

            decimal multiplyResult = Convert.ToInt32(userData * 5);
            Console.WriteLine(userData + " * 5 = " + multiplyResult);


        }
    }
}
