using System;


namespace Loop_Assignment_Do_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favoret number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 100;

            do
            {
                switch (number)
                {
                    case 55:
                        Console.WriteLine("Guess my favoret number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You guessed 55. Try Again");
                        break;
                    case 78:
                        Console.WriteLine("Guess my favoret number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You guessed 78. Try Again");
                        break;
                    case 100:
                        Console.WriteLine("You guessed 100. That is my favoret number!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Guess my favoret number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You are wrong. please try again");
                        break;
                }
            }
            while (!isGuessed);
            {

            }
            Console.ReadLine();
        }

    }
}
