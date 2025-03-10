﻿namespace TCG
{
	public static class Sections
	{
		private static Section[] TheSections =
		{
			// all
			new Section(Rarity.Ancient_Mew, "Ancient Mew", SortMode.NO_SORT),
			new Section(Rarity.Pikachu_Worlds_Collection, "Pikachu Worlds Collection", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Costume_Pikachu, "Full Art Custume Pikachu", SortMode.SORT_BY_SET),
			new Section(Rarity.Gold_Pokemon, "Gold Pokémon", SortMode.SORT_BY_SET),
			new Section(Rarity.Metal, "Metal Cards", SortMode.SORT_BY_SET),
			// new Section(Rarity.Stamped, "Stamped Cards (0 priority)", SortMode.SORT_BY_SET),
			
			// os
			new Section(Rarity.Secret_OS, "Secret Rare (OS)", SortMode.SORT_BY_SET),

			// neo
			new Section(Rarity.Shining_Neo, "Shining (Neo)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// e series
			new Section(Rarity.Secret_e_Series, "Secret Rare (e Series)", SortMode.SORT_BY_SET),
			new Section(Rarity.Crystal_Type, "Crystal Type", SortMode.NO_SORT),

			// ex
			new Section(Rarity.Secret_EX, "Secret Rare (EX)", SortMode.SORT_BY_SET),
			new Section(Rarity.ex, "ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Delta_Species_ex, "δ ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Rockets_ex, "Rockets ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Lucario_ex, "Lucario ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Gold_Star, "Gold Star", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Delta_Species_Gold_Star, "δ Gold Star", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Unown, "Unown Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Holo_Energy_EX_Emerald, "Holo Energy (EX Emerald)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Holo_Energy_EX_Holon_Phantoms, "Holo Energy (EX Holon Phantoms)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Holo_Energy_EX_Power_Keepers, "Holo Energy (EX Power Keepers)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// DP
			new Section(Rarity.Secret_DP, "Secret Rare (DP)", SortMode.SORT_BY_SET),
			new Section(Rarity.Secret_DP_Gold, "Secret Rare (DP - Gold)", SortMode.SORT_BY_SET),
			new Section(Rarity.LV_X, "LV.X", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.LV_X_SP, "LV.X (SP)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.LV_X_Arceus, "LV.X (Arceus)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Shiny_Holo, "Shiny Holo Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Rotom, "Rotom Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Arceus, "Arceus Subset", SortMode.SORT_BY_SET),

			// HGSS
			new Section(Rarity.Secret_HGSS, "Secret Rare (HGSS)", SortMode.SORT_BY_SET),
			new Section(Rarity.Prime, "Prime", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.LEGEND, "LEGEND", SortMode.NO_SORT),
			new Section(Rarity.Alph_Lithograph, "Alph Litograph", SortMode.SORT_BY_SET),
			new Section(Rarity.Shiny_Legend, "Shiny Legend Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Shiny_Legend_Promo, "Shiny Legend Promo", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// BW & XY
			new Section(Rarity.Secret_BWXY, "Secret Rare (BW & XY)", SortMode.SORT_BY_SET),
			new Section(Rarity.Secret_BWXY_Shiny, "Secret Rare (BW & XY - Shiny)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(Rarity.Secret_BWXY_Gold, "Secret Rare (BW & XY - Gold)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX),
			new Section(Rarity.Secret_Evolutions, "Secret Rare (Evolutions)", SortMode.SORT_BY_SET),
			new Section(Rarity.EX, "EX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Plasma, "EX (Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Radiant, "EX (Radiant)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Evolutions, "EX (Evolutions)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX, "Mega EX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Primal, "Mega EX (Primal)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Evolutions, "Mega EX (Evolutions)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Ace_Spec, "Ace Spec", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Ace_Spec_Plasma, "Ace Spec (Plasma)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.BREAK, " BREAK", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Ancient_Trait_Alpha, "Ancient Trait α", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Omega, "Ancient Trait Ω", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Delta, "Ancient Trait Δ", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Theta, "Ancient Trait θ", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Mirrored_Stadium, "Mirrored Stadium", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),

			new Section(Rarity.Radiant_Collection_BW, "Radiant Collection (BW)", SortMode.SORT_BY_SET),
			new Section(Rarity.Radiant_Collection_XY, "Radiant Collection (XY)", SortMode.SORT_BY_SET),

			new Section(Rarity.Full_Art_Pokemon_BWXY_Textured, "Full Art Pokémon (BW & XY - Textured)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_BWXY_Radiant, "Full Art Pokémon (BW & XY - Radiant)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_BWXY_Plasma, "Full Art Pokémon (BW & XY - Plasma)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_BWXY_Legendary, "Full Art Pokémon (BW & XY - Legendary)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_BWXY_Mythical, "Full Art Pokémon (BW & XY - Mythical)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_BWXY_Other, "Full Art Pokémon (BW & XY - Other)", SortMode.SORT_BY_SET),
			new Section(Rarity.EX_Full_Art, "EX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Evolutions, "EX Full Art (Evolutions)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Plasma, "EX Full Art (Team Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Radiant_BW, "EX Full Art (Radiant - BW)", SortMode.SORT_BY_SET),
			new Section(Rarity.EX_Full_Art_Radiant_XY, "EX Full Art (Radiant - XY)", SortMode.SORT_BY_SET),
			new Section(Rarity.EX_Full_Art_Special, "EX Full Art (Special)", SortMode.SORT_BY_SET),
			new Section(Rarity.M_EX_Full_Art, "Mega EX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Full_Art_Primal, "Mega EX Full Art (Primal)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Full_Art_Evolutions, "Mega EX Full Art (Evolutions)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Full_Art_Radiant, "Mega EX Full Art (Radiant)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Trainer_BW_XY, "Full Art Trainer (BW & XY)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Trainer_BW_XY_Plasma, "Full Art Trainer (BW & XY - Plasma)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Trainer_Evolutions, "Full Art Trainer (Evolutions)", SortMode.SORT_BY_NAME),

			new Section(Rarity.EX_Special_Art, "EX Special Art", SortMode.SORT_BY_SET),
			new Section(Rarity.M_EX_Special_Art, "Mega EX Special Art", SortMode.SORT_BY_SET),

			new Section(Rarity.Secret_M_EX, "Mega EX Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// SM
			new Section(Rarity.GX, "GX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX, "Ultra Beast GX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_GX, "Tag Team GX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_UB_GX, "Tag Team Ultra Beast GX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Shining_SM, "Shining (SM)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Prism_Star, "Prism Star", SortMode.SORT_BY_SET_AND_NAME_AND_DEX_AND_TYPE),

			new Section(Rarity.Shiny_Vault_SM, "Shiny Vault (SM)", SortMode.SORT_BY_SET),

			new Section(Rarity.Full_Art_Pokemon_SM, "Full Art Pokémon (SM)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_SM_Screaming, "Full Art Pokémon (SM - Screaming)", SortMode.SORT_BY_SET),
			new Section(Rarity.GX_Full_Art, "GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX_Full_Art, "Ultra Beast GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_GX_Full_Art, "Tag Team GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_UB_GX_Full_Art, "Tag Team Ultra Beast GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.GX_Shiny_Full_Art, "GX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX_Shiny_Full_Art, "Ultra Beast GX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Full_Art_Trainer_SM, "Full Art Trainer (SM)", SortMode.SORT_BY_NAME_AND_TYPE),

			new Section(Rarity.GX_Special_Art, "GX Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_GX_Special_Art, "Tag Team GX Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_UB_GX_Special_Art, "Tag Team Ultra Beast GX Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			
			new Section(Rarity.Character_Art_SM, "Character Art (SM)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			new Section(Rarity.Gold_Item_SM, "Gold Item (SM)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Stadium_SM, "Gold Stadium (SM)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Gold_Energy_SM, "Gold Energy (SM)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.Gold_Special_Energy_SM, "Gold Special Energy (SM)", SortMode.SORT_BY_NAME),
			new Section(Rarity.GX_Gold, "GX Gold", SortMode.SORT_BY_SET_AND_DEX),
			new Section(Rarity.TT_GX_Gold, "Tag Team GX Gold", SortMode.SORT_BY_SET_AND_TYPE),

			new Section(Rarity.GX_Rainbow, "GX Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX_Rainbow, "Ultra Beast GX Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_GX_Rainbow, "Tag Team GX Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_UB_GX_Rainbow, "Tag Team Ultra Beast GX Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// SWSH
			new Section(Rarity.V, "V", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX, "VMAX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Blue, "VMAX (Blue)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Gigantamax, "VMAX (Gigantamax)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Eternamax, "VMAX (Eternamax)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VSTAR, "VSTAR", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Union, "V-UNION", SortMode.SORT_BY_SET),
			new Section(Rarity.Amazing_Rare, "Amazing Rare", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Radiant, "Radiant", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Seal_Stone, "Seal Stone", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Seal_Stone_Non_Holo, "Seal Stone (Non Holo)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			new Section(Rarity.Shiny_Vault_SWSH, "Shiny Vault (SWSH)", SortMode.SORT_BY_SET),
			new Section(Rarity.Classic_Collection, "Classic Collection", SortMode.NO_SORT),

			new Section(Rarity.Full_Art_Energy_SWSH, "Full Art Energy (SWSH)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.Full_Art_Pokemon_SWSH, "Full Art Pokémon (SWSH)", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Pokemon_SWSH_Stamp_Box, "Full Art Pokémon (SWSH - Stamp Box)", SortMode.SORT_BY_SET),
			new Section(Rarity.V_Full_Art, "V Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Shiny_Full_Art, "V Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Shiny_Full_Art, "VMAX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Full_Art_Trainer_SWSH, "Full Art Trainer (SWSH)", SortMode.SORT_BY_NAME),

			new Section(Rarity.Special_Art_Pokemon_SWSH, "Special Art Pokémon (SWSH)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SWSH_Forest, "Special Art Pokémon (SWSH - Forest)", SortMode.SORT_BY_SET),
			new Section(Rarity.V_Special_Art, "V Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Special_Art, "VMAX Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VSTAR_Special_Art, "VSTAR Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Trainer_SWSH, "Special Art Trainer (SWSH)", SortMode.SORT_BY_NAME),

			new Section(Rarity.Character_Art_SWSH, "Character Art (SWSH)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Character_Art, "V Character Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Character_Art, "VMAX Character Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_UNION_Character_Art, "V-UNION Character Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			new Section(Rarity.Gold_Item_SWSH, "Gold Item (SWSH)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Stadium_SWSH, "Gold Stadium (SWSH)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Gold_Energy_SWSH, "Gold Energy (SWSH)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.Gold_Special_Energy_SWSH, "Gold Special Energy (SWSH)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Gold_Shiny, "Gold Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Gold, "V Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VSTAR_Gold, "VSTAR Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_VMAX_Gold, "V & VMAX Gold", SortMode.SORT_BY_SET),
			new Section(Rarity.VSTAR_Gold_Special_Art, "VSTAR Gold Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			new Section(Rarity.Rainbow_Trainer, "Rainbow Trainer", SortMode.SORT_BY_NAME),
			new Section(Rarity.VMAX_Rainbow, "VMAX Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Rainbow_Blue, "VMAX Rainbow (Blue)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Rainbow_Gigantamax, "VMAX Rainbow (Gigantamax)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Rainbow_Eternamax, "VMAX Rainbow (Eternamax)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VSTAR_Rainbow, "VSTAR Rainbow", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// SV
			new Section(Rarity.ex_SV, "ex (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Ancient, "ex (SV - Ancient)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Future, "ex (SV - Future)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera, "Tera ex (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Ace_Spec_SV, "Ace Spec (SV)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Ace_Spec_SV_Ancient, "Ace Spec (SV - Ancient)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Ace_Spec_SV_Future, "Ace Spec (SV - Future)", SortMode.SORT_BY_NAME_AND_TYPE),

			new Section(Rarity.Shiny_Vault_SV, "Shiny Vault (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			new Section(Rarity.Full_Art_Pokemon_SV, "Full Art Pokémon (SV)", SortMode.SORT_BY_SET),
			new Section(Rarity.ex_SV_Full_Art, "ex (SV) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Ancient_Full_Art, "ex (SV - Ancient) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Future_Full_Art, "ex (SV - Future) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Full_Art, "Tera ex (SV) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Shiny_Full_Art, "ex (SV) Shiny Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Ancient_Shiny_Full_Art, "Ancient ex (SV) Shiny Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Future_Shiny_Full_Art, "Future ex (SV) Shiny Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Shiny_Full_Art, "Tera ex (SV) Shiny Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Full_Art_Trainer_SV, "Full Art Trainer (SV)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Trainer_SV_Ancient, "Full Art Trainer (SV - Ancient)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Trainer_SV_Future, "Full Art Trainer (SV - Future)", SortMode.SORT_BY_NAME),

			new Section(Rarity.Special_Art_Pokemon_SV, "Special Art Pokémon (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SV_Woodblock, "Special Art Pokémon (SV - Woodblock)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SV_Glitter, "Special Art Pokémon (SV - Glitter)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SV_Ancient, "Special Art Pokémon (SV - Ancient)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SV_Future, "Special Art Pokémon (SV - Future)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Pokemon_SV_Shiny, "Special Art Pokémon (SV - Shiny)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Special_Art, "ex (SV) Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Special_Art_Woodblock, "ex (SV) Special Art (Woodblock)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Ancient_Special_Art, "ex (SV - Ancient) Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Future_Special_Art, "ex (SV - Future) Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Special_Art, "Tera ex (SV) Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Shiny_Special_Art, "ex (SV) Shiny Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Shiny_Special_Art, "Tera ex (SV) Shiny Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Trainer_SV, "Special Art Trainer (SV)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Trainer_SV_Poke_Ball, "Special Art Trainer (SV - Poké Ball)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Trainer_SV_Border, "Special Art Trainer (SV - Border)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Trainer_SV_Ancient, "Special Art Trainer (SV - Ancient)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Trainer_SV_Future, "Special Art Trainer (SV - Future)", SortMode.SORT_BY_NAME),

			new Section(Rarity.Gold_Item_SV, "Gold Item (SV)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Item_Ancient_SV, "Gold Item (SV - Ancient)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Stadium_SV, "Gold Stadium (SV)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Energy_SV, "Gold Energy (SV)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.Gold_Special_Energy_SV, "Gold Special Energy (SV)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.ex_SV_Gold, "ex (SV) Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Ancient_Gold, "ex (SV - Ancient) Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Future_Gold, "ex (SV - Future) Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Gold, "Tera ex (SV) Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Gold_Raised_Foil, "ex (SV) Gold (Raised Foil)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Gold_Silhouette_Ancient, "ex (SV) Gold (Silhouette - Ancient)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Gold_Silhouette_Future, "ex (SV) Gold (Silhouette - Future)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Gold_Silhouette_Tera, "ex (SV) Gold (Silhouette - Tera)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
