namespace Katas.Tests;

public class SortBinaryTreeLevelsTests
{
	[Test]
	public void NullTest()
	{
		TreeNode tree = null;
		var sorted = SortBinaryTreeLevels.TreeByLevels(tree);
		Assert.That(sorted, Is.EqualTo(new List<int>()));
	}

	[Test]
	public void SimpleTree()
	{
		var simple = new TreeNode(new TreeNode(2), new TreeNode(3), 1);
		var sorted = SortBinaryTreeLevels.TreeByLevels(simple);
		Assert.That(sorted, Is.EqualTo(new List<int> { 1, 2, 3 }));
	}

	[Test]
	public void LongerTree()
	{
		var simple = new TreeNode(new TreeNode(null, new TreeNode(null, null, 4), 2),
			new TreeNode(new TreeNode(null, null, 5), new TreeNode(null, null, 6), 3), 1);
		var sorted = SortBinaryTreeLevels.TreeByLevels(simple);
		Assert.That(sorted, Is.EqualTo(new List<int>
		{
			1,
			2,
			3,
			4,
			5,
			6
		}));
	}
}