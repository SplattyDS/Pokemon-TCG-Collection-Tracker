namespace TCG
{
	public static class HoloSections
	{
		private static Section[] TheSections =
		{
			// original series
			new Section(HoloRarity.OS_STARLIGHT_HOLO, "OS - Starlight Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_PIXEL_COSMOS_HOLO, "OS - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_PIXEL_COSMOS_HOLO_DARK, "OS - Pixel Cosmos Holo (Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_PIXEL_COSMOS_HOLO_OWNER, "OS - Pixel Cosmos Holo (Owner)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_PIXEL_COSMOS_HOLO_ROCKET, "OS - Pixel Cosmos Holo (Rocket)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_CLASSIC_STARS_HOLO, "OS - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.OS_PIXEL_COSMOS_HOLO_ENERGY, "OS - Pixel Cosmos Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(HoloRarity.OS_CLASSIC_STARS_HOLO_ENERGY, "OS - Classic Stars Holo Energy", SortMode.SORT_BY_TYPE),

			new Section(HoloRarity.OS_REVERSE_PIXEL_COSMOS_HOLO, "OS - Reverse Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.OS_REVERSE_PIXEL_COSMOS_HOLO_ROCKET, "OS - Reverse Pixel Cosmos Holo (Rocket)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// neo series
			new Section(HoloRarity.NEO_PIXEL_COSMOS_HOLO, "Neo - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.NEO_PIXEL_COSMOS_HOLO_DARK, "Neo - Pixel Cosmos Holo (Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.NEO_PIXEL_COSMOS_HOLO_LIGHT, "Neo - Pixel Cosmos Holo (Light)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.NEO_SMOOTH_COSMOS_HOLO_LIGHT, "Neo - Smooth Cosmos Holo (Light)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.NEO_REVERSE_PIXEL_COSMOS_HOLO, "Neo - Reverse Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// legendary collection
			new Section(HoloRarity.LC_STARLIGHT_HOLO, "Legendary Collection - Starlight Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.LC_STARLIGHT_HOLO_DARK, "Legendary Collection - Starlight Holo (Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.LC_REVERSE_FIREWORKS_HOLO, "Legendary Collection - Reverse Fireworks Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.LC_REVERSE_FIREWORKS_HOLO_DARK, "Legendary Collection - Reverse Fireworks Holo (Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			
			// e series
			new Section(HoloRarity.E_PIXEL_COSMOS_HOLO, "e Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.E_CLASSIC_STARS_HOLO, "e Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.E_REVERSE_PLAIN_HOLO, "e Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// EX series
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO, "EX Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_AQUA, "EX Series - Pixel Cosmos Holo (Aqua)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_MAGMA, "EX Series - Pixel Cosmos Holo (Magma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_DARK, "EX Series - Pixel Cosmos Holo (Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_VICTORY_MEDAL, "EX Series - Pixel Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_DELTA, "EX Series - Pixel Cosmos Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_SMOOTH_COSMOS_HOLO_DELTA, "EX Series - Smooth Cosmos Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_VERTICAL_PLAIN_HOLO_DELTA, "EX Series - Vertical Plain Holo Delta", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_CLASSIC_STARS_HOLO, "EX Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_PIXEL_WAVE_HOLO_ENERGY, "EX Series - Pixel Wave Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_ENERGY, "EX Series - Plain Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EX_REVERSE_PLAIN_HOLO, "EX Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REVERSE_PLAIN_HOLO_AQUA, "EX Series - Reverse Plain Holo (Aqua)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_REVERSE_PLAIN_HOLO_MAGMA, "EX Series - Reverse Plain Holo (Magma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_BIG_ENERGY_HOLO_HL, "EX Series - Big Energy Holo (Hidden Legends)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_FL, "EX Series - Energy Holo (FireRed & LeafGreen)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_TRR, "EX Series - Energy Holo (Team Rocket Returns)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_TRR_DARK, "EX Series - Energy Holo (Team Rocket Returns - Dark)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_ENERGY_HOLO_TRR_ROCKET, "EX Series - Energy Holo (Team Rocket Returns - Rocket)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PRISM_HOLO_D, "EX Series - Prism Holo (Deoxys)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_2D_POKEBALL_HOLO_E, "EX Series - 2D Pokeball Holo (Emerald)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_3D_POKEBALL_HOLO_UF, "EX Series - 3D Pokeball Holo (Unseen Forces)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_DS, "EX Series - Plain Holo (Delta Species)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_DS_HOLON, "EX Series - Plain Holo (Delta Species - Holon)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_DS_DELTA, "EX Series - Plain Holo (Delta Species - δ)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PIXEL_COSMOS_HOLO_LM, "EX Series - Pixel Cosmos Holo (Legend Maker)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_HP, "EX Series - Mirror Holo (Holon Phantoms)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_HP_HOLON, "EX Series - Mirror Holo (Holon Phantoms - Holon)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_HP_DELTA, "EX Series - Mirror Holo (Holon Phantoms - δ)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_CG, "EX Series - Mirror Holo (Crystal Guardians)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_CG_DELTA, "EX Series - Mirror Holo (Crystal Guardians - δ)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_DF, "EX Series - Mirror Holo (Dragon Frontiers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_MIRROR_HOLO_DF_DELTA, "EX Series - Mirror Holo (Dragon Frontiers - δ)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EX_PLAIN_HOLO_PK, "EX Series - Plain Holo (Power Keepers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// DPPt series
			new Section(HoloRarity.DP_PIXEL_COSMOS_HOLO, "DPPt Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_PIXEL_COSMOS_HOLO_SP, "DPPt Series - Pixel Cosmos Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_SMOOTH_COSMOS_HOLO_SP, "DPPt Series - Smooth Cosmos Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_PIXEL_COSMOS_HOLO_VICTORY_MEDAL, "DPPt Series - Pixel Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_RUMBLE_PIXEL_COSMOS_HOLO, "DPPt Series - Rumble Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_RUMBLE_PIXEL_COSMOS_HOLO_LOGO, "DPPt Series - Rumble Pixel Cosmos Holo Logo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CRACKED_ICE_HOLO, "DPPt Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CRACKED_ICE_HOLO_SP, "DPPt Series - Cracked Ice Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CLASSIC_STARS_HOLO, "DPPt Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_MIRROR_HOLO_ENERGY, "DPPt Series - Mirror Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_CROSSHATCH_HOLO_ENERGY, "DPPt Series - Crosshatch Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_REVERSE_MIRROR_HOLO, "DPPt Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_MIRROR_HOLO_SP, "DPPt Series - Reverse Mirror Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.DP_REVERSE_CRACKED_ICE_HOLO, "DPPt Series - Reverse Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_CRACKED_ICE_HOLO_SP, "DPPt Series - Reverse Cracked Ice Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_CROSSHATCH_HOLO, "DPPt Series - Reverse Crosshatch Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_CROSSHATCH_HOLO_SP, "DPPt Series - Reverse Crosshatch Holo (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.DP_REVERSE_PLAIN_HOLO, "DPPt Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// HGSS series
			new Section(HoloRarity.HGSS_PIXEL_COSMOS_HOLO, "HGSS Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_PIXEL_COSMOS_HOLO_VICTORY_MEDAL, "HGSS Series - Pixel Cosmos Holo Victory Medal", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_CRACKED_ICE_HOLO, "HGSS Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.HGSS_CLASSIC_STARS_HOLO, "HGSS Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

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
			new Section(HoloRarity.BWXY_PIXEL_COSMOS_HOLO, "BW & XY Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_PIXEL_COSMOS_HOLO_PLASMA, "BW & XY Series - Pixel Cosmos Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_SMOOTH_COSMOS_HOLO, "BW & XY Series - Smooth Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_MIRROR_HOLO, "BW & XY Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CRACKED_ICE_HOLO, "BW & XY Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CRACKED_ICE_HOLO_PLASMA, "BW & XY Series - Cracked Ice Holo (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CONFETTI_HOLO, "BW & XY Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.BWXY_CLASSIC_STARS_HOLO, "BW & XY Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

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
			new Section(HoloRarity.EV_STARLIGHT_HOLO, "XY Evolutions - Starlight Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_SMOOTH_COSMOS_HOLO, "XY Evolutions - Smooth Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_MIRROR_HOLO, "XY Evolutions - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_CRACKED_ICE_HOLO, "XY Evolutions - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_SHEEN_HOLO, "XY Evolutions - Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.EV_CLASSIC_STARS_HOLO, "XY Evolutions - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EV_MIRROR_HOLO_ENERGY, "XY Evolutions - Mirror Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.EV_REVERSE_MIRROR_HOLO, "XY Evolutions - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SM Series
			new Section(HoloRarity.SM_WATER_WEB_HOLO, "SM Series - Water Web Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SMOOTH_COSMOS_HOLO, "SM Series - Smooth Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_MIRROR_HOLO, "SM Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_CRACKED_ICE_HOLO, "SM Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_CONFETTI_HOLO, "SM Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO, "SM Series - Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO_DP, "SM Series - Sheen Holo (Detective Pikachu)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SEQUIN_HOLO, "SM Series - Sequin Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_CLASSIC_STARS_HOLO, "SM Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_WATER_WEB_HOLO_ENERGY, "SM Series - Water Web Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO_ENERGY, "SM Series - Sheen Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_SHEEN_HOLO_ENERGY_TT, "SM Series - Sheen Holo Energy (TT)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO, "SM Series - Reverse Big Energy Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SM_REVERSE_SMOOTH_COSMOS_BIG_ENERGY_HOLO, "SM Series - Reverse Smooth Cosmos Big Energy Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SM_REVERSE_SHEEN_HOLO, "SM Series - Reverse Sheen Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SWSH Series
			new Section(HoloRarity.SWSH_LINE_HOLO, "SWSH Series - Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_LINE_HOLO_LOST, "SWSH Series - Line Holo (Lost)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PLAIN_HOLO, "SWSH Series - Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_SMOOTH_COSMOS_HOLO, "SWSH Series - Smooth Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PIXEL_COSMOS_HOLO, "SWSH Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PIXEL_COSMOS_HOLO_LOST, "SWSH Series - Pixel Cosmos Holo (Lost)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_MIRROR_HOLO, "SWSH Series - Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_CRACKED_ICE_HOLO, "SWSH Series - Cracked Ice Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_CONFETTI_HOLO, "SWSH Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_SEQUIN_HOLO, "SWSH Series - Sequin Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_MIRAGE_HOLO, "SWSH Series - Mirage Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_CLASSIC_STARS_HOLO, "SWSH Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_PLAIN_HOLO_ENERGY, "SWSH Series - Plain Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PLAIN_HOLO_ENERGY_STAR, "SWSH Series - Plain Holo Energy (Star)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_LINE_HOLO_ENERGY, "SWSH Series - Line Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_LINE_HOLO_ENERGY_STAR, "SWSH Series - Line Holo Energy (Star)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_PIXEL_COSMOS_HOLO_ENERGY_STAR, "SWSH Series - Pixel Cosmos Holo Energy (Star)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO_LOST, "SWSH Series - Reverse Energy Banner Holo (Lost)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SWSH_REVERSE_SMOOTH_COSMOS_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Smooth Cosmos Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_MIRROR_ENERGY_BANNER_HOLO, "SWSH Series - Reverse Mirror Energy Banner Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_MIRROR_HOLO, "SWSH Series - Reverse Mirror Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_PLAIN_HOLO, "SWSH Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_LINE_HOLO, "SWSH Series - Reverse Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SWSH_REVERSE_PIXEL_COSMOS_HOLO, "SWSH Series - Reverse Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			// SV Series
			new Section(HoloRarity.SV_MIRAGE_HOLO, "SV Series - Mirage Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_MIRAGE_HOLO_ANCIENT, "SV Series - Mirage Holo (Ancient)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_MIRAGE_HOLO_FUTURE, "SV Series - Mirage Holo (Future)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_SMOOTH_COSMOS_HOLO, "SV Series - Smooth Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_PIXEL_COSMOS_HOLO, "SV Series - Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_PIXEL_COSMOS_HOLO_ANCIENT, "SV Series - Pixel Cosmos Holo (Ancient)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_PIXEL_COSMOS_HOLO_FUTURE, "SV Series - Pixel Cosmos Holo (Future)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_CONFETTI_HOLO, "SV Series - Confetti Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_LINE_HOLO, "SV Series - Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_SNOWFLAKE_HOLO, "SV Series - Snowflake Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_CLASSIC_STARS_HOLO, "SV Series - Classic Stars Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SV_SMOOTH_COSMOS_HOLO_ENERGY, "SV Series - Smooth Cosmos Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_PIXEL_COSMOS_HOLO_ENERGY, "SV Series - Pixel Cosmos Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_TOXIC_CHAIN_HOLO_ENERGY, "SV Series - Toxic Chain Holo Energy", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SV_REVERSE_ROCKY_HOLO, "SV Series - Reverse Rocky Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_TOXIC_CHAIN_HOLO, "SV Series - Reverse Toxic Chain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_ANCIENT_HOLO, "SV Series - Reverse Ancient Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_FUTURE_HOLO, "SV Series - Reverse Future Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),

			new Section(HoloRarity.SV_REVERSE_MIRAGE_ROCKY_HOLO, "SV Series - Reverse Mirage Rocky Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_PIXEL_COSMOS_HOLO, "SV Series - Reverse Pixel Cosmos Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_LINE_HOLO, "SV Series - Reverse Line Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(HoloRarity.SV_REVERSE_PLAIN_HOLO, "SV Series - Reverse Plain Holo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
