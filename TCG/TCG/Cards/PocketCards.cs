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
			new PocketCard("Lapras", Pokedex.Lapras, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, -1),
			new PocketCard("Meowth", Pokedex.Meowth, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, -1),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.Special_Art_ex, Types.Fire, Sets.Genetic_Apex, -1),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Special_Art_ex, Types.Lightning, Sets.Genetic_Apex, -1),
			new PocketCard("Squirtle", Pokedex.Squirtle, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Genetic_Apex, -1),
			new PocketCard("Pidgeot", Pokedex.Pidgeot, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Genetic_Apex, -1),
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