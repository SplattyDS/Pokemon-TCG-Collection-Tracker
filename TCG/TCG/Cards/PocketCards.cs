using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public static class PocketCards
	{
		private static PocketCard[] TheCards =
		{
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, -1),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, -1),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.ex, Types.Psychic, Sets.Genetic_Apex, -1),
			new PocketCard("Lapras", Pokedex.Lapras, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, -1),
			new PocketCard("Meowth", Pokedex.Meowth, PocketRarity.ex, Types.Colorless, Sets.Genetic_Apex, -1),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, -1),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, -1),
		};
		
		public static PocketCard[] Get()
		{
			return TheCards;
		}

		public static PocketCard Find(Sets set, double setNum)
		{
			return TheCards.Where(c => c.set == set && c.setNum == setNum).First();
		}
		
		public static PocketCard[] HasDuplicates()
		{
			int count = TheCards.Length;
			
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < count; j++)
				{
					if (i != j && TheCards[i].IsEqualTo(TheCards[j]))
						return new PocketCard[] { TheCards[i], TheCards[j] };
				}
			}
			
			return null;
		}
	}
}