using System.Linq;
using System.Collections.Generic;

namespace TCG
{
	public class SetReverse
	{
		public Sets set;
		public HoloRarity[] reverseRarity;

		public SetReverse(Sets set, params HoloRarity[] reverseRarity)
		{
			this.set = set;
			this.reverseRarity = reverseRarity;
		}
	}

	public static class SetReverses
	{
		private static SetReverse[] TheList =
		{
			new SetReverse(Sets.Legendary_Collection, HoloRarity.LC_REVERSE_FIREWORKS_HOLO, HoloRarity.LC_REVERSE_FIREWORKS_HOLO_DARK),
			new SetReverse(Sets.Expedition, HoloRarity.E_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.Aquapolis, HoloRarity.E_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.Skyridge, HoloRarity.E_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.EX_Ruby_Sapphire, HoloRarity.EX_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.EX_Sandstorm, HoloRarity.EX_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.EX_Dragon, HoloRarity.EX_REVERSE_PLAIN_HOLO),
			new SetReverse(Sets.EX_Team_Magma_vs_Team_Aqua, HoloRarity.EX_REVERSE_PLAIN_HOLO, HoloRarity.EX_REVERSE_PLAIN_HOLO_AQUA, HoloRarity.EX_REVERSE_PLAIN_HOLO_MAGMA),
			new SetReverse(Sets.EX_Hidden_Legends, HoloRarity.EX_BIG_ENERGY_HOLO_HL),
			new SetReverse(Sets.EX_FireRed_LeafGreen, HoloRarity.EX_ENERGY_HOLO_FL),
			new SetReverse(Sets.EX_Team_Rocket_Returns, HoloRarity.EX_ENERGY_HOLO_TRR, HoloRarity.EX_ENERGY_HOLO_TRR_DARK, HoloRarity.EX_ENERGY_HOLO_TRR_ROCKET),
			new SetReverse(Sets.EX_Deoxys, HoloRarity.EX_PRISM_HOLO_D),
			new SetReverse(Sets.EX_Emerald, HoloRarity.EX_2D_POKEBALL_HOLO_E),
			new SetReverse(Sets.EX_Unseen_Forces, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
			new SetReverse(Sets.EX_Delta_Species, HoloRarity.EX_PLAIN_HOLO_DS, HoloRarity.EX_PLAIN_HOLO_DS_DELTA, HoloRarity.EX_PLAIN_HOLO_DS_HOLON),
			new SetReverse(Sets.EX_Legend_Maker, HoloRarity.EX_PIXEL_COSMOS_HOLO_LM),
			new SetReverse(Sets.EX_Holon_Phantoms, HoloRarity.EX_MIRROR_HOLO_HP, HoloRarity.EX_MIRROR_HOLO_HP_DELTA, HoloRarity.EX_MIRROR_HOLO_HP_HOLON),
			new SetReverse(Sets.EX_Crystal_Guardians, HoloRarity.EX_MIRROR_HOLO_CG, HoloRarity.EX_MIRROR_HOLO_CG_DELTA),
			new SetReverse(Sets.EX_Dragon_Frontiers, HoloRarity.EX_MIRROR_HOLO_DF, HoloRarity.EX_MIRROR_HOLO_DF_DELTA),
			new SetReverse(Sets.EX_Power_Keepers, HoloRarity.EX_PLAIN_HOLO_PK),

			new SetReverse(Sets.Diamond_Pearl, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Mysterious_Treasures, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Secret_Wonders, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Great_Encounters, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Majestic_Dawn, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Legends_Awakened, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Stormfront, HoloRarity.DP_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Platinum, HoloRarity.DP_REVERSE_MIRROR_HOLO, HoloRarity.DP_REVERSE_MIRROR_HOLO_SP),
			new SetReverse(Sets.Rising_Rivals, HoloRarity.DP_REVERSE_MIRROR_HOLO, HoloRarity.DP_REVERSE_MIRROR_HOLO_SP),
			new SetReverse(Sets.Supreme_Victors, HoloRarity.DP_REVERSE_MIRROR_HOLO, HoloRarity.DP_REVERSE_MIRROR_HOLO_SP),
			new SetReverse(Sets.Arceus, HoloRarity.DP_REVERSE_MIRROR_HOLO, HoloRarity.DP_REVERSE_MIRROR_HOLO_SP),

			new SetReverse(Sets.HeartGold_SoulSilver, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Unleashed, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Undaunted, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Triumphant, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Call_of_Legends, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),

			new SetReverse(Sets.Black_White, HoloRarity.BWXY_REVERSE_MIRROR_HOLO),
			new SetReverse(Sets.Emerging_Powers, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Noble_Victories, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Next_Destinies, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Dark_Explorers, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Dragons_Exalted, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Boundaries_Crossed, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Plasma_Storm, HoloRarity.BWXY_REVERSE_ENERGY_HOLO, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),
			new SetReverse(Sets.Plasma_Freeze, HoloRarity.BWXY_REVERSE_ENERGY_HOLO, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),
			new SetReverse(Sets.Plasma_Blast, HoloRarity.BWXY_REVERSE_ENERGY_HOLO, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),
			new SetReverse(Sets.Legendary_Treasures, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),

			new SetReverse(Sets.XY, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Flashfire, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Furious_Fists, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Phantom_Forces, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Primal_Clash, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Double_Crisis, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_AQUA, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_MAGMA),
			new SetReverse(Sets.Roaring_Skies, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Ancient_Origins, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.BREAKthrough, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.BREAKpoint, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Generations, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Fates_Collide, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Steam_Siege, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
			new SetReverse(Sets.Evolutions, HoloRarity.EV_REVERSE_MIRROR_HOLO),

			new SetReverse(Sets.Sun_Moon, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Guardians_Rising, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Burning_Shadows, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Shining_Legends, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Crimson_Invasion, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Ultra_Prism, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Forbidden_Light, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Celestial_Storm, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Dragon_Majesty, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Lost_Thunder, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Team_Up, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Unbroken_Bonds, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Unified_Minds, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Hidden_Fates, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
			new SetReverse(Sets.Cosmic_Eclipse, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),

			new SetReverse(Sets.Sword_Shield, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Rebel_Clash, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Darkness_Ablaze, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Champions_Path, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Vivid_Voltage, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Shining_Fates, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Battle_Styles, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Chilling_Reign, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Evolving_Skies, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Fusion_Strike, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Brilliant_Stars, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Astral_Radiance, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Pokémon_GO, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Lost_Origin, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Silver_Tempest, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
			new SetReverse(Sets.Crown_Zenith, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

			new SetReverse(Sets.Scarlet_Violet, HoloRarity.SV_REVERSE_ROCKY_HOLO),
			new SetReverse(Sets.Paldea_Evolved, HoloRarity.SV_REVERSE_ROCKY_HOLO),
			new SetReverse(Sets.Obsidian_Flames, HoloRarity.SV_REVERSE_ROCKY_HOLO),
			new SetReverse(Sets.SV_151, HoloRarity.SV_REVERSE_ROCKY_HOLO),
		};

		public static HoloRarity[] GetRarities(Sets set)
		{
			if (TheList.Where(e => e.set == set).Any())
				return TheList.Where(e => e.set == set).First().reverseRarity;

			return null;
		}

		public static IEnumerable<HoloCard> FilterCards(IEnumerable<HoloCard> cardsFromSet, Sets set, bool returnReverses)
		{
			HoloRarity[] rarities = GetRarities(set);

			if (returnReverses)
			{
				if (rarities == null)
					return null;

				return cardsFromSet.Where(c => rarities.Contains(c.rarity));
			}
			else
			{
				if (rarities == null)
					return cardsFromSet;

				return cardsFromSet.Where(c => !rarities.Contains(c.rarity));
			}
		}
	}
}
