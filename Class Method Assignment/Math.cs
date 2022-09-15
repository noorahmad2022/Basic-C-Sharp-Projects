using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Math
    {
        public static void Function(int userNumber, int defaultValue, out int dividFunction, out int addFunction)
        {
            dividFunction = userNumber/defaultValue;
            addFunction = userNumber + defaultValue;
        }

        public static void Function(double userNumber, double defaultValue, out double multiPleFunction)
        {
            multiPleFunction = userNumber*defaultValue;
        }


    }
}
