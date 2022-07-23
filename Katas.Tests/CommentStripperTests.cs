//using System.Text.RegularExpressions;

//namespace Katas.Tests;

//public class CommentStripperTests
//{
//	[Test]
//	public void SimpleCommentShouldBeRemoved()
//	{
//		var result = CommentStripper.StripComments("apples, pears # and bananas\nthis #something",
//			new[] { "#" });
//		Assert.That(result, Is.EqualTo("apples, pears\nthis"));
//	}

//	[Test]
//	public void MultipleCommentShouldBeRemoved()
//	{
//		var result =
//			CommentStripper.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples",
//				new[] { "#", "!" });
//		Assert.That(result, Is.EqualTo("apples, pears\ngrapes\nbananas"));
//	}
//}

//public class CommentStripper
//{
//	public static string StripComments(string text, string[] commentSymbols)
//	{
//		var tokens=text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
//		var resultTokens= new List<string>();
//		foreach (var token in tokens)
//		{
//			foreach (var commentSymbol in commentSymbols)
//			{
//				if ()
//				var index=token.IndexOf(commentSymbol);
//				var removed = "";
//				if (index == -1)
//				{
//					if (!resultTokens.Any(token.Contains))
//						resultTokens.Add(token);
//				}
//				else
//					{
//						removed = token.Substring(0, index).TrimEnd();
//						resultTokens.Add(removed);
//					}
//			}
//		}
//		//var result = "";
//		//foreach (var symbol in commentSymbols)
//		//{ 
//		//	result = Regex.Replace(text, $"({symbol}.*?)(?=\n)", string.Empty);
//		//	result = Regex.Replace(result, " \n", "\n");
			
//		//}
//		return string.Join("\n", resultTokens);
//	}
//}