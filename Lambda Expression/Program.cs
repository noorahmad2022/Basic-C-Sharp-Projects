using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        class Employee
        {
            public int eID { get; set; }
            public string eFirstName { get; set; }
            public string eLastName { get; set; }

            public Employee(int eID, string eFirstName, string eLastName)
            {
                this.eID = eID;
                this.eFirstName = eFirstName;
                this.eLastName = eLastName;
            }
        }  
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Joe", "Win"));
            employees.Add(new Employee(2, "Michael", "Man"));
            employees.Add(new Employee(3, "Lyla", "Abbatiello"));
            employees.Add(new Employee(4, "Joe", "Abraham"));
            employees.Add(new Employee(5, "Micaela", "Acevedo"));
            employees.Add(new Employee(6, "Breonia", "Adam"));
            employees.Add(new Employee(7, "Kara", "Marie"));
            employees.Add(new Employee(8, "Nicole", "Adkins"));
            employees.Add(new Employee(9, "Parsa", "Alaeddini"));
            employees.Add(new Employee(10, "Alexa", "Alcon"));

            foreach (Employee e in employees)
            {
                if (e.eFirstName == "Joe")
                {
                    Console.WriteLine("Employee ID: {0}, \n First Name: {1} \n Last Name: {2} \n", e.eID, e.eFirstName, e.eLastName);
                }
            }

            // Lambda Expression

            Console.WriteLine("********** Lambda Expression ************* \n");
            
            //List<Employee> lambdaList = employees.Where(x=> x.eFirstName=="Joe").ToList();

            List<Employee> lambdaList = employees.Where(x => x.eID> 5).ToList();


            foreach (Employee e in lambdaList)
            {
                Console.WriteLine("Employee ID: {0}, \n First Name: {1} \n Last Name: {2} \n", e.eID, e.eFirstName, e.eLastName);

            }



            Console.ReadLine();
        }
    }
}
