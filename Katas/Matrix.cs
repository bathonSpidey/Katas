namespace Katas;

public class Matrix
{
	public static int Determinant(int[][] matrix) => Calculate(matrix, matrix.Length);

	private static int Calculate(int[][] matrix, int dimension)
	{
		var determinant = 0;
		var subMatrix = new int[dimension, dimension];
		if (dimension == 2)
			return matrix[0][0] * matrix[1][1] - matrix[1][0] * matrix[0][1];
		for (var iteration = 0; iteration < dimension; iteration++)
		{
			var subRow = 0;
			for (var row = 1; row < dimension; row++)
			{
				var subColumn = 0;
				for (var column = 0; column < dimension; column++)
				{
					if (column == iteration)
						continue;
					subMatrix[subRow, subColumn] = matrix[row][column];
					subColumn++;
				}
				subRow++;
			}
			if (iteration % 2 == 0)
				determinant += matrix[0][iteration] * Calculate(ToJaggedArray(subMatrix), dimension - 1);
			else
				determinant -= matrix[0][iteration] * Calculate(ToJaggedArray(subMatrix), dimension - 1);
		}
		return determinant;
	}

	//stackoverflow, https://stackoverflow.com/questions/21986909/convert-multidimensional-array-to-jagged-array-in-c-sharp
	internal static int[][] ToJaggedArray(int[,] twoDimensionalArray)
	{
		var rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
		var rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
		var numberOfRows = rowsLastIndex + 1;
		var columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
		var columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
		var numberOfColumns = columnsLastIndex + 1;
		var jaggedArray = new int[numberOfRows][];
		for (var i = rowsFirstIndex; i <= rowsLastIndex; i++)
		{
			jaggedArray[i] = new int[numberOfColumns];
			for (var j = columnsFirstIndex; j <= columnsLastIndex; j++)
				jaggedArray[i][j] = twoDimensionalArray[i, j];
		}
		return jaggedArray;
	}
}