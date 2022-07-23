using System.Numerics;

namespace Katas;

public class PowerTower
{
	public static int Tower(BigInteger start, BigInteger height, int modulo)
	{
		if (modulo == 1)
			return 0;
		if (start == 1 || height == 0)
			return 1;
		var result = start;
		while (height > 1)
		{
			result = Pow(start, result);
			height--;
		}
		return (int)(result % modulo);
	}

	private static BigInteger Pow(BigInteger value, BigInteger exponent)
	{
		var originalValue = value;
		while (exponent-- > 1)
			value = BigInteger.Multiply(value, originalValue);
		return value;
	}
}