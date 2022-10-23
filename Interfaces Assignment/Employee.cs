using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Assignment
{
    internal class Employee: person, IQuittable
    {
        public void Quit(string quit)
        {
            Console.WriteLine(quit);
        }

        interface IQuittable
        {
            void Quit(string quit);
        }
    }
}
