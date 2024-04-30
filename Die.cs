using System;

public class Die
{
	private int currentValue;
	private Random random;

	public Die()
	{
		random = new Random();
		Roll();
	}

	public int Roll()
	{
		currentValue = random.Next(1, 7);
		return currentValue;
	}
}
	{
	}
}
