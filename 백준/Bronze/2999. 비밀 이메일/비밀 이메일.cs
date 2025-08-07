using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int N = input.Length;
            int R = FindMaxR(N);
            int C = N / R;

            char[,] message = new char[R, C];

            int index = 0;
            for (int j = 0; j < C; j++)
            {
                for (int i = 0; i < R; i++)
                {
                    message[i, j] = input[index++];
                }
            }

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(message[i, j]);
                }
            }
        }

        static int FindMaxR(int N)
        {
            for (int R = (int)Math.Sqrt(N); R >= 1; R--)
            {
                if (N % R == 0)
                {
                    int C = N / R;
                    if (R <= C)
                        return R;
                }
            }
            return 1;
        }
    }
}