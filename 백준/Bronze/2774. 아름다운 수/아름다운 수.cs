using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Numerics;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            List<string> X = new List<string>();

            for (int i = 0; i < T; i++)
            {
                X.Add(Console.ReadLine());
            }

            foreach (var beutiful in X)
            {
                HashSet<char> beutifulNum = new HashSet<char>();

                foreach (char digit in beutiful)
                {
                    beutifulNum.Add(digit);
                }

                Console.WriteLine(beutifulNum.Count);
            }
            
        }
    }
}