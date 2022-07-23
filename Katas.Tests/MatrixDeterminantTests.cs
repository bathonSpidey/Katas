namespace Katas.Tests;

public class MatrixDeterminantTests
{
	[Test]
	public void TwoByTwo()
	{
		var matrix = new[] { new[] { 1, 3 }, new[] { 2, 5 } };
		var solved = Matrix.Determinant(matrix);
		Assert.That(solved, Is.EqualTo(-1));
	}

	[Test]
	public void ThreeByThree()
	{
		var matrix = new[] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } };
		var solved = Matrix.Determinant(matrix);
		Assert.That(solved, Is.EqualTo(-20));
	}
}