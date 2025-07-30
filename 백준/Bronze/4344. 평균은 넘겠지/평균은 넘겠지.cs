int C = int.Parse(Console.ReadLine());

List<float[]> scores = new List<float[]>();

for (int i = 0; i < C; i++)
{
    float[] caseInput = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

    scores.Add(caseInput);
}

for (int i = 0; i < C; i++)
{
    float allScore = 0;
    int total = scores[i].Count() -1;
    int overAvg = 0;

    foreach (float sum in scores[i].Skip(1))
    {
        allScore += sum;
    }

    float average = allScore / total;

    foreach (float stu in scores[i].Skip(1))
    {
        if (stu > average) overAvg++;
    }

    float per = (float)overAvg / total * 100;
    float round = (float)Math.Round(per, 3);

    Console.WriteLine(round.ToString("F3") + "%");
}