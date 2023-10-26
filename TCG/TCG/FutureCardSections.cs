namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Raging Surf (JP)", "RS", 36),
			new FutureCardSection("Ancient Roar (JP)", "AR", 35),
			new FutureCardSection("Future Flash (JP)", "FF", 35),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 2),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 6),
			new FutureCardSection("Scarlet & Violet Promo (CH)", "SVPCH", 2),

			new FutureCardSection("ex Starter Decks (JP)", "EXSD", 1),
			new FutureCardSection("Starter Set Terastal ex (JP)", "SST", 2),
			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 3), // don't forget Bulbasaur & Squirtle IR

			new FutureCardSection("Classic - Venusaur Deck", "CLV", 1),
			new FutureCardSection("Classic - Charizard Deck", "CLC", 1),
			new FutureCardSection("Classic - Blastoise Deck", "CLB", 1),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}