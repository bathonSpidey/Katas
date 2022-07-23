namespace Katas.Tests;

public class Lift
{
	private static int totalCapacity;
	private int direction;
	private readonly List<int> spaceLeft;
	private int currentFloor;

	private Lift(int capacity)
	{
		totalCapacity = capacity;
		spaceLeft = new List<int>();
		currentFloor = 0;
		direction = 1;
	}

	public static int[] TheLift(int[][] queues, int capacity)
	{
		var lift = new Lift(capacity);
		var stops = new List<int> { 0 };
		var personToAdd = new List<int>();
		var count = 0;
		for (var floor = 0; floor < queues.GetLength(0); floor++)
		{
			lift.currentFloor = floor;
			if (queues[floor].Length == 0 && lift.spaceLeft.Count == 0)
			{
				count++;
				continue;
			}
			for (var person = 0; person < lift.spaceLeft.Count; person++)
				if (lift.spaceLeft[person] == floor)
				{
					if (stops[^1] != floor)
						stops.Add(floor);
					lift.spaceLeft.RemoveAt(person);
				}
			if (lift.spaceLeft.Count != totalCapacity && queues[floor].Length != 0)
			{
				for (var person = 0; person < queues[floor].Length; person++)
					if (queues[floor][person] > floor && lift.spaceLeft.Count != capacity)
					{
						if (stops[^1] != floor)
							stops.Add(floor);
						personToAdd.Add(queues[floor][person]);
					}
				foreach (var person in personToAdd)
				{
					var indexToRemove=Array.IndexOf(queues[floor], person);
					queues[floor]= queues[floor].Where((source, index) => index != indexToRemove).ToArray();
				}
				lift.spaceLeft.AddRange(personToAdd);
			}
		}
		for (var floor = queues.GetLength(0)-1; floor >= 0; floor--)
		{
			lift.currentFloor = floor;
			if (queues[floor].Length == 0 && lift.spaceLeft.Count == 0)
			{
				count++;
				continue;
			}
			for (var person = 0; person < lift.spaceLeft.Count; person++)
				if (lift.spaceLeft[person] == floor)
				{
					if (stops[^1] != floor)
						stops.Add(floor);
					lift.spaceLeft.RemoveAt(person);
				}
			if (lift.spaceLeft.Count != totalCapacity && queues[floor].Length != 0)
			{
				for (var person = 0; person < queues[floor].Length; person++)
					if (queues[floor][person] < floor && lift.spaceLeft.Count != capacity)
					{
						if (stops[^1] != floor)
							stops.Add(floor);
						personToAdd.Add(queues[floor][person]);
					}
				foreach (var person in personToAdd)
				{
					var indexToRemove = Array.IndexOf(queues[floor], person);
					queues[floor] = queues[floor].Where((source, index) => index != indexToRemove).ToArray();
				}
				lift.spaceLeft.AddRange(personToAdd);
			}

		}
		stops.Add(0);
		return stops.ToArray();
	}
}