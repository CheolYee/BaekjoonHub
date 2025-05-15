using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            Console.WriteLine($"{n[0] / n[1]}");
        }
    }
}
