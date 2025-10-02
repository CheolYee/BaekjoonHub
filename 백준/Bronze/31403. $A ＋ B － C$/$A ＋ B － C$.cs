using System;
using System.Text;

namespace BackJoon3
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine(A + B - C);
            Console.WriteLine(int.Parse(A.ToString() + B.ToString()) - C);


        }
    }
}
