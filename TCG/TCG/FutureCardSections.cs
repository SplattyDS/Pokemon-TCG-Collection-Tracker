namespace TCG
{
	public static class FutureCardSections
	{
		private static FutureCardSection[] TheCards =
		{
			new FutureCardSection("Sword & Shield Promo (JP)", "SSP", 5),
			new FutureCardSection("Scarlet & Violet Promo (JP)", "SVP", 3),
			new FutureCardSection("Triple Beat (JP)", "TB", 36),
			new FutureCardSection("Snow Hazard (JP)", "SH", 6),
			new FutureCardSection("Clay Burst (JP)", "CB", 6),
			new FutureCardSection("Starter Set Pikachu ex & Pawmot (JP)", "SVC", 1),
			new FutureCardSection("Pokemon TCG Classic (Venusaur & Lugia ex Deck)", "CLF", 1),
			new FutureCardSection("Pokemon TCG Classic (Charizard & Ho-Oh ex Deck)", "CLL", 1),
			new FutureCardSection("Pokemon TCG Classic (Blastoise & Suicune ex Deck)", "CLK", 1),
		};

		public static FutureCardSection[] Get()
		{
			return TheCards;
		}
	}
}