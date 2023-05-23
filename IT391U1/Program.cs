using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IT391U1
{
    class Assignment
    {
        static void Main(string[] args)
        {
            //*********************************************************
            //****Assignment 1, Section 1
            //*********************************************************
            Console.WriteLine();
            Console.WriteLine("********** Section 1 **********");
            Console.WriteLine();
            Console.Write("The Fibonacci value of 10 is: ");
            Console.WriteLine(fibonacci(10));
            Console.WriteLine();

            //*********************************************************
            //****Assignment 1, Section 2
            //*********************************************************

            Console.WriteLine();
            Console.WriteLine("********** Section 2 **********");
            Console.WriteLine();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Factorial of {0}! = {1}", i, factorial(i));
            }
            Console.WriteLine();
        }

        //Fibonacci method
        public static int fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return fibonacci(number - 1) + fibonacci(number - 2);
        }

        //Factorial Method
        public static int factorial(int n)
        {
            if (n <= 0)
                return 1;
            else 
                return n * factorial(n - 1);
        }
    }
}