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
            Console.WriteLine("Enter your choice(addition: 1)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                try
                {
                    int a, b;
                    Console.WriteLine("Enter first number: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a+b;
                    Console.WriteLine("Result " + result);
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                    throw;
                }
            }
        }
    }
}
