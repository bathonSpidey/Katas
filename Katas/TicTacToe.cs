namespace Katas;

public class TicTacToe
{
	public int IsSolved(int[,] boardState)
	{
		var winner = CheckRows(boardState);
		if (winner > 0)
			return winner;
		winner = CheckCols(boardState);
		if (winner > 0)
			return winner;
		winner = CheckDiagonals(boardState);
		if (winner > 0)
			return winner;
		winner = CheckIncomplete(boardState);
		return winner;
	}

	private static int CheckDiagonals(int[,] boardState) =>
		boardState[0, 0] == boardState[1, 1] && boardState[0, 0] == boardState[2, 2] ||
		boardState[0, 2] == boardState[1, 1] && boardState[2, 0] == boardState[1, 1]
			? boardState[1, 1]
			: -1;

	private static int CheckIncomplete(int[,] boardState)
	{
		for (var row = 0; row < boardState.GetLength(0); row++)
		for (var col = 0; col < boardState.GetLength(1); col++)
			if (boardState[row, col] == 0)
				return -1;
		return 0;
	}

	private static int CheckCols(int[,] boardState)
	{
		var winner = -1;
		for (var col = 0; col < boardState.GetLength(1); col++)
			if (boardState[0, col] == boardState[1, col] && boardState[0, col] == boardState[2, col] &&
					boardState[0, col] != 0)
			{
				winner = boardState[0, col];
				break;
			}
		return winner;
	}

	private static int CheckRows(int[,] boardState)
	{
		var winner = -1;
		for (var row = 0; row < boardState.GetLength(0); row++)
			if (boardState[row, 0] == boardState[row, 1] && boardState[row, 0] == boardState[row, 2] &&
					boardState[row, 0] != 0)
			{
				winner = boardState[row, 0];
				break;
			}
		return winner;
	}
}