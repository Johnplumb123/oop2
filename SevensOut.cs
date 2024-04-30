using System;

public class SevensOut
{
    private Die[] dice;
    private Random random:
    private int totalScore;

    public SevensOut()
    {
        dice = new Die[2]
        random = new Random
        totalScore = 0;
        for (int i = 0; i < dice.Length; i++)
        {
            dice[i] = new Die();
        }
    }

    public void Play()
    {
        Console.WriteLine("Welcome to sevens out game.");
        Console.WriteLine("Rolling Die...");

        while (true)
        {
            int rollTotal = RollDie();
            if (rollTotal == 7)
            {
                Console.WriteLine("You have rolled a 7, game over.");
                break;
            }
            else
            {
                totalScore += rollTotal
                if (dice[0].currentValue == dice[1].currentValue)
                {
                    totalScore += rollTotal;
                }

                Console.WriteLine($"You have rolled a total of {rollTotal}. Total score: {totalScore}");
            }
}

        private int RollDice()
        {
            int rollTotal = 0;
            foreach (var die in dice)
            {
                rollTotal += die.Value;
            }
            return rollTotal;
        }



        