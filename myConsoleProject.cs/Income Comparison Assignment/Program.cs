using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** Academy of Learning Career College ***************");
            Console.WriteLine("*************** Anonymous Income Comparison Program ***************");
            Console.WriteLine("");

            Console.WriteLine("Please Enter Person 1 Salary Details");
            Console.Write("Hour Rate: ");
            decimal Person1Hours = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            decimal Person1HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Please Enter Person 2 Salary Details");
            Console.Write("Hour Rate: ");
            decimal Person2Hours = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Hours worked per week: ");
            decimal Person2HoursPerWeek = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");
            decimal Person1Salary = Person1Hours * Person1HoursPerWeek * 52; //as per CRA payroll calculation there are 52 pay in a year for weekly payroll.
            Console.WriteLine("Person 1 Anual Salary = " + Person1Salary);
            
            decimal Person2Salary = Person2Hours * Person2HoursPerWeek * 52; //as per CRA payroll calculation there are 52 pay in a year for weekly payroll.
            Console.WriteLine("Person 2 Anual Salary = " + Person2Salary);
            

            bool moreIncome = Person1Salary > Person2Salary;
            Console.WriteLine("Person 1 Make more money than Person 2:  " + moreIncome);
            Console.ReadLine();
        }
    }
}
