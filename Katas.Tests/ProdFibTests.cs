namespace Katas.Tests;

public class ProdFibTests
{
	[Test]
	public void ZeroShouldReturn() =>
		Assert.That(ProdFib.ProductFib(0), Is.EqualTo(new ulong[] { 0, 1, 1 }));

	[TestCase(714, new ulong[] { 21, 34, 1 })]
	[TestCase(4895, new ulong[] { 55, 89, 1 })]
	public void Hard(long input, ulong[] expected) =>
		Assert.That(ProdFib.ProductFib((ulong)input), Is.EqualTo(expected));

	[Test]
	public void CheckFalseCase() =>
		Assert.That(ProdFib.ProductFib(800), Is.EqualTo(new ulong[] { 34, 55, 0 }));
}