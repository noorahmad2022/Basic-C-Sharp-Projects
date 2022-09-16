using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine(firstName + " " + lastName + "\n");
        }
    }
}
