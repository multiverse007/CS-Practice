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

            int[,] a1 = new int[m, n];

            Console.WriteLine("Enter the Matrix 1 elements");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] a2 = new int[m, n];

            Console.WriteLine("Enter the Matrix 2 elements");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] a3 = new int[m, n];
            
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a3[i, j] = a1[i, j] + a2[i, j];
                }
            }

            Console.WriteLine("The Added Matrix is : ");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(a3[i, j] + " ");
                }
                Console.WriteLine();
            }
        
        }
    }
}