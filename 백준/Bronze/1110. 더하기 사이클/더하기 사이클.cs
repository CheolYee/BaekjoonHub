using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cycle = 0;
            int newNumber = N;

            do
            {

                int tens = newNumber / 10;
                int ones = newNumber % 10;
                int sum = tens + ones;

                newNumber = ones * 10 + (sum % 10);
                cycle++;
            }
            while (N != newNumber);
            Console.WriteLine(cycle);
        }
    }
}