namespace Katas;

public class Sudoku
{
	public static bool ValidateSolution(int[][] puzzle) =>
		CheckEmptySpaces(puzzle) && CheckRowsAndColumns(puzzle) && CheckQuadrant(puzzle);

	private static bool CheckQuadrant(int[][] puzzle) => puzzle[0][1] != puzzle[1][0];

	private static bool CheckRowsAndColumns(int[][] puzzle)
	{
		var rowSum = 0;
		var colSum = 0;
		var start = 0;
		while (start < 9)
		{
			for (var col = 0; col < puzzle[0].Length; col++)
				rowSum += puzzle[start][col];
			if (rowSum != Total)
				return false;
			colSum += puzzle.Sum(row => row[start]);
			if (colSum != Total)
				return false;
			start++;
			rowSum = 0;
			colSum = 0;
		}
		return true;
	}

	private const int Total = 45;

	private static bool CheckEmptySpaces(int[][] puzzle)
	{
		foreach (var row in puzzle)
		{
			if (row.Length != row.Distinct().Count())
				return false;
			for (var col = 0; col < puzzle[0].Length; col++)
				if (row[col] == 0)
					return false;
		}
		return true;
	}
}