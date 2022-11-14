using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        struct Employee
        {
            public int empId;
            public string firstName;
            public string lastName;
            public string SSN;
        }

        static void Main(string[] args)
        {

            Employee emp1 = new Employee();

            emp1.empId = 1;
            emp1.firstName = "Noorahmad";
            emp1.lastName = "Noor";
            emp1.SSN = "778-792-9729";

            Console.WriteLine(emp1.firstName);

            Console.ReadLine();
        }
    }
}