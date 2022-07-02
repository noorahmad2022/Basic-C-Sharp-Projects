using System;

namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Boolean AND OR
            int packageWidth = 10;
             int packageHight = 30;

            bool tooBig = (packageHight > 25 && packageWidth > 25); // Boolean AND
            bool tooBig1 = (packageHight > 25 || packageWidth > 25); // Boolean OR
            bool tooBig2 = (packageHight > 25 ^ packageWidth > 25); // Boolean XOR, mean if one condition is true the result will be true

            Console.WriteLine("Boolean AND Function :  " + tooBig);
            Console.WriteLine("Boolean OR Function :  " + tooBig1);
            Console.WriteLine("Boolean XOR Function :  " + tooBig2);
            Console.ReadLine();


        //Boolean Logic - More than One AND
            string firstName = "Noorahmad";
            string lastName = "Noor";
            string phoneNumber = "7787929729";

            bool isauthorized = (firstName == "Noorahmad" && lastName == "Noor" && phoneNumber == "7787929729");
          
            Console.WriteLine("More than One AND : " + isauthorized);
            Console.ReadLine();

        // Boolean Logic - More than One OR with equal and Not equal
            int bankAccountBalance = 500;
            bool isInARockBand = false;
            string name = "Noorahmad";

            bool isRealyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Noor");
            bool isRealyCool1 = (bankAccountBalance > 100000 || isInARockBand || name != "Noor");
            Console.WriteLine("Boolean Logic - More than One OR with equal : " + isRealyCool);
            Console.WriteLine("Boolean Logic - More than One OR with equal : " + isRealyCool1);
            Console.ReadLine();

        // Boolean Logic - Combining Operators
            int num1 = 7;
            int num2 = 12;
            int num3 = 23;
            int num4 = 14;
            int num5 = 8;
            int num6 = 5;

            bool result = (num1 > num2 && (num3 == num4 || num5 > num6));
            Console.WriteLine("Combining Operators : " + result);
            Console.ReadLine();
        }
    }
}
