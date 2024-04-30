using System;

public class ThreeorMore
{
    private Die[] dice;
    private Random random;
    private int totalscore;

    public ThreeorMore()
    {
        dice = new Die[5];
        random = new Random();
        totalscore = 0;
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = new Die();
        }
    }


    public void Play()
    {
        Console.WriteLine("Welcome to Three or More Game.");
        Console.WriteLine("Rolling die...");

        while (totalscore < 20)
        {
            RollDice();
            int score = CalculateScore();
            totalscore += score;
            Console.WriteLine($"You have scored {score} points in this round.");
            Console.WriteLine($"Total score: {totalscore}");
        }

        Console.WriteLine("Well done, you have reached 20 points first. ");
    }

    private void RollDice()
    {
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i].Roll();
        }
    }

    private int calculateScore()
    {
        int[] counts = new int[6];
        foreach (var die in dice)
        {
            counts[die.currentValue -1 ]++;
        }

        int score = 0;
        for (int i = 0; i < counts.Length;  i++)
        {
            if (counts[i] >= 3)
            {
                score = 3 * (i + 1);
                break;
            }
        }

        if (score == 0)
        {
            if (counts.Contains(4))
            {
                score = 6;
            }
            else if (counts.Contains(5))
            {
                score = 7;
            }
        }

        return score;
    }
}
