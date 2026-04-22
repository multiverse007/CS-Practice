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

            int[] a = new int[n];
            Console.WriteLine("Enter the Array elements");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(a);
            Console.WriteLine("Max Element of the Array is " + a[a.Length-1]);
        }
    }
}