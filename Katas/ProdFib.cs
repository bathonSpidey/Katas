namespace Katas.Tests;

public class ProdFib
{
	public static ulong[] ProductFib(ulong product)
	{
		ulong previous = 0;
		ulong current = 1;
		while (previous * current < product)
		{
			var swap = current;
			current = previous + current;
			previous = swap;
		}
		ulong exact = 0;
		if (product == previous * current)
			exact = 1;
		return new[] { previous, current, exact };
	}
}