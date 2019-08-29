using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuredExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVal = 32;
            object objVal = intVal;
            string strVal;

            try
            {
                strVal = (string)objVal;
                Console.WriteLine(strVal);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("The program is still running!");

            try
            {
                Divide();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);                
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Divide()
        {
            int numerator;
            int denominator;

            Console.WriteLine("Enter the numerator: ");
            numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the denominator: ");
            denominator = Int32.Parse(Console.ReadLine());

            int result;
            try
            {
                result = numerator / denominator;
            }
            catch (Exception e)
            {
                throw new Exception("Division by zero is not permitted, " +
                    "please change the denominator", e.InnerException);
            }

            Console.WriteLine();
            Console.WriteLine("Result = " + result);


        }
    }
}
