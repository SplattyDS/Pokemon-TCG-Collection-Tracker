﻿namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Crimson Haze (JP)", "CH", 39),
			new FutureCardSection("Mask of Change (JP)", "MC", 43),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 11),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 4),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 5),
			new FutureCardSection("Battle Academy (JP)", "SVI", 4),
			new FutureCardSection("Battle Master Decks (JP)", "SVJ", 2),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}