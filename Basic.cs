using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryanMaurya
{
    class SwitchCaseProgram
    {
        static void Main(string[] args)
        {

            int option = 3;
            switch (option)
            {
                // A switch section can have more than one case label. 
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
 
                case 4-1: //can be an expression
                    Console.WriteLine("Case 3");
                    break;
                // If the value of switchExpression is not 0,1,2,3, the 
                // default case is executed. 
                default:
                    Console.WriteLine("Default case (optional)");
                    break;
            }

            //just to keep the console up running
            Console.ReadKey();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;

            Console.Write("Enter first number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("\nBefore Swapping :");
            Console.Write("\nFirst Number = " + number1+ "\nSecond Number = " + number2);

            //logic of swappping two numbers
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("\n\nAfter Swapping : ");
            Console.Write("\nFirst Number = " + number1 + "\nSecond Number = " + number2);

            Console.ReadLine();
        }
    }
}




using System;

namespace AryanMaurya
{
    class HelloWorld
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!!!"); //prints Hello World!!!

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class EvenOddBetweeentheRange
    {
        static void Main(string[] args)
        {
            int start_range, end_range,i;
            Console.Write("Even and odd numbers between the given Range ");

            Console.Write("\nEnter the start value of the range ");
            start_range = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the end value of the range ");
            end_range = int.Parse(Console.ReadLine());

     //logic of finding Even numbers
            Console.Write("\nEven Numbers between the range " + start_range + " - " + end_range + " are \n");
            for(i = start_range; i<= end_range; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
     
     //logic of finding Odd numbers
            Console.Write("\n\nOdd Numbers between the range " + start_range + " - " + end_range + " are \n");
            for (i = start_range; i <= end_range; i++)
            {
            if(i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Read();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AryanMaurya
{
    class ConditionalStatementProgram
    {
        static void Main()
        {
            int number;

            number = 0;

            //normal if
            if (number == 0)
            {
                Console.WriteLine("The number is 0"); //this line will be executed only when the value of the number is 0
            }

            //if else
            if (number < 0)
            {
                Console.WriteLine("The number is less than 0"); //this line will be executed only when the value of the number is less than 0
            }
            else
            {
                Console.WriteLine("The number is greater than or equal to 0");
            }

            //if elseif
            if (number < 0)
            {
                Console.WriteLine("The number is less than 0");
            }
            else if(number >0)
            {
                Console.WriteLine("The number is greater than 0");
            }
            else
            {
                Console.WriteLine("The number is 0");
            }

            //just to keep the console active
            Console.ReadKey();

        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int number1, number2, sum;

            Console.Write("Enter first number : ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number : ");
            number2 = int.Parse(Console.ReadLine());
  
   //logic of adding two numbers
            sum = number1 + number2;

            Console.Write("\nSum of the 2 numbers is : " + sum);

            Console.ReadLine();
        }
    }
}