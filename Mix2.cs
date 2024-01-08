using System;

namespace AryanMaurya
{
    class ReverseEachWord
    {
        public static void Main()
        {
            int strLen, i, j;
            string str;
            string reverse = "", temp = "";

            Console.Write("Enter string : ");
            str = Console.ReadLine();

            strLen = str.Length - 1;

            for (i = 0; i <= strLen; i++)
            {
                temp += str[i];

                if ((str[i] == ' ') || (i == strLen))
                {
                    for (j = temp.Length - 1; j >= 0; j--)
                    {
                        reverse += temp[j];
                        if ((j == 0) && (i != strLen))
                            reverse += " ";
                    }
                    temp = "";
                }
            }

            Console.WriteLine("\nReverse of " + str + " :" + reverse);
            Console.ReadKey();
        }
    }
}
using System;

namespace AryanMaurya
{
    class ReverseSentence
    {
        public static void Main()
        {
            Console.Write("Enter sentence : ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');

            Console.WriteLine("\nReverse Sentence : ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace AryanMaurya
{
    class ReverseString
    {
        public static void Main()
        {
            String original, reverse = "";

            Console.Write("Enter a string to reverse : ");
            original = Console.ReadLine();

            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
                reverse = reverse + original[i];

            Console.WriteLine("\nReverse of " + original + " is : " + reverse);

            Console.ReadLine();
        }
    }
}
using System;

namespace AryanMaurya
{
    class RepeatString
    {
        public static void Main()
        {
            int i, n;
            String strName = "";

            Console.Write("Enter your name : ");
            strName = Console.ReadLine();

            Console.Write("\nEnter the number of times you want to print your name : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(strName + " ");
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
using System.Collections;

namespace CreativeCub
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList { "Hello", 10, "World", false, 100, "Good Morning" };
            var onlyStr = al.OfType<string>();
            Console.WriteLine("Printing only strings ->\n");
            foreach (var str in onlyStr)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            String original, reverse = "";

            Console.WriteLine("Enter a string : ");
            original = Console.ReadLine();

            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
                reverse = reverse + original.ElementAt(i);

            if (original.Equals(reverse))
                Console.WriteLine("Entered string is a palindrome.");
            else
                Console.WriteLine("Entered string is not a palindrome.");

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
        public static void Main(string[] args)
        {
            int r, m1, m2, m3, t;
            float p;
            string n;
            Console.Write("Enter Roll Number : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            n = Console.ReadLine();
            Console.Write("Mark of Maths : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark of Science : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark of Grammar : ");
            m3 = Convert.ToInt32(Console.ReadLine());
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine("Total : " + t);
            Console.WriteLine("Percentage : " + p);
            if (p >= 35 && p < 50)
            {
                Console.WriteLine("Grade is C");
            }
            if (p >= 50 && p <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            if (p > 60 && p <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            if (p > 80 && p <= 100)
            {
                Console.WriteLine("Grade is A+");
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

namespace CreativeCub
{
    class Program
    {
        string value, substring;
        int j, i;
        string[] a;
        void input()
        {
            Console.Write("Enter the String : ");
            value = Console.ReadLine();
            a = new string[value.Length];
            Console.WriteLine("All Possible substrings of the given string are :");
            for (i = 1; i <= value.Length; i++)
            {
                for (j = 0; j <= value.Length - i; j++)
                {
                    substring = value.Substring(j, i);
                    a[j] = substring;
                    Console.WriteLine(a[j]);
                }
            }
        }
        public static void Main()
        {
            Program pg = new Program();
            pg.input();
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
        public static void Main()
        {
            string s1 = "Hello";
            string s2 = "World";
            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);
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
        string str;
        public void readdata()
        {
            Console.Write("Enter a String : ");
            str = Console.In.ReadLine();
        }
        public void abbre()
        {
            char[] c, result;
            int j = 0;
            c = new char[str.Length];
            result = new char[str.Length];
            c = str.ToCharArray();
            result[j++] = (char)((int)c[0] ^ 32);
            result[j++] = '.';
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (c[i] == ' ' || c[i] == '\t' || c[i] == '\n')
                {
                    int k = (int)c[i + 1] ^ 32;
                    result[j++] = (char)k;
                    result[j++] = '.';
                }
            }
            Console.Write("The Abbreviation for {0} is ", str);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static void Main()
        {
            Program obj = new Program();
            obj.readdata();
            obj.abbre();
        }
    }
}