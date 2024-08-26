namespace TCG
{
	public enum SortMode
	{
		NO_SORT,
		SORT_BY_SET,
		SORT_BY_TYPE,
		SORT_BY_NAME,
		SORT_BY_NAME_AND_TYPE,
		SORT_BY_SET_AND_TYPE,
		SORT_BY_SET_AND_DEX,
		SORT_BY_TYPE_AND_SET,
		SORT_BY_SET_AND_DEX_AND_TYPE,
		SORT_BY_SET_AND_DEX_AND_TYPE_DX,
		SORT_BY_SET_AND_NAME_AND_DEX_AND_TYPE,
		SORT_BY_DEX_AND_TYPE_AND_SET,
	}

	public class Section
	{
		public Rarity rarity;
		public HoloRarity holoRarity;
		public PocketRarity pocketRarity;
		public string title;
		public SortMode sortMode;

		public Section(Rarity rarity, string title, SortMode sortMode = SortMode.NO_SORT)
		{
			this.rarity = rarity;
			this.title = title;
			this.sortMode = sortMode;
		}

		public Section(HoloRarity holoRarity, string title, SortMode sortMode = SortMode.NO_SORT)
		{
			this.holoRarity = holoRarity;
			this.title = title;
			this.sortMode = sortMode;
		}

		public Section(PocketRarity pocketRarity, string title, SortMode sortMode = SortMode.NO_SORT)
		{
			this.pocketRarity = pocketRarity;
			this.title = title;
			this.sortMode = sortMode;
		}
	}
}