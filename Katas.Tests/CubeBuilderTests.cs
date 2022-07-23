namespace Katas.Tests;

public class CubeBuilderTests
{
	[Test]
	public void NonExistent() => Assert.That(CubeBuilder.findNb(24723578342962), Is.EqualTo(-1));

	[TestCase(4183059834009, 2022)]
	[TestCase(135440716410000, 4824)]
	[TestCase(40539911473216, 3568)]
	public void ExistingCube(long number, long expected)
	{
		var cube = CubeBuilder.findNb(number);
		Assert.That(cube, Is.EqualTo(expected));
	}
}