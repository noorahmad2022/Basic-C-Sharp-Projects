using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    public class myClass
    {
        public void myOperation(int num1, int num2)
        {
            int operation = num1 * 50;
            Console.WriteLine("The first number you entered is " +num1 + " which is * by 50 " + "and the Result = " + operation);
            Console.WriteLine("The second number you entered is  "+num2+ " and there is no operation required for this");

        }
    }
}
