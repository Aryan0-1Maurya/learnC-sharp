using System;

namespace InheritanceExample
{
    public class Box
    {
        public int width;
        public int height;
        public int depth;

        public Box(int w, int h, int d)
        {
            width = w;
            height = h;
            depth = d;
        }

        public void getVolume()
        {
            Console.WriteLine("Volume is : " + width * height * depth);
        }
    }

    public class MatchBox : Box
    {
        public int weight;

        public MatchBox(int w, int h, int d, int m) : base(w, h, d)
        {
            weight = m;
        }

        static void Main(string[] args)
        {
            MatchBox mb1 = new MatchBox(10, 20, 30, 40);

            mb1.getVolume();

            Console.WriteLine("width of MatchBox is " + mb1.width);
            Console.WriteLine("height of MatchBox is " + mb1.height);
            Console.WriteLine("depth of MatchBox is " + mb1.depth);
            Console.WriteLine("weight of MatchBox is " + mb1.weight);

            Console.ReadLine();
        }
    }
}






using System;

namespace AryanMaurya
{
    class FahrenheitToCelsius
    {
        public static void Main()
        {

            double centigrade;
            double fahrenheit;

            Console.Write("Enter temperature in Fahrenheit : ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            centigrade = (fahrenheit - 32) * (5.0 / 9.0);
            Console.WriteLine("\nTemperature in Celsius : {0}", centigrade);

            //This line is to hold the output screen
            Console.Read();
        }
    }
}






using System;

namespace AryanMaurya
{
    class DecimalToBinary
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //Decimal to binary conversion
            Console.WriteLine("\nThe Binary Representation of Decimal Number " + n + 
                " is " + Convert.ToString(n, 2));

            Console.ReadKey();

        }
    }
}






using System;

namespace AryanMaurya
{
    class CubeRoot
    {
        public static void Main()
        {
            double num, res;

            Console.Write("Enter the Number : ");
            num = double.Parse(Console.ReadLine());

            res = Math.Round((Math.Pow(num, (double)1 / 3)),2);

            Console.Write("\nCube Root of " + num + " is " + res);

            Console.ReadLine();
        }
    }
}






using System;

namespace AryanMaurya
{
    class CubeOfNumber
    {
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int cube = number * number * number;

            Console.Write("\nThe cube of " + number + " is " + cube);

            Console.ReadLine();
        }
    }
}






using System;

namespace AryanMaurya
{
    class SecondsToTime
    { 
        public static void Main()
        {
            int seconds;
            int hours;
            int minutes;
            int second;

            Console.Write("Enter time in seconds : ");
            seconds = Convert.ToInt32(Console.ReadLine());

            second = seconds % 60;
            minutes = (seconds / 60) % 60;
            hours = (seconds / 60) / 60;

            Console.WriteLine("\n{0} hours {1} minutes {2} seconds", hours, minutes, 
                second);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}






using System;

namespace AryanMaurya
{
    class InchesToFeet
    {
        public static void Main()
        {
            int inches;
            int feet;
            int inche;

            Console.Write("Enter height in inches : ");
            inches =Convert.ToInt32(Console.ReadLine());

            feet = inches / 12;
            inche = inches % 12;

            Console.WriteLine("\n{0} foot and {1} inche", feet, inche);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}






using System;

namespace AryanMaurya
{
    class CelsiusToFahrenheit
    { 
        public static void Main()
        {
            double centigrade;
            double fahrenheit;

            Console.Write("Enter temperature in centigrade : ");
            centigrade = Convert.ToDouble(Console.ReadLine());

            fahrenheit = 1.8 * centigrade + 32;
            Console.WriteLine("\nTemperature in Fahrenheit : {0}", fahrenheit);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}






using System;

namespace AryanMaurya
{
    class AreaOfTriangle
    {
        public static void Main()
        {
            double area;
            double @base;
            double height;

            Console.Write("Enter base of Triangle : ");
            @base = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter height of Triangle : ");
            height = Convert.ToDouble(Console.ReadLine());

            //area of triangle = (1/2) * base * height
            area = 0.5 * @base * height;
            Console.WriteLine("\nArea of Triangle is {0}", area);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}






using System;

namespace AryanMaurya
{
    class AreaOfSquare
    {
        public static void Main()
        {
            int side, area;

            Console.Write("Enter value of the sides of square : ");
            side = Convert.ToInt32(Console.ReadLine());

            area = side * side;

            Console.WriteLine("\nArea of Square : " + area);
            Console.ReadLine();
        }
    }
}






using System;

namespace AryanMaurya
{
    class AreaOfRectangle
    {
        public static void Main()
        {
            double width = 0;
            double height = 0;

            Console.Write("Enter rectangle height : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("\nEnter rectangle width : ");
            width = double.Parse(Console.ReadLine());

            Console.Write("\nArea of Rectangle : ");
            Console.WriteLine(height * width);

            Console.Read();
        }
    }
}






using System;

namespace AryanMaurya
{
    class Area_Circumference_Circle
    {
        public static void Main()
        {
            double area;
            double circumference;
            double radius;

            Console.Write("Enter radius of circle : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * radius * radius;
            Console.WriteLine("\nArea of Circle is {0}", area);

            circumference = 2 * 3.14 * radius;
            Console.WriteLine("\nCircumference of Circle is {0}", circumference);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}






using System;

namespace AryanMaurya
{
    class AreaOfCircle
    {
        public static void Main()
        {
            double area;
            double radius;

            Console.Write("Enter radius of circle : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * radius * radius;
            Console.WriteLine("\nArea of Circle is {0}", area);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}