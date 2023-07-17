namespace TCG
{
	public static class HoloSections
	{
		private static Section[] TheSections =
		{
			// original series
			new Section(HoloRarity.OS_STAR_HOLO, "OS - Star Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_COSMOS_HOLO, "OS - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_COSMOS_HOLO_ENERGY, "OS - Cosmos Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(HoloRarity.OS_REVERSE_COSMOS_HOLO, "OS - Reverse Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// neo series
			new Section(HoloRarity.NEO_COSMOS_HOLO, "Neo - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.NEO_REVERSE_COSMOS_HOLO, "Neo - Reverse Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// legendary collection
			new Section(HoloRarity.LC_STAR_HOLO, "Legendary Collection - Star Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.LC_REVERSE_SILVER_FIREWORKS_HOLO, "Legendary Collection - Reverse Silver Fireworks Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// e series
			new Section(HoloRarity.E_COSMOS_HOLO, "e Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.E_REVERSE_REFRACTOR_HOLO, "e Series - Reverse Refractor Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// EX series
			new Section(HoloRarity.EX_COSMOS_HOLO, "EX Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_VICTORY_MEDAL, "EX Series - Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_DELTA, "EX Series - Cosmos Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_VERTICAL_REFRACTOR_HOLO_DELTA, "EX Series - Vertical Refractor Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_REVERSE_REFRACTOR_HOLO, "EX Series - Reverse Refractor Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_BIG_ENERGY_HOLO_HL, "EX Series - Big Energy Holo (Hidden Legends)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_FL, "EX Series - Energy Holo (FireRed & LeafGreen)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_TRR, "EX Series - Energy Holo (Team Rocket Returns)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PRISM_HOLO_D, "EX Series - Prism Holo (Deoxys)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_2D_POKEBALL_HOLO_E, "EX Series - 2D Pokeball Holo (Emerald)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_3D_POKEBALL_HOLO_UF, "EX Series - 3D Pokeball Holo (Unseen Forces)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REFRACTOR_HOLO_DS, "EX Series - Refractor Holo (Delta Species)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_LM, "EX Series - Cosmos Holo (Legend Maker)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REFRACTOR_HOLO_HP, "EX Series - Refractor Holo (Holon Phantoms)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REFRACTOR_HOLO_CG, "EX Series - Refractor Holo (Crystal Guardians)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REFRACTOR_HOLO_DF, "EX Series - Refractor Holo (Dragon Frontiers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REFRACTOR_HOLO_PK, "EX Series - Refractor Holo (Power Keepers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_PIXEL_WAVE_HOLO_ENERGY, "EX Series - Pixel Wave Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
