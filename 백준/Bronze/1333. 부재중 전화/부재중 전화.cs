using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int N = input[0];
            int L = input[1];
            int D = input[2];

            int total = N * (L + 5);

            for (int i = 0; ; i += D)
            {
                bool isAnswer = true;

                for (int j = 0; j < N; j++)
                {
                    int start = j * (L + 5);
                    int end = start + L;

                    if (i >= start && i < end)
                    {
                        isAnswer = false;
                        break;
                    }
                }

                if (isAnswer)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}