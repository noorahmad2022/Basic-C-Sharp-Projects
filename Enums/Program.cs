using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        public daysOfTheWeek Day { get; set; }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current Day" + "\n"+"e.g. Monday, Tuesday, Wednesday,Thursday, Friday,Saturday,Sunday");

                string userInput = Console.ReadLine();

                daysOfTheWeek currentDay = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek),userInput);
                Console.WriteLine(currentDay.ToString());
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public enum daysOfTheWeek
        {
            Monday = 14,
            Tuesday = 15,
            Wednesday = 16,
            Thursday = 17,
            Friday = 18,
            Saturday = 13,
            Sunday = 12
        }
    }
}
