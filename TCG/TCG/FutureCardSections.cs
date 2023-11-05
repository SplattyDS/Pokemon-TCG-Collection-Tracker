namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Shiny Treasure ex (JP)", "ST", 17),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 2),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 6),
			new FutureCardSection("Chinese Cards", "CH", 4),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 5),

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