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
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= N; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}
