using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class CardInfo
	{
		public CardBase card;
		public string info;

		public CardInfo(CardBase card, string info)
		{
			this.card = card;
			this.info = info;
		}
	}

	public static class CardInfos
	{
		private static CardInfo[] TheInfos =
		{
			new CardInfo(Cards.Find(Sets.Unnumbered_Promo, -1, Rarity.Ancient_Mew), "Pokémon The Movie 2000 release (1st week only)"),
			new CardInfo(HoloCards.Find(Sets.Base_Set, 8, HoloRarity.OS_PIXEL_COSMOS_HOLO), "2-Player CD-ROM Starter Set exclusive"),
		};

		public static CardInfo[] Get()
		{
			return TheInfos;
		}

		public static string GetInfoFromCard(CardBase card)
		{
			CardInfo info = TheInfos.Where(i => i.card == card).FirstOrDefault();

			if (info == null)
				return "";

			return info.info;
		}
	}
}
