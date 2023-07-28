namespace TCG
{
	public static class Sections
	{
		private static Section[] TheSections =
		{
			// all
			new Section(Rarity.Secret, "Secret Rare", SortMode.SORT_BY_SET),
			new Section(Rarity.Ancient_Mew, "Ancient Mew", SortMode.NO_SORT),
			new Section(Rarity.Full_Art, "Full Art Pokémon", SortMode.SORT_BY_SET),
			new Section(Rarity.Japanese_Full_art, "Japanese Full Art Pokémon", SortMode.SORT_BY_SET),
			new Section(Rarity.Gold_Pokemon, "Gold Pokémon", SortMode.SORT_BY_SET),
			new Section(Rarity.Metal, "Metal Cards", SortMode.SORT_BY_SET),
			new Section(Rarity.Stamped, "Stamped Cards (0 priority)", SortMode.SORT_BY_SET),
			
			// neo
			new Section(Rarity.Shining_Neo, "Shining (Neo)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// e series
			new Section(Rarity.Crystal_Type, "Crystal Type", SortMode.NO_SORT),

			// ex
			new Section(Rarity.ex, "ex", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Gold_Star, "Gold Star", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Unown, "Unown Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// DP
			new Section(Rarity.LV_X, "LV.X", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Shiny_Holo, "Shiny Holo Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Rotom, "Rotom Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Arceus, "Arceus Subset", SortMode.SORT_BY_SET),

			// HGSS
			new Section(Rarity.Prime, "Prime", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.LEGEND, "LEGEND", SortMode.NO_SORT),
			new Section(Rarity.Alph_Lithograph, "Alph Litograph", SortMode.SORT_BY_SET),
			new Section(Rarity.Shiny_Legend, "Shiny Legend Subset", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),

			// BW & XY
			new Section(Rarity.EX, "EX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX, "Mega EX", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Ace_Spec, "Ace Spec", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.BREAK, " BREAK", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Ancient_Trait_Alpha, "Ancient Trait α", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Omega, "Ancient Trait Ω", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Delta, "Ancient Trait Δ", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Ancient_Trait_Theta, "Ancient Trait θ", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Mirrored_Stadium, "Mirrored Stadium", SortMode.SORT_BY_DEX_AND_TYPE_AND_SET),
			new Section(Rarity.Radiant_Collection, "Radiant Collection", SortMode.SORT_BY_SET),
			new Section(Rarity.Full_Art_Trainer_BW_XY, "Full Art Trainer (BW & XY)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Trainer_Evolutions, "Full Art Trainer (Evolutions)", SortMode.SORT_BY_NAME),
			new Section(Rarity.EX_Full_Art, "EX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Plasma, "EX Full Art (Team Plasma)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Radiant, "EX Full Art (Radiant)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.M_EX_Full_Art_Radiant, "M EX Full Art (Radiant)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.EX_Full_Art_Special, "EX Full Art (Special)", SortMode.SORT_BY_SET),
			new Section(Rarity.M_EX_Full_Art, "Mega EX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
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
			new Section(Rarity.Full_Art_Trainer_SM, "Full Art Trainer (SM)", SortMode.SORT_BY_NAME),
			new Section(Rarity.GX_Full_Art, "GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX_Full_Art, "Ultra Beast GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_GX_Full_Art, "Tag Team GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.TT_UB_GX_Full_Art, "Tag Team Ultra Beast GX Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.GX_Shiny_Full_Art, "GX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.UB_GX_Shiny_Full_Art, "Ultra Beast GX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
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
			new Section(Rarity.Shiny_Vault_SWSH, "Shiny Vault (SWSH)", SortMode.SORT_BY_SET),
			new Section(Rarity.Classic_Collection, "Classic Collection", SortMode.NO_SORT),
			new Section(Rarity.Full_Art_Trainer_SWSH, "Full Art Trainer (SWSH)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Full_Art_Energy_SWSH, "Full Art Energy (SWSH)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.V_Full_Art, "V Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Shiny_Full_Art, "V Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Shiny_Full_Art, "VMAX Shiny", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Trainer_SWSH, "Special Art Trainer (SWSH)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Pokemon_SWSH, "Special Art Pokémon (SWSH)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.V_Special_Art, "V Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VMAX_Special_Art, "VMAX Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.VSTAR_Special_Art, "VSTAR Special Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
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
			new Section(Rarity.ex_SV_Tera, "Tera ex (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Full_Art_Trainer_SV, "Full Art Trainer (SV)", SortMode.SORT_BY_NAME),
			new Section(Rarity.ex_SV_Full_Art, "ex (SV) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Tera_Full_Art, "Tera ex (SV) Full Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Special_Art_Trainer_SV, "Special Art Trainer (SV)", SortMode.SORT_BY_NAME),
			new Section(Rarity.Special_Art_Pokemon_SV, "Special Art Pokémon (SV)", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.ex_SV_Special_Art, "ex (SV) Special Art Art", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
			new Section(Rarity.Gold_Item_SV, "Gold Item (SV)", SortMode.SORT_BY_NAME_AND_TYPE),
			new Section(Rarity.Gold_Energy_SV, "Gold Energy (SV)", SortMode.SORT_BY_TYPE),
			new Section(Rarity.ex_SV_Gold, "ex (SV) Gold", SortMode.SORT_BY_SET_AND_DEX_AND_TYPE),
		};

		public static Section[] Get()
		{
			return TheSections;
		}
	}
}
