namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Pokemon Card 151 (JP)", "PC", 54),
			new FutureCardSection("Sword & Shield Promo (JP)", "SSP", 3),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 5),
			new FutureCardSection("ex Starter Decks (JP)", "EXSD", 1),
			new FutureCardSection("Pokemon TCG Classic - Venusaur & Lugia ex Deck (JP)", "CLF", 1),
			new FutureCardSection("Pokemon TCG Classic - Charizard & Ho-Oh ex Deck (JP)", "CLL", 1),
			new FutureCardSection("Pokemon TCG Classic - Blastoise & Suicune ex Deck (JP)", "CLK", 1),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}