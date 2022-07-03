using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Concatenate three strings.
            string string01 = "I looked for Mary and ";
            string string02 = "Samantha at the ";
            string string03 = "bus station.";

            var concatString = string.Concat(string01, string02, string03);
            Console.WriteLine(concatString);
            Console.ReadLine();

                                    // OR
            Console.Write(string01 + string02 + string03);
            Console.ReadLine();
            Console.WriteLine("");

        // Convert a string to uppercase..
            string myName = "Noorahmad Noor";
            myName = myName.ToUpper();
            Console.WriteLine(myName);
            Console.ReadLine();

            //StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("My name is Noorahmad");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
