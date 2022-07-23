//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Katas.Tests
//{
//		public class TreeNodeTests
//		{
//			[Test]
//			public void NullTreeShouldBeTree()
//			{
//				TreeNode root = null;
//				var result = TreeNode.IsPerfect(root);
//				Assert.IsTrue(result);
//			}

//			[Test]
//			public void TwiNodeIsPerfect()
//			{
//				TreeNode root = TreeNode.Leaf().WithLeaves(); ;
//				var result = TreeNode.IsPerfect(root);
//				Assert.IsTrue(result);
//			}

//	}

//		public class TreeNode
//		{
//			public TreeNode left;
//			public TreeNode right;

//			public static bool IsPerfect(TreeNode root)
//			{
//				if (root == null)
//					return true;
//				if (this.left!=null && right!=null)

//				return false;
//			}

//			public static TreeNode Leaf()
//			{
//				return new TreeNode();
//			}

//			public static TreeNode Join(TreeNode left, TreeNode right)
//			{
//				return new TreeNode().WithChildren(left, right);
//			}

//			public TreeNode WithLeft(TreeNode left)
//			{
//				this.left = left;
//				return this;
//			}

//			public TreeNode WithRight(TreeNode right)
//			{
//				this.right = right;
//				return this;
//			}

//			public TreeNode WithChildren(TreeNode left, TreeNode right)
//			{
//				this.left = left;
//				this.right = right;
//				return this;
//			}

//			public TreeNode WithLeftLeaf()
//			{
//				return WithLeft(Leaf());
//			}

//			public TreeNode WithRightLeaf()
//			{
//				return WithRight(Leaf());
//			}

//			public TreeNode WithLeaves()
//			{
//				return WithChildren(Leaf(), Leaf());
//			}
//		}
//}
