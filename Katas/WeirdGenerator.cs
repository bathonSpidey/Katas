namespace Katas;

public class WeirdGenerator
{
	public static string ToWeirdCase(string input)
	{
		var words=input.Split(' ');
		var result = new List<string>();
		foreach (var letters in words.Select(word => word.ToCharArray()))
		{
			for (var index = 0; index < letters.Length; index++)
				letters[index] = index % 2 == 0
					? char.ToUpper(letters[index])
					: char.ToLower(letters[index]);
			result.Add(new string(letters));
		}
		return string.Join(" ", result);
	}
}