using System;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
		public IPackOfCards Create()
		{
			var cards = new List<ICard>();
			foreach(var suit in Enum.GetValues(typeof(Suit)).Cast<Suit>())
			{
				foreach(var face in Enum.GetValues(typeof(Face)).Cast<Face>())
				{
					cards.Add(new Card(suit, face));
				}
			}

			return new PackOfCards(cards.ToArray());
		}
	}
}
