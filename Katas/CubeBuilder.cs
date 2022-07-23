namespace Katas;

public class CubeBuilder
{
	public static long findNb(long number)
	{
		long total = 0;
		var count = 0;
		for (var index = 1; index < number; index++)
		{
			total += (long)Math.Pow(index, 3);
			count++;
			if (total == number)
				return count;
			if (total > number)
				return -1;
		}
		return -1;
	}
}