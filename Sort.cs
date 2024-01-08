using System;
using System.Collections.Generic;

namespace AryanMaurya
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 120,23,453,123,2446,2324,5,77,4646,12 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++) //outer loop iterates n times(n is the length of the array)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++) //inner loop will iterate n-1 times
                {
                    if (arr[sort] > arr[sort + 1]) //logic: if the LHS value is greater than RHS then swap the value
                    {
                        //swap logic
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            //print the sorted array on console
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            //keeps the console open till any key is entered
            Console.ReadKey();
        }
    }
}





using System;
using System.Collections.Generic;


namespace AryanMaurya
{
    class HeapSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        public static void HeapSort(int[] input)
        {
            //an unordered array input of length heapSize
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                //Build the heap in array a input that largest value is at the root
                MaxHeap(input, heapSize, p);
            // (The following loop maintains the invariants that input[0:end] is a heap and every element
            // beyond end is greater than everything before it (so input[end:count] is in sorted order))
            for (int i = input.Length - 1; i > 0; i--)
            {
                //(input[0] is the root and largest value. The swap moves it in front of the sorted elements.)
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;
                //(the heap size is reduced by one)
                heapSize--;
                //(the swap ruined the heap property, so restore it)
                MaxHeap(input, heapSize, 0);
            }
        }

        private static void MaxHeap(int[] input, int heapSize, int index)
        {
            print(input);
            int left = (index + 1) * 2 - 1; 
            int right = (index + 1) * 2;
            int largest =0;
            //(The largest holds the largest element. Since we assume the heaps rooted at the
            // children are valid, this means that we are done.)
            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;
                //(repeat to continue sifting down the child now)
                MaxHeap(input, heapSize, largest);
            }

            
        }

        //function to print the array
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
int[] arr = { 5,7,3,4,1};

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            //invokation of static function within the same class needs not object reference or class name
            HeapSort(arr);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}

using System;

namespace AryanMaurya
{
    class InsertionSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        static void InsertionSort(int[] input)
        {
            //The outer loop runs over all the elements except the first one because the single-element prefix input[0:1]
            //is trivially sorted,so the invariant that the first i+1 entries are sorted is true from the start. 
            for (int i = 0; i < input.Length - 1; i++)
            {
                //The inner loop moves element input[i] to its correct place so that after the loop,
                //the first i+2 elements are sorted.
                for (int j = i + 1; j > 0; j--)
                {
                    if (input[j - 1] > input[j])
                    {
                        int temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                }
                print(input);
            }
            
        }

        //function to print the array
public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 5, 7, 3, 4, 1 };

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            //invokation of static function within the same class needs not object reference or class name
            InsertionSort(arr);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}





using System;

namespace AryanMaurya
{
    class MergeSortProgram
    {
        //static function-functions that are invoked without creating an object of the class
        public static void MergeSort(int[] input, int left, int right) //left- begin index right- end index
        {
            print(input);
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle); // split / merge left half
                MergeSort(input, middle + 1, right); // split / merge right half

                // merge the two half runs
                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                // While there are elements in the left or right runs
                for (int k = left; k < right + 1; k++)
                {
                    // If left run head exists and is <= existing right run head.
                    if (i == leftArray.Length)
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
              }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        } 

        //function to print the array
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 5, 7, 3, 4, 1 };

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            //invokation of static function within the same class needs not object reference or class name
            MergeSort(arr,0,arr.Length-1);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}





using System;

namespace AryanMaurya
{
    class QuickSortProgram
    {
        public static void QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(input, left, right);
                QuickSort(input, left, q - 1);
                QuickSort(input, q + 1, right);
            }
        }

        private static int Partition(int[] input, int left, int right)
        {
            print(input);
            // put the chosen pivot at input[right]
            int pivot = input[right];
            int temp;

            int i = left;
            // Compare remaining array elements against pivot = input[right]
            for (int j = left; j < right; j++)
            {
                // Move pivot to its final place
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        //function to print the array
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //input array initialization that needs that needs to be sorted
            int[] arr = { 5, 7, 3, 4, 1 };

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            selectionSort(arr);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}





using System;

namespace AryanMaurya
{
    class ShellSortProgram
    {
        static void shellSort(int[] input, int array_size)
        {
            int i, j, increment, temp;
            increment = 3;
            // Start with the largest gap and work down to a gap of 1 
            while (increment > 0)
            {
                print(input);
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = input[i];
                   // shift earlier gap-sorted elements up until the correct location for input[i] is found
                    while ((j >= increment) && (input[j - increment] > temp))
                    {
                        input[j] = input[j - increment];
                        j = j - increment;
                    }
                    //put temp (the original input[i]) in its correct location
                    input[j] = temp;
                }
                if (increment / 2 != 0)
                    increment = increment / 2;
                else if (increment == 1)
                    increment = 0;
                else
                    increment = 1;
            }
        }


public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //input array initialization that needs to be sorted
            int[] arr = { 5, 7, 3, 4, 1 };

            Console.WriteLine("Before Sorting");
            print(arr);
            Console.WriteLine("Sorting Process starts:");
            shellSort(arr,arr.Length);
            Console.WriteLine("Sorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);
            //keeps the console open till any key is entered
            Console.ReadKey();

        }
    }
}