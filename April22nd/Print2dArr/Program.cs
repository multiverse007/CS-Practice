using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializing the variables
            int[,] a = new int[2,3];

            Console.WriteLine("Enter the Array elements");
            for(int i= 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Array is : ");
            for(int i= 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}