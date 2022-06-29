using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class StringToIneger
    {
        static void Main()
        {
            string yearsOld = "12";
            int currentAge = Convert.ToInt32(yearsOld);
            Console.WriteLine("Your current Age is " + currentAge);
            Console.ReadLine();

            int Age = 24;
            string yourAge = Age.ToString();
            Console.WriteLine("Your current age is " + yourAge);
            Console.ReadLine();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine("Today raining status = " + rainingStatus);
            Console.ReadLine();
        }
    }
    