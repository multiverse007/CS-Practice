using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializing the variables
            Console.Write("Enter rows : ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[m, n];

            Console.WriteLine("Enter the Matrix 1 elements");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] aT = new int[n, m];
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    aT[j, i] = a[i, j];
                }
            }
            Console.WriteLine("The Original Matrix is : ");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Transpose of the Matrix is : ");
            for(int i= 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(aT[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}