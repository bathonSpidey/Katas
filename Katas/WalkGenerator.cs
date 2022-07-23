namespace Katas;

public class WalkGenerator
{
	public static bool ValidWalk(string[] walk)
	{
		if (walk.Length != 10)
			return false;
		var total = 0;
		foreach (var direction in walk)
			switch (direction)
			{
			case "n":
				total += 1;
				break;
			case "e":
				total += 2;
				break;
			case "w":
				total -= 2;
				break;
			default:
				total -= 1;
				break;
			}
		return total == 0;
	}
}