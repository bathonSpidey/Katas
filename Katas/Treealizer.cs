namespace Katas;

public class Treealizer
{
	public static TreeNode? ArrayToTree(int[] array, int index = 0)
	{
		if (index >= array.Length)
			return null;
		return new TreeNode(ArrayToTree(array, 2 * index + 1)!, ArrayToTree(array, 2 * index + 2)!,
			array[index]);
	}
}