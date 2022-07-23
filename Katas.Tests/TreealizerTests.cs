namespace Katas.Tests;

public class TreealizerTests
{
	[Test]
	public void Null()
	{
		var result = Treealizer.ArrayToTree(new List<int>().ToArray());
		Assert.That(result, Is.Null);
	}

	[Test]
	public void OneLevelTree()
	{
		var result = Treealizer.ArrayToTree(new List<int> { 1, 2, 3 }.ToArray());
		var expected = new TreeNode(new TreeNode(2), new TreeNode(3), 1);
		Assert.That(result!.value, Is.EqualTo(expected.value));
	}
}