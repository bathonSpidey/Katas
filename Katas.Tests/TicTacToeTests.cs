namespace Katas.Tests;

public class TicTacToeTests
{
	[Test]
	public void IncompleteState()
	{
		var tictac = new TicTacToe();
		var result = tictac.IsSolved(new[,] { { 0, 0, 1 }, { 0, 1, 2 }, { 2, 1, 0 } });
		Assert.That(result, Is.EqualTo(-1));
	}

	[TestCaseSource(nameof(BoardStates))]
	public void RowWinner(int expected, int[,] board)
	{
		var tictac = new TicTacToe();
		var result = tictac.IsSolved(board);
		Assert.That(result, Is.EqualTo(expected));
	}

	//ncrunch: no coverage start
	public static IEnumerable<TestCaseData> BoardStates()
	{
		yield return new TestCaseData(1, new[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } });
		yield return new TestCaseData(2, new[,] { { 2, 2, 2 }, { 0, 1, 1 }, { 0, 0, 0 } });
		yield return new TestCaseData(2, new[,] { { 0, 0, 0 }, { 2, 2, 2 }, { 0, 1, 1 } });
		yield return new TestCaseData(1, new[,] { { 1, 0, 0 }, { 1, 2, 2 }, { 1, 0, 0 } });
		yield return new TestCaseData(1, new[,] { { 1, 2, 1 }, { 0, 1, 2 }, { 2, 0, 1 } });
		yield return new TestCaseData(0, new[,] { { 1, 2, 1 }, { 2, 2, 1 }, { 1, 1, 2 } });
	}
	//ncrunch: no coverage end
}