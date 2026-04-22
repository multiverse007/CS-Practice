using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initializing the teams

            // 1st Innings
            int[,] team1 = new int[20,6];
            
            int score1 = 0;
            int wickets1 = 0;

            Console.WriteLine("Enter 1st innings");
            for(int i = 0;i < 20; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.WriteLine("\nOver : " + i + " Ball : "+ (j+1));
                    Console.Write("Enter if it's wicket or not (1 or 0) : ");
                    int w = Convert.ToInt32(Console.ReadLine());

                    if (w == 1)
                    {
                        wickets1++;
                        team1[i, j] = -1;
                        if (wickets1 == 10)
                        {
                            Console.WriteLine("\nScore : " + score1 + " - " + wickets1 + " Over : " + i + "." + (j + 1));
                            team1[i, j] = -10;
                            break;
                        }
                        Console.WriteLine("\nScore : " + score1 + " - " + wickets1 + " Over : " + i + "." + (j + 1));
                        continue;
                    }

                    Console.Write("Enter the score : ");
                    team1[i, j] = Convert.ToInt32(Console.ReadLine());

                    score1+=team1[i, j];

                    Console.WriteLine("\nScore : " + score1 + " - " + wickets1 + " Over : " + i + "." + (j + 1));
                }

                if (wickets1 == 10)
                {
                    break;
                }
            }

            // 2nd Innings
            int[,] team2 = new int[20,6];

            int score2 = 0;
            int wickets2 = 0;

            Console.WriteLine("\nEnter 2nd Innings");
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.WriteLine("\nOver : " + i + " Ball : "+ (j+1));
                    Console.Write("Enter if it's wicket or not (1 or 0) : ");
                    int w = Convert.ToInt32(Console.ReadLine());

                    if (w == 1)
                    {
                        wickets2++;
                        team2[i, j] = -1;
                        if (wickets2 == 10)
                        {
                            Console.WriteLine("\nScore : " + score2 + " - " + wickets2 + " Over : " + i + "." + (j + 1));
                            team2[i, j] = -10;
                            break;
                        }
                        Console.WriteLine("\nScore : " + score2 + " - " + wickets2 + " Over : " + i + "." + (j + 1));
                        continue;
                    }

                    Console.Write("Enter the score : ");
                    team2[i, j] = Convert.ToInt32(Console.ReadLine());

                    score2+=team2[i, j];

                    Console.WriteLine("\nScore : " + score2 + " - " + wickets2 + " Over : " + i + "." + (j + 1));

                    if(score2 > score1)
                    {
                        break;
                    }
                }

                if (wickets2 == 10 || score2 > score1)
                {
                    break;
                }

            }

            Console.WriteLine("Team 1 Score : " + score1 + " Team 2 Score : " + score2);

            Console.WriteLine();

            if(score2 > score1)
            {
                Console.WriteLine("Team 2 won");
            }
            else
            {
                Console.WriteLine("Team 1 won");
            }
        }
    }
}