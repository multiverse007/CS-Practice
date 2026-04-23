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

            Console.Write("Enter rows : ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns : ");
            int q = Convert.ToInt32(Console.ReadLine());

            int[,] a2 = new int[p, q];

            Console.WriteLine("Enter the Matrix 2 elements");
            for(int i= 0; i < p; i++)
            {
                for(int j = 0; j < q; j++)
                {
                    a2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // If the column of the first matrix is not equal with rows of the second matrix then multiplication is not possible
            if(n != p)
            {
                Console.WriteLine("Matrix Multiplication not possible");
                Environment.Exit(0);
            }

            int[,] a3 = new int[m, q];
            
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < q; j++)
                {
                    a3[i, j] = 0;

                    for(int k = 0; k < n; k++)
                    {
                        a3[i, j] += a1[i, k] * a2[k, j];
                    }
                }
            }

            Console.WriteLine("The Multiplied Matrix is : ");
            for(int i= 0; i < m; i++)
            {
                for(int j = 0; j < q; j++)
                {
                    Console.Write(a3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
