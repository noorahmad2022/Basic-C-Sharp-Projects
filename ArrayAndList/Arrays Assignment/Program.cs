using System;
using System.Collections.Generic;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main()
        {

            // Create a one-dimensional array of strings. Ask the user to select an index of the array and then display the string at that index on the screen

            string[] strArray = { "C#", "Java", "HTML", "CSS", "BootStrap" };
            Console.WriteLine("Please select an index of arrary from 0 to 4 to display the String :");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The String on typed index is : "+ strArray[userInput] +"\n");
            //Console.ReadLine();


            // Create a one-dimensional array of integers. Ask the user to select an index of the array and then display the integer at that index on the screen

            int[] intArray = new int[] { 100, 200, 1000, 2000, 4000,200 };
            Console.WriteLine("Select the number from 0-5 to win the price :");
            int intInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You Win $" + intArray[intInput] + "\n");
            //Console.ReadLine();


            // Add in a message that displays when the user selects an index that doesn’t exist.

            string[] stringArray = { "C#", "Java", "HTML", "CSS", "BootStrap" };
            Console.WriteLine("Please type you favorit language i.e. C#, Java, HTML, CSS, BootStrap");

            string value = Convert.ToString(Console.ReadLine());
            int index = Array.IndexOf(stringArray, value);
            if (index > -1)
            {
                Console.WriteLine("{0} Language found in the array at index {1}", value, index + "\n");
            }
            else
            {
                Console.WriteLine("your favorit language not found" + "\n");
            }
            //Console.ReadLine();


            // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen

            Console.WriteLine("select a number from 0-4 to display the value");
            int listInput = Convert.ToInt32(Console.ReadLine());

            List<string> strList = new List<string>();
            strList.Add("C#");
            strList.Add("C++");
            strList.Add("Java");
            strList.Add("HTML");
            strList.Add("CSS");

            Console.WriteLine("Number "+ listInput +" Values is = " + strList[listInput] + "\n");
            Console.ReadLine();
        }
    }
}
