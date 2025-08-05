using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hights = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                hights.Add(int.Parse(Console.ReadLine()));
            }

            int total = hights.Sum();
            int remove = total - 100;

            bool found = false;

            for (int i = 0; i < 8 && !found; i++)
            {
                for (int j = i + 1; j < 9 && !found; j++)
                {
                    if (hights[i] + hights[j] == remove)
                    {
                        hights.RemoveAt(j);
                        hights.RemoveAt(i);
                        found = true;
                    }
                }
            }

            hights.Sort();

            foreach (int hight in hights)
            {
                Console.WriteLine(hight);
            }
        }
    }
}