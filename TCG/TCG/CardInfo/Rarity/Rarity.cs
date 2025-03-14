﻿namespace TCG
{
	public enum Rarity
	{
		/*
			order:
		Regular {type}
		Subset
		Full Art {type}
		Shiny Full Art {type}
		Special Art {type}
		Character Art {type}
		Gold {type}
		Rainbow {type}
		*/

		// -
		Unknown,

		// all
		Ancient_Mew,
		Pikachu_Worlds_Collection,
		Full_Art_Costume_Pikachu,
		Gold_Pokemon,
		Metal,
		Stamped,

		// os
		Secret_OS,

		// neo
		Shining_Neo,

		// e series
		Secret_e_Series,
		Crystal_Type,

		// ex
		Secret_EX,
		ex,
		Delta_Species_ex,
		Rockets_ex,
		Lucario_ex,
		Gold_Star,
		Delta_Species_Gold_Star,
		Unown,
		Holo_Energy_EX_Emerald,
		Holo_Energy_EX_Holon_Phantoms,
		Holo_Energy_EX_Power_Keepers,

		// DP
		Secret_DP,
		Secret_DP_Gold,
		LV_X,
		LV_X_SP,
		LV_X_Arceus,
		Shiny_Holo,
		Rotom,
		Arceus,

		// HGSS
		Secret_HGSS,
		Prime,
		LEGEND,
		Alph_Lithograph,
		Shiny_Legend,
		Shiny_Legend_Promo,

		// BW & XY
		Secret_BWXY,
		Secret_BWXY_Shiny,
		Secret_BWXY_Gold,
		Secret_Evolutions,
		EX,
		EX_Plasma,
		EX_Radiant,
		EX_Evolutions,
		M_EX,
		M_EX_Primal,
		M_EX_Evolutions,
		Ace_Spec,
		Ace_Spec_Plasma,
		BREAK,
		Ancient_Trait_Alpha,
		Ancient_Trait_Omega,
		Ancient_Trait_Delta,
		Ancient_Trait_Theta,
		Mirrored_Stadium,

		Radiant_Collection_BW,
		Radiant_Collection_XY,

		Full_Art_Pokemon_BWXY_Textured,
		Full_Art_Pokemon_BWXY_Radiant,
		Full_Art_Pokemon_BWXY_Plasma,
		Full_Art_Pokemon_BWXY_Legendary,
		Full_Art_Pokemon_BWXY_Mythical,
		Full_Art_Pokemon_BWXY_Other,
		EX_Full_Art,
		EX_Full_Art_Evolutions,
		M_EX_Full_Art,
		M_EX_Full_Art_Primal,
		M_EX_Full_Art_Evolutions,
		EX_Full_Art_Plasma,
		EX_Full_Art_Radiant_BW,
		EX_Full_Art_Radiant_XY,
		M_EX_Full_Art_Radiant,
		EX_Full_Art_Special,
		Full_Art_Trainer_BW_XY,
		Full_Art_Trainer_BW_XY_Plasma,
		Full_Art_Trainer_Evolutions,

		EX_Special_Art,
		M_EX_Special_Art,

		Secret_M_EX,

		// SM
		GX,
		UB_GX,
		TT_GX,
		TT_UB_GX,
		Shining_SM,
		Prism_Star,

		Shiny_Vault_SM,

		Full_Art_Pokemon_SM,
		Full_Art_Pokemon_SM_Screaming,
		GX_Full_Art,
		UB_GX_Full_Art,
		TT_GX_Full_Art,
		TT_UB_GX_Full_Art,
		GX_Shiny_Full_Art,
		UB_GX_Shiny_Full_Art,
		Full_Art_Trainer_SM,

		GX_Special_Art,
		TT_GX_Special_Art,
		TT_UB_GX_Special_Art,

		Character_Art_SM,

		Gold_Item_SM,
		Gold_Stadium_SM,
		Gold_Energy_SM,
		Gold_Special_Energy_SM,
		GX_Gold,
		TT_GX_Gold,

		GX_Rainbow,
		UB_GX_Rainbow,
		TT_GX_Rainbow,
		TT_UB_GX_Rainbow,

		// SWSH
		V,
		VMAX,
		VMAX_Blue,
		VMAX_Gigantamax,
		VMAX_Eternamax,
		VSTAR,
		V_Union,
		Amazing_Rare,
		Radiant,
		Seal_Stone,
		Seal_Stone_Non_Holo,

		Shiny_Vault_SWSH,
		Classic_Collection,

		Full_Art_Pokemon_SWSH,
		Full_Art_Pokemon_SWSH_Stamp_Box,
		V_Full_Art,
		V_Shiny_Full_Art,
		VMAX_Shiny_Full_Art,
		Full_Art_Trainer_SWSH,
		Full_Art_Energy_SWSH,

		Special_Art_Pokemon_SWSH,
		Special_Art_Pokemon_SWSH_Forest,
		V_Special_Art,
		VMAX_Special_Art,
		VSTAR_Special_Art,
		Special_Art_Trainer_SWSH,

		Character_Art_SWSH,
		V_Character_Art,
		VMAX_Character_Art,
		V_UNION_Character_Art,

		Gold_Item_SWSH,
		Gold_Stadium_SWSH,
		Gold_Energy_SWSH,
		Gold_Special_Energy_SWSH,
		Gold_Shiny,
		V_Gold,
		VSTAR_Gold,
		V_VMAX_Gold,
		VSTAR_Gold_Special_Art,

		Rainbow_Trainer,
		VMAX_Rainbow,
		VMAX_Rainbow_Blue,
		VMAX_Rainbow_Gigantamax,
		VMAX_Rainbow_Eternamax,
		VSTAR_Rainbow,

		// SV
		ex_SV,
		ex_SV_Ancient,
		ex_SV_Future,
		ex_SV_Tera,
		Ace_Spec_SV,
		Ace_Spec_SV_Ancient,
		Ace_Spec_SV_Future,

		Shiny_Vault_SV,

		Full_Art_Pokemon_SV,
		ex_SV_Full_Art,
		ex_SV_Ancient_Full_Art,
		ex_SV_Future_Full_Art,
		ex_SV_Tera_Full_Art,
		ex_SV_Shiny_Full_Art,
		ex_SV_Ancient_Shiny_Full_Art,
		ex_SV_Future_Shiny_Full_Art,
		ex_SV_Tera_Shiny_Full_Art,
		Full_Art_Trainer_SV,
		Full_Art_Trainer_SV_Ancient,
		Full_Art_Trainer_SV_Future,

		Special_Art_Pokemon_SV,
		Special_Art_Pokemon_SV_Woodblock,
		Special_Art_Pokemon_SV_Glitter,
		Special_Art_Pokemon_SV_Ancient,
		Special_Art_Pokemon_SV_Future,
		Special_Art_Pokemon_SV_Shiny,
		ex_SV_Special_Art,
		ex_SV_Special_Art_Woodblock,
		ex_SV_Ancient_Special_Art,
		ex_SV_Future_Special_Art,
		ex_SV_Tera_Special_Art,
		ex_SV_Shiny_Special_Art,
		ex_SV_Tera_Shiny_Special_Art,
		Special_Art_Trainer_SV,
		Special_Art_Trainer_SV_Poke_Ball,
		Special_Art_Trainer_SV_Border,
		Special_Art_Trainer_SV_Ancient,
		Special_Art_Trainer_SV_Future,

		Gold_Item_SV,
		Gold_Item_Ancient_SV,
		Gold_Stadium_SV,
		Gold_Energy_SV,
		Gold_Special_Energy_SV,
		ex_SV_Gold,
		ex_SV_Ancient_Gold,
		ex_SV_Future_Gold,
		ex_SV_Tera_Gold,
		ex_SV_Gold_Raised_Foil,
		ex_SV_Gold_Silhouette_Ancient,
		ex_SV_Gold_Silhouette_Future,
		ex_SV_Gold_Silhouette_Tera,
	}
}