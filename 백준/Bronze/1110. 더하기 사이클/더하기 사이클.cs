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
            int N = int.Parse(Console.ReadLine());

            int cycle = 0;
            int newNumber = N;

            while (true)
            {
                cycle++;

                int tens = newNumber / 10;
                int ones = newNumber % 10;

                int sum = tens + ones;

                int sumOnes = sum % 10;

                newNumber = ones * 10 + sumOnes;

                if (N == newNumber)
                {
                    break;
                }

            }

            Console.WriteLine(cycle);
        }
    }
}