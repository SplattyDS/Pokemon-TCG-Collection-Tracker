using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	static class CloneCards
	{
		private static Card[][] TheCards =
		{
			new Card[]
			{
				Cards.Find(Sets.Plasma_Storm, 18),
				Cards.Find(Sets.Legendary_Treasures, 24),
			},
			new Card[]
			{
				Cards.Find(Sets.Next_Destinies, 22),
				Cards.Find(Sets.Legendary_Treasures, 29),
				Cards.Find(Sets.BW_Promo, 36),
			},
			new Card[]
			{
				Cards.Find(Sets.Next_Destinies, 38),
				Cards.Find(Sets.Legendary_Treasures, 44),
				Cards.Find(Sets.BW_Promo, 37),
			},
			new Card[]
			{
				Cards.Find(Sets.Next_Destinies, 51),
				Cards.Find(Sets.Legendary_Treasures, 52),
				Cards.Find(Sets.BW_Promo, 38),
			},
			new Card[]
			{
				Cards.Find(Sets.Next_Destinies, 54),
				Cards.Find(Sets.Legendary_Treasures, 54),
			},
			new Card[]
			{
				Cards.Find(Sets.Dark_Explorers, 63),
				Cards.Find(Sets.Legendary_Treasures, 88),
			},
			new Card[]
			{
				Cards.Find(Sets.Boundaries_Crossed, 101),
				Cards.Find(Sets.Legendary_Treasures, 100),
			},
			new Card[]
			{
				Cards.Find(Sets.Boundaries_Crossed, 103),
				Cards.Find(Sets.Legendary_Treasures, 101),
			},
			new Card[]
			{
				Cards.Find(Sets.Plasma_Storm, 108),
				Cards.Find(Sets.Legendary_Treasures, 102),
			},
			new Card[]
			{
				Cards.Find(Sets.Sword_Shield, 9),
				Cards.Find(Sets.Shining_Fates, 9),
			},
			new Card[]
			{
				Cards.Find(Sets.Brilliant_Stars, 17),
				Cards.Find(Sets.Crown_Zenith, 18),
			},
			new Card[]
			{
				Cards.Find(Sets.Brilliant_Stars, 27),
				Cards.Find(Sets.Crown_Zenith, 22),
			},
			new Card[]
			{
				Cards.Find(Sets.Rebel_Clash, 35),
				Cards.Find(Sets.Shining_Fates, 18),
			},
			new Card[]
			{
				Cards.Find(Sets.Lost_Origin, 58),
				Cards.Find(Sets.Crown_Zenith, 45),
			},
			new Card[]
			{
				Cards.Find(Sets.Sword_Shield, 79),
				Cards.Find(Sets.Shining_Fates, 37),
			},
			new Card[]
			{
				Cards.Find(Sets.Battle_Styles, 62),
				Cards.Find(Sets.Brilliant_Stars, 68),
			},
			new Card[]
			{
				Cards.Find(Sets.Darkness_Ablaze, 104),
				Cards.Find(Sets.Shining_Fates, 44),
			},
			new Card[]
			{
				Cards.Find(Sets.Evolving_Skies, 110),
				Cards.Find(Sets.Crown_Zenith, 100),
			},
			new Card[]
			{
				Cards.Find(Sets.Sword_Shield, 155),
				Cards.Find(Sets.Shining_Fates, 54),
			},
			new Card[]
			{
				Cards.Find(Sets.Obsidian_Flames, 22),
				Cards.Find(Sets.Paldean_Fates, 5),
			},
			new Card[]
			{
				Cards.Find(Sets.Scarlet_Violet, 86),
				Cards.Find(Sets.Paldean_Fates, 29),
			},
			new Card[]
			{
				Cards.Find(Sets.Paldea_Evolved, 130),
				Cards.Find(Sets.Paldean_Fates, 59),
			},
			new Card[]
			{
				Cards.Find(Sets.Paldea_Evolved, 153),
				Cards.Find(Sets.Paldean_Fates, 69),
			},
			new Card[]
			{
				Cards.Find(Sets.Paldea_Evolved, 169),
				Cards.Find(Sets.Paldean_Fates, 75),
			},
			new Card[]
			{
				Cards.Find(Sets.Paldea_Evolved, 5),
				Cards.Find(Sets.Paldean_Fates, 2),
			},
			new Card[]
			{
				Cards.Find(Sets.Obsidian_Flames, 125),
				Cards.Find(Sets.Paldean_Fates, 54),
			},
		};

		public static Card[][] Get()
		{
			return TheCards;
		}
	}
}
