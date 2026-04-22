using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializing the variables
            Console.Write("Enter the array length : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[n];

            Console.WriteLine("Enter the Array elements");
            for(int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr2 = arr1;  // Copying the reference

            int [] arr3 = new int[n];

            // Copying the data
            for(int i = 0; i < n; i++)
            {
                arr3[i] = arr1[i];
            }
            
            Console.WriteLine("Array 2 : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("\nArray 3 : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
}