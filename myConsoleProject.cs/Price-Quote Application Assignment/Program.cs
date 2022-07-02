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
            int packageWeigh = Convert.ToInt32(Console.ReadLine());
                if (packageWeigh > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. ****** Have a good day ******");
                    Console.ReadLine();
                    return;
                }
            
            Console.WriteLine("Please enter the package width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int totalAllDimension = packageWidth + packageHeight + packageLength;
            if (totalAllDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. ****** Have a good day ******");
                Console.ReadLine();
                return;
            }
            int priceQuote = (packageWidth * packageHeight * packageLength)/100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + priceQuote +".00");
            Console.ReadLine();

        }
    }
}
