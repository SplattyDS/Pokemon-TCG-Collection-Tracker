namespace TCG
{
	public static class PocketSections
	{
		private static Section[] TheSections =
		{
			new Section(PocketRarity.Holo, "Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.ex, "ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.Special_Art_Pokémon, "Special Art Pokémon", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.Full_Art_ex, "Full Art ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.Full_Art_Trainer, "Full Art Trainer", SortMode.SORT_BY_NAME),
			new Section(PocketRarity.Special_Art_ex, "Special Art ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.Immersive_Art, "Immersive Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(PocketRarity.Gold_ex, "Gold ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
