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

        }
    }
}
