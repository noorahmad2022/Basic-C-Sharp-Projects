using System;

namespace Branching
{
    internal class Program
    {
        static void Main()
        {
        // IF Function

            if (true)
            {
                Console.WriteLine("Hello World");
                Console.ReadLine();
            }
        // IF Else Function

            if (1 == 1)
            {
                Console.WriteLine("1 is equal to 1 : ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("1 does NOT Equal to 1 : ");
                Console.ReadLine();
            }

            string name = "Noorahmad";
            if (name =="Noor" ) 
            {
                Console.WriteLine("Your name is Noorahmad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your name is not Noorahmad");
                Console.ReadLine();
            }

        //ELSE IF Function

            string name1 = "Adam"; //change the name to Erike to see the True Result
            if(name1 == "Jesse")
            {
                Console.WriteLine("Your name is Jesse ");
            }
            else if(name1 == "Brett")
            {
                Console.WriteLine("Your name is not Jesse ");
            }
            else if (name1 == "Erike")
            {
                Console.WriteLine("Your Name is Erike");
            }
            else
            {
                Console.WriteLine("Your Name NOT MATCH");
            }
            Console.ReadLine();

        //IF NOT Equal

            string name2 = "Noor";
            if(name2 != "Noor")
            {
                Console.WriteLine("Your name is not Noor");
            }
            else
            {
                Console.WriteLine("Your name is Noor");
            }
            Console.ReadLine();

        // IF Greater/ Lesser Than

            int number01 = 15;
            int number02 = 14;
            if (number01 > number02)
            {
                Console.WriteLine("Number 1 is Greater than Number 2");
            }
            else
            {
                Console.WriteLine("The Second number is Larger than First");
            }
            Console.ReadLine();

            int customerAge = 19;
            if(customerAge > 21)
            {
                Console.WriteLine("No you may not purchase that bottle of wine");
            }
            else
            {
                Console.WriteLine("That will be #23.71");
            }
            Console.ReadLine();

        // Using AND with IF

            int N1 = 7;
            int N2 = 18;
            int N3 = 12;
            if(N2> N1 && N3 < N2)
            {
                Console.WriteLine("The second number is larger than the others");
            }
            Console.ReadLine();

         // Using AND with IF

            int num1 = 9;
            if (num1>7 || num1 == 12)
            {
                Console.WriteLine("At least one value is true.");
            }
            Console.ReadLine();

            string role = "Administrator";
            if(role =="admin" || role == "Administrator")
            {
                Console.WriteLine("You are an Administrator, and You may have access to ther entire software system.");
            }
            Console.ReadLine();

        // Assignment

            int num01 = 18;
            int num02 = 14;
            int num03 = 21;
            int num04 = 13;

            if (num1 > num02)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num02 < num03)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num03 > num01)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num04 < num02)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            // Assignment

            int num11 = 18;
            int num21 = 14;
            int num31 = 21;
            int num41 = 13;

            if (num11 > num21 && num31 < num21)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num21 < num31 || num41 > num11)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num31 > num11 && num11 < num21)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num41 != num21 && num21 > num31)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            //Assignment

            int anum1 = 26;
            int anum2 = 9;
            int anum3 = 14;
            int anum4 = 11;

            if (anum1 > anum2 && anum3 < anum2)
            {
                Console.WriteLine("Statement 1");
            }
            else if (anum2 > anum3 || anum4 > anum1)
            {
                Console.WriteLine("Statement 2");
            }
            else if (anum3 < anum1 && anum1 > anum2)
            {
                Console.WriteLine("Statement 3");
            }
            else if (anum4 < anum2 && anum2 < anum3)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            //Assignment

            int mum1 = 19;
            int mum2 = 14;
            int mum3 = 14;
            int mum4 = 18;

            if (mum1 > mum2 && mum3 < mum2)
            {
                Console.WriteLine("Statement 1 M");
            }
            else if (mum2 != mum3 || mum4 > mum1)
            {
                Console.WriteLine("Statement 2 M");
            }
            else if (mum3 < mum1 && mum1 > mum2)
            {
                Console.WriteLine("Statement 3 M");
            }
            else if (mum4 < mum2 && mum2 < mum3)
            {
                Console.WriteLine("Statement 4 M");
            }
            Console.ReadLine();

            //Assignment

            int tum1 = 5;
            int tum2 = 2;
            int tum3 = 8;
            int tum4 = 6;

            if (tum1 < tum2)
            {
                Console.WriteLine("Statement 1 T");
            }
            else if (tum2 > tum3)
            {
                Console.WriteLine("Statement 2 T");
            }
            else if (tum3 < tum1)
            {
                Console.WriteLine("Statement 3 T");
            }
            else if (tum4 > tum2)
            {
                Console.WriteLine("Statement 4 T");
            }
            Console.ReadLine();
        }
    }
}
