namespace Katas;

public class TreeNode
{

	public TreeNode(TreeNode left, TreeNode right, int value)
	{
		this.left = left;
		this.right = right;
		this.value = value;
	}
	public TreeNode left;
	public TreeNode right;
	public int value;

	public TreeNode(int value) => this.value = value;
	public static TreeNode Leaf(int value) => new(value);

	public TreeNode WithLeaves(int leftVal, int rightVal)
	{
		left = new TreeNode(leftVal);
		right = new TreeNode(rightVal);
		return this;
	}

	public static TreeNode Join(int value, TreeNode leftNode, TreeNode rightNode)
	{
		var node = new TreeNode(value);
		node.left = leftNode;
		node.right = rightNode;
		return node;
	}
}