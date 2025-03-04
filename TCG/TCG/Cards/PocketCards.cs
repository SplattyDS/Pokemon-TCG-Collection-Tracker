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
			new PocketCard("Venusaur ex", Pokedex.Venusaur, PocketRarity.ex, Types.Grass, Sets.Genetic_Apex, 4, true),
			new PocketCard("Exeggutor ex", Pokedex.Exeggutor, PocketRarity.ex, Types.Grass, Sets.Genetic_Apex, 23, true),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 36, true),
			new PocketCard("Arcanine ex", Pokedex.Arcanine, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 41),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.ex, Types.Fire, Sets.Genetic_Apex, 47),
			new PocketCard("Blastoise ex", Pokedex.Blastoise, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 56, true),
			new PocketCard("Starmie ex", Pokedex.Starmie, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 76, true),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.ex, Types.Water, Sets.Genetic_Apex, 84, true),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, 96, true),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.ex, Types.Lightning, Sets.Genetic_Apex, 104, true),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.ex, Types.Psychic, Sets.Genetic_Apex, 123, true),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.ex, Types.Psychic, Sets.Genetic_Apex, 129),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.ex, Types.Fighting, Sets.Genetic_Apex, 146, true),
			new PocketCard("Marowak ex", Pokedex.Marowak, PocketRarity.ex, Types.Fighting, Sets.Genetic_Apex, 153, true),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.ex, Types.Colorless, Sets.Genetic_Apex, 195, true),
			new PocketCard("Bulbasaur", Pokedex.Bulbasaur, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 227),
			new PocketCard("Gloom", Pokedex.Gloom, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 228, true),
			new PocketCard("Pinsir", Pokedex.Pinsir, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Genetic_Apex, 229, true),
			new PocketCard("Charmander", Pokedex.Charmander, PocketRarity.Special_Art_Pokémon, Types.Fire, Sets.Genetic_Apex, 230, true),
			new PocketCard("Rapidash", Pokedex.Rapidash, PocketRarity.Special_Art_Pokémon, Types.Fire, Sets.Genetic_Apex, 231, true),
			new PocketCard("Squirtle", Pokedex.Squirtle, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 232, true),
			new PocketCard("Gyarados", Pokedex.Gyarados, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 233, true),
			new PocketCard("Lapras", Pokedex.Lapras, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Genetic_Apex, 234),
			new PocketCard("Electrode", Pokedex.Electrode, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Genetic_Apex, 235, true),
			new PocketCard("Alakazam", Pokedex.Alakazam, PocketRarity.Special_Art_Pokémon, Types.Psychic, Sets.Genetic_Apex, 236, true),
			new PocketCard("Slowpoke", Pokedex.Slowpoke, PocketRarity.Special_Art_Pokémon, Types.Psychic, Sets.Genetic_Apex, 237, true),
			new PocketCard("Diglett", Pokedex.Diglett, PocketRarity.Special_Art_Pokémon, Types.Fighting, Sets.Genetic_Apex, 238, true),
			new PocketCard("Cubone", Pokedex.Cubone, PocketRarity.Special_Art_Pokémon, Types.Fighting, Sets.Genetic_Apex, 239, true),
			new PocketCard("Nidoqueen", Pokedex.Nidoqueen, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 240, true),
			new PocketCard("Nidoking", Pokedex.Nidoking, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 241, true),
			new PocketCard("Golbat", Pokedex.Golbat, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 242, true),
			new PocketCard("Weezing", Pokedex.Weezing, PocketRarity.Special_Art_Pokémon, Types.Darkness, Sets.Genetic_Apex, 243, true),
			new PocketCard("Dragonite", Pokedex.Dragonite, PocketRarity.Special_Art_Pokémon, Types.Dragon, Sets.Genetic_Apex, 244, true),
			new PocketCard("Pidgeot", Pokedex.Pidgeot, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 245, true),
			new PocketCard("Meowth", Pokedex.Meowth, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 246),
			new PocketCard("Ditto", Pokedex.Ditto, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 247),
			new PocketCard("Eevee", Pokedex.Eevee, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 248, true),
			new PocketCard("Porygon", Pokedex.Porygon, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 249),
			new PocketCard("Snorlax", Pokedex.Snorlax, PocketRarity.Special_Art_Pokémon, Types.Colorless, Sets.Genetic_Apex, 250, true),
			new PocketCard("Venusaur ex", Pokedex.Venusaur, PocketRarity.Full_Art_ex, Types.Grass, Sets.Genetic_Apex, 251),
			new PocketCard("Exeggutor ex", Pokedex.Exeggutor, PocketRarity.Full_Art_ex, Types.Grass, Sets.Genetic_Apex, 252),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 253),
			new PocketCard("Arcanine ex", Pokedex.Arcanine, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 254, true),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.Full_Art_ex, Types.Fire, Sets.Genetic_Apex, 255),
			new PocketCard("Blastoise ex", Pokedex.Blastoise, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 256),
			new PocketCard("Starmie ex", Pokedex.Starmie, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 257, true),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.Full_Art_ex, Types.Water, Sets.Genetic_Apex, 258, true),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Full_Art_ex, Types.Lightning, Sets.Genetic_Apex, 259, true),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.Full_Art_ex, Types.Lightning, Sets.Genetic_Apex, 260),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.Full_Art_ex, Types.Psychic, Sets.Genetic_Apex, 261),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Full_Art_ex, Types.Psychic, Sets.Genetic_Apex, 262),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.Full_Art_ex, Types.Fighting, Sets.Genetic_Apex, 263),
			new PocketCard("Marowak ex", Pokedex.Marowak, PocketRarity.Full_Art_ex, Types.Fighting, Sets.Genetic_Apex, 264),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.Full_Art_ex, Types.Colorless, Sets.Genetic_Apex, 265),
			new PocketCard("Erika", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 266),
			new PocketCard("Misty", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 267, true),
			new PocketCard("Blaine", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 268),
			new PocketCard("Koga", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 269, true),
			new PocketCard("Giovanni", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 270),
			new PocketCard("Brock", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 271, true),
			new PocketCard("Sabrina", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 272, true),
			new PocketCard("Lt. Surge", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Genetic_Apex, 273),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.Special_Art_ex, Types.Fire, Sets.Genetic_Apex, 274),
			new PocketCard("Articuno ex", Pokedex.Articuno, PocketRarity.Special_Art_ex, Types.Water, Sets.Genetic_Apex, 275),
			new PocketCard("Zapdos ex", Pokedex.Zapdos, PocketRarity.Special_Art_ex, Types.Lightning, Sets.Genetic_Apex, 276, true),
			new PocketCard("Gengar ex", Pokedex.Gengar, PocketRarity.Special_Art_ex, Types.Psychic, Sets.Genetic_Apex, 277),
			new PocketCard("Machamp ex", Pokedex.Machamp, PocketRarity.Special_Art_ex, Types.Fighting, Sets.Genetic_Apex, 278),
			new PocketCard("Wigglytuff ex", Pokedex.Wigglytuff, PocketRarity.Special_Art_ex, Types.Colorless, Sets.Genetic_Apex, 279),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Immersive_Art, Types.Fire, Sets.Genetic_Apex, 280, true),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Immersive_Art, Types.Lightning, Sets.Genetic_Apex, 281, true),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Immersive_Art, Types.Psychic, Sets.Genetic_Apex, 282, true),
			new PocketCard("Charizard ex", Pokedex.Charizard, PocketRarity.Gold_ex, Types.Fire, Sets.Genetic_Apex, 284),
			new PocketCard("Pikachu ex", Pokedex.Pikachu, PocketRarity.Gold_ex, Types.Lightning, Sets.Genetic_Apex, 285, true),
			new PocketCard("Mewtwo ex", Pokedex.Mewtwo, PocketRarity.Gold_ex, Types.Psychic, Sets.Genetic_Apex, 286),
			new PocketCard("Mew", Pokedex.Mew, PocketRarity.Immersive_Art, Types.Psychic, Sets.Genetic_Apex, 283, true),
			new PocketCard("Pikachu", Pokedex.Pikachu, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Promo_A, 9, true),
			new PocketCard("Mewtwo", Pokedex.Mewtwo, PocketRarity.Special_Art_Pokémon, Types.Psychic, Sets.Promo_A, 10, true),
			new PocketCard("Venusaur", Pokedex.Venusaur, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Promo_A, 18, true),
			new PocketCard("Venusaur", Pokedex.Venusaur, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 3),
			new PocketCard("Butterfree", Pokedex.Butterfree, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 7, true),
			new PocketCard("Beedrill", Pokedex.Beedrill, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 10, true),
			new PocketCard("Vileplume", Pokedex.Vileplume, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 13, true),
			new PocketCard("Victreebel", Pokedex.Victreebel, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 20, true),
			new PocketCard("Exeggutor", Pokedex.Exeggutor, PocketRarity.Holo, Types.Grass, Sets.Genetic_Apex, 22, true),
			new PocketCard("Charizard", Pokedex.Charizard, PocketRarity.Holo, Types.Fire, Sets.Genetic_Apex, 35, true),
			new PocketCard("Arcanine", Pokedex.Arcanine, PocketRarity.Holo, Types.Fire, Sets.Genetic_Apex, 40, true),
			new PocketCard("Flareon", Pokedex.Flareon, PocketRarity.Holo, Types.Fire, Sets.Genetic_Apex, 45, true),
			new PocketCard("Moltres", Pokedex.Moltres, PocketRarity.Holo, Types.Fire, Sets.Genetic_Apex, 46, true),
			new PocketCard("Blastoise", Pokedex.Blastoise, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 55, true),
			new PocketCard("Poliwrath", Pokedex.Poliwrath, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 61, true),
			new PocketCard("Gyarados", Pokedex.Gyarados, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 78),
			new PocketCard("Lapras", Pokedex.Lapras, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 79, true),
			new PocketCard("Vaporeon", Pokedex.Vaporeon, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 80, true),
			new PocketCard("Omastar", Pokedex.Omastar, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 82, true),
			new PocketCard("Articuno", Pokedex.Articuno, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 83, true),
			new PocketCard("Greninja", Pokedex.Greninja, PocketRarity.Holo, Types.Water, Sets.Genetic_Apex, 89, true),
			new PocketCard("Raichu", Pokedex.Raichu, PocketRarity.Holo, Types.Lightning, Sets.Genetic_Apex, 95, true),
			new PocketCard("Magneton", Pokedex.Magneton, PocketRarity.Holo, Types.Lightning, Sets.Genetic_Apex, 98, true),
			new PocketCard("Jolteon", Pokedex.Jolteon, PocketRarity.Holo, Types.Lightning, Sets.Genetic_Apex, 102, true),
			new PocketCard("Zapdos", Pokedex.Zapdos, PocketRarity.Holo, Types.Lightning, Sets.Genetic_Apex, 103, true),
			new PocketCard("Eelektross", Pokedex.Eelektross, PocketRarity.Holo, Types.Lightning, Sets.Genetic_Apex, 109, true),
			new PocketCard("Alakazam", Pokedex.Alakazam, PocketRarity.Holo, Types.Psychic, Sets.Genetic_Apex, 117),
			new PocketCard("Gengar", Pokedex.Gengar, PocketRarity.Holo, Types.Psychic, Sets.Genetic_Apex, 122),
			new PocketCard("Hypno", Pokedex.Hypno, PocketRarity.Holo, Types.Psychic, Sets.Genetic_Apex, 125, true),
			new PocketCard("Mewtwo", Pokedex.Mewtwo, PocketRarity.Holo, Types.Psychic, Sets.Genetic_Apex, 128, true),
			new PocketCard("Gardevoir", Pokedex.Gardevoir, PocketRarity.Holo, Types.Psychic, Sets.Genetic_Apex, 132),
			new PocketCard("Machamp", Pokedex.Machamp, PocketRarity.Holo, Types.Fighting, Sets.Genetic_Apex, 145),
			new PocketCard("Golem", Pokedex.Golem, PocketRarity.Holo, Types.Fighting, Sets.Genetic_Apex, 149, true),
			new PocketCard("Kabutops", Pokedex.Kabutops, PocketRarity.Holo, Types.Fighting, Sets.Genetic_Apex, 159, true),
			new PocketCard("Nidoqueen", Pokedex.Nidoqueen, PocketRarity.Holo, Types.Darkness, Sets.Genetic_Apex, 168, true),
			new PocketCard("Nidoking", Pokedex.Nidoking, PocketRarity.Holo, Types.Darkness, Sets.Genetic_Apex, 171, true),
			new PocketCard("Muk", Pokedex.Muk, PocketRarity.Holo, Types.Darkness, Sets.Genetic_Apex, 175, true),
			new PocketCard("Weezing", Pokedex.Weezing, PocketRarity.Holo, Types.Darkness, Sets.Genetic_Apex, 177, true),
			new PocketCard("Melmetal", Pokedex.Melmetal, PocketRarity.Holo, Types.Metal, Sets.Genetic_Apex, 182),
			new PocketCard("Dragonite", Pokedex.Dragonite, PocketRarity.Holo, Types.Dragon, Sets.Genetic_Apex, 185, true),
			new PocketCard("Pidgeot", Pokedex.Pidgeot, PocketRarity.Holo, Types.Colorless, Sets.Genetic_Apex, 188, true),
			new PocketCard("Kangaskhan", Pokedex.Kangaskhan, PocketRarity.Holo, Types.Colorless, Sets.Genetic_Apex, 203, true),
			new PocketCard("Ditto", Pokedex.Ditto, PocketRarity.Holo, Types.Colorless, Sets.Genetic_Apex, 205, true),
			new PocketCard("Aerodactyl", Pokedex.Aerodactyl, PocketRarity.Holo, Types.Colorless, Sets.Genetic_Apex, 210, true),
			new PocketCard("Snorlax", Pokedex.Snorlax, PocketRarity.Holo, Types.Colorless, Sets.Genetic_Apex, 211, true),
			new PocketCard("Chansey", Pokedex.Chansey, PocketRarity.Holo, Types.Colorless, Sets.Promo_A, 11, true),
			new PocketCard("Meowth", Pokedex.Meowth, PocketRarity.Holo, Types.Colorless, Sets.Promo_A, 12, true),
			new PocketCard("Butterfree", Pokedex.Butterfree, PocketRarity.Holo, Types.Grass, Sets.Promo_A, 13, true),
			new PocketCard("Lapras ex", Pokedex.Lapras, PocketRarity.ex, Types.Water, Sets.Promo_A, 14, true),
			new PocketCard("Greninja", Pokedex.Greninja, PocketRarity.Holo, Types.Water, Sets.Promo_A, 19, true),
			new PocketCard("Bulbasaur", Pokedex.Bulbasaur, PocketRarity.Holo, Types.Grass, Sets.Promo_A, 23, true),
			new PocketCard("Magnemite", Pokedex.Magnemite, PocketRarity.Holo, Types.Lightning, Sets.Promo_A, 24, true),
			new PocketCard("Celebi ex", Pokedex.Celebi, PocketRarity.ex, Types.Grass, Sets.Mythical_Island, 3),
			new PocketCard("Serperior", Pokedex.Serperior, PocketRarity.Holo, Types.Grass, Sets.Mythical_Island, 6, true),
			new PocketCard("Volcarona", Pokedex.Volcarona, PocketRarity.Holo, Types.Fire, Sets.Mythical_Island, 14),
			new PocketCard("Gyarados ex", Pokedex.Gyarados, PocketRarity.ex, Types.Water, Sets.Mythical_Island, 18, true),
			new PocketCard("Vaporeon", Pokedex.Vaporeon, PocketRarity.Holo, Types.Water, Sets.Mythical_Island, 19, true),
			new PocketCard("Raichu", Pokedex.Raichu, PocketRarity.Holo, Types.Lightning, Sets.Mythical_Island, 26, true),
			new PocketCard("Mew", Pokedex.Mew, PocketRarity.Holo, Types.Psychic, Sets.Mythical_Island, 31, true),
			new PocketCard("Mew ex", Pokedex.Mew, PocketRarity.ex, Types.Psychic, Sets.Mythical_Island, 32),
			new PocketCard("Golem", Pokedex.Golem, PocketRarity.Holo, Types.Fighting, Sets.Mythical_Island, 45),
			new PocketCard("Aerodactyl ex", Pokedex.Aerodactyl, PocketRarity.ex, Types.Fighting, Sets.Mythical_Island, 46),
			new PocketCard("Marshadow", Pokedex.Marshadow, PocketRarity.Holo, Types.Fighting, Sets.Mythical_Island, 47, true),
			new PocketCard("Pidgeot ex", Pokedex.Pidgeot, PocketRarity.ex, Types.Colorless, Sets.Mythical_Island, 59, true),
			new PocketCard("Tauros", Pokedex.Tauros, PocketRarity.Holo, Types.Colorless, Sets.Mythical_Island, 60, true),
			new PocketCard("Exeggutor", Pokedex.Exeggutor, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Mythical_Island, 69, true),
			new PocketCard("Serperior", Pokedex.Serperior, PocketRarity.Special_Art_Pokémon, Types.Grass, Sets.Mythical_Island, 70),
			new PocketCard("Salandit", Pokedex.Salandit, PocketRarity.Special_Art_Pokémon, Types.Fire, Sets.Mythical_Island, 71, true),
			new PocketCard("Vaporeon", Pokedex.Vaporeon, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Mythical_Island, 72, true),
			new PocketCard("Dedenne", Pokedex.Dedenne, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Mythical_Island, 73, true),
			new PocketCard("Marshadow", Pokedex.Marshadow, PocketRarity.Special_Art_Pokémon, Types.Fighting, Sets.Mythical_Island, 74, true),
			new PocketCard("Celebi ex", Pokedex.Celebi, PocketRarity.Full_Art_ex, Types.Grass, Sets.Mythical_Island, 75),
			new PocketCard("Gyarados ex", Pokedex.Gyarados, PocketRarity.Full_Art_ex, Types.Water, Sets.Mythical_Island, 76),
			new PocketCard("Mew ex", Pokedex.Mew, PocketRarity.Full_Art_ex, Types.Psychic, Sets.Mythical_Island, 77),
			new PocketCard("Aerodactyl ex", Pokedex.Aerodactyl, PocketRarity.Full_Art_ex, Types.Fighting, Sets.Mythical_Island, 78),
			new PocketCard("Pidgeot ex", Pokedex.Pidgeot, PocketRarity.Full_Art_ex, Types.Colorless, Sets.Mythical_Island, 79),
			new PocketCard("Budding Expeditioner", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Mythical_Island, 80),
			new PocketCard("Blue", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Mythical_Island, 81),
			new PocketCard("Leaf", Pokedex.NVT, PocketRarity.Full_Art_Trainer, Types.Supporter, Sets.Mythical_Island, 82),
			new PocketCard("Mew ex", Pokedex.Mew, PocketRarity.Special_Art_ex, Types.Psychic, Sets.Mythical_Island, 83, true),
			new PocketCard("Aerodactyl ex", Pokedex.Aerodactyl, PocketRarity.Special_Art_ex, Types.Fighting, Sets.Mythical_Island, 84),
			new PocketCard("Celebi ex", Pokedex.Celebi, PocketRarity.Immersive_Art, Types.Grass, Sets.Mythical_Island, 85, true),
			new PocketCard("Mew ex", Pokedex.Mew, PocketRarity.Gold_ex, Types.Psychic, Sets.Mythical_Island, 86),
			new PocketCard("Moltres ex", Pokedex.Moltres, PocketRarity.ex, Types.Fire, Sets.Promo_A, 25),
			new PocketCard("Pikachu", Pokedex.Pikachu, PocketRarity.Special_Art_Pokémon, Types.Lightning, Sets.Promo_A, 26),
			new PocketCard("Volcarona", Pokedex.Volcarona, PocketRarity.Holo, Types.Fire, Sets.Promo_A, 28),
			new PocketCard("Blastoise", Pokedex.Blastoise, PocketRarity.Special_Art_Pokémon, Types.Water, Sets.Promo_A, 29),
			new PocketCard("Charmander", Pokedex.Charmander, PocketRarity.Holo, Types.Fire, Sets.Promo_A, 32),
			new PocketCard("Squirtle", Pokedex.Squirtle, PocketRarity.Holo, Types.Water, Sets.Promo_A, 33),
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