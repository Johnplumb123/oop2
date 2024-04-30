using System;

public class Game
{
	private SevensOut sevensOutGame;
	private ThreeorMore threeOrMoreGame;
	private Statistics statistics;
	private Testing testing;

	public Game()
	{
		sevensOutGame = new SevensOut();
		threeOrMoreGame = new ThreeorMore();
		statistics = new Statistics();
		testing = new Testing();
	}

	public void Start()
	{
		bool exit = false;

		while (!exit)
		{
            Console.WriteLine("Welcome to the Dice Games!");
            Console.WriteLine("1. Play Sevens Out Game");
            Console.WriteLine("2. Play Three or More Game");
            Console.WriteLine("3. View Statistics");
            Console.WriteLine("4. Perform Tests");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");

			string choice = Console.ReadLine();

			switch (choice)
			{
                case "1":
                    Console.Clear();
                    sevensOutGame.Play();
                    break;
                case "2":
                    Console.Clear();
                    threeOrMoreGame.Play();
                    break;
                case "3":
                    Console.Clear();
                    statistics.DisplayStatistics();
                    break;
                case "4":
                    Console.Clear();
                    testing.PerformTests();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("You have entered an invalid option, please choose again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
        }
	}
}
