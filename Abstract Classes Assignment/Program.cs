﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();

            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            Console.ReadLine();
        }
    }
}
