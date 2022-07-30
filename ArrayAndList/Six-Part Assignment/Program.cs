using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Assignment
{
    internal class Program
    {
        static void Main()
        {
        // Console App Assignment Part 1
           Console.WriteLine("Enter any text to show at the end of each employee name?");
           string userText = Console.ReadLine();
           
            string[] empName = { "Noorahmad", "Jesse", "Daniel", "Adam" };
            for (int j = 0; j < empName.Length; j++)
            {
             Console.WriteLine(empName[j] + ", " + userText);
                
            }
            Console.ReadLine();


         // Console App Assignment Part 2 and 3
         // An infinite loop is a loop that keeps running ‘forever’, 

            int i = 0;
            while (true)
            {
                Console.WriteLine($"i = {i}");
                i++;

                if (i < 11)
                {
                    //break;
                }

                else if(i>10 && i <= 15)
                {
                    //break
                }

                else if (i>20)
                {
                    break;  //if we don't write break, the loops keeps running.
                }
            }
            Console.ReadLine();


        // Console App Assignment Part 4

           List<string> employees = new List<string> { "Noorahmad", "Jesse", "Daniel", "Adam" };

           Console.WriteLine("Please type the employee name i.e. Noorahmad, Jesse, Daniel, and Adam to display thier ID number");
           string userData = Convert.ToString(Console.ReadLine());

            int index = employees.FindIndex(a => a.Contains($"{userData}"));

            if (index >= 1)
            {
                Console.WriteLine("Employee ID = " + index);
            }
            else
            {
                Console.WriteLine("Employee not found in a list");
            }

            Console.ReadLine();

        // Console App Assignment Part 5 and 6
        
            List<String> identical = new List<string>() { "Jesse", "Jesse", "Daniel", "Adam", "Noorahmad" };

            Console.WriteLine("Enter an employee Name?");
            string empNamebyUser = Console.ReadLine();

            foreach (string identicalName in identical)
            {
                if (empNamebyUser.Contains(identicalName))
                {
                    Console.WriteLine(identicalName + " Found in the list");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, not found in the list");
                }
            }
            Console.ReadLine();

        }
    }
}
