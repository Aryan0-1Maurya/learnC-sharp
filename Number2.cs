using System;

namespace AryanMaurya
{
    class DisariumNumber
    {
        public void show(int n)
        {
            int c = 1, rev, sum, x;
            x = n;
            sum = 0;
            rev = 0;

            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n = n / 10;
            }

            while (rev > 0)
            {
                sum = sum + (int)Math.Pow(rev % 10, c);
                c++;
                rev = rev / 10;
            }

            if (sum == x)
                Console.WriteLine("\n"+x + " is DISARIUM number");
            else
                Console.WriteLine("\n"+x + " is not DISARIUM number");
        }

        public static void Main()
        {
            Console.Write("Enter number to check its DISARIUM no. or not : ");

            DisariumNumber ob = new DisariumNumber();
            ob.show(int.Parse(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}








using System;

namespace AryanMaurya
{
    class FloorExample
    {
        public static void Main()
        {
            //Using Math.Floor 
            Console.WriteLine("Floor value of 50.0: " + Math.Floor(50.0));
            Console.WriteLine("Floor value of 23.8: " + Math.Floor(23.8));
            Console.WriteLine("Floor value of -46.5: " + Math.Floor(-46.5));

            Console.ReadKey();
        }
    }
}








using System;

namespace AryanMaurya
{
    class PerfectSquare
    {
        public static void Main()
        {
            int start, end, n, sum = 0;
            float s;

            Console.Write("Enter starting value of the range : ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter ending value of the range : ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Perfect Square numbers present in the range " + start + " to " + end + " are : ");

            for (int i = start; i < end; i++)
            {
                s = (float)Math.Sqrt(i);
                n = (int)Math.Floor(s);

                if (s == n)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine("\n\nSum of the perfect square numbers between the range " + start + " to " + end + " are : " + sum);

            Console.ReadLine();
        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
                Console.Write(i+" is an Even Number");
            else
                Console.Write(i+" is an Odd Number");

            Console.Read();
        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
       public static void Main(string[] args)
        {

            Console.Write("Enter the limit : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, number);
            Console.Read();
        }
        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
        public static void Main()
        {
            int n;
            int a = 0;
            int b = 1;

            Console.Write("Enter the limit : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
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

namespace CreativeCub
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = GetFactorial(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
            Console.ReadKey();
        }

        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.Write("Enter the Number : ");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();

        }
    }
}








using System;

namespace AryanMaurya
{
    class DuckNumber
    {
        public static void Main()
        {
            Console.Write("Enter any number : ");
            String n = Console.ReadLine();

            int l = n.Length;
            int c = 0;
            char ch;

            for (int i = 1; i < l; i++)
            {
                ch = n[i];
                if (ch == '0')
                    c++;
            }

            char f = n[0];

            if (c > 0 && f != '0')
                Console.WriteLine("\n" + n + " is a duck number");
            else
                Console.WriteLine("\n" + n + " is not a duck number");

            Console.ReadKey();
        }
    }
}








using System;

namespace AryanMaurya
{
    class NivenNumber
    {
        static void Main(string[] args)
        {
            int c, d, sum = 0;

            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            c = n;

            //finding sum of digits
            while (c > 0)
            {
                d = c % 10;
                sum = sum + d;
                c = c / 10;
            }

            if (n % sum == 0)
                Console.WriteLine("\n" + n + " is a Niven Number.");
            else
                Console.WriteLine("\n" + n + " is not a Niven Number.");

            Console.ReadKey();
        }
    }
}

using System;

namespace AryanMaurya
{
    class NeonNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int square = num * num;

            int sum = 0;

            while (square != 0)//Loop to find the sum of digits.
            {
                int a = square % 10;
                sum = sum + a;
                square = square / 10;
            }

            if (sum == num)
            {
                Console.WriteLine("\n" + num + " is a Neon Number.");
            }
            else
            {
                Console.WriteLine("\n" + num + " is not a Neon Number.");
            }

            Console.ReadLine();
        }
    }
}








using System;

namespace AryanMaurya
{
    class MagicNumber
    {
        private int input()
        {
            Console.Write("Enter a number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public bool isMagic(int n)
        {
            int sum = 0, flag;
            do
            {
                flag = 0;

                while (n % 10 == 0)
                    n /= 10;

                while (n % 10 != 0 || n > 0)
                {
                    sum += (n % 10);
                    n /= 10;
                }

                if (sum >= 10)
                {
                    n = sum;
                    sum = 0;
                }

                else
                    flag = 1;
            } while (flag == 0);

            if (sum == 1)
                return true;
            else
                return false;
        }

        public static void Main()
        {
            MagicNumber mn = new MagicNumber();
            int num = mn.input();

            if (mn.isMagic(num))
                Console.WriteLine("\n" + num + " is a Magic Number");
            else
                Console.WriteLine("\n" + num + " is not a Magic Number");

            Console.ReadLine();
        }
    }
}








using System;

namespace AryanMaurya
{
    class LucasSeries
    {
        public static void Main()
        {
            int num1, num2, limit, add;

            Console.Write("Enter the limit of the series : ");
            limit = Convert.ToInt32(Console.ReadLine());

            num1 = 2;
            num2 = 1;

            Console.WriteLine("\nLucas Series:");

            while (limit >= num1)
            {
                Console.Write(num1 + " ");

                add = num1 + num2;
                num1 = num2;
                num2 = add;
            }
            Console.ReadLine();
        }
    }
}








using System;

namespace AryanMaurya
{
    class KrishnaMurthyNumber
    {
        int fact(int n)
        {
            int i, fact = 1;

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static void Main()
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            KrishnaMurthyNumber kmn = new KrishnaMurthyNumber();

            if (kmn.isKrishnaMurthy(number))
            {
                Console.WriteLine("\n" + number + " is a Krishna Murthy Number");
            }

            else
            {
                Console.WriteLine("\n" + number + " is not a Krishna Murthy Number");
            }

            Console.ReadLine();
        }

        bool isKrishnaMurthy(int number)
        {
            int temp, k = 0;
            int n = number;

            while (number > 0)
            {
                temp = number % 10;
                k = k + fact(temp);
                number = number / 10;
            }

            if (k == n)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}








using System;

namespace AryanMaurya
{
    class KeithNumber
    {
        public static void Main()
        {
            int i;

            Console.Write("Enter the number : ");

            int n = Convert.ToInt32(Console.ReadLine());

            int copy = n;
            String s = n.ToString();

            //finding the number of digits (d) in the number
            int d = s.Length;

            //array for storing the terms of the series
            int[] arr = new int[n];

            for (i = d - 1; i >= 0; i--)
            {
                //storing the digits of the number in the array
                arr[i] = copy % 10;
                copy = copy / 10;
            }

            i = d;
            int sum = 0;

            //finding the sum till it is less than the number
            while (sum < n)
            {
                sum = 0;

                //loop for generating and adding the previous 'd' terms
                for (int j = 1; j <= d; j++)
                {
                    sum = sum + arr[i - j];
                }

                //storing the sum in the array
                arr[i] = sum;
                i++;
            }

            //if sum is equal to the number, then it is a Keith number
            if (sum == n)
                Console.WriteLine("\n" + n + " is a Keith Number");
            else
                Console.WriteLine("\n" + n + " is a not a Keith Number");

            Console.ReadLine();
        }
    }
}








using System;

namespace AryanMaurya
{
    class KaprekarNumber
    {
        int digitcount(int x)
        {
            int digit = 0;

            while (x != 0)
            {
                digit++;
                x /= 10;
            }
            return digit;
        }

        public static void Main()
        {
            int n, quo, rem, sq, temp;
            int digits;

            KaprekarNumber ob = new KaprekarNumber();

            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());

            sq = n * n;

            digits = ob.digitcount(n * n);

            quo = sq / (int)Math.Pow(10, digits / 2);
            rem = sq % (int)Math.Pow(10, digits / 2);

            temp = quo + rem;

            if (temp == n)
                Console.WriteLine("\n" + n + " is a Kaprekar Number \n");
            else
                Console.WriteLine("\n" + n + " is not a kaprekar Number");

            Console.ReadLine();
        }
    }
}








using System;

namespace AryanMaurya
{
    class HappyNumber
    {
        int n;
        HappyNumber()
        {
            n = 0;
        }

        void getnum(int num)
        {
            n = num;
        }

        int sum_sq_digits(int x)
        {
            if (x == 0)
                return 0;
            else
            {
                int d = x % 10;
                return (d * d + sum_sq_digits(x / 10));
            }
        }

        void isHappyNumber()
        {
            int a = sum_sq_digits(n);
            while (a > 9)
            {
                a = sum_sq_digits(a);
            }
            if (a == 1)
                Console.WriteLine("\n" + n + " is a Happy Number");
            else
                Console.WriteLine("\n" + n + " is not a Happy Number");
        }

        public static void Main()
        {
            HappyNumber ob = new HappyNumber();

            Console.Write("Enter any number : ");
            int b = int.Parse(Console.ReadLine());

            ob.getnum(b);
            ob.isHappyNumber();

            Console.ReadLine();
        }
    }
}

using System;

namespace AryanMaurya
{
    class GreatestNumber
    {
        public static void Main()
        {
            int num, i, temp, max;

            // Reading numbers want to be read
            Console.Write("Enter the range : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter " + num + " number : ");
            // Reading 1st number
            max = Convert.ToInt32(Console.ReadLine());

            // Reading other number
            for (i = 1; i < num; i++)
            {
                temp = Convert.ToInt32(Console.ReadLine());
                if (temp < max)
                    continue;
                else
                    // largest number
                    max = temp;
            }

            Console.WriteLine("\nLargest Number is " + max);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConverter
{
    class BaseConverter
    {
        static void Main(string[] args)
        {
            int convertnumber;
            string val;
            char ch ='y';

            Console.WriteLine("Menu \n\n1.Convert Decimal to Binary,Octal,Hexadecimal \n\n2.Convert Binary to Decimal,Octal,Hexadecimal \n\n3.Convert Octal to Decimal,Binary,Hexadecimal \n\n4.Convert Hexadecimal to Decimal,Binary,Octal");
            
            while (ch != 'n')
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:

                        Console.WriteLine("\nEnter Decimal Number : ");
                        String deci = Console.ReadLine();

                        //Decimal to binary
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Decimal to octal
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Octal : " + Convert.ToString(convertnumber, 8));

                        //Decimal to Hexadecimal
                        convertnumber = Convert.ToInt32(deci, 10);
                        Console.WriteLine("\nDecimal to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;

                    case 2:

                        Console.WriteLine("\nEnter Binary Number : ");
                        val = Console.ReadLine();

                        //Binary to Decimal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Decimal : " + Convert.ToString(convertnumber, 10));
case 3:

                        Console.WriteLine("\nEnter Octal Number : ");
                        String oct = Console.ReadLine();

                        //Octal to Decimal
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Decimal : " + Convert.ToString(convertnumber, 10));

                        //Octal to Binary
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Octal to Hexadecimal
                        convertnumber = Convert.ToInt32(oct, 8);
                        Console.WriteLine("\nOctal to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;

                    case 4:

                        Console.WriteLine("\nEnter Hexadecimal Number : ");
                        String hexa = Console.ReadLine();

                        //Hexadecimal to Decimal
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Decimal : " +
                        //Binary to Octal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Octal : " + Convert.ToString(convertnumber, 8));

                        //Binary to Hexadecimal
                        convertnumber = Convert.ToInt32(val, 2);
                        Console.WriteLine("\nBinary to Hexadecimal : " + Convert.ToString(convertnumber, 16));

                        break;Convert.ToString(convertnumber, 10));

                        //Hexadecimal to Binary
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Binary : " + Convert.ToString(convertnumber, 2));

                        //Hexadecimal to Octal
                        convertnumber = Convert.ToInt32(hexa, 16);
                        Console.WriteLine("\nHexadecimal to Octal : " + Convert.ToString(convertnumber, 8));

                        break;
                }

                Console.WriteLine("\nDo you want to continue y or n");
                ch = char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}






