using System;

namespace AryanMaurya
{
    class AdamNumbers
    {
        int CountNumberOfDigits(int n)
        {
            int numdgits = 0;
            do
            {
                n = n / 10;
                numdgits++;
            }
            while (n > 0);
            return numdgits;
        }

        int ReverseNumber(int n)
        {
            int i = 0, result = 0;
            int numdigits = CountNumberOfDigits(n);

            for (i = 0; i < numdigits; i++)
            {
                result *= 10;
                result += n % 10;
                n = n / 10;
            }

            return result;
        }

        static void Main(string[] args)
        {
            AdamNumbers an = new AdamNumbers();

            int i, n, rn;
            int sn, rsn, rrsn;Console.Write("Enter the minimum number of range : ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter the maximum number of range : ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Adam Numbers between the range " + s + 
                " to " + e + " : ");

            for (i = s; i < e; i++)
            {
                n = i;
                rn = an.ReverseNumber(i);

                if (n == rn)
                    continue;

                sn = n * n;
                rsn = rn * rn;
                rrsn = an.ReverseNumber(rsn);

                if (rrsn == sn)
                {
                    Console.Write("{0} ", n);
                }
            }
            Console.ReadKey();
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
            int number, remainder, sum = 0;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;

            }
            if (sum == number)
            {
                Console.Write("Entered Number is an Armstrong Number.");
            }
            else
                Console.Write("Entered Number is not an Armstrong Number.");
            Console.ReadLine();
        }

    }
}









using System;

namespace AryanMaurya
{
    class AutomorphicNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            int square = input * input;

            String inputAsString = input + "";
            String squareAsString = square + "";

            if (squareAsString.EndsWith(inputAsString))
            {
                Console.WriteLine("\n"+input + " is an Automorphic Number");
            }
            else
            {
                Console.WriteLine("\n"+input + " is not an Automorphic Number");
            }
            Console.ReadKey();
        }
    }
}









using System;

namespace AryanMaurya
{
    class PositiveNegativeZero
    {
        public static void Main()
        {
            int num;
            Console.Write("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else if (num == 0)
            {
                Console.WriteLine("Zero");
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

namespace CreativeCub
{
    class Program
    {
        public static void Main(String[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0, i;
            Console.Write("Enter First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for (i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (num1 == sum2 && num2 == sum1)
            {
                Console.WriteLine("They are a Pair of Amicable Numbers");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("They are not Amicable Numbers");
                Console.ReadLine();
            }
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
        public static void Main(String[] args)
        {
            Console.Write("Enter a number to convert to words : ");
            Double n = Double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", NumWordsWrapper(n));
            Console.Read();
        }
        static String NumWordsWrapper(double n)
        {
            string words = "";
            double intPart;
            double decPart = 0;
            if (n == 0)
                return "zero";
            try {
                string[] splitter = n.ToString().Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = double.Parse(splitter[1]);
            } catch {
                intPart = n;
            }

            words = NumWords(intPart);

            if (decPart > 0) {
                if (words != "")
                    words += " and ";
                int counter = decPart.ToString().Length;
                switch (counter) {
                    case 1: words += NumWords(decPart) + " tenths"; break;
                    case 2: words += NumWords(decPart) + " hundredths"; break;
                    case 3: words += NumWords(decPart) + " thousandths"; break;
                    case 4: words += NumWords(decPart) + " ten-thousandths"; break;
                    case 5: words += NumWords(dePart) + " hundred-thousandths"; break;
                    case 6: words += NumWords(decPart) + " millionths"; break;
                    case 7: words += NumWords(decPart) + " ten-millionths"; break;
                }
            }
            return words;
        }

        static String NumWords(double n) //converts double to words
        {
            string[] numbersArr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensArr = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] suffixesArr = new string[] { "thousand", "million", "billion", "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion", "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion", "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion", "Octodecillion", "Novemdecillion", "Vigintillion" };
            string words = "";bool tens = false;

            if (n < 0) {
                words += "negative ";
                n *= -1;
            }

            int power = (suffixesArr.Length + 1) * 3;

            while (power > 3) {
                double pow = Math.Pow(10, power);
                if (n >= pow) {
                    if (n % pow > 0) {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1] + ", ";
                    } else if (n % pow == 0) {
                        words += NumWords(Math.Floor(n / pow)) + " " + suffixesArr[(power / 3) - 1];
                    }
                    n %= pow;
                }
                power -= 3;
            }
            if (n >= 1000) {
                if (n % 1000 > 0) words += NumWords(Math.Floor(n / 1000)) + " thousand, ";
                else words += NumWords(Math.Floor(n / 1000)) + " thousand";
                n %= 1000;
            }
            if (0 <= n && n <= 999) {
                if ((int)n / 100 > 0) {
                    words += NumWords(Math.Floor(n / 100)) + " hundred";
                    n %= 100;}
                if ((int)n / 10 > 1) {
                    if (words != "")
                        words += " ";
                    words += tensArr[(int)n / 10 - 2];
                    tens = true;
                    n %= 10;
                }

                if (n < 20 && n > 0) {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? "-" + numbersArr[(int)n - 1] : numbersArr[(int)n - 1]);
                    n -= Math.Floor(n);
                }
            }

            return words;

        }
    }
}





