using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "black", "brown", "red", "orange", "yellow",
            "green", "blue", "violet", "grey", "white"};

            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            int first = Array.IndexOf(colors, A);
            int second = Array.IndexOf(colors, B);
            int multi = Array.IndexOf(colors, C);

            long result = (first * 10 + second) * (long)Math.Pow(10, multi);
            Console.WriteLine(result);
        }
    }
}
