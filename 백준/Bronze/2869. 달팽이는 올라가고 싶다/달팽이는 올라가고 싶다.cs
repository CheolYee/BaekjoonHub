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
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine((int)Math.Ceiling((double)(input[2] - input[1]) / (input[0] - input[1])));
        }
    }
}
