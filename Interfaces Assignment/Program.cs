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
            Employee employee = new Employee();

            employee.firstName = "Noor Ahmad";
            employee.lastName = "Noor";
            employee.SayName();

            employee.Quit("Interface Methode is running!");
            Console.ReadLine();
        }
    }
}
