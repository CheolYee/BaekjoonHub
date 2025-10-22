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

            StringBuilder sb = new StringBuilder();

            int testCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string S = input[1];
                int R = int.Parse(input[0]);

                foreach (char cur in S)
                {
                    for (int j = 0; j < R; j++)
                    {
                        sb.Append(cur);
                    }
                }
                sb.Append('\n');
            }

            Console.WriteLine(sb.ToString());
            

        }
    }
}
