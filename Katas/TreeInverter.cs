namespace Katas;

public class TreeInverter
{
	public static TreeNode InvertTree(TreeNode? root)
	{
		if (root != null)
		{
			(root.left, root.right) = (root.right, root.left);
			InvertTree(root.left);
			InvertTree(root.right);
			return root;
		}
		return null!;
	}
}