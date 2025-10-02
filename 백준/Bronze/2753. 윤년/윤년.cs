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
            
            if (N % 400 == 0 || (N % 4 == 0 && N % 100 != 0))
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);
        }
    }
}
