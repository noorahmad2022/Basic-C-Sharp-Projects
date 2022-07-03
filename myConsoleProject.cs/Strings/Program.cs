using System;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

// escape sequences

        // using quotes in strings
            string name = "Noorahmad";
            string quote = "The man said \"Hello\", Noorahmad.";    // use "" in string
            Console.WriteLine(quote);
            Console.ReadLine();

            string newline = "Hello \n Noorahmad Noor \n Good Monrning."; //use new line in string
            Console.WriteLine(newline);
            Console.ReadLine();

            string tab = "Customer Name \n First Name \t Noorahmad \n Last Name \t Noor "; //use tab in string
            Console.WriteLine(tab);
            Console.ReadLine();

            string filePath = "C:\\Users\\Noorahmad\\Desktop "; //use back slush \ in string
            Console.WriteLine(filePath);
            Console.ReadLine();

            //OR

            string filePath1 = @"C:\Users\Noorahmad\Desktop "; //Tell the C# after @ is all a part of string.
            Console.WriteLine(filePath1);
            Console.ReadLine();

            bool trueOrfalse = name.Contains("Noor"); //string contain a letter
            bool trueOrfalse1 = name.EndsWith("no"); //string end with a letter
            Console.WriteLine(trueOrfalse);
            Console.WriteLine(trueOrfalse1);

            Console.ReadLine();

            int length = name.Length;
            Console.WriteLine("Name = " + length +" Charectors"); //count the letters in string
            Console.ReadLine();

            name = name.ToUpper();
            Console.WriteLine(name); //convert string to Upper Case
            Console.ReadLine();

            StringBuilder sb = new StringBuilder(); //this is a string class, if we have big program it best practice to use this becuase it will not overhead the memory if your string is changable. and not change the string value.
            sb.Append("My name is Noorahmad");
            Console.WriteLine(sb); 
            Console.ReadLine();

            sb.Append("My name is Noorahmad Noor");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
