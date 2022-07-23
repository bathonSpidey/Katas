namespace Katas.Tests;

public class SudokuTests
{
	[Test]
	public void AnyEmptyCellShouldBeFalse()
	{
		var puzzle = new[]
		{
			new[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, new[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
			new[] { 1, 9, 8, 3, 0, 2, 5, 6, 7 }, new[] { 8, 5, 0, 7, 6, 1, 4, 2, 3 },
			new[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, new[] { 7, 0, 3, 9, 2, 4, 8, 5, 6 },
			new[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, new[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
			new[] { 3, 0, 0, 2, 8, 6, 1, 7, 9 }
		};
		var solve = Sudoku.ValidateSolution(puzzle);
		Assert.That(solve, Is.False);
	}

	[Test]
	public void DuplicateShouldBeFalse()
	{
		var puzzle = new[]
		{
			new[] { 5, 3, 4, 6, 7, 8, 9, 5, 2 }, new[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
			new[] { 1, 9, 8, 3, 0, 2, 5, 6, 7 }, new[] { 8, 5, 0, 7, 6, 1, 4, 2, 3 },
			new[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, new[] { 7, 0, 3, 9, 2, 4, 8, 5, 6 },
			new[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, new[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
			new[] { 3, 0, 0, 2, 8, 6, 1, 7, 9 }
		};
		var solve = Sudoku.ValidateSolution(puzzle);
		Assert.That(solve, Is.False);
	}

	[Test]
	public void ValidSHouldBeTrue()
	{
		var puzzle = new[]
		{
			new[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 }, new[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
			new[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 }, new[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
			new[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 }, new[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
			new[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 }, new[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
			new[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
		};
		var solve = Sudoku.ValidateSolution(puzzle);
		Assert.That(solve, Is.True);
	}

	[Test]
	public void RepeatedQuadrant()
	{
		var puzzle = new[]
		{
			new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 2, 3, 1, 5, 6, 4, 8, 9, 7 },
			new[] { 3, 1, 2, 6, 4, 5, 9, 7, 8 }, new[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 },
			new[] { 5, 6, 4, 8, 9, 7, 2, 3, 1 }, new[] { 6, 4, 5, 9, 7, 8, 3, 1, 2 },
			new[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 }, new[] { 8, 9, 7, 2, 3, 1, 5, 6, 4 },
			new[] { 9, 7, 8, 3, 1, 2, 6, 4, 5 }
		};
		var solve = Sudoku.ValidateSolution(puzzle);
		Assert.That(solve, Is.False);
	}
}