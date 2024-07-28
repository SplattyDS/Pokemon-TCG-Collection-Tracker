namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Mask of Change (JP)", "MC", 3),
			new FutureCardSection("Night Wanderer (JP)", "NW", 39),
			new FutureCardSection("Stellar Miracle (JP)", "SM", 44),
			new FutureCardSection("Stellar Crown", "SCR", 5),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 14),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 4),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 2),
			new FutureCardSection("Battle Master Decks (JP)", "SVJ", 2),
			new FutureCardSection("Starter Set Tera Type Stellar (JP)", "SVL", 4),

			new FutureCardSection("Korean Cards", "KO", 1),
			new FutureCardSection("Chinese Cards", "CH", 9),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}