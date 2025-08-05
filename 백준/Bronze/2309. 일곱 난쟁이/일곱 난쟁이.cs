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

            List<int> seven = new List<int>();
            bool found = false;

            for (int i = 0; i < 8 && !found; i++)
            {
                for (int j = i + 1; j < 9 && !found; j++)
                {
                    if (hights[i] + hights[j] == remove)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i && k != j)
                            {
                                seven.Add(hights[k]);
                            }
                        }
                        found = true;
                    }
                }
            }

            seven.Sort();

            foreach (int hight in seven)
            {
                Console.WriteLine(hight);
            }
        }
    }
}