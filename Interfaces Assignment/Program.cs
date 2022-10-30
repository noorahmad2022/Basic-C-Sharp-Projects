using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //person person = new Employee();

            IQuittable quittable = new Employee();

            quittable.Quit("Interface Methode is running!");
          
            Console.ReadLine();
        }
    }
}
