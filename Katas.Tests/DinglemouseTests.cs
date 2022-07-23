namespace Katas.Tests;

public class DinglemouseTests
{
	[Test]
	public void EmptyView()
	{
		char[][] view = { };
		var height = Dinglemouse.PeakHeight(view);
		Assert.That(height, Is.EqualTo(0));
	}

	[Test]
	public void OneView()
	{
		char[][] view = { "^^^^^^        ".ToCharArray() };
		var height = Dinglemouse.PeakHeight(view);
		Assert.That(height, Is.EqualTo(1));
	}

	[Test]
	public void TwoView()
	{
		char[][] view = { "^^^^^^        ".ToCharArray(), " ^^^^^^^^     ".ToCharArray() };
		var height = Dinglemouse.PeakHeight(view);
		Assert.That(height, Is.EqualTo(1));
	}

	[Test]
	public void ThreeView()
	{
		char[][] view =
		{
			"^^^^^^        ".ToCharArray(), " ^^^^^^^^     ".ToCharArray(),
			"  ^^^^^^^     ".ToCharArray()
		};
		var height = Dinglemouse.PeakHeight(view);
		Assert.That(height, Is.EqualTo(2));
	}

	[Test]
	public void SimpleMountain()
	{
		char[][] view =
		{
			"^^^^^^        ".ToCharArray(), " ^^^^^^^^     ".ToCharArray(),
			"  ^^^^^^^     ".ToCharArray(), "  ^^^^^       ".ToCharArray(),
			"  ^^^^^^^^^^^ ".ToCharArray(), "  ^^^^^^      ".ToCharArray(),
			"  ^^^^        ".ToCharArray()
		};
		var height = Dinglemouse.PeakHeight(view);
		Assert.That(height, Is.EqualTo(3));
	}
}