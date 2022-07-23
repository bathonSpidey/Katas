namespace Katas;

public class TwinPrime
{
	public static bool IsTwinPrime(int number) => IsPrime(number) && (IsPrime(number + 2) || IsPrime(number - 2));

	private static bool IsPrime(int number)
	{
		if (number <= 1)
			return false;
		if (number == 2)
			return true;
		if (number % 2 == 0)
			return false;
		for (var i = 3; i <= (int)Math.Floor(Math.Sqrt(number)); i += 2)
			if (number % i == 0)
				return false;
		return true;
	}
}