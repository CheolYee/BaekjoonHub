using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (input[0] == input[1])
            {
                Console.WriteLine("==");
            }
            else
            {
                Console.WriteLine(input[0] > input[1] ? ">" : "<"); 

            }
        }
    }
}
