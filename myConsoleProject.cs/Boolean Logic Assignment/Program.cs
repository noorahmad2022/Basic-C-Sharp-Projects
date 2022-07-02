using System;


namespace Boolean_Logic_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean Logic Assignment

            Console.WriteLine("What is your age?  ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (answer by true or false)  ");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?  ");
            int ticket = Convert.ToInt32(Console.ReadLine());

            bool carInsurance = (age > 15 && ticket <= 3 && DUI != true);

            Console.WriteLine("Car Insurance Approval Resule = " +carInsurance);
            Console.ReadLine();
        }
    }
}
