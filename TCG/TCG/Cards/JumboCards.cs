using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public static class JumboCards
	{
		private static JumboCard[] TheCards =
		{
			new JumboCard("Articuno, Moltres, and Zapdos", Pokedex.Articuno, JumboRarity.Exclusive, Types.Colorless, Sets.Unnumbered_Promo, -1),
			new JumboCard("Shadow Lugia", Pokedex.Lugia, JumboRarity.Exclusive, Types.Psychic, Sets.Unnumbered_Promo, -1),
			new JumboCard("Darkrai & Cresselia LEGEND", Pokedex.Darkrai, JumboRarity.Combination, Types.Darkness, Sets.Unnumbered_Promo, -1),
			new JumboCard("Palkia & Dialga LEGEND", Pokedex.Palkia, JumboRarity.Combination, Types.Water, Sets.Unnumbered_Promo, -1),
			new JumboCard("Zorua and Celebi", Pokedex.Zorua, JumboRarity.Exclusive, Types.Darkness, Sets.Unnumbered_Promo, -1),
			new JumboCard("Zoroark and Legendary Pokémon", Pokedex.Zoroark, JumboRarity.Exclusive, Types.Darkness, Sets.Unnumbered_Promo, -1),
			new JumboCard("_____'s Snivy", Pokedex.Snivy, JumboRarity.Exclusive, Types.Grass, Sets.Unnumbered_Promo, -1),
			new JumboCard("_____'s Tepig", Pokedex.Tepig, JumboRarity.Exclusive, Types.Fire, Sets.Unnumbered_Promo, -1),
			new JumboCard("_____'s Oshawott", Pokedex.Oshawott, JumboRarity.Exclusive, Types.Water, Sets.Unnumbered_Promo, -1),
			new JumboCard("Solgaleo GX", Pokedex.Solgaleo, JumboRarity.Redacted, Types.Metal, Sets.Sun_Moon, 89),
			new JumboCard("Lunala GX", Pokedex.Lunala, JumboRarity.Redacted, Types.Psychic, Sets.Sun_Moon, 66),
			new JumboCard("Raikou, Entei & Suicune", Pokedex.Raikou, JumboRarity.Exclusive, Types.Colorless, Sets.Unnumbered_Promo, -1),
			new JumboCard("Tornadus, Thundurus & Landorus", Pokedex.Tornadus, JumboRarity.Exclusive, Types.Colorless, Sets.Unnumbered_Promo, -1),
			new JumboCard("Reshiram, Zekrom & Kyurem", Pokedex.Reshiram, JumboRarity.Exclusive, Types.Dragon, Sets.Unnumbered_Promo, -1),
			new JumboCard("Zacian V", Pokedex.Zacian, JumboRarity.Redacted, Types.No_Sorting, Sets.Sword_Shield, 138),
			new JumboCard("Zamazenta V", Pokedex.Zamazenta, JumboRarity.Redacted, Types.No_Sorting, Sets.Sword_Shield, 139),
			new JumboCard("Greninja V-UNION", Pokedex.Greninja, JumboRarity.Combination, Types.Water, Sets.Unnumbered_Promo, -1, true),
			new JumboCard("Mewtwo V-UNION", Pokedex.Mewtwo, JumboRarity.Combination, Types.Psychic, Sets.Unnumbered_Promo, -1, true),
			new JumboCard("Zacian V-UNION", Pokedex.Zacian, JumboRarity.Combination, Types.Metal, Sets.Unnumbered_Promo, -1, true),
			new JumboCard("Pikachu V-UNION", Pokedex.Pikachu, JumboRarity.Combination, Types.Lightning, Sets.Unnumbered_Promo, -1, true),
			new JumboCard("Morpeko V-UNION", Pokedex.Morpeko, JumboRarity.Combination, Types.Lightning, Sets.Unnumbered_Promo, -1),
			new JumboCard("Morpeko V-UNION", Pokedex.Morpeko, JumboRarity.Combination, Types.Lightning, Sets.Unnumbered_Promo, -1),
			new JumboCard("Miraidon ex", Pokedex.Miraidon, JumboRarity.Redacted, Types.No_Sorting, Sets.Unnumbered_Promo, -1),
			new JumboCard("Koraidon ex", Pokedex.Koraidon, JumboRarity.Redacted, Types.No_Sorting, Sets.Unnumbered_Promo, -1),
			new JumboCard("Terapagos & Friends", Pokedex.Terapagos, JumboRarity.Exclusive, Types.Colorless, Sets.Unnumbered_Promo, -1),
		};

		public static JumboCard[] Get()
		{
			return TheCards;
		}

		public static JumboCard Find(Sets set, double setNum)
		{
			return TheCards.Where(c => c.set == set && c.setNum == setNum).First();
		}

		public static JumboCard[] HasDuplicates()
		{
			int count = TheCards.Length;

			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < count; j++)
				{
					if (i != j && TheCards[i].IsEqualTo(TheCards[j]))
						return new JumboCard[] { TheCards[i], TheCards[j] };
				}
			}

			return null;
		}
	}
}