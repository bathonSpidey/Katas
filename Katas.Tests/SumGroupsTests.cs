namespace Katas.Tests;

public class SumGroupsTests
{
	[TestCase(new[] { 2, 1, 2, 2, 6, 5, 0, 2, 0, 5, 5, 7, 7, 4, 3, 3, 9 }, 6)]
	[TestCase(new[] { 2, 1, 2, 2, 6, 5, 0, 2, 0, 3, 3, 3, 9, 2 }, 5)]
	[TestCase(new[] { 1 }, 1)]
	[TestCase(new[] { 1, 2 }, 2)]
	[TestCase(new[] { 1, 1, 2, 2 }, 1)]
	public void Sample(int[] input, int expected)
	{
		var result = SumGroups.Calculate(input);
		Assert.That(result, Is.EqualTo(expected));
	}
}