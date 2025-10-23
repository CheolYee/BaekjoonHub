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
            int count = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i  = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                if (IsGrouped(input))
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }

        public static bool IsGrouped(string input)
        {
            HashSet<char> chars = new HashSet<char>();
            char prev = '\0';

            foreach (char c in input)
            {
                if (c != prev && chars.Contains(c))
                {
                    return false;
                }

                chars.Add(c);
                prev = c;
            }
            return true;
        }
    }
}
