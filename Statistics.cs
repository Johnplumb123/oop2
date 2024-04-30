using System;

public class Statistics
{
	private int SevensOutPlays;
	private int ThreeorMorePlays;
	private int SevensOutHighScore;
	private int ThreeorMoreHighScore;
	private int SevensOutTotalrounds;
	private int ThreeorMoreTotalrounds;
	private int SevensOutTotalscore;
	private int ThreeorMoreTotalscore;

	public Statistics()
	{
		SevensOutPlays = 0;
		ThreeorMorePlays = 0;
		SevensOutHighScore = 0;
		ThreeorMoreHighScore = 0;
		SevensOutTotalrounds = 0;
		ThreeorMoreTotalrounds = 0;
		SevensOutTotalscore = 0;
		ThreeorMoreTotalscore = 0;
    }

	public void updateThreeorMoreStatistics(int score, int rounds)
	{
		ThreeorMorePlays++;
		ThreeorMoreTotalrounds += rounds;
		ThreeorMoreTotalscore += score;
		if (score > ThreeorMoreHighScore)
		{
			ThreeorMoreHighScore = score;
		}
	}

    public void updateSevensOutStatistics(int score, int rounds)
    {
        SevensOutPlays++;
        SevensOutTotalrounds += rounds;
        SevensOutTotalscore += score;
        if (score > SevensOutHighScore)
        {
            SevensOutHighScore = score;
        }
    }

    public void DisplayStastics()
	{
		Console.WriteLine("Game Stats:");
		Console.WriteLine($"total number of plays: {ThreeorMorePlays}");
        Console.WriteLine($"High score: {threeOrMoreHighScore}");
		Console.WriteLine($"Average score; {(ThreeorMorePlays == 0 ? 0 : ThreeorMoreTotalscore / ThreeorMorePlays)}");
		Console.WriteLine($"Average rounds played before winning: {(ThreeorMorePlays == 0 ? 0 : ThreeorMoreTotalrounds / ThreeorMorePlays)}");
    }
}
