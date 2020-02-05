using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string avg = "The avgerage is: ";
            (int[] arrayA, _, _) = InitArrays();
            (_, int[] arrayB, _) = InitArrays();
            (_, _, int[] arrayC) = InitArrays();
            Console.WriteLine($"{avg}{Problem1(arrayA)}");
            Console.WriteLine($"{avg}{Problem1(arrayB)}");
            Console.WriteLine($"{avg}{Problem1(arrayC)}");
            Console.WriteLine("==============================");
            Problem2(arrayA);
            Problem2(arrayB);
            Problem2(arrayC);
            Console.WriteLine("==============================");
            Array.Reverse(arrayA);
            Array.Reverse(arrayB);
            Array.Reverse(arrayC);
            Problem3(arrayA);
            Problem3(arrayB);
            Problem3(arrayC);
            Console.WriteLine("==============================");
            Problem4(arrayA);
            Problem4(arrayB);
            Problem4(arrayC);
        }

        public static (int[], int[], int[]) InitArrays()
        {
            int[] arrayA = new int[] { 0, 2, 4, 6, 8, 10};
            int[] arrayB = new int[] { 1, 3, 5, 7, 9};
            int[] arrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};
            return (arrayA, arrayB, arrayC);
        }

        public static double Problem1(int[] array)
        {
            int arrayLength = array.Length;
            int sum = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }
            double avg = sum / array.Length;
            return avg;
        }

        public static void Problem2(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void Problem3(int[] array)
        {
            Console.Write("To the right or left (R/L): ");
            string param1 = Console.ReadLine();
            Console.Write("How many places? ");
            int param2 = int.Parse(Console.ReadLine());
            int lastElement;
            _ = new int[array.Length];
            _ = new List<int>();

            if (param1 == "R")
            { 
                for (int i = 1; i < param2 + 1; i++)
                {

                    lastElement = array[^1];
                    int[] newArray = array.Take(array.Length - 1).ToArray();
                    List<int> listOfNumbers = newArray.ToList<int>();
                    listOfNumbers.Insert(0, lastElement);

                    array = listOfNumbers.ToArray();
                }
            }
            else if (param1 == "L")
            {
                for(int i = 1; i < param2 - 1; i++)
                {

                    lastElement = array[array.Length + 1];
                    int[] newArray = array.Take(array.Length + 1).ToArray();
                    List<int> listOfNumbers = newArray.ToList<int>();
                    listOfNumbers.Insert(0, lastElement);

                    array = listOfNumbers.ToArray();
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void Problem4(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
