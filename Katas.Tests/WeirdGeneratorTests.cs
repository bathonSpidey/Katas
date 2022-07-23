namespace Katas.Tests;

public class WeirdGeneratorTests
{
	[Test]
	public void SimpleCase()
	{
		var result = WeirdGenerator.ToWeirdCase("abc");
		Assert.That(result, Is.EqualTo("AbC"));
	}

	[Test]
	public void SimpleSentenceCase()
	{
		var result = WeirdGenerator.ToWeirdCase("This is a test");
		Assert.That(result, Is.EqualTo("ThIs Is A TeSt"));
	}
}