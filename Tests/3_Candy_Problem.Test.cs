using Xunit;
using CandyProblem;

namespace CandyProblem.Test;

public class CandyProblemTest
{

	[Fact]
	public void GetMissingCandiesTest_5_8_6_4()
	{
		int[] input = { 5, 8, 6, 4 };
		int expected = 9;

		int actual = CandyProblem.GetMissingCandies(input);

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void GetMissingCandiesTest_1_2_4_6()
	{
		int[] input = { 1, 2, 4, 6 };
		int expected = 11;

		int actual = CandyProblem.GetMissingCandies(input);

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void GetMissingCandiesTest_1_2()
	{
		int[] input = { 1, 2 };
		int expected = 1;

		int actual = CandyProblem.GetMissingCandies(input);

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void GetMissingCandiesTest_4_2()
	{
		int[] input = { 4, 2 };
		int expected = 2;

		int actual = CandyProblem.GetMissingCandies(input);

		Assert.Equal(expected, actual);
	}
}