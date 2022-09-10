using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myClass myClass = new myClass();

            Console.WriteLine("Enter the First Number");
            int userFirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int userScondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("********** Methode call by passing two number! ***************");
            myClass.myOperation(userFirstNum, userScondNum);
            Console.WriteLine("");

            Console.WriteLine("********** Methode call specifying the parameters by name ***************");
            myClass.myOperation(num2: userScondNum, num1: userFirstNum);

            Console.ReadLine();
        }
    }
}
