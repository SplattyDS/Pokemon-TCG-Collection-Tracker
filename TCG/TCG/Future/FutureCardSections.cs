namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Ancient Roar (JP)", "AR", 1),
			new FutureCardSection("Future Flash (JP)", "FF", 1),
			new FutureCardSection("Crimson Haze (JP)", "CH", 39),
			new FutureCardSection("Mask of Change (JP)", "MC", 20),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 9),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 2),

			new FutureCardSection("Special Deck Set ex Venusaur & Charizard & Blastoise (JP)", "SVG", 5),
			new FutureCardSection("Battle Academy (JP)", "SVI", 4),
		};

		public static FutureCardSection[] Get()
		{
			return TheSections;
		}
	}
}