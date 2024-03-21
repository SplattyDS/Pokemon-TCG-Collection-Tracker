﻿namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Wild Force ex (JP)", "WF", 38),
			new FutureCardSection("Cyber Judge ex (JP)", "CJ", 38),
			new FutureCardSection("Crimson Haze (JP)", "CH", 24),
			new FutureCardSection("Mask of Change (JP)", "MC", 4),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 10),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 3),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 5),
			new FutureCardSection("Starter Deck & Build Sets (JP)", "SVH", 3),
			new FutureCardSection("Battle Academy (JP)", "SVI", 7),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}