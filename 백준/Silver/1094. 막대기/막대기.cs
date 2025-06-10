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
            int X = int.Parse(Console.ReadLine());
            int count = 0;

            while (X > 0)
            {
                if (X % 2 == 1) count++;
                X /= 2;
            }
            Console.WriteLine(count);
        }
    }
}