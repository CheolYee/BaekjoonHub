using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Numerics;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int N = input[0];
            int m = input[1];
            int M = input[2];
            int T = input[3];
            int R = input[4];

            if (m + T > M)
            {
                Console.WriteLine("-1");
                return;
            }

            int makbak = m;
            int time = 0;
            int undongTIme = 0;

            while (undongTIme < N)
            {
                if (makbak + T <= M)
                {
                    makbak += T;
                    undongTIme++;
                }
                else
                {
                    makbak -= R;
                    if (makbak < m)
                        makbak = m;
                }

                time++;
            }
            Console.WriteLine(time);
        }
    }
}