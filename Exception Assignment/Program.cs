using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<int> number = new List<int>();
                number.Add(5);
                number.Add(4);
                number.Add(2);

                Console.WriteLine("Enter a number to divid into the list: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int i in number)
                {
                    int result = userNumber / i;
                    Console.WriteLine(result);
                }
            }
            catch (Exception userNumber)
            {
                Console.WriteLine(userNumber.Message);
            }

            Console.ReadLine();
        }
    }
}
