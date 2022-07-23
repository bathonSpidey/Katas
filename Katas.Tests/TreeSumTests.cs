namespace Katas.Tests;

public class TreeSumTests
{
	[Test]
	public void NullTree()
	{
		var result = TreeSum.MaxSum(null);
		Assert.That(result, Is.EqualTo(0));
	}

	[Test]
	public void SimpleTree()
	{
		var root = TreeNode.Join(1, TreeNode.Leaf(2), TreeNode.Leaf(3));
		Assert.That(TreeSum.MaxSum(root), Is.EqualTo(4));
	}

	[Test]
	public void LongerTree()
	{
		var left = TreeNode.Leaf(-22).WithLeaves(9, 50);
		var right = TreeNode.Leaf(11).WithLeaves(9, 2);
		var root = TreeNode.Join(5, left, right);
		Assert.That(TreeSum.MaxSum(root), Is.EqualTo(33));
	}
}