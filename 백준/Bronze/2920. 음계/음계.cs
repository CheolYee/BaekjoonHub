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
            string[] input = Console.ReadLine().Split();

            string lesult = "";

            foreach (string line in input)
            {
                lesult += line;
            }

            if (lesult == "12345678") Console.WriteLine("ascending");
            else if (lesult == "87654321") Console.WriteLine("descending");
            else Console.WriteLine("mixed");
        }
    }
}
