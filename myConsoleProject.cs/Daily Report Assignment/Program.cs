using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("******** Academy of Learning Career College ********");
            Console.WriteLine("*************** Student Daily Report ***************");
            Console.WriteLine("");
            Console.ReadLine();

            Console.WriteLine("What course are you in? ");
            string course = Convert.ToString(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("What Page Number? ");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool help = Convert.ToBoolean(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics. ");
            string experience = Convert.ToString(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific ");
            string feedback = Convert.ToString(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Summary of your question, Please press enter to submit");
            Console.WriteLine("");
            Console.WriteLine("Course Name                 = " + course);
            Console.WriteLine("Page Number                 = " + pageNum);
            Console.WriteLine("Help Required               = " + help);
            Console.WriteLine("Your Positive experience    = " + experience);
            Console.WriteLine("Your Feedback               = " + feedback);
            Console.WriteLine("Number of hours you study   = " + hours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();




            ////string pageNum = "10";
            //Console.WriteLine("Enter Page Number:");
            //var pageNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(pageNum);
            //Console.ReadLine();



            //string pageNumber = "What page number?";
            //Console.ReadLine();
            //int whatPageNum = Convert.ToInt32(pageNumber);
            //Console.WriteLine(whatPageNum);

            //Console.ReadLine();





        }
    }
}
