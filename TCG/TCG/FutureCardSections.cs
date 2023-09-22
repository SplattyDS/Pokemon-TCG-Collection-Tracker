namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Raging Surf (JP)", "RS", 36),
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Paradox Rift", "PR", 4),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 2),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 5),
			new FutureCardSection("Scarlet & Violet Promo (CH)", "SVPCH", 2),

			new FutureCardSection("ex Starter Decks (JP)", "EXSD", 1),
			new FutureCardSection("Starter Set Terastal ex (JP)", "SST", 2),

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