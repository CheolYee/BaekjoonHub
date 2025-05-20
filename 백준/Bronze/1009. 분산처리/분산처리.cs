using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int result = GetLastComputer(a, b);
            Console.WriteLine(result);
        }
    }

    static int GetLastComputer(int a, int b)
    {
        a = a % 10;

        if (a == 0) return 10;  // 10번 컴퓨터

        // 패턴 테이블
        int[] pattern;
        switch (a)
        {
            case 1: pattern = new int[] { 1 }; break;
            case 2: pattern = new int[] { 2, 4, 8, 6 }; break;
            case 3: pattern = new int[] { 3, 9, 7, 1 }; break;
            case 4: pattern = new int[] { 4, 6 }; break;
            case 5: pattern = new int[] { 5 }; break;
            case 6: pattern = new int[] { 6 }; break;
            case 7: pattern = new int[] { 7, 9, 3, 1 }; break;
            case 8: pattern = new int[] { 8, 4, 2, 6 }; break;
            case 9: pattern = new int[] { 9, 1 }; break;
            default: pattern = new int[] { 0 }; break;
        }

        int index = (b - 1) % pattern.Length;
        return pattern[index];
    }
}
