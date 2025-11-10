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

            while (true)
            {
                long[] inputs = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

                if (inputs[0] + inputs[1] + inputs[2] == 0) break;

                Array.Sort(inputs);

                if ((inputs[0] * inputs[0]) + (inputs[1] * inputs[1]) == (inputs[2] * inputs[2]))
                {
                    sb.AppendLine("right");
                }
                else
                {
                    sb.AppendLine("wrong");
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
