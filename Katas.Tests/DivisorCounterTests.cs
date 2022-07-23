namespace Katas.Tests;

public class DivisorCounterTests
{
	[TestCase(1, 1)]
	[TestCase(2, 3)]
	[TestCase(3, 5)]
	[TestCase(4, 8)]
	[TestCase(5, 10)]
	[TestCase(20, 66)]
	[TestCase(900, 6276)]
	[TestCase(9999, 93643)]
	[TestCase(10000000, 162725364)]
	public void CountDivisors(long number, long expected) =>
		Assert.That(DivisorsCounter.CountDivisors(number), Is.EqualTo(expected));
}