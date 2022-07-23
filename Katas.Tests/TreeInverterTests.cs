using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tests
{
		public class TreeInverterTests
		{
			[Test]
			public void SimpleTree()
			{
				var result = TreeInverter.InvertTree(new TreeNode(new TreeNode(null, null, 2),
					new TreeNode(null, null, 3), 1));
				var expected = new TreeNode(new TreeNode(null, null, 3), new TreeNode(null, null, 2), 1);
				Assert.That(result.left.value, Is.EqualTo(expected.left.value));
			}

			[Test]
			public void TwoLevelTree()
			{
				var result = TreeInverter.InvertTree(new TreeNode(new TreeNode(new TreeNode(null, null, 4), new TreeNode(null, null, 5), 2),
					new TreeNode(new TreeNode(null, null, 6), new TreeNode(null, null, 7), 3), 1));
				var expected = new TreeNode(new TreeNode(new TreeNode(null, null, 7), new TreeNode(null, null, 6), 3), new TreeNode(new TreeNode(null, null, 4), new TreeNode(null, null, 5), 2), 1);
				Assert.That(result.left.left.value, Is.EqualTo(expected.left.left.value));
			}
	}
}
