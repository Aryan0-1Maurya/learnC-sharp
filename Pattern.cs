using System;

namespaceAryanMaurya
{
    class Pyramid
    {
        public static void Main()
        {
            Console.Write("Enter the number of levels of pyramid : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPyramid : ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}






using System;

namespaceAryanMaurya
{
    class BinaryTriangle1
    {
        public static void Main()
        {
            int i, j, k, rows;
            
            Console.Write("Enter the Number of Rows : ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBinary Triangle \n");
            for (i = 1; i <= rows; i++)
            {
                for (k = rows - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                if (i % 2 != 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0 ");
                        }

                        else
                        {
                            Console.Write("1 ");
                        }
                    }
                }

                else if (i % 2 == 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("1 ");
                        }

                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}







using System;

namespaceAryanMaurya
{
    class BinaryTriangle
    {
        public static void Main()
        {
            int p, lastInt = 0, input;

            Console.Write("Enter the Number of Rows : ");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBinary Triangle \n");

            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}