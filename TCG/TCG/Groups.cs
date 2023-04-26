using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public static class Groups
	{
		private static Group[] TheGroups =
		{
			new Group // Silver Dialga EX
			(
				Rarity.Gold_Pokemon,
				Rules.ENFORCE_LAST,
				Cards.Find(Sets.Phantom_Forces, 122)
			),
			new Group // Aquapolis Crystal Types
			(
				Rarity.Crystal_Type,
				Rules.ENFORCE_LAST,
				Cards.Find(Sets.Aquapolis, 148),
				Cards.Find(Sets.Aquapolis, 149),
				Cards.Find(Sets.Aquapolis, 150)
			),
			new Group // Deoxys ex
			(
				Rarity.ex,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.EX_Deoxys, 97),
				Cards.Find(Sets.Japanese_EX, 5)
			),
			new Group // Rayquaza ex (1)
			(
				Rarity.ex,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.EX_Dragon, 97),
				Cards.Find(Sets.Japanese_EX, 4)
			),
			new Group // Rayquaza ex (2)
			(
				Rarity.ex,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.EX_Deoxys, 102),
				Cards.Find(Sets.Japanese_EX, 6)
			),
			new Group // Infernape LV.X
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Diamond_Pearl, 121),
				Cards.Find(Sets.DP_Promo, 10)
			),
			new Group // Palkia LV.X
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Great_Encounters, 106),
				Cards.Find(Sets.DP_Promo, 18),
				Cards.Find(Sets.Japanese_DP, 1)
			),
			new Group // Dialga LV.X
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Great_Encounters, 105),
				Cards.Find(Sets.DP_Promo, 17),
				Cards.Find(Sets.DP_Promo, 37)
			),
			new Group // Garchomp LV.X
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Majestic_Dawn, 97),
				Cards.Find(Sets.Japanese_DP, 2)
			),
			new Group // Arceus LV.X (1)
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Arceus, 94),
				Cards.Find(Sets.DP_Promo, 53)
			),
			new Group // Arceus LV.X (2)
			(
				Rarity.LV_X,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Arceus, 95),
				Cards.Find(Sets.DP_Promo, 56)
			),
			new Group // Venusaur EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.XY, 1),
				Cards.Find(Sets.Evolutions, 1),
				Cards.Find(Sets.XY_Promo, 28)
			),
			new Group // Charizard EX (1)
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Flashfire, 11),
				Cards.Find(Sets.XY_Promo, 29)
			),
			new Group // Charizard EX (2)
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Flashfire, 12),
				Cards.Find(Sets.Flashfire, 12.1),
				Cards.Find(Sets.Evolutions, 12)
			),
			new Group // Blastoise EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.XY, 29),
				Cards.Find(Sets.XY, 29.1),
				Cards.Find(Sets.Evolutions, 21),
				Cards.Find(Sets.XY_Promo, 30)
			),
			new Group // Kyurem EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Next_Destinies, 38),
				Cards.Find(Sets.Legendary_Treasures, 44),
				Cards.Find(Sets.BW_Promo, 37)
			),
			new Group // Mewtwo EX (1)
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.BREAKthrough, 61),
				Cards.Find(Sets.XY_Promo, 183)
			),
			new Group // Mewtwo EX (2)
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.BREAKthrough, 62),
				Cards.Find(Sets.XY_Promo, 107)
			),
			new Group // Black Kyurem EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Boundaries_Crossed, 101),
				Cards.Find(Sets.Boundaries_Crossed, 101.1),
				Cards.Find(Sets.Legendary_Treasures, 100),
				Cards.Find(Sets.BW_Promo, 62)
			),
			new Group // White Kyurem EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Boundaries_Crossed, 103),
				Cards.Find(Sets.Boundaries_Crossed, 103.1),
				Cards.Find(Sets.Legendary_Treasures, 101),
				Cards.Find(Sets.BW_Promo, 63)
			),
			new Group // Tornadus EX
			(
				Rarity.EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Dark_Explorers, 90),
				Cards.Find(Sets.BW_Promo, 96)
			),
			new Group // M Venusaur EX
			(
				Rarity.M_EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.XY, 2),
				Cards.Find(Sets.Evolutions, 2)
			),
			new Group // M Charizard EX
			(
				Rarity.M_EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Flashfire, 13),
				Cards.Find(Sets.Evolutions, 13)
			),
			new Group // M Charizard EX
			(
				Rarity.M_EX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.XY, 30),
				Cards.Find(Sets.XY, 30.1),
				Cards.Find(Sets.Evolutions, 22)
			),
			new Group // Mewtwo EX
			(
				Rarity.EX_Full_Art,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.BREAKthrough, 157),
				Cards.Find(Sets.XY_Promo, 125)
			),
			new Group // Giratina EX
			(
				Rarity.EX_Full_Art,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Dragons_Exalted, 124),
				Cards.Find(Sets.Japanese_BW_XY, 2)
			),
			new Group // Charizard GX
			(
				Rarity.GX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Hidden_Fates, 9),
				Cards.Find(Sets.SM_Promo, 211)
			),
			new Group // Tapu Koko GX
			(
				Rarity.GX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Guardians_Rising, 47),
				Cards.Find(Sets.SM_Promo, 50),
				Cards.Find(Sets.SM_Promo, 33)
			),
			new Group // Zygarde GX
			(
				Rarity.GX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Japanese_SM, 42),
				Cards.Find(Sets.SM_Promo, 122)
			),
			new Group // Silvally GX
			(
				Rarity.GX,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Crimson_Invasion, 90),
				Cards.Find(Sets.SM_Promo, 91),
				Cards.Find(Sets.Ultra_Prism, 116)
			),
			new Group // Rillaboom V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Rebel_Clash, 17),
				Cards.Find(Sets.SWSH_Promo, 14)
			),
			new Group // Victini V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Sword_Shield, 25),
				Cards.Find(Sets.SWSH_Promo, 104)
			),
			new Group // Cinderace V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Rebel_Clash, 35),
				Cards.Find(Sets.Shining_Fates, 18),
				Cards.Find(Sets.SWSH_Promo, 15)
			),
			new Group // Inteleon V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Rebel_Clash, 49),
				Cards.Find(Sets.SWSH_Promo, 16)
			),
			new Group // Pikachu V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Vivid_Voltage, 43),
				Cards.Find(Sets.SWSH_Promo, 61)
			),
			new Group // Sylveon V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Evolving_Skies, 74),
				Cards.Find(Sets.SWSH_Promo, 202)
			),
			new Group // Tyranitar V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Battle_Styles, 97),
				Cards.Find(Sets.SWSH_Promo, 109)
			),
			new Group // Zacian V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Sword_Shield, 138),
				Cards.Find(Sets.SWSH_Promo, 18)
			),
			new Group // Zamazenta V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Sword_Shield, 139),
				Cards.Find(Sets.SWSH_Promo, 19)
			),
			new Group // Dragonite V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Pokémon_GO, 49),
				Cards.Find(Sets.SWSH_Promo, 235)
			),
			new Group // Arceus V
			(
				Rarity.V,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Brilliant_Stars, 122),
				Cards.Find(Sets.SWSH_Promo, 306),
				Cards.Find(Sets.SWSH_Promo, 204)
			),
			new Group // Gold Zacian V, Zamazenta V and Eternatus V(MAX)
			(
				Rarity.V_VMAX_Gold,
				Rules.GROUP_CARDS,
				Cards.Find(Sets.Shining_Fates_SV, 121),
				Cards.Find(Sets.Shining_Fates_SV, 122),
				Cards.Find(Sets.SWSH_Promo, 76),
				Cards.Find(Sets.SWSH_Promo, 77)
			),
			new Group // Special Art Pokémon in a forest
			(
				Rarity.Special_Art_Pokemon_SWSH,
				Rules.ENFORCE_LAST,
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 26),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 27),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 28),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 29),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 30),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 31),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 32),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 33),
				Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 34)
			),
			new Group // Black & Gold V / VMAX
			(
				Rarity.V_VMAX_Gold,
				Rules.ENFORCE_LAST,
				Cards.Find(Sets.SWSH_Promo, 76),
				Cards.Find(Sets.SWSH_Promo, 77),
				Cards.Find(Sets.Shining_Fates_SV, 121),
				Cards.Find(Sets.Shining_Fates_SV, 122),
				Cards.Find(Sets.Brilliant_Stars, 215),
				Cards.Find(Sets.Brilliant_Stars, 216),
				Cards.Find(Sets.Astral_Radiance, 245),
				Cards.Find(Sets.Astral_Radiance, 246),
				Cards.Find(Sets.Silver_Tempest, 244),
				Cards.Find(Sets.Silver_Tempest, 245),
				Cards.Find(Sets.Lost_Origin, 246),
				Cards.Find(Sets.Lost_Origin, 247)
			),
		};

		static public Group[] Get()
		{
			return TheGroups;
		}
	}
}