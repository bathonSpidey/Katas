namespace Katas.Tests;

public class TwinPrimeTests
{
	[TestCase(5, true)]
	[TestCase(7, true)]
	[TestCase(8, false)]
	public void ShouldYieldCorrectResult(int number, bool expected) =>
		Assert.That(TwinPrime.IsTwinPrime(number), Is.EqualTo(expected));
}