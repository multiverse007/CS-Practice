using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the array length : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            
            Console.WriteLine("Enter the Array elements");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the Element to Search : ");
            int ele = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for(int i = 0; i < a.Length ; i++)
            {
                if (a[i] == ele)
                {
                    flag = 1;
                    Console.WriteLine("Element Found in index : " + i);
                    break;
                }
            }

            if(flag == 0)
            {
                Console.WriteLine("Element not Found");
            }
        }
    }
}