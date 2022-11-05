using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<int, string, string, double> emp1 = new Employee<int, string, string, double>();
                emp1.ID = 1;
                emp1.firstName = "Noor Ahmad";
                emp1.lastName = "Noor";
                emp1.things= 452;

            Employee<int, string, string, string> emp2 = new Employee<int, string, string, string>();
               emp2.ID = 2;
               emp2.firstName = "Malice";
               emp2.lastName = "Safi";
               emp2.things = "658";

            Console.WriteLine("Employee 1 Information \n \n" + "ID =  " + emp1.ID + "\n" + "First Name =  " + emp1.firstName + "\n" + "Last Name =  " + emp1.lastName + "\n"+ "PIN Code = "+ emp1.things+ "\n \n \n");
            Console.WriteLine("Employee 2 Information \n \n" + "ID =  " + emp2.ID + "\n" + "First Name =  " + emp2.firstName + "\n" + "Last Name =  " + emp2.lastName + "\n"+ "PIN Code = "+ emp2.things+ "\n \n \n");

            Console.ReadLine();
        }
    }
}
