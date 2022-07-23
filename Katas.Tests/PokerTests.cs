namespace Katas.Tests;

public class PokerTests
{
	[TestCase("KS AS TS QS JS", HandValue.RoyalFlush)]
	[TestCase("2H 3H 4H 5H 6H", HandValue.StraightFlush)]
	[TestCase("AS AH 2H AD AC", HandValue.FourOfAKind)]
	[TestCase("2S AH 2H AS AC", HandValue.FullHouse)]
	[TestCase("2H 3H 5H 6H 7H", HandValue.Flush)]
	[TestCase("2S 3H 4H 5S 6C", HandValue.Straight)]
	[TestCase("AH AC 5H 6H AS", HandValue.ThreeOfAKind)]
	[TestCase("2S 2H 4H 5S 4C", HandValue.TwoPairs)]
	[TestCase("AH AC 5H 6H 7S", HandValue.Pair)]
	[TestCase("2S 2H 4H 5S 4C", HandValue.TwoPairs)]
	[TestCase("2S AH 4H 5S KC", HandValue.HighCard)]
	[TestCase("JH 9H TH KH QH", HandValue.StraightFlush)]
	[TestCase("4S 3H 2C 7S 5H", HandValue.HighCard)]
	public void HandsShouldReturnRank(string hand, HandValue value) =>
		Assert.That(new PokerHand(hand).Rank, Is.EqualTo(value));

	[TestCase("2H 3H 4H 5H 6H", "KS AS TS QS JS", Result.Loss)]
	[TestCase("2H 3H 4H 5H 6H", "AS AD AC AH JD", Result.Win)]
	[TestCase("AS AH 2H AD AC", "JS JD JC JH 3D", Result.Win)]
	[TestCase("2S AH 2H AS AC", "JS JD JC JH AD", Result.Loss)]
	[TestCase("2S AH 2H AS AC", "2H 3H 5H 6H 7H", Result.Win)]
	[TestCase("AS 3S 4S 8S 2S", "2H 3H 5H 6H 7H", Result.Win)]
	[TestCase("2S 3H 4H 5S 6C", "3D 4C 5H 6H 2S", Result.Tie)]
	[TestCase("2S AH 2H AS AC", "JS JD JC JH AD", Result.Loss)]
	[TestCase("2S AH 2H AS AC", "2H 3H 5H 6H 7H", Result.Win)]
	public void CompareRanks(string hand, string otherHand, Result expected) =>
		Assert.That(new PokerHand(hand).CompareWith(new PokerHand(otherHand)), Is.EqualTo(expected));

	[TestCase("Highest straight flush wins", Result.Loss, "2H 3H 4H 5H 6H", "KS AS TS QS JS")]
	[TestCase("Straight flush wins of 4 of a kind", Result.Win, "2H 3H 4H 5H 6H", "AS AD AC AH JD")]
	[TestCase("Highest 4 of a kind wins", Result.Win, "AS AH 2H AD AC", "JS JD JC JH 3D")]
	[TestCase("4 Of a kind wins of full house", Result.Loss, "2S AH 2H AS AC", "JS JD JC JH AD")]
	[TestCase("Full house wins of flush", Result.Win, "2S AH 2H AS AC", "2H 3H 5H 6H 7H")]
	[TestCase("Highest flush wins", Result.Win, "AS 3S 4S 8S 2S", "2H 3H 5H 6H 7H")]
	[TestCase("Flush wins of straight", Result.Win, "2H 3H 5H 6H 7H", "2S 3H 4H 5S 6C")]
	[TestCase("Equal straight is tie", Result.Tie, "2S 3H 4H 5S 6C", "3D 4C 5H 6H 2S")]
	[TestCase("Straight wins of three of a kind", Result.Win, "2S 3H 4H 5S 6C", "AH AC 5H 6H AS")]
	[TestCase("3 Of a kind wins of two pair", Result.Loss, "2S 2H 4H 5S 4C", "AH AC 5H 6H AS")]
	[TestCase("2 Pair wins of pair", Result.Win, "2S 2H 4H 5S 4C", "AH AC 5H 6H 7S")]
	[TestCase("Highest pair wins", Result.Loss, "6S AD 7H 4S AS", "AH AC 5H 6H 7S")]
	[TestCase("Pair wins of nothing", Result.Loss, "2S AH 4H 5S KC", "AH AC 5H 6H 7S")]
	[TestCase("Highest card loses", Result.Loss, "2S 3H 6H 7S 9C", "7H 3C TH 6H 9S")]
	[TestCase("Highest card wins", Result.Win, "4S 5H 6H TS AC", "3S 5H 6H TS AC")]
	[TestCase("Equal cards is tie", Result.Tie, "2S AH 4H 5S 6C", "AD 4C 5H 6H 2C")]
	[TestCase("Hard Test", Result.Loss, "7C 7S 3S 7H 5S", "AC KH QH AH AS")]
	public void PokerHandTest(string description, Result expected, string hand, string opponentHand) => Assert.AreEqual(expected, new PokerHand(hand).CompareWith(new PokerHand(opponentHand)), description);
}