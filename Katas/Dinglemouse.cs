namespace Katas;

public class Dinglemouse
{
	public static int PeakHeight(char[][] mountain)
	{
		var currentElevation = 0;
		var spiral = true;
		while (spiral)
		{
			var increaseElevation = false;
			spiral = false;
			var newMountain = new char[mountain.Length][];
			for (var row = 0; row < mountain.Length; row++)
				newMountain[row] = (char[])mountain[row].Clone();
			for (var column = 0; column < mountain.Length; column++)
			for (var innerRow = 0; innerRow < mountain[column].Length; innerRow++)
				if (isOnTheEdge(column, innerRow, mountain))
				{
					if (mountain[column][innerRow] != ' ')
					{
						increaseElevation = true;
						newMountain[column][innerRow] = ' ';
					}
				}
				else
				{
					spiral = true;
				}
			mountain = newMountain;
			if (increaseElevation)
				currentElevation++;
		}
		return currentElevation;
	}

	private static bool isOnTheEdge(int y, int x, char[][] mountain)
	{
		if (y == 0 || x == 0 || y == mountain.Length - 1 || x == mountain[0].Length - 1)
			return true;
		char[] borders =
		{
			mountain[y + 1][x], mountain[y - 1][x], mountain[y][x + 1], mountain[y][x - 1]
		};
		return borders.Any(edge => edge == ' ');
	}
}