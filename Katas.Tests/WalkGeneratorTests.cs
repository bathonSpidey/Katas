namespace Katas.Tests;

public class WalkGeneratorTests
{
	[TestCase(new[] { "w" }, false)]
	[TestCase(new[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }, false)]
	[TestCase(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }, true)]
	[TestCase(new[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }, false)]
	[TestCase(new[] { "n", "n", "n", "n", "n", "w", "w", "w", "w", "w" }, false)]
	[TestCase(new[] { "n", "n", "n", "n", "n", "e", "e", "e", "e", "e" }, false)]
	public void ValidWalk(string[] walk, bool expected) =>
		Assert.That(WalkGenerator.ValidWalk(walk), Is.EqualTo(expected));
}