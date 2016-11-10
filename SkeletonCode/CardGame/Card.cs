namespace SkeletonCode.CardGame
{
	public sealed class Card : ICard
	{
		public Card(Suit suit, Face face)
		{
			Suit = suit;
			Face = face;
		}

		public Suit Suit { get; private set; }

		public Face Face { get; private set; }
	}
}
