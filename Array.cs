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
            int[] arrayA = new int[5];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of ArrayA : {0}", +lengthA);

            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the LongLength Array : {0}", longLength);

            int[,] twoD = new int[5, 10];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections;

namespace ArrayListExample
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            //creating arraylist
            ArrayList al = new ArrayList();

            //adding object in arraylist  
            al.Add("Java");
            al.Add("C");
            al.Add("C++");
            al.Add("php");

            Console.Write("Contents of ArrayList : ");

            //Using Enhance for-loop
            foreach (String str in al)
            {
                Console.Write("\n" + str);
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
        public static void Main()
        {
            int n;
            float large, small;
            int[] a ;

            Console.Write("Enter the size of Array : ");
            string s = Console.ReadLine();

            n = Int32.Parse(s);
            a = new int[n];

            Console.WriteLine("Enter the array elements");

            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

            Console.Write("");

            large = a[0];
            small = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
                else if (a[i] < small)
                    small = a[i];
            }

            Console.WriteLine("Largest element in the array is {0}", large);
            Console.WriteLine("Smallest element in the array is {0}", small);

            Console.Read();

        }
    }
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub
{
    class JaggedArrayProgram
    {
        static void Main()
        {
            // Declare the array of two elements: 
            int[][] jaggedarr = new int[2][];

            // Initialize the elements:
            jaggedarr[0] = new int[4] { 1, 3, 7, 9 };
            jaggedarr[1] = new int[5] { 2, 4, 6, 8,7};

            // Display the array elements: 
            for (int i = 0; i < jaggedarr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedarr[i][j], j == (jaggedarr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.ReadKey();
        }
    }
}




using System;

namespace Matrix_Addition
{
    class MatrixAddition
    {
        static void Main(string[] args)
        {
            int m, n, i, j;

            Console.WriteLine("Enter number of rows and columns of the matrix : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[m, n];

            Console.WriteLine("Enter the First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] B = new int[m, n];

            Console.WriteLine("Enter the Second Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Second Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
        }

            Console.WriteLine("Matrix Multiplication :");
            int[,] c = new int[row, n];
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}



// using System;

// namespace MatrixMultiplication
// {
//     class MatrixMultiplication
//     {
//         static void Main(string[] args)
//         {
//             int i, j, row, col;

//             Console.WriteLine("Enter the Number of Rows and Columns for First Matrix : ");
//             row = Convert.ToInt32(Console.ReadLine());
//             col = Convert.ToInt32(Console.ReadLine());

//             int[,] a = new int[row, col];

//             Console.WriteLine("Enter the First Matrix : ");
//             for (i = 0; i < row; i++)
//             {
//                 for (j = 0; j < col; j++)
//                 {
//                     a[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }

//             Console.WriteLine("First matrix :");
//             for (i = 0; i < row; i++)
//             {
//                 for (j = 0; j < col; j++)
//                 {
//                     Console.Write(a[i, j] + "\t");
//                 }
//                 Console.WriteLine();
//             }

//             Console.WriteLine("Enter the Number of Rows and Columns for Second Matrix : ");
//             int m = Convert.ToInt32(Console.ReadLine());
//             int n = Convert.ToInt32(Console.ReadLine());

//             int[,] b = new int[m, n];

//             Console.WriteLine("Enter the Second Matrix : ");
//             for (i = 0; i < m; i++)
//             {
//                 for (j = 0; j < n; j++)
//                 {
//                     b[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }

//             Console.WriteLine()
using System;

namespace ProgrammingHub
{
    class Matrix_Subtraction
    {
        static void Main(string[] args)
        {
            int m, n, i, j;

            Console.WriteLine("Enter number of rows and columns of the matrix : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[m, n];

            Console.WriteLine("Enter the First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] B = new int[m, n];

            Console.WriteLine("Enter The Second Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Second Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
     }

            int[,] C = new int[m, n];

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }

            Console.WriteLine("Matrix Subtraction :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
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
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original Array : ");

            foreach (int a in array)
                Console.WriteLine(a);

            Array.Reverse(array);

            Console.WriteLine("Reversed Array : ");

            foreach (int value in array)
                Console.WriteLine(value);

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
            List<string> names = new List<string>();
            names.Add("Ram");
            names.Add("Rose");
            names.Add("Abs");
            names.Add("Edward");
            names.Add("Sita");

            Console.WriteLine("Array without sorting..");

            foreach (string s in names)
                Console.WriteLine(s);
            names.Sort();

            Console.WriteLine("\nArray after sorting..");
            foreach (string s in names)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}




using System;
using System.Collections.Generic;

namespace ProgrammingHub
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] a ;
            int size;

            Console.Write("Enter the size of array : ");
            size = int.Parse(Console.ReadLine());

            a = new int[size];

            Console.Write("\nEnter the elements of array : ");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nBefore Sorting, Elements of array is : \n");
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }

            int temp = 0;

            for (int write = 0; write < size; write++) //outer loop iterates n times(n is the length of the array)
            {
                for (int sort = 0; sort < size - 1; sort++) //inner loop will iterate n-1 times
                {
                    if (a[sort] < a[sort + 1]) //logic: if the LHS value is greater than RHS then swap the value
                    {
                        //swap logic
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                 }
            }

            //print the sorted array on console
            Console.Write("\n\nAfter Sorting, Elements of array in descending order is : \n");
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");
            
            //keeps the console open till any key is entered
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class TwoDimensionalArray
    {
        static void Main(string[] args)
        {
            //Declaring the two dimensional array
            int[,] array;
            int row, column;

            Console.WriteLine("Enter the row value : ");
            row = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the column value : ");
            column = int.Parse(Console.ReadLine());

            array = new int[row, column];

            //initializing the two dimensional array
            Console.WriteLine("\nEnter the elements of 2d array : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Accessing the elements of two dimensional array
            Console.WriteLine("\nThe elements of 2d array are : ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}