using System;

namespace ProgrammingHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base value : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the exponent(power) value : ");
            int exp = Convert.ToInt32(Console.ReadLine());

            double x = Power(number, exp);
            Console.WriteLine("\nThe value of " + number + " raised to the power " + exp + " is : " + x);

            Console.ReadLine();
        }

        internal static double Power(double @base, int exponent)
        {
            if (exponent < 0)
            {
                Console.Error.WriteLine("Usage of this function is limited to positive exponents only");
                throw new Exception();
            }
            else if (exponent == 1)
            {
                return @base;
            }
            else if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return @base * Power(@base, exponent - 1);
            }
        }
    }
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x < 10)
            {
                Console.WriteLine("value of x : " + x);
                x++;
            }
            Console.ReadLine();
        }
    }
}






using System;

namespace ForEachLoop
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (int a in intArray)
            {
                Console.WriteLine(a + " ");
            }
            Console.ReadLine();
        }
    }
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            //For loop
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("value of i : " + i);
            }
            Console.ReadLine();
        }
    }
}






using System;

namespace Do_WhileLoop
{
    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine("value of x : " + x);
                x++;
            } while (x < 10);

            Console.ReadLine();
        }
    }
}






using System;

namespace ProgrammingHub
{
    class Arithmetic_Operations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSum : " + (a + b));
            Console.WriteLine("Difference : " + (a - b));
            Console.WriteLine("Product : " + (a * b));
            Console.WriteLine("Quotient : " + (a / b));
            Console.WriteLine("Integer Quotient : " + (a / b));
            Console.WriteLine("Remainder : " + (a % b));
            Console.WriteLine("Exponent : " + Math.Pow(a, b));

            Console.Read();
        }
    }
}
