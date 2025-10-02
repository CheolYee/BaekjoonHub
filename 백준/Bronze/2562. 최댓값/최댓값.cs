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
            List<int> all = new List<int>();

            int index = 0;

            for (int i = 0; i < 9; i++)
            {
                int input = int.Parse(Console.ReadLine());

                all.Add(input);
            }

            index = all.IndexOf(all.Max()) +1;

            Console.WriteLine(all.Max());
            Console.WriteLine(index);


        }
    }
}
