namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheSections =
		{
			new FutureCardSection("Paradise Dragona (JP)", "PD", 39),
			new FutureCardSection("Supercharged Breaker (JP)", "SB", 7),
			new FutureCardSection("Scarlet & Violet 9 (TBA)", "SV9EN", 4),

			new FutureCardSection("Scarlet & Violet Promo", "SVPEN", 9),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 6),

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