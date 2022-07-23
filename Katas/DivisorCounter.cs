namespace Katas;

public class DivisorsCounter
{
	public static long CountDivisors(long number)
	{
		var total = 0L;
		var sqrt = (long)Math.Sqrt(number);
		for (var factor = 1L; factor <= sqrt; factor++)
			total += number / factor * 2;
		total -= sqrt * sqrt;
		return total;
	}
}