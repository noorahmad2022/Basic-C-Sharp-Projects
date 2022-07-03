using System;

namespace Price_Quote_Application_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************** Academy of Learning Career College *****************************");
            Console.WriteLine("*************** Welcome to Package Express. Please follow the instructions below. ***************");
            Console.WriteLine("");
            Console.ReadLine();


            Console.WriteLine("Please enter the package weight: ");
            double packageWeigh = Convert.ToDouble(Console.ReadLine());
                if (packageWeigh > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. ****** Have a good day ******");
                    Console.ReadLine();
                    return;
                }

            Console.WriteLine("Please enter the package width: ");
            double packageWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            double packageHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            double packageLength = Convert.ToDouble(Console.ReadLine());

            double totalAllDimension = packageWidth + packageHeight + packageLength;
            if (totalAllDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. ****** Have a good day ******");
                Console.ReadLine();
                return;
            }
            double priceQuote = (packageWidth * packageHeight * packageLength * packageWeigh) /100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + priceQuote);
            Console.ReadLine();


        //Assignment
            int num1 = 43;
            int num2 = 37;

            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is less than num2";
            Console.WriteLine(result);
            Console.ReadLine();

        //Asignment

            int num11 = 43;
            int num12 = 37;
            int num13 = 68;
            int num14 = 54;

            if (num11 < num12)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num11 >= num13)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num13 <= num12)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num11 - num12 <= num13 - num14)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();


        //Assignment

            int num01 = 43;
            int num02 = 37;
            int num03 = 68;

            string numresult = num01 > num02 && num02 < num03 ? "statement 11111" : "statement 2222";
            Console.WriteLine(numresult);
            Console.ReadLine();


        //Assignment
            int mum1 = 43;
            int mum2 = 37;
            int mum3 = 68;

            string mumresult = mum1 > mum2 && mum2 > mum3 ? "Statement 1 M" : "Statement 2 M";
            Console.WriteLine(mumresult);
            Console.ReadLine();

        }
    }
}
