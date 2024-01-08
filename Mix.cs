using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculator
    {
        static void Main(string[] args)
        {
            float basic_salary, hra, da, pf, gross_salary, income_tax, deduction, net_salary;

            Console.Write("Enter the basic salary : ");
            basic_salary = float.Parse(Console.ReadLine());

            da = basic_salary * 15 / 100;

            hra = basic_salary * 10 / 100;

            pf = basic_salary * 10 / 100;

            income_tax = basic_salary * 10 / 100;
            
            deduction = pf + income_tax;

            gross_salary = basic_salary + da + hra;

            net_salary = gross_salary - deduction;

            Console.Write("\n\nBasic Salary : " + basic_salary);
            Console.Write("\n\nDearness Allowance : " + da);
            Console.Write("\n\nHouse Rent Allowance : " + hra);
            Console.Write("\n\nProvident Fund : " + pf);
            Console.Write("\n\nGross Salary : " + gross_salary);
            Console.Write("\n\nDeduction : " + deduction);
            Console.Write("\n\nNet Salary : " + net_salary);
            Console.ReadLine();
        }
    }
}









using System;

namespace AryanMaurya
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;

            Console.Write("Enter a Year : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y % 100 == 0)
            {
                if (y % 400 == 0)
                {
                    Console.WriteLine("\nThe year is a Leap year");
                }
                else
                {
                    Console.WriteLine("\nThe year is not a Leap year");
                }
            }
            else
            {
                if (y % 4 == 0)
                {
                    Console.WriteLine("\nThe year is a Leap year");
                }
                else
                {
                    Console.WriteLine("\nThe year is not a Leap year");
                }
            }
            Console.ReadLine();
        }
    }
}
using System;

namespace AryanMaurya
{
    class Program
    {
        public static void Main()
        {
            char alphabet;
            char c;

            Console.Write("Enter a Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine());

            c = Char.ToUpper(alphabet);

            if (c.Equals('A') || c.Equals('E') || c.Equals('I') || c.Equals('O') ||
                c.Equals('U'))
            {
                Console.WriteLine("{0} is vowel", alphabet);
            }
            else
            {
                Console.WriteLine("{0} is not vowel", alphabet);
            }

            //This line is to hold the output screen
            Console.Read();
        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int number1, number2;
            float div;

            Console.Write("Enter first number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter your selection: \n1.Addition \n2.Substraction \n3.Multiplication \n4.Division:\n");
            int choose;
            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.Write("Addition of " + number1 + " and " + number2 + " is " + (number1 + number2));
                    break;
                case 2:
                    Console.Write("Subtraction of " + number1 + " and " + number2 + " is " + (number1 - number2));
                    break;
                case 3:
                    Console.Write("Multiplication of " + number1 + " and " + number2 + " is " + (number1 * number2));
                    break;
                case 4:
                    div = ((float)number1) / ((float)number2);
                    Console.Write("Division of " + number1 + " and " + number2 + " is " + div);
                    break;
            }
            Console.ReadLine();
        }
    }
}
