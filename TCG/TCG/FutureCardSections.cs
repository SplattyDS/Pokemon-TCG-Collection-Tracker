namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Wild Force ex (JP)", "WF", 4),
			new FutureCardSection("Cyber Judge ex (JP)", "CJ", 4),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 3),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 6),
			new FutureCardSection("Chinese Cards", "CH", 6),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 5),
			new FutureCardSection("Starter Deck & Build Sets (JP)", "SVH", 3),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}