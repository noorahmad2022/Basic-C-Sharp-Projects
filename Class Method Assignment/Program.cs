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
            int userData = Convert.ToInt32(Console.ReadLine());
            int divNum = 2;
            Class1 myClass = new Class1();
            myClass.methode(userData,out divNum);
            string userString = "The result is =  ";
            myClass.methode(userString);

            Console.WriteLine(userString + divNum);
            
            Console.ReadLine();

        }
    }
}
