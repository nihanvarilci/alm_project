using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String yourname = "Mr. Nice";
            Console.WriteLine("Hello {0}", yourname);
            String x = "welcome to calculator";
            Console.WriteLine("Hello {0}", x);
            Console.WriteLine("ASD");

            double result;
            Console.WriteLine("Enter your choice(addition: 1), (division:  2)");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)
            {
                Console.WriteLine("Enter first number: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double b = Convert.ToInt32(Console.ReadLine());
                result = addition(a,b);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter first number: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                double b = Convert.ToInt32(Console.ReadLine());
                result = division(a, b);
            }

        }
        static double addition(double a, double b)
        {
            double result;
           
            result = a + b;
            Console.WriteLine("Result is  " + result);
            return result;
           
        }
        static double division(double a, double b)
        {
            double result;
            
            result = a / b;
            Console.WriteLine("Result is  " + result);
            return result;           
        }
    }
}
