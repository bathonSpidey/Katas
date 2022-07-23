namespace Katas;

public class SumGroups
{
	public static int Calculate(int[] sequence)
	{
		var previous = sequence[0];
		var result = new List<int>();
		var sum = previous;
		for (var i = 1; i <= sequence.Length; i++)
		{
			if (i != sequence.Length && previous % 2 == sequence[i] % 2)
				sum += sequence[i];
			else
			{
				if (result.Count >= 1 && sum % 2 == result.Last() % 2)
					result.RemoveAt(result.Count - 1);
				result.Add(sum);
				if (i != sequence.Length)
					sum = sequence[i];
			}
			if (i != sequence.Length)
				previous = sequence[i];
		}
		return result.Count;
	}
}