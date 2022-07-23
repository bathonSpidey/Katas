namespace Katas;

public class Mixing
{
	public static string Mix(string firstText, string secondText)
	{
		var commonDictionary = Tracker(firstText, secondText);
		var result = ResultBuilder(commonDictionary);
		return result == ""
			? result
			: result.Remove(result.Length - 1, 1);
	}

	private static Dictionary<string, List<int>> Tracker(string firstText, string secondText)
	{
		var commonDictionary = new Dictionary<string, List<int>>();
		foreach (var alphabet in Alphabets)
		{
			var countFirstText = firstText.Count(c => c == alphabet);
			var countSecondText = secondText.Count(c => c == alphabet);
			if (countFirstText > countSecondText && countFirstText > 1)
				commonDictionary[alphabet.ToString()] = new List<int> { 1, countFirstText };
			else if (countSecondText > countFirstText && countSecondText > 1)
				commonDictionary[alphabet.ToString()] = new List<int> { 2, countSecondText };
			else if (countFirstText == countSecondText && countSecondText > 1)
				commonDictionary[alphabet.ToString()] = new List<int> { 3, countFirstText };
		}
		return commonDictionary;
	}

	private static readonly List<char> Alphabets = new()
	{
		'a',
		'b',
		'c',
		'd',
		'e',
		'f',
		'g',
		'h',
		'i',
		'j',
		'k',
		'l',
		'm',
		'n',
		'o',
		'p',
		'q',
		'r',
		's',
		't',
		'u',
		'v',
		'w',
		'x',
		'y',
		'z'
	};

	private static string ResultBuilder(Dictionary<string, List<int>> commonDictionary)
	{
		var result = "";
		var finalSorted = commonDictionary.OrderByDescending(a => a.Value[1]).ThenBy(a => a.Value[0]);
		foreach (var entry in finalSorted)
		{
			var key = entry.Value[0].ToString();
			if (key == "3")
				key = "=";
			result += $"{key}:{string.Concat(Enumerable.Repeat(entry.Key, entry.Value[1]))}/";
		}
		return result;
	}
}