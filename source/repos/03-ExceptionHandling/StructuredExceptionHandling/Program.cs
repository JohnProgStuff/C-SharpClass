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
            catch (Exception e)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("the program is still running");

            try
            {
                Divide();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Divide()
        {
            int numerator;
            int denominator;

            
            Console.Write("Enter a numerator: ");
            numerator = Int32.Parse(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Enter a denominator ");
            denominator = Int32.Parse(Console.ReadLine());
            int result;
            try
            { 
                result = numerator / denominator;

                //Console.WriteLine();
                Console.WriteLine("Result = " + result);
            }
            catch(Exception e)
            {
                throw new Exception("Division by zero is not permitted, " +
                    "please change the denominator.", e.InnerException);
            }
           

        }
    }
}
