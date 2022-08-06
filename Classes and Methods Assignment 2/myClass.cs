using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    public class myClass
    {
        public void mathOperations(int num1, int num2=5)
        {
            int result = num1+ num2;
            Console.WriteLine(result);
        }
    }
}
