using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJoon3
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int H = input[0];
                int N = input[2];

                int currentH;
                int currentW;

                if (N % H == 0)
                {
                    currentH = H;
                    currentW = N / H;
                }
                else
                {
                    currentH = N % H;
                    currentW = N / H + 1;
                }

                int roomNumber = currentH * 100 + currentW;
                Console.WriteLine(roomNumber);
                
            }

        }
    }
}
