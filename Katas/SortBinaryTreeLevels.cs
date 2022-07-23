namespace Katas;

public class SortBinaryTreeLevels
{
	public static List<int> TreeByLevels(TreeNode? root)
	{
		if (root == null)
			return new List<int>();
		ListPerLevel.Clear();
		ListPerLevel.Add(0, new List<int>());
		AddLevelNumbers(root, 1);
		var result = new List<int>();
		for (var level = 0; level < ListPerLevel.Count; level++)
			result.AddRange(ListPerLevel[level]);
		return result;
	}

	private static readonly Dictionary<int, List<int>> ListPerLevel = new();

	private static void AddLevelNumbers(TreeNode node, int level)
	{
		ListPerLevel[level-1].Add(node.value);
		if (node.left == null && node.right == null)
			return;
		if (!ListPerLevel.ContainsKey(level))
			ListPerLevel.Add(level, new List<int>());
		if (node.left != null)
			AddLevelNumbers(node.left, level + 1);
		if (node.right != null)
			AddLevelNumbers(node.right, level + 1);
	}
}