using System;
using System.Text;

namespace BackJoon3
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                for (int j = index -1; j >= 0; j--)
                {
                    if (j <= i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }


        }
    }
}
