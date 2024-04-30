using System;

public class Testing 
{
	public void Tests()
	{
		TestSevensOut();
		TestThreeorMore();
	}

	private void TestsforSevensOut()
	{
		TestsforSevensOut sevensOutgame = new SevensOut();

		Debug.Assert(sevensOutgame.PlayTest() <= 7, "Sevens out game test failed as total score exceeds 7.");

		Debug.Assert(sevensOutgame.PlayTest() == 7, "Sevens out game test failed, game doesnt end when total is 7.");

	}

	private void TestsforThreeorMore()
	{
		TestsforThreeorMore threeorMoregame = new ThreeorMore();

		Debug.Assert(threeorMoregame.PlayTest() <= 20, "Three or More game test failed , total score exceeds 20.");

		Debug.Assert(threeOrMoreGame.PlayTest() == 20, "Three or More game test failed, game doesnt end when total is 20.");

		Debug.Assert(threeOrMoreGame.Testcombinartionscoring() == true, "Three or More test failed, die combination scoring error. ");

		Debug.Assert(threeOrMoreGame.TestRoll() == true, "Three or More test failed: Die Reroll error. ");

        Debug.Assert(threeOrMoreGame.TestThreeOfAkind() == true, "Three or More test failed: 3-of-a-kind scoring error.");

        Debug.Assert(threeOrMoreGame.TestfourOfAkind() == true, "Three or More test failed: 4-of-a-kind scoring error.");

        Debug.Assert(threeOrMoreGame.TestfiveOfAkind() == true, "Three or More test failed: 5-of-a-kind scoring error.");

    }
}
