using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNum2byUser;
            int Result;
            myClass myClass = new myClass();
            myClass.inputNum1 = 20;
            myClass.inputNum2 = 5;

            //Result = Convert.ToInt32 (myClass.inputNum1 * myClass.inputNum2);
            //Console.WriteLine(Result);

            Console.WriteLine("Enter the First Number: ");
            myClass.inputNum1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("For the second number the default value is 5, DO NOT ENTER THE SECOND NUMBER");
            inputNum2byUser = Console.ReadLine();

            if(inputNum2byUser == null)
            {
                myClass.inputNum2 = 5;
            }

            Result = Convert.ToInt32(myClass.inputNum1 * myClass.inputNum2);
            Console.WriteLine(Result);

            Console.ReadLine();
        }
    }
}
