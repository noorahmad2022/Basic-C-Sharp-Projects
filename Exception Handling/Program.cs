using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two number now");
                int result = numberOne / numberTwo;
                Console.WriteLine(numberOne + " Divided by "+ numberTwo + " is equal to: " + result);
                Console.ReadLine();

            }
            catch(FormatException ex)
            {
                //Console.WriteLine(ex.ToString());
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a number ");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divid by Zero");

            }
            catch(Exception ex)  //this is for all other error or General Exception
            {
                Console.WriteLine(ex.Message);
            }
            finally // in Try Catch statement, the Finally Block typically keep the database log, and will alway run.
            {
                Console.ReadLine();
            }
            
        }
    }
}
