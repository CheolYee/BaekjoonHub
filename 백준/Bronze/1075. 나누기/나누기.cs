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


            int N = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());


            int Base = (N / 100) * 100;

            for(int i = 0; i<100; i++)
            {
                if((Base + i) % F == 0)
                {
                    Console.WriteLine(i.ToString("D2"));
                    break;
                }
            }

        }
    }
}
