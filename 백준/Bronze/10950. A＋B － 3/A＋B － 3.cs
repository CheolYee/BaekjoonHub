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
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sb.AppendLine((input[0] + input[1]).ToString());
            }

            Console.Write(sb);
            

        }
    }
}
