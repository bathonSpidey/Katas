namespace Katas;

public class PokerHand
{
	public HandValue Rank;
	public PokerHand(string hand) => Rank = DetermineHandValue(hand.Split());
	public int HighestValueFourOfAKind { get; set; }
	public int SumStraight { get; set; }
	public int SumFLush { get; set; }
	public int HighCard { get; set; }
	public int HighPair { get; set; }
	public int ThreeKindHighest { get; set; }
	public int HighStraightFlush { get; set; }
	private readonly Dictionary<string, int> cardValueLookUp = new()
	{
		{ "T", 10 },
		{ "J", 11 },
		{ "Q", 12 },
		{ "K", 13 },
		{ "A", 14 }
	};

	public Result CompareWith(PokerHand otherHand)
	{
		if ((int)Rank > (int)otherHand.Rank)
			return Result.Win;
		if ((int)Rank < (int)otherHand.Rank)
			return Result.Loss;
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.FourOfAKind)
		{
			if (HighestValueFourOfAKind > otherHand.HighestValueFourOfAKind)
				return Result.Win;
			if (HighestValueFourOfAKind < otherHand.HighestValueFourOfAKind)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.Flush)
		{
			if (SumFLush > otherHand.SumFLush)
				return Result.Win;
			if (SumFLush < otherHand.SumFLush)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.Straight)
		{
			if (SumStraight > otherHand.SumStraight)
				return Result.Win;
			if (SumStraight < otherHand.SumStraight)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.ThreeOfAKind)
		{
			if (ThreeKindHighest > otherHand.ThreeKindHighest)
				return Result.Win;
			if (ThreeKindHighest < otherHand.ThreeKindHighest)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.HighCard)
		{
			if (HighCard > otherHand.HighCard)
				return Result.Win;
			if (HighCard < otherHand.HighCard)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.Pair)
		{
			if (HighPair > otherHand.HighPair)
				return Result.Win;
			if (HighPair < otherHand.HighPair)
				return Result.Loss;
		}
		if ((int)Rank == (int)otherHand.Rank && Rank == HandValue.StraightFlush)
		{
			if (HighStraightFlush > otherHand.HighStraightFlush)
				return Result.Win;
			if (HighStraightFlush < otherHand.HighStraightFlush)
				return Result.Loss;
		}
		return Result.Tie;
	}

	private HandValue DetermineHandValue(string[] hand)
	{
		if (isRoyalFlush(hand))
			return HandValue.RoyalFlush;
		if (isStraightFlush(hand))
			return HandValue.StraightFlush;
		if (isFourOfAKind(hand))
			return HandValue.FourOfAKind;
		if (isFullHouse(hand))
			return HandValue.FullHouse;
		if (isFlush(hand))
			return HandValue.Flush;
		if (isStraight(hand))
			return HandValue.Straight;
		if (isThreeOfAKind(hand))
			return HandValue.ThreeOfAKind;
		if (isTwoPairs(hand))
			return HandValue.TwoPairs;
		if (isPair(hand))
			return HandValue.Pair;
		var cardValues = SerializeCards(hand);
		HighCard = cardValues.Sum();
		return HandValue.HighCard;
	}

	private bool isPair(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		var groups = cardValues.GroupBy(x => x);
		HighPair = cardValues.Sum();
		foreach (var group in groups.Where(group => group.Count() == 2))
			HighCard = group.Key;
		return groups.Count(group => group.Count() == 2) == 1;
	}

	private bool isTwoPairs(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		var groups = cardValues.GroupBy(x => x);
		return groups.Count(group => group.Count() == 2) == 2;
	}

	private bool isThreeOfAKind(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		var groups = cardValues.GroupBy(x => x);
		ThreeKindHighest = cardValues.Sum();
		return groups.First().Count() == 3 || groups.Last().Count() == 3;
	}

	private bool isStraight(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		SumStraight = cardValues.Sum();
		cardValues.Sort();
		for (var index = 0; index < cardValues.Count - 1; index++)
			if (cardValues[index + 1] - cardValues[index] != 1)
				return false;
		return true;
	}

	private bool isFlush(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		SumFLush = cardValues.Sum();
		var previousSuit = "";
		foreach (var suit in hand.Select(card => card.Substring(card.Length - 1)))
		{
			if (previousSuit == "")
			{
				previousSuit = suit;
				continue;
			}
			if (previousSuit != suit)
				return false;
			previousSuit = suit;
		}
		return true;
	}

	private bool isFullHouse(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		var groups = cardValues.GroupBy(x => x);
		return groups.Count(group => group.Count() == 3) == 1 &&
			groups.Count(group => group.Count() == 2) == 1;
	}

	private bool isFourOfAKind(string[] hand)
	{
		var cardValues = SerializeCards(hand);
		var groups = cardValues.GroupBy(x => x);
		HighestValueFourOfAKind = cardValues.Sum();
		foreach (var group in groups.Where(group => group.Count() == 4))
			return true;
		return false;
	}

	private List<int> SerializeCards(string[] hand)
	{
		var cardValues = new List<int>();
		foreach (var value in hand.Select(card => card.Substring(0, 1)))
			if (value == "T" || value == "J" || value == "Q" || value == "K" || value == "A")
			{
				cardValues.Add(cardValueLookUp[value]);
			}
			else
			{
				int.TryParse(value, out var cardNumber);
				cardValues.Add(cardNumber);
			}
		return cardValues;
	}

	private bool isStraightFlush(string[] hand)
	{
		var allSameSuit = CheckAllCardsHaveSameSuit(hand);
		if (!allSameSuit)
			return false;
		var numbers = SerializeCards(hand);
		HighStraightFlush = numbers.Sum();
		numbers.Sort();
		for (var index = 0; index < numbers.Count - 2; index++)
			if (numbers[index + 1] - numbers[index] != 1)
				return false;
		return true;
	}

	private bool isRoyalFlush(string[] hand) =>
		!hand.Any(card => int.TryParse(card.Substring(0, 1), out _)) &&
		CheckAllCardsHaveSameSuit(hand);

	private static bool CheckAllCardsHaveSameSuit(string[] hand)
	{
		var previousSuit = "";
		foreach (var currentSuit in hand.Select(card => card.Substring(card.Length - 1)))
		{
			if (previousSuit == "")
			{
				previousSuit = currentSuit;
				continue;
			}
			if (previousSuit != currentSuit)
				return false;
			previousSuit = currentSuit;
		}
		return true;
	}
}

public enum HandValue
{
	HighCard,
	Pair,
	TwoPairs,
	ThreeOfAKind,
	Straight,
	Flush,
	FullHouse,
	FourOfAKind,
	StraightFlush,
	RoyalFlush
}