namespace Katas.Tests;

public class MixingTests
{
	[TestCase("A aaaa bb c", "& aaa bbb c d", "1:aaaa/2:bbb")]
	[TestCase("Are they here", "yes, they are here", "2:eeeee/2:yy/=:hh/=:rr")]
	[TestCase("looping is fun but dangerous", "less dangerous than coding",
		"1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg")]
	[TestCase("codewars", "codewars", "")]
	public void SimpleMix(string first, string second, string expected) =>
		Assert.That(Mixing.Mix(first, second), Is.EqualTo(expected));
}