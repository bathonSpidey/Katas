namespace Katas;

public class Lift
{
	private static int totalCapacity;
	private static List<int> stops = new();
	private static int direction = 1;
	private readonly List<int> spaceLeft;

	private Lift(int capacity)
	{
		totalCapacity = capacity;
		spaceLeft = new List<int>();
	}

	public static int[] TheLift(int[][] queues, int capacity)
	{
		var lift = new Lift(capacity);
		stops = new List<int> { 0 };
		direction = 1;
		var notCleared = true;
		while (notCleared)
		{
			LiftMovingUp(queues, lift);
			LiftMovingDown(queues, lift);
			if (!queues.Any(x => x.Length > 0))
				notCleared = false;
		}
		if (stops[^1] != 0)
			stops.Add(0);
		return stops.ToArray();
	}

	private static void LiftMovingDown(int[][] queues, Lift lift)
	{
		for (var floor = queues.GetLength(0) - 1; floor >= 0; floor--)
		{
			if (queues[floor].Length == 0 && lift.spaceLeft.Count == 0)
				continue;
			GettingOff(lift, floor);
			direction = -1;
			LiftMoving(queues, lift, floor);
		}
	}

	private static void LiftMovingUp(int[][] queues, Lift lift)
	{
		for (var floor = 0; floor < queues.GetLength(0); floor++)
		{
			if (queues[floor].Length == 0 && lift.spaceLeft.Count == 0)
				continue;
			GettingOff(lift, floor);
			direction = 1;
			LiftMoving(queues, lift, floor);
		}
	}

	private static void LiftMoving(int[][] queues, Lift lift, int floor)
	{
		if (lift.spaceLeft.Count != totalCapacity && queues[floor].Length != 0)
		{
			var personToAdd = new List<int>();
			for (var person = 0; person < queues[floor].Length; person++)
			{
				if (queues[floor][person] > floor && lift.spaceLeft.Count != totalCapacity &&
						direction == 1)
				{
					if (stops[^1] != floor)
						stops.Add(floor);
					personToAdd.Add(queues[floor][person]);
				}
				if (queues[floor][person] < floor && lift.spaceLeft.Count != totalCapacity &&
						direction == -1)
				{
					if (stops[^1] != floor)
						stops.Add(floor);
					personToAdd.Add(queues[floor][person]);
				}
			}
			GettingOn(queues, personToAdd, floor, lift);
		}
	}

	private static void GettingOn(int[][] queues, List<int> personToAdd, int floor, Lift lift)
	{
		foreach (var indexToRemove in personToAdd.Select(person =>
							Array.IndexOf(queues[floor], person)))
			queues[floor] = queues[floor].Where((_, index) => index != indexToRemove).ToArray();
		lift.spaceLeft.AddRange(personToAdd);
	}

	private static void GettingOff(Lift lift, int floor)
	{
		for (var person = 0; person < lift.spaceLeft.Count; person++)
			if (lift.spaceLeft[person] == floor)
			{
				if (stops[^1] != floor)
					stops.Add(floor);
				lift.spaceLeft.RemoveAt(person);
			}
	}
}