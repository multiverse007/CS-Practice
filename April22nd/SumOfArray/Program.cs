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
            int sum = 0;
            Console.WriteLine("Enter the Array elements");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("sum of the array is " + sum);
        }
    }
}