using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double[] score = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
            double[] zuzaks = new double[score.Length];

            double M = score.Max();

            double avg = 0;

            for (int i = 0; i < N; i++)
            {
                zuzaks[i] = score[i] / M * 100;
            }

            foreach (double zuzak in zuzaks)
            {
                avg += zuzak;
            }

            avg /= N;

            Console.WriteLine(avg.ToString("0.0############################"));

        }
    }
}