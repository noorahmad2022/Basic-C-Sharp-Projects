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
            Console.WriteLine("Enter the First Number: ");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Second Number: ");


            if (Console.ReadLine() != null)
            {
                myClass myClass = new myClass();
                myClass.mathOperations(inputNum1);
            }
            else
            {
                int inputNum2 = Convert.ToInt32(Console.ReadLine());
                int result = inputNum1 + inputNum2;
                Console.WriteLine(result);
            }




            //Console.WriteLine("Enter the Second Number, if you leave empty. The default value is 5 : ");
            //int inputNum2 = Convert.ToInt32(Console.ReadLine());


            //if (inputNum2 != null)
            //{
            //    Classes_and_Methods_Assignment_2.myClass myClass = new myClass();
            //    myClass.mathOperations(inputNum1, inputNum2);
            //}
            //else
            //{
            //    myClass myClass1 = new myClass();
            //    myClass1.mathOperations(inputNum1 + inputNum2);
            //}


            Console.ReadLine();
        }
    }
}
