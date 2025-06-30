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

            /*double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);*/

            /* Console.WriteLine($"{n[0] / n[1]}");*/


            int T = int.Parse(Console.ReadLine());

            List<(int, int)> Values = new List<(int, int)>();

            for (int i = 0; i < T; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Values.Add((input[0], input[1]));
            }
            
            for (int i = 0; i < T; i++)
            {
                int n = Values[i].Item2;
                int r = Values[i].Item1;

                Console.WriteLine(Combination(n, r));
            }
        }

        static long Combination(int n, int r)
        {
            if (r == 0 || n == r) return 1;

            long result = 1;

            for (int i = 1; i <= r; i++)
            {
                result *= n--;
                result /= i;
            }

            return result;
        }
    }
}
