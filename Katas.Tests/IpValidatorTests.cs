namespace Katas.Tests;

public class IpValidatorTests
{
	[TestCase("")]
	[TestCase("1.2.3")]
	[TestCase("1.2.3.4.5")]
	[TestCase("123.456.78.90")]
	[TestCase("123.045.067.089")]
	[TestCase("abc.def.ghi.jkl")]
	[TestCase("123.456.789.0")]
	[TestCase("12.34.56")]
	[TestCase("12.34.56.00")]
	[TestCase("12.34.56.7.8")]
	[TestCase("12.34.256.78")]
	[TestCase("12.34.256.78")]
	[TestCase("113.4.-0.255")]
	[TestCase("12.34.56 .1")]
	[TestCase("12.34.56.78sf")]
	[TestCase("pr12.34.56.78")]
	public void InvalidIps(string ip)
	{
		var result = IpValidator.IsValidIp(ip);
		Assert.That(result, Is.False);
	}

	[TestCase("1.2.3.4")]
	[TestCase("0.0.0.0")]
	[TestCase("137.255.156.100")]
	public void ValidIps(string ip)
	{
		var result = IpValidator.IsValidIp(ip);
		Assert.That(result, Is.True);
	}
}