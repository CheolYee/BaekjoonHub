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
            HashSet<int> list = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                int value = int.Parse(Console.ReadLine());
                list.Add(value % 42);
            }
            Console.WriteLine(list.Count);
        }
    }
}
