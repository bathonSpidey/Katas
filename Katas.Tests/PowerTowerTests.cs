namespace Katas.Tests;

public class PowerTowerTests
{
	[TestCase(729, 0, 1, 0)]
	[TestCase(729, 0, 2, 1)]
	[TestCase(1, 897, 8934279, 1)]
	public void CornerCases(int start, int height, int modulo,int expected)
	{
		var tower = PowerTower.Tower(start, height, modulo);
		Assert.That(tower, Is.EqualTo(expected));
	}

	[TestCase(2, 4, 1000, 536)]
	[TestCase(2, 4, 1000, 536)]
	[TestCase(2, 2, 1000, 4)]
	[TestCase(2, 3, 100000, 16)]
	[TestCase(2, 4, 100000000, 65536)]
	[TestCase(4, 2, 10000000, 256)]
	[TestCase(4, 3, 10, 6)]
	[TestCase(7, 1, 5, 2)]
	[TestCase(2, 5, 65519, 68)]
	[TestCase(2, 4, 131072, 65536)]
	public void SimpleCase(int start, int height, int modulo, int expected)
	{
		var tower = PowerTower.Tower(start, height, modulo);
		Assert.That(tower, Is.EqualTo(expected));
	}
}