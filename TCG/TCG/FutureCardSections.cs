namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheCards =
		{
			new FutureCardSection("Pokemon Card 151 (JP)", "PC", 56),
			new FutureCardSection("Ruler of the Black Flame (JP)", "BF", 3),
			new FutureCardSection("Sword & Shield Promo (JP)", "SSP", 3),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 4),
			new FutureCardSection("ex Special Set (JP)", "EXSS", 3),
			new FutureCardSection("ex Starter Decks (JP)", "EXSD", 8),
			new FutureCardSection("Pokemon TCG Classic - Venusaur & Lugia ex Deck (JP)", "CLF", 1),
			new FutureCardSection("Pokemon TCG Classic - Charizard & Ho-Oh ex Deck (JP)", "CLL", 1),
			new FutureCardSection("Pokemon TCG Classic - Blastoise & Suicune ex Deck (JP)", "CLK", 1),
		};

		public static FutureCardSection[] Get()
		{
			return TheCards;
		}
	}
}