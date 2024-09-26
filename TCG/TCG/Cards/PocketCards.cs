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
			new PocketCard("Venusaur ex", Pokedex.Venusaur, PocketRarity.ex, Types.Grass, Sets.Genetic_Apex, 4),
			new PocketCard("Exeggutor ex", Pokedex.Exeggutor, PocketRarity.ex, Types.Grass, Sets.Genetic_Apex, 23),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 36),
			new PocketCard("Arcanine ex", Pokedex.Arcanine, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 41),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 47),
			new PocketCard("Blastoise ex", Pokedex.Blastoise, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 56),
			new PocketCard("Starmie ex", Pokedex.Starmie, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 76),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 84),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, 96),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, 104),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.ex, Types.Psychic, Sets.Genetic_Apex, 123),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.ex, Types.Psychic, Sets.Genetic_Apex, 129),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.ex, Types.Fighting, Sets.Genetic_Apex, 146),
			new PocketCard("Marowak ex", Pokedex.Marowak, PocketRarity.ex, Types.Fighting, Sets.Genetic_Apex, 153),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.ex, Types.Colorless, Sets.Genetic_Apex, 195),
			new PocketCard("Bulbasaur", Pokedex.Bulbasaur, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 227),
			new PocketCard("Gloom", Pokedex.Gloom, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 228),
			new PocketCard("Pinsir", Pokedex.Pinsir, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 229),
			new PocketCard("Charmander", Pokedex.Charmander, PocketRarity.Special_Art_Pokémon, Types.Fire, Sets.Genetic_Apex, 230),
			new PocketCard("Rapidash", Pokedex.Rapidash, PocketRarity.Special_Art_Pokémon, Types.Fire, Sets.Genetic_Apex, 231),
			new PocketCard("Squirtle", Pokedex.Squirtle, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 232),
			new PocketCard("Gyarados", Pokedex.Gyarados, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 233),
			new PocketCard("Lapras", Pokedex.Lapras, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 234),
			new PocketCard("Electrode", Pokedex.Electrode, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Genetic_Apex, 235),
			new PocketCard("Alakazam", Pokedex.Alakazam, PocketRarity.Special_Art_Pokémon, Types.Psychic, Sets.Genetic_Apex, 236),
			new PocketCard("Slowpoke", Pokedex.Slowpoke, PocketRarity.Special_Art_Pokémon, Types.Psychic, Sets.Genetic_Apex, 237),
			new PocketCard("Diglett", Pokedex.Diglett, PocketRarity.Special_Art_Pokémon, Types.Fighting, Sets.Genetic_Apex, 238),
			new PocketCard("Cubone", Pokedex.Cubone, PocketRarity.Special_Art_Pokémon, Types.Fighting, Sets.Genetic_Apex, 239),
			new PocketCard("Nidoqueen", Pokedex.Nidoqueen, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 240),
			new PocketCard("Nidoking", Pokedex.Nidoking, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 241),
			new PocketCard("Golbat", Pokedex.Golbat, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 242),
			new PocketCard("Weezing", Pokedex.Weezing, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 243),
			new PocketCard("Dragonite", Pokedex.Dragonite, PocketRarity.Special_Art_Pokémon, Types.Dragon, Sets.Genetic_Apex, 244),
			new PocketCard("Pidgeot", Pokedex.Pidgeot, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 245),
			new PocketCard("Meowth", Pokedex.Meowth, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 246),
			new PocketCard("Ditto", Pokedex.Ditto, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 247),
			new PocketCard("Eevee", Pokedex.Eevee, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 248),
			new PocketCard("Porygon", Pokedex.Porygon, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 249),
			new PocketCard("Snorlax", Pokedex.Snorlax, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 250),
			new PocketCard("Venusaur ex", Pokedex.Venusaur, PocketRarity.Full_Art_ex, Types.Grass, Sets.Genetic_Apex, 251),
			new PocketCard("Exeggutor ex", Pokedex.Exeggutor, PocketRarity.Full_Art_ex, Types.Grass, Sets.Genetic_Apex, 252),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 253),
			new PocketCard("Arcanine ex", Pokedex.Arcanine, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 254),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 255),
			new PocketCard("Blastoise ex", Pokedex.Blastoise, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 256),
			new PocketCard("Starmie ex", Pokedex.Starmie, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 257),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 258),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Full_Art_ex, Types.Lightning, Sets.Genetic_Apex, 259),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.Full_Art_ex, Types.Lightning, Sets.Genetic_Apex, 260),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.Full_Art_ex, Types.Psychic, Sets.Genetic_Apex, 261),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Full_Art_ex, Types.Psychic, Sets.Genetic_Apex, 262),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.Full_Art_ex, Types.Fighting, Sets.Genetic_Apex, 263),
			new PocketCard("Marowak ex", Pokedex.Marowak, PocketRarity.Full_Art_ex, Types.Fighting, Sets.Genetic_Apex, 264),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.Full_Art_ex, Types.Colorless, Sets.Genetic_Apex, 265),
			new PocketCard("Erika", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 266),
			new PocketCard("Misty", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 267),
			new PocketCard("Blaine", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 268),
			new PocketCard("Koga", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 269),
			new PocketCard("Giovanni", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 270),
			new PocketCard("Brock", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 271),
			new PocketCard("Sabrina", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 272),
			new PocketCard("Lt. Surge", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 273),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.Special_Art_ex, Types.Fire, Sets.Genetic_Apex, 274),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.Special_Art_ex, Types.Water, Sets.Genetic_Apex, 275),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.Special_Art_ex, Types.Lightning, Sets.Genetic_Apex, 276),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.Special_Art_ex, Types.Psychic, Sets.Genetic_Apex, 277),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.Special_Art_ex, Types.Fighting, Sets.Genetic_Apex, 278),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.Special_Art_ex, Types.Colorless, Sets.Genetic_Apex, 279),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Immersive_Art_ex, Types.Fire, Sets.Genetic_Apex, 280),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Immersive_Art_ex, Types.Lightning, Sets.Genetic_Apex, 281),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Immersive_Art_ex, Types.Psychic, Sets.Genetic_Apex, 282),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Gold_ex, Types.Fire, Sets.Genetic_Apex, 283),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Gold_ex, Types.Lightning, Sets.Genetic_Apex, 284),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Gold_ex, Types.Psychic, Sets.Genetic_Apex, 285),
			new PocketCard("Mew", Pokedex.Mew, PocketRarity.Immersive_Art_ex, Types.Psychic, Sets.Genetic_Apex, 286),
			new PocketCard("Pikachu", Pokedex.Pikachu, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Promo_A, 9),
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