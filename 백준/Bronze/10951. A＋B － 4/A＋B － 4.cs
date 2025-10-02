using System;
using System.Text;

namespace BackJoon3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                while (true)
                {
                    string line = Console.ReadLine();
                    if (string.IsNullOrEmpty(line)) break;

                    int[] input = Array.ConvertAll(line.Split(), int.Parse);
                    sb.AppendLine((input[0] + input[1]).ToString());
                }
            }
            catch
            {
               
            }

            Console.Write(sb);
        }
    }
}
