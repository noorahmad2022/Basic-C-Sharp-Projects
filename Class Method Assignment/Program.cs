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
            

            Console.WriteLine("Enter any Number to divid into 2");
            Class1 myClass = new Class1();
            myClass.methode(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();

        }
    }
}
