using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num11 = 43;
            int num21 = 37;
            int num31 = 68;

            string result = num11 + num21 > num31 ? "Statement1" : "statement2";
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
