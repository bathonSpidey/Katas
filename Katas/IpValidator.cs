namespace Katas;

public class IpValidator
{
	public static bool IsValidIp(string ip)
	{
		if (ip.Count(x => x == '.') != 3 || ip.Contains(" ") || ip.Contains("-"))
			return false;
		var splitValues = ip.Split('.');
		foreach (var splitValue in splitValues)
		{
			if (splitValue.StartsWith("0", StringComparison.Ordinal) && splitValue.Length > 1)
				return false;
			if (!(int.TryParse(splitValue, out var value) && value >= 0 && value <= 255))
				return false;
		}
		return true;
	}
}