namespace Katas.Tests;

public class LiftTests
{
	[Test]
	public void SimpleGoingUp()
	{
		int[][] queues =
		{
			Array.Empty<int>(), // G
			Array.Empty<int>(), // 1
			new[] { 5, 5, 5 }, // 2
			Array.Empty<int>(), // 3
			Array.Empty<int>(), // 4
			Array.Empty<int>(), // 5
			Array.Empty<int>() // 6
		};
		Assert.That(Lift.TheLift(queues, 5), Is.EqualTo(new[] { 0, 2, 5, 0 }));
	}

	[Test]
	public void SimpleGoingDown()
	{
		int[][] queues =
		{
			Array.Empty<int>(), // G
			Array.Empty<int>(), // 1
			new[] { 1, 1 }, // 2
			Array.Empty<int>(), // 3
			Array.Empty<int>(), // 4
			Array.Empty<int>(), // 5
			Array.Empty<int>() // 6
		};
		Assert.That(Lift.TheLift(queues, 5), Is.EqualTo(new[] { 0, 2, 1, 0 }));
	}
}