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
            
            Employee<string> emp = new Employee<string>();

            emp.Things.Add("Noorahmad");
            emp.Things.Add("John");
            emp.Things.Add("Bob");

            foreach (string employee in emp.Things)
            {
                Console.WriteLine(employee);
            }

            Employee<int> emp1 = new Employee<int>();

            emp1.Things.Add(1);
            emp1.Things.Add(2);
            emp1.Things.Add(3);


            foreach (string emplist in emp.Things)
            {
                Console.WriteLine(emplist);
            }



            Console.WriteLine();
            Console.WriteLine("Press any key to shut down ....");
            Console.ReadLine();



        }
    }
}
