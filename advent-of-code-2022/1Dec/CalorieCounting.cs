namespace advent.of.code.first.dec;

public static class CalorieCounting
{
    public static int StageOne(string[] fileData)
    {
        var highestScore = 0;
        var currentNumberCount = 0;

        foreach (string line in fileData)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                highestScore = currentNumberCount > highestScore ? currentNumberCount : highestScore;
                currentNumberCount = 0;
            }
            else
            {
                currentNumberCount += int.Parse(line);

            }
        }

        return highestScore;
    }

    public static int StageTwo(string[] fileData)
    {
        int[] highestScores = new int[3];
        var currentNumberCount = 0;

        foreach (string line in fileData)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
               // add highest score to array
                var smallestLocation = 0;

                for (int i = 0; i < highestScores.Length; i++)
                {
                    if (highestScores[smallestLocation] > highestScores[i])
                    {
                        smallestLocation = i;
                    }
                }

                if (currentNumberCount > highestScores[smallestLocation])
                {
                    highestScores[smallestLocation] = currentNumberCount;
                }

                currentNumberCount = 0;
            }
            else
            {
                currentNumberCount += int.Parse(line);

            }
        }

        return highestScores.Sum();
    }
}