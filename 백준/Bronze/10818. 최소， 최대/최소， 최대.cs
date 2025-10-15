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
            int numCount = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.Write(nums.Min() + " " + nums.Max());

            

        }
    }
}
