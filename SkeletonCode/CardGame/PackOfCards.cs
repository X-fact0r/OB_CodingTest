using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkeletonCode.CardGame
{
	public class PackOfCards : IPackOfCards
	{
		private static Random rng = new Random();
		private List<ICard> pack;

		public PackOfCards(ICard[] cards)
		{
			if(cards == null)
			{
				throw new ArgumentNullException("cards");
			}

			pack = cards.ToList();
		}

		public int Count
		{
			get	{ return pack.Count; }
		}

		public void Shuffle()
		{
			pack = pack.OrderBy(e => rng.Next()).ToList();
		}

		public ICard TakeCardFromTopOfPack()
		{
			if(pack.Count == 0)
			{
				throw new InvalidOperationException("Pack is empty"); // TODO: confirm requirements!
			}

			var topCard = pack.First();
			pack.RemoveAt(0);

			return topCard;
		}

		public IEnumerator<ICard> GetEnumerator()
		{
			return pack.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return pack.GetEnumerator();
		}
	}
}
