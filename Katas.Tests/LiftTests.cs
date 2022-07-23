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

	[Test]
	public void SimpleUpAndUp()
	{
		int[][] queues =
		{
			new int[0], // G
			new int[]{3}, // 1
			new int[]{4}, // 2
			new int[0], // 3
			new int[]{5}, // 4
			new int[0], // 5
			new int[0],
		};
		Assert.That(Lift.TheLift(queues, 5), Is.EqualTo(new[] { 0, 1, 2, 3, 4, 5, 0 }));
	}

	[Test]
	public void SimpleDownAndDown()
	{
		int[][] queues =
		{
			new int[0], // G
			new int[]{0}, // 1
			new int[0], // 2
			new int[0], // 3
			new int[]{2}, // 4
			new int[]{3}, // 5
			new int[0],
		};
		Assert.That(Lift.TheLift(queues, 5), Is.EqualTo(new[] { 0, 5, 4, 3, 2, 1, 0 }));
	}
}