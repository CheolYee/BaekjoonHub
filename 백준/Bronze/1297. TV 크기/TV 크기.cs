using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int D = input[0];
            int H = input[1];
            int W = input[2];

            double k = D / Math.Sqrt(W * W + H * H);

            Console.WriteLine($"{(int)(k*H)} {(int)(k*W)}");
        }
    }
}