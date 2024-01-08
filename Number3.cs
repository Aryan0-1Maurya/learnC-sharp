using System;

namespace ProgrammingHub
{
    class UniqueNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            String s = n.ToString(); //converting the number into String form 
            int l = s.Length;

            int flag = 0; /* loop for checking whether there are repeated digits */

            for (int i = 0; i < l - 1; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (s[i] == s[j]) //if any digits match, then we know it is not a Unique Number 
                    {
                        flag = 1; break;
                    }
                }
            }

            if (flag == 0)
                Console.WriteLine("\n" + s + " is a Unique Number");
            else
                Console.WriteLine("\n" + s + " is Not a Unique Number");

            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class TwinPrime
    {
        public static void Main()
        {
            int j = 0;
            int LastPrime = 1;

            Console.WriteLine("Twin Primes between 1 to 100 are : \n");

            for (int i = 1; i < 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (i == j)
                {
                    if ((i - LastPrime) == 2)
                    {
                        Console.WriteLine("(" + (i - 2) + "," + i + ")");
                    }

                    LastPrime = i;
                }
            }
            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class TribonacciSeries
    {
        public static void Main()
        {
            Console.Write("Enter number till u want Tribonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 0, c = 1;
            int d = a + b + c;

            Console.WriteLine("\nTribonacci Series : ");
            Console.Write(a + " " + b + " " + c);

            for (int i = 4; i <= n; i++)
            {
                Console.Write(" " + d);
                a = b;
                b = c;
                c = d;
                d = a + b + c;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class SunnyNumber
    {
        public static void Main()
        {
            int n, n1;
            double x;

            Console.Write("Enter number : ");
            n = Convert.ToInt32(Console.ReadLine());

            n1 = n + 1;
            x = Math.Sqrt(n1);

            if ((int)x == x)
            {
                Console.WriteLine("\n" + n + " is a Sunny Number");
            }
            else
            {
                Console.WriteLine("\n" + n + " is not a Sunny Number");
            }
            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class SquareRoot
    {
        public static void Main()
        {
            int n;

            Console.Write("Enter Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            double sq = Math.Sqrt(n);
            Console.Write("\nSquare root of " + n + " is " + Convert.ToString(Math.Round(sq, 3)));

            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class SpecialNumber
    {
        static int num;

        private void input()
        {
            Console.Write("Enter the Number to check for Special Number : ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        public bool isSpecial(int n)
        {
            int spec = 0, temp = n;

            while (temp % 10 != 0)
            {
                spec += factorial(temp % 10);
                temp /= 10;
            }

            if (spec == n) return true;
            else return false;
        }

        private int factorial(int n)
        {
            if ((n == 1) || (n == 0))
                return 1;
            else
                return (n * factorial(n - 1));
        }

        public static void Main()
        {
            SpecialNumber obj = new SpecialNumber();
            obj.input();

            if (obj.isSpecial(num))
                Console.WriteLine("\n" + num + " is a Special Number");
            else
                Console.WriteLine("\n" + num + " is not a Special Number");

            Console.ReadLine();
        }
    }
}

using System;

namespace ProgrammingHub
{
    class ReverseNumber
    {
        public static void Main()
        {
            int reverse = 0, number = 0;

            Console.Write("Enter number to Reverse : ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number = number / 10;
            }
            Console.WriteLine("\nReverse of a number : " + reverse);

            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class RandomNumber
    {
        public static void Main()
        {
            //Random function to generated random numbers
            Random r = new Random();

            Console.WriteLine("Random number between 0 to 1000 : ");

            //Printing 10 Random number between 0 to 1000
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(r.Next(1000));
            }
            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class PrimorialNumber
    {
        public static void Main()
        {
            int num;

            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            int res = 2, flag = 0;
            String str = "2";

            for (int i = 3; i <= num; i++)
            {
                flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag != 1)
                {
                    res *= i;
                    str = str + " * " + i;
                }
            }
            Console.Write("\n" + num + " = " + str + " = " + res);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersBetweentheRange
{
    class PrimeNumbersBetweentheRange
    {
        static void Main(string[] args)
        {
            int i, j, upper_limit, lower_limit, flag = 1, counter = 0;

            Console.Write("Enter the lower limit of the range : ");
            lower_limit = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the upper limit of the range : ");
            upper_limit = int.Parse(Console.ReadLine());

     //logic of prime number
            Console.Write("\nThe Prime Numbers between the Range " + lower_limit + " - " + upper_limit + " are \n");
            for(i = lower_limit+1; i < upper_limit; i++)
            {
                for(j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        flag = 0;
                        break;
                    }       
                }

                if(flag == 1 && i != 1)
                {
                    Console.Write(i + " ");
                    counter++;
                }
                flag = 1;
            }

            Console.Write("\n\nThe Number of Prime Number between the range " + lower_limit + " - " + upper_limit + " : " + counter);
            Console.Read();
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int n, i, res;
            bool flag = true;

            Console.WriteLine("Please Enter a No.");
            n = int.Parse(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                res = n % i;
                if (res == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine(n + " is Prime Number");
      else
                Console.WriteLine(n + " is not Prime Number");

            Console.ReadLine();
        }
    }
}

using System;

namespace ProgrammingHub
{
    class PrimeFactors
    {
        private bool prime(int a)
        {
            bool b = true;

            for (int i = 2; i <= (a / 2); i++)
            {
                if (a % i == 0)
                    b = false;
            }
            return b;
        }

        public static void Main()
        {
            Console.Write("Enter the Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            PrimeFactors o = new PrimeFactors();

            Console.Write("\nPrime Factors of " + a + " are : ");
            for (int i = 1; i <= (a / 2); i++)
            {
                if (a % i == 0)
                {
                    bool b = o.prime(i);
                    if (b == true)
                        Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}




using System;

namespace ProgrammingHub
{
    class PerfectNumberInRange
    {
        public static void Main()
        {
            int sum;

            Console.Write("Enter the start value of the range : ");
            int strt = int.Parse(Console.ReadLine());

            Console.Write("\nEnter the end value of the range : ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Perfect Numbers between " + strt + " to " + end + " are ");

            for (int n = strt; n <= end; n++)
            {
                sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum = sum + i;
                    }
                }

                if (sum == n)
                {
                    Console.Write(n + " ");
                }
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace ProgrammingHub
{
    class PerfectNumber
    {
        public static void Main()
        {
            int number, sum = 0, n;

            Console.Write("Enter the Number : ");
            number = int.Parse(Console.ReadLine());

            n = number;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine("\n" + number + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine("\n" + number + " is not a Perfect Number");
            }

            Console.ReadLine();
        }
    }
}


