namespace Katas.Tests;

public class TreeSum
{
	public static int MaxSum(TreeNode? root) =>
		root == null
			? 0
			: root.value + Math.Max(MaxSum(root.left), MaxSum(root.right));
}