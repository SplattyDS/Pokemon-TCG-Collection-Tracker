﻿namespace TCG
{
	// cosmos holo includes both the pixel and smooth versions, if a card had both, both are added

	public enum HoloRarity
	{
		// for things like the 3 SWSH play labs promos
		DELETED,

		// os
		OS_STARLIGHT_HOLO,
		OS_PIXEL_COSMOS_HOLO,
		OS_PIXEL_COSMOS_HOLO_DARK,
		OS_PIXEL_COSMOS_HOLO_OWNER,
		OS_PIXEL_COSMOS_HOLO_ROCKET,
		OS_CLASSIC_STARS_HOLO_ENERGY,

		OS_PIXEL_COSMOS_HOLO_ENERGY,
		OS_CLASSIC_STARS_HOLO,

		OS_REVERSE_PIXEL_COSMOS_HOLO,
		OS_REVERSE_PIXEL_COSMOS_HOLO_ROCKET,

		// neo
		NEO_PIXEL_COSMOS_HOLO,
		NEO_PIXEL_COSMOS_HOLO_DARK,
		NEO_PIXEL_COSMOS_HOLO_LIGHT,
		NEO_SMOOTH_COSMOS_HOLO_LIGHT,

		NEO_REVERSE_PIXEL_COSMOS_HOLO,

		// legendary collection
		LC_STARLIGHT_HOLO,
		LC_STARLIGHT_HOLO_DARK,

		LC_REVERSE_FIREWORKS_HOLO,
		LC_REVERSE_FIREWORKS_HOLO_DARK,

		// e series
		E_PIXEL_COSMOS_HOLO,
		E_CLASSIC_STARS_HOLO,

		E_REVERSE_PLAIN_HOLO,

		// ex
		// the PLAIN_HOLO reverses need more documentation
		// this also includes EX_VERTICAL_PLAIN_HOLO_DELTA
		EX_PIXEL_COSMOS_HOLO,
		EX_PIXEL_COSMOS_HOLO_AQUA,
		EX_PIXEL_COSMOS_HOLO_MAGMA,
		EX_PIXEL_COSMOS_HOLO_DARK,
		EX_PIXEL_COSMOS_HOLO_VICTORY_MEDAL,
		EX_PIXEL_COSMOS_HOLO_DELTA,
		EX_SMOOTH_COSMOS_HOLO_DELTA,
		EX_VERTICAL_PLAIN_HOLO_DELTA,
		EX_CLASSIC_STARS_HOLO,

		EX_PIXEL_WAVE_HOLO_ENERGY,
		EX_PLAIN_HOLO_ENERGY,

		EX_REVERSE_PLAIN_HOLO,
		EX_REVERSE_PLAIN_HOLO_AQUA,
		EX_REVERSE_PLAIN_HOLO_MAGMA,
		EX_BIG_ENERGY_HOLO_HL,
		EX_ENERGY_HOLO_FL,
		EX_ENERGY_HOLO_TRR,
		EX_ENERGY_HOLO_TRR_DARK,
		EX_ENERGY_HOLO_TRR_ROCKET,
		EX_PRISM_HOLO_D,
		EX_2D_POKEBALL_HOLO_E,
		EX_3D_POKEBALL_HOLO_UF,
		EX_PLAIN_HOLO_DS,
		EX_PLAIN_HOLO_DS_HOLON,
		EX_PLAIN_HOLO_DS_DELTA,
		EX_PIXEL_COSMOS_HOLO_LM,
		EX_MIRROR_HOLO_HP,
		EX_MIRROR_HOLO_HP_HOLON,
		EX_MIRROR_HOLO_HP_DELTA,
		EX_MIRROR_HOLO_CG,
		EX_MIRROR_HOLO_CG_DELTA,
		EX_MIRROR_HOLO_DF,
		EX_MIRROR_HOLO_DF_DELTA,
		EX_PLAIN_HOLO_PK,

		// DP
		DP_PIXEL_COSMOS_HOLO,
		DP_PIXEL_COSMOS_HOLO_SP,
		DP_SMOOTH_COSMOS_HOLO_SP,
		DP_PIXEL_COSMOS_HOLO_VICTORY_MEDAL,
		DP_RUMBLE_PIXEL_COSMOS_HOLO,
		DP_RUMBLE_PIXEL_COSMOS_HOLO_LOGO,
		DP_CRACKED_ICE_HOLO,
		DP_CRACKED_ICE_HOLO_SP,
		DP_CLASSIC_STARS_HOLO,

		DP_MIRROR_HOLO_ENERGY,
		DP_CROSSHATCH_HOLO_ENERGY,

		DP_REVERSE_MIRROR_HOLO,
		DP_REVERSE_MIRROR_HOLO_SP,

		DP_REVERSE_CRACKED_ICE_HOLO,
		DP_REVERSE_CRACKED_ICE_HOLO_SP,
		DP_REVERSE_CROSSHATCH_HOLO,
		DP_REVERSE_CROSSHATCH_HOLO_SP,
		DP_REVERSE_PLAIN_HOLO,

		// HGSS
		HGSS_PIXEL_COSMOS_HOLO,
		HGSS_PIXEL_COSMOS_HOLO_VICTORY_MEDAL,
		HGSS_CRACKED_ICE_HOLO,
		HGSS_CLASSIC_STARS_HOLO,

		HGSS_MIRROR_HOLO_ENERGY_COL,
		HGSS_CROSSHATCH_HOLO_ENERGY,
		HGSS_CROSSHATCH_HOLO_ENERGY_COL,

		HGSS_REVERSE_MIRROR_HOLO,

		HGSS_REVERSE_CROSSHATCH_HOLO,

		// BW & XY
		BWXY_TINSEL_HOLO,
		BWXY_TINSEL_HOLO_PLASMA,
		BWXY_SHEEN_HOLO,
		BWXY_SHEEN_HOLO_FLARE,
		BWXY_SHEEN_HOLO_AQUA,
		BWXY_SHEEN_HOLO_MAGMA,
		BWXY_PIXEL_COSMOS_HOLO,
		BWXY_PIXEL_COSMOS_HOLO_PLASMA,
		BWXY_SMOOTH_COSMOS_HOLO,
		BWXY_MIRROR_HOLO,
		BWXY_CRACKED_ICE_HOLO,
		BWXY_CRACKED_ICE_HOLO_PLASMA,
		BWXY_CONFETTI_HOLO,
		BWXY_CLASSIC_STARS_HOLO,

		BWXY_CROSSHATCH_HOLO_ENERGY_BW,
		BWXY_MIRROR_HOLO_ENERGY,
		BWXY_CROSSHATCH_HOLO_ENERGY,
		BWXY_SHEEN_HOLO_ENERGY,
		BWXY_MIRROR_HOLO_ENERGY_GENERATIONS,

		BWXY_REVERSE_MIRROR_HOLO,
		BWXY_REVERSE_MIRROR_HOLO_PLASMA,
		BWXY_REVERSE_MIRROR_HOLO_AQUA,
		BWXY_REVERSE_MIRROR_HOLO_MAGMA,
		BWXY_REVERSE_ENERGY_HOLO,

		BWXY_REVERSE_CROSSHATCH_HOLO,
		BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA,

		// XY Evolutions
		EV_STARLIGHT_HOLO,
		EV_SMOOTH_COSMOS_HOLO,
		EV_MIRROR_HOLO,
		EV_CRACKED_ICE_HOLO,
		EV_SHEEN_HOLO,
		EV_CLASSIC_STARS_HOLO,

		EV_MIRROR_HOLO_ENERGY,

		EV_REVERSE_MIRROR_HOLO,

		// SM
		SM_WATER_WEB_HOLO,
		SM_SMOOTH_COSMOS_HOLO,
		SM_PIXEL_COSMOS_HOLO,
		SM_MIRROR_HOLO,
		SM_CRACKED_ICE_HOLO,
		SM_CONFETTI_HOLO,
		SM_SHEEN_HOLO,
		SM_SHEEN_HOLO_DP,
		SM_SEQUIN_HOLO,
		SM_CLASSIC_STARS_HOLO,

		SM_WATER_WEB_HOLO_ENERGY,
		SM_SHEEN_HOLO_ENERGY,
		SM_SHEEN_HOLO_ENERGY_TT,

		SM_REVERSE_BIG_ENERGY_HOLO,

		SM_REVERSE_SMOOTH_COSMOS_BIG_ENERGY_HOLO,
		SM_REVERSE_SHEEN_HOLO,

		// SWSH
		SWSH_LINE_HOLO,
		SWSH_LINE_HOLO_LOST,
		SWSH_PLAIN_HOLO,
		SWSH_SMOOTH_COSMOS_HOLO,
		SWSH_PIXEL_COSMOS_HOLO,
		SWSH_PIXEL_COSMOS_HOLO_LOST,
		SWSH_MIRROR_HOLO,
		SWSH_CRACKED_ICE_HOLO,
		SWSH_CONFETTI_HOLO,
		SWSH_SEQUIN_HOLO,
		SWSH_MIRAGE_HOLO,
		SWSH_CLASSIC_STARS_HOLO,

		SWSH_PLAIN_HOLO_ENERGY,
		SWSH_PLAIN_HOLO_ENERGY_STAR,
		SWSH_LINE_HOLO_ENERGY,
		SWSH_LINE_HOLO_ENERGY_STAR,
		SWSH_PIXEL_COSMOS_HOLO_ENERGY_STAR,

		SWSH_REVERSE_ENERGY_BANNER_HOLO,
		SWSH_REVERSE_ENERGY_BANNER_HOLO_LOST,

		SWSH_REVERSE_SMOOTH_COSMOS_ENERGY_BANNER_HOLO,
		SWSH_REVERSE_MIRROR_ENERGY_BANNER_HOLO,
		SWSH_REVERSE_MIRROR_HOLO,
		SWSH_REVERSE_PLAIN_HOLO,
		SWSH_REVERSE_LINE_HOLO,
		SWSH_REVERSE_PIXEL_COSMOS_HOLO,

		// SV
		SV_MIRAGE_HOLO,
		SV_MIRAGE_HOLO_ANCIENT,
		SV_MIRAGE_HOLO_FUTURE,
		SV_SMOOTH_COSMOS_HOLO,
		SV_PIXEL_COSMOS_HOLO,
		SV_PIXEL_COSMOS_HOLO_ANCIENT,
		SV_PIXEL_COSMOS_HOLO_FUTURE,
		SV_CONFETTI_HOLO,
		SV_CONFETTI_HOLO_ANCIENT,
		SV_LINE_HOLO,
		SV_GLITTER_HOLO,
		SV_SNOWFLAKE_HOLO,
		SV_CLASSIC_STARS_HOLO,

		SV_SMOOTH_COSMOS_HOLO_ENERGY,
		SV_PIXEL_COSMOS_HOLO_ENERGY,
		SV_TOXIC_CHAIN_HOLO_ENERGY,
		SV_PLAIN_HOLO_ENERGY_TERA,
		SV_PIXEL_COSMOS_HOLO_ENERGY_TERA,
		SV_CRACKED_ICE_HOLO_ENERGY_TERA,

		SV_REVERSE_ROCKY_HOLO,
		SV_REVERSE_TOXIC_CHAIN_HOLO,
		SV_REVERSE_ANCIENT_HOLO,
		SV_REVERSE_FUTURE_HOLO,

		SV_REVERSE_MIRAGE_ROCKY_HOLO,
		SV_REVERSE_PIXEL_COSMOS_ROCKY_HOLO,
		SV_REVERSE_PIXEL_COSMOS_HOLO,
		SV_REVERSE_LINE_HOLO,
		SV_REVERSE_PLAIN_HOLO,

		SV_REVERSE_POKE_BALL_HOLO,
		SV_REVERSE_MASTER_BALL_HOLO,
	}
}