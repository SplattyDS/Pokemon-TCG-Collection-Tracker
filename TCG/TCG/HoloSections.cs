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

			new Section(HoloRarity.LC_REVERSE_FIREWORKS_HOLO, "Legendary Collection - Reverse Fireworks Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// e series
			new Section(HoloRarity.E_COSMOS_HOLO, "e Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.E_REVERSE_PLAIN_HOLO, "e Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// EX series
			new Section(HoloRarity.EX_COSMOS_HOLO, "EX Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_VICTORY_MEDAL, "EX Series - Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_DELTA, "EX Series - Cosmos Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_VERTICAL_PLAIN_HOLO_DELTA, "EX Series - Vertical Plain Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_PIXEL_WAVE_HOLO_ENERGY, "EX Series - Pixel Wave Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_REVERSE_PLAIN_HOLO, "EX Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_BIG_ENERGY_HOLO_HL, "EX Series - Big Energy Holo (Hidden Legends)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_FL, "EX Series - Energy Holo (FireRed & LeafGreen)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_TRR, "EX Series - Energy Holo (Team Rocket Returns)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PRISM_HOLO_D, "EX Series - Prism Holo (Deoxys)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_2D_POKEBALL_HOLO_E, "EX Series - 2D Pokeball Holo (Emerald)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_3D_POKEBALL_HOLO_UF, "EX Series - 3D Pokeball Holo (Unseen Forces)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_DS, "EX Series - Plain Holo (Delta Species)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_COSMOS_HOLO_LM, "EX Series - Cosmos Holo (Legend Maker)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_HP, "EX Series - Mirror Holo (Holon Phantoms)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_CG, "EX Series - Mirror Holo (Crystal Guardians)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_DF, "EX Series - Mirror Holo (Dragon Frontiers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_PK, "EX Series - Plain Holo (Power Keepers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// DPPt series
			new Section(HoloRarity.DP_COSMOS_HOLO, "DPPt Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_COSMOS_HOLO_VICTORY_MEDAL, "DPPt Series - Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_RUMBLE_COSMOS_HOLO, "DPPt Series - Rumble Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_RUMBLE_COSMOS_HOLO_LOGO, "DPPt Series - Rumble Cosmos Holo Logo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CRACKED_ICE_HOLO, "DPPt Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_MIRROR_HOLO_ENERGY, "DPPt Series - Mirror Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CROSSHATCH_HOLO_ENERGY, "DPPt Series - Crosshatch Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_REVERSE_MIRROR_HOLO, "DPPt Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_REVERSE_CRACKED_ICE_HOLO, "DPPt Series - Reverse Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_CROSSHATCH_HOLO, "DPPt Series - Reverse Crosshatch Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_PLAIN_HOLO, "DPPt Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// HGSS series
			new Section(HoloRarity.HGSS_COSMOS_HOLO, "HGSS Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_COSMOS_HOLO_VICTORY_MEDAL, "HGSS Series - Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_CRACKED_ICE_HOLO, "HGSS Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.HGSS_MIRROR_HOLO_ENERGY_COL, "HGSS Series - Mirror Holo Energy (COL)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_CROSSHATCH_HOLO_ENERGY, "HGSS Series - Crosshatch Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_CROSSHATCH_HOLO_ENERGY_COL, "HGSS Series - Crosshatch Holo Energy (COL)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.HGSS_REVERSE_MIRROR_HOLO, "HGSS Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO, "HGSS Series - Reverse Crosshatch Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// BW & XY series
			new Section(HoloRarity.BWXY_TINSEL_HOLO, "BW & XY Series - Tinsel Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_TINSEL_HOLO_PLASMA, "BW & XY Series - Tinsel Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SHEEN_HOLO, "BW & XY Series - Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SHEEN_HOLO_FLARE, "BW & XY Series - Sheen Holo (Flare)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SHEEN_HOLO_AQUA, "BW & XY Series - Sheen Holo (Aqua)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SHEEN_HOLO_MAGMA, "BW & XY Series - Sheen Holo (Magma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_COSMOS_HOLO, "BW & XY Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_COSMOS_HOLO_PLASMA, "BW & XY Series - Cosmos Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_MIRROR_HOLO, "BW & XY Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CRACKED_ICE_HOLO, "BW & XY Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CRACKED_ICE_HOLO_PLASMA, "BW & XY Series - Cracked Ice Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CONFETTI_HOLO, "BW & XY Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.BWXY_CROSSHATCH_HOLO_ENERGY_BW, "BW & XY Series - Crosshatch Holo Energy (BW)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_MIRROR_HOLO_ENERGY, "BW & XY Series - Mirror Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CROSSHATCH_HOLO_ENERGY, "BW & XY Series - Crosshatch Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SHEEN_HOLO_ENERGY, "BW & XY Series - Sheen Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_MIRROR_HOLO_ENERGY_GENERATIONS, "BW & XY Series - Mirror Holo Energy (Generations)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.BWXY_REVERSE_MIRROR_HOLO, "BW & XY Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA, "BW & XY Series - Reverse Mirror Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_REVERSE_MIRROR_HOLO_AQUA, "BW & XY Series - Reverse Mirror Holo (Aqua)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_REVERSE_MIRROR_HOLO_MAGMA, "BW & XY Series - Reverse Mirror Holo (Magma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_REVERSE_ENERGY_HOLO, "BW & XY Series - Reverse Energy Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO, "BW & XY Series - Reverse Crosshatch Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA, "BW & XY Series - Reverse Crosshatch Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// XY Evolutions
			new Section(HoloRarity.EV_STAR_HOLO, "XY Evolutions - Star Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_COSMOS_HOLO, "XY Evolutions - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_MIRROR_HOLO, "XY Evolutions - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_CRACKED_ICE_HOLO, "XY Evolutions - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_SHEEN_HOLO, "XY Evolutions - Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EV_MIRROR_HOLO_ENERGY, "XY Evolutions - Mirror Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EV_REVERSE_MIRROR_HOLO, "XY Evolutions - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SM Series
			new Section(HoloRarity.SM_WATER_WEB_HOLO, "SM Series - Water Web Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_COSMOS_HOLO, "SM Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_MIRROR_HOLO, "SM Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_CRACKED_ICE_HOLO, "SM Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_CONFETTI_HOLO, "SM Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO, "SM Series - Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO_DP, "SM Series - Sheen Holo (Detective Pikachu)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SEQUIN_HOLO, "SM Series - Sequin Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_SHEEN_HOLO_ENERGY, "SM Series - Sheen Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO_ENERGY_TT, "SM Series - Sheen Holo Energy (TT)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO, "SM Series - Reverse Big Energy Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_REVERSE_COSMOS_BIG_ENERGY_HOLO, "SM Series - Reverse Cosmos Big Energy Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_REVERSE_SHEEN_HOLO, "SM Series - Reverse Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SWSH Series
			new Section(HoloRarity.SWSH_LINE_HOLO, "SWSH Series - Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PLAIN_HOLO, "SWSH Series - Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_COSMOS_HOLO, "SWSH Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_MIRROR_HOLO, "SWSH Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_CRACKED_ICE_HOLO, "SWSH Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_CONFETTI_HOLO, "SWSH Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_SEQUIN_HOLO, "SWSH Series - Sequin Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_PLAIN_HOLO_ENERGY, "SWSH Series - Plain Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PLAIN_HOLO_ENERGY_STAR, "SWSH Series - Plain Holo Energy (Star)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_LINE_HOLO_ENERGY, "SWSH Series - Line Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_LINE_HOLO_ENERGY_STAR, "SWSH Series - Line Holo Energy (Star)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_REVERSE_COSMOS_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Cosmos Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_MIRROR_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Mirror Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_MIRROR_HOLO, "SWSH Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_PLAIN_HOLO, "SWSH Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_LINE_HOLO, "SWSH Series - Reverse Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SV Series
			new Section(HoloRarity.SV_MIRAGE_HOLO, "SV Series - Mirage Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_COSMOS_HOLO, "SV Series - Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_LINE_HOLO, "SV Series - Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SV_COSMOS_HOLO_ENERGY, "SV Series - Cosmos Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SV_REVERSE_ROCKY_HOLO, "SV Series - Reverse Rocky Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
