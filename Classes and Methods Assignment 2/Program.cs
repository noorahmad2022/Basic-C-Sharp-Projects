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

            Console.WriteLine("Enter First Number");
            int userEntry1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            string userEntry2 = Convert.ToString(Console.ReadLine());

            if (userEntry2 == "")
            {
                myClass myClass = new myClass();
                int result = myClass.mathOp(userEntry1);
                Console.WriteLine(result);
            }
            if (userEntry2 != "")
            {
                myClass myClass = new myClass();
                int result = myClass.mathOp(userEntry1,Convert.ToInt32(userEntry2));
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
