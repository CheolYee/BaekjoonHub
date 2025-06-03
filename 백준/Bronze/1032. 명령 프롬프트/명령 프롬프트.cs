using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);*/

            /* Console.WriteLine($"{n[0] / n[1]}");*/


            int N = int.Parse(Console.ReadLine());
            string[] fileName = new string[N];

            for (int i = 0; i < N; i++)
            {
                fileName[i] = Console.ReadLine();
            }

            int minLength = fileName[0].Length;

            char[] result = new char[minLength];

            for (int i = 0; i < minLength; i++)
            {
                char thisChar = fileName[0][i];
                bool isMatch = true;

                for (int j = 0; j < fileName.Length; j++)
                {
                    if (fileName[j][i] != thisChar)
                    {
                        isMatch = false;
                        break;
                    }
                }

                result[i] = isMatch ? thisChar : '?';
            }

            Console.WriteLine(result);
        }
    }
}
