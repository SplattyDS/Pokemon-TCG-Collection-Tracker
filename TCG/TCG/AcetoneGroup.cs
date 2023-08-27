using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class AcetoneGroup
	{
		public string holoName;
		public (CardBase, AcetoneStatus)[] cards;

		public AcetoneGroup(string holoName, params (CardBase, AcetoneStatus)[] cards)
		{
			this.holoName = holoName;
			this.cards = cards;
		}
	}
	
	public enum AcetoneStatus
	{
		NO_PROGRESS,
		CARD_OBTAINED,
		
		ACETONED_UNIQUE,
		ACETONED_DUPLICATE,
		
		WONT_TEST,

		NUM_STATUSES,
	}

	public static class AcetoneGroups
	{
		public static AcetoneGroup[] TheGroups;

		public static IEnumerable<AcetoneGroup> Get()
		{
			return TheGroups;
		}

		public static void Init()
		{
			TheGroups = new AcetoneGroup[]
			{
				new AcetoneGroup("Star Holo",
					(HoloCards.Find(Sets.Jungle, 14, HoloRarity.OS_STAR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Legendary_Collection, 11, HoloRarity.LC_STAR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Legendary_Collection, 4, HoloRarity.LC_STAR_HOLO_DARK), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Pixel Cosmos Holo",
					(HoloCards.Find(Sets.Base_Set_2, 11, HoloRarity.OS_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Team_Rocket, 11, HoloRarity.OS_PIXEL_COSMOS_HOLO_DARK), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Gym_Heroes, 7, HoloRarity.OS_PIXEL_COSMOS_HOLO_OWNER), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Gym_Heroes, 13, HoloRarity.OS_PIXEL_COSMOS_HOLO_ROCKET), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.OS_PIXEL_COSMOS_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Best_of_Game, 1, HoloRarity.OS_REVERSE_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Best_of_Game, 5, HoloRarity.OS_REVERSE_PIXEL_COSMOS_HOLO_ROCKET), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Neo_Genesis, 2, HoloRarity.NEO_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Neo_Destiny, 8, HoloRarity.NEO_PIXEL_COSMOS_HOLO_DARK), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Neo_Destiny, 15, HoloRarity.NEO_PIXEL_COSMOS_HOLO_LIGHT), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Southern_Islands, 5, HoloRarity.NEO_REVERSE_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Skyridge, 11, HoloRarity.E_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Rocket_Returns, 1, HoloRarity.EX_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 5, HoloRarity.EX_PIXEL_COSMOS_HOLO_AQUA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 8, HoloRarity.EX_PIXEL_COSMOS_HOLO_MAGMA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Rocket_Returns, 2, HoloRarity.EX_PIXEL_COSMOS_HOLO_DARK), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.EX_PIXEL_COSMOS_HOLO_VICTORY_MEDAL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.POP_Series_4, 2, HoloRarity.EX_PIXEL_COSMOS_HOLO_DELTA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Legend_Maker, 12, HoloRarity.EX_PIXEL_COSMOS_HOLO_LM), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rising_Rivals, 7, HoloRarity.DP_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Supreme_Victors, 11, HoloRarity.DP_PIXEL_COSMOS_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.DP_PIXEL_COSMOS_HOLO_VICTORY_MEDAL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rumble, 7, HoloRarity.DP_RUMBLE_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rumble, 10, HoloRarity.DP_RUMBLE_PIXEL_COSMOS_HOLO_LOGO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.HGSS_Promo, 3, HoloRarity.HGSS_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.HGSS_PIXEL_COSMOS_HOLO_PW), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.HGSS_PIXEL_COSMOS_HOLO_VICTORY_MEDAL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Emerging_Powers, 56, HoloRarity.BWXY_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.BW_Promo, 79, HoloRarity.BWXY_PIXEL_COSMOS_HOLO_PLASMA), AcetoneStatus.NO_PROGRESS),
					// SWSH_PIXEL_COSMOS_HOLO
					// SWSH_PIXEL_COSMOS_HOLO_ENERGY_STAR
					// SWSH_REVERSE_PIXEL_COSMOS_HOLO
					(HoloCards.Find(Sets.Paldea_Evolved, 107, HoloRarity.SV_PIXEL_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					// SV_PIXEL_COSMOS_HOLO_ENERGY

					(Cards.Find(Sets.Unnumbered_Promo, 1, Rarity.Ancient_Mew), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Team_Rocket, 83, Rarity.Secret_OS), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Neo_Revelation, 66, Rarity.Shining_Neo), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Aquapolis, 149, Rarity.Crystal_Type), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Hidden_Legends, 102, Rarity.Secret_EX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Promo, 1, Rarity.ex), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Deoxys, 108, Rarity.Rockets_ex), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Unseen_Forces, 114, Rarity.Gold_Star), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Unseen_Forces, 118, Rarity.Unown), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Emerald, 104, Rarity.Holo_Energy_EX_Emerald), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Mysterious_Treasures, 124, Rarity.Secret_DP), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Supreme_Victors, 150, Rarity.Secret_DP_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.DP_Promo, 10, Rarity.LV_X), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.DP_Promo, 46, Rarity.LV_X_SP), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.DP_Promo, 53, Rarity.LV_X_Arceus), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.DP_Promo, 50, Rarity.Arceus), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.HeartGold_SoulSilver, 123, Rarity.Secret_HGSS), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Triumphant, 97, Rarity.Prime), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Triumphant, 101, Rarity.LEGEND), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Call_of_Legends, 96, Rarity.Shiny_Legend), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.HGSS_Promo, 21, Rarity.Shiny_Legend_Promo), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Smooth Cosmos Holo",
					(HoloCards.Find(Sets.SWSH_Promo, 137, HoloRarity.NEO_SMOOTH_COSMOS_HOLO_LIGHT), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.SWSH_Promo, 136, HoloRarity.EX_SMOOTH_COSMOS_HOLO_DELTA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.SWSH_Promo, 138, HoloRarity.DP_SMOOTH_COSMOS_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.XY_Promo, 161, HoloRarity.BWXY_SMOOTH_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.XY_Promo, 179, HoloRarity.EV_SMOOTH_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.SM_Promo, 42, HoloRarity.SM_SMOOTH_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Celestial_Storm, 8, HoloRarity.SM_REVERSE_SMOOTH_COSMOS_BIG_ENERGY_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.SWSH_Promo, 29, HoloRarity.SWSH_SMOOTH_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Vivid_Voltage, 130, HoloRarity.SWSH_REVERSE_SMOOTH_COSMOS_ENERGY_BANNER_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Scarlet_Violet, 70, HoloRarity.SV_SMOOTH_COSMOS_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.SWSH_Promo, 135, Rarity.LV_X), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SWSH_Promo, 132, Rarity.Prime), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SM_Promo, 228, Rarity.Full_Art_Pokemon_SM), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Fireworks Holo",
					(HoloCards.Find(Sets.Legendary_Collection, 99, HoloRarity.LC_REVERSE_FIREWORKS_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Legendary_Collection, 38, HoloRarity.LC_REVERSE_FIREWORKS_HOLO_DARK), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (1)",
					(HoloCards.Find(Sets.Expedition, 148, HoloRarity.E_REVERSE_PLAIN_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Ruby_Sapphire, 109, HoloRarity.EX_PLAIN_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Dragon, 72, HoloRarity.EX_REVERSE_PLAIN_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 3, HoloRarity.EX_REVERSE_PLAIN_HOLO_AQUA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 8, HoloRarity.EX_REVERSE_PLAIN_HOLO_MAGMA), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Skyridge, 145.1, Rarity.Crystal_Type), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Vertical Plain Holo", // is this different from mirror?
					(HoloCards.Find(Sets.EX_Holon_Phantoms, 14, HoloRarity.EX_VERTICAL_PLAIN_HOLO_DELTA), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.EX_Dragon_Frontiers, 96, Rarity.Delta_Species_ex), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.EX_Dragon_Frontiers, 101, Rarity.Delta_Species_Gold_Star), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Pixel Wave Holo",
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.EX_PIXEL_WAVE_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Big Energy Holo*", // some said it might come off with acetone
					(HoloCards.Find(Sets.EX_Hidden_Legends, 83, HoloRarity.EX_BIG_ENERGY_HOLO_HL), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Energy Holo*", // some said it might come off with acetone
					(HoloCards.Find(Sets.EX_FireRed_LeafGreen, 13, HoloRarity.EX_ENERGY_HOLO_FL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Rocket_Returns, 63, HoloRarity.EX_ENERGY_HOLO_TRR), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Rocket_Returns, 37, HoloRarity.EX_ENERGY_HOLO_TRR_DARK), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Team_Rocket_Returns, 46, HoloRarity.EX_ENERGY_HOLO_TRR_ROCKET), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Prism Holo*", // some said it might come off with acetone
					(HoloCards.Find(Sets.EX_Deoxys, 82, HoloRarity.EX_PRISM_HOLO_D), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("2D Pokéball Holo*", // some said it might come off with acetone
					(HoloCards.Find(Sets.EX_Emerald, 52, HoloRarity.EX_2D_POKEBALL_HOLO_E), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("3D Pokéball Holo*", // some said it might come off with acetone
					(HoloCards.Find(Sets.EX_Unseen_Forces, 12, HoloRarity.EX_3D_POKEBALL_HOLO_UF), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (2)",
					(HoloCards.Find(Sets.EX_Delta_Species, 63, HoloRarity.EX_PLAIN_HOLO_DS), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Delta_Species, 71, HoloRarity.EX_PLAIN_HOLO_DS_HOLON), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Delta_Species, 14, HoloRarity.EX_PLAIN_HOLO_DS_DELTA), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirror Holo (1)",
					(HoloCards.Find(Sets.EX_Holon_Phantoms, 58, HoloRarity.EX_MIRROR_HOLO_HP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Holon_Phantoms, 44, HoloRarity.EX_MIRROR_HOLO_HP_HOLON), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Holon_Phantoms, 10, HoloRarity.EX_MIRROR_HOLO_HP_DELTA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Crystal_Guardians, 59, HoloRarity.EX_MIRROR_HOLO_CG), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Crystal_Guardians, 68, HoloRarity.EX_MIRROR_HOLO_CG_DELTA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Dragon_Frontiers, 51, HoloRarity.EX_MIRROR_HOLO_DF), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.EX_Dragon_Frontiers, 4, HoloRarity.EX_MIRROR_HOLO_DF_DELTA), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.EX_Holon_Phantoms, 107, Rarity.Holo_Energy_EX_Holon_Phantoms), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (3)",
					(HoloCards.Find(Sets.EX_Power_Keepers, 68, HoloRarity.EX_PLAIN_HOLO_PK), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.EX_Power_Keepers, 108, Rarity.Holo_Energy_EX_Power_Keepers), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Cracked Ice Holo",
					(HoloCards.Find(Sets.Supreme_Victors, 5, HoloRarity.DP_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Supreme_Victors, 8, HoloRarity.DP_CRACKED_ICE_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.POP_Series_8, 13, HoloRarity.DP_REVERSE_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rising_Rivals, 60, HoloRarity.DP_REVERSE_CRACKED_ICE_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.HGSS_Promo, 10, HoloRarity.HGSS_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Noble_Victories, 80, HoloRarity.BWXY_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Plasma_Blast, 13, HoloRarity.BWXY_CRACKED_ICE_HOLO_PLASMA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Evolutions, 35, HoloRarity.EV_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Burning_Shadows, 28, HoloRarity.SM_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Vivid_Voltage, 39, HoloRarity.SWSH_CRACKED_ICE_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.EX_FireRed_LeafGreen, 114, Rarity.ex), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Rising_Rivals, 118, Rarity.Rotom), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirror Holo (2)",
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.DP_MIRROR_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Secret_Wonders, 14, HoloRarity.DP_REVERSE_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Arceus, 12, HoloRarity.DP_REVERSE_MIRROR_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Call_of_Legends, 95, HoloRarity.HGSS_MIRROR_HOLO_ENERGY_COL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Call_of_Legends, 50, HoloRarity.HGSS_REVERSE_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Generations, 32, HoloRarity.BWXY_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.BWXY_MIRROR_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Generations, 83, HoloRarity.BWXY_MIRROR_HOLO_ENERGY_GENERATIONS), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Black_White, 45, HoloRarity.BWXY_REVERSE_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Plasma_Freeze, 20, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Double_Crisis, 27, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_AQUA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Double_Crisis, 22, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_MAGMA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Dark_Explorers, 14, HoloRarity.BWXY_REVERSE_ENERGY_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Evolutions, 53, HoloRarity.EV_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Evolutions, 96, HoloRarity.EV_MIRROR_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Evolutions, 63, HoloRarity.EV_REVERSE_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Sun_Moon, 52, HoloRarity.SM_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Supreme_Victors, 153, Rarity.Shiny_Holo), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.HeartGold_SoulSilver, 123.1, Rarity.Secret_HGSS), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Crosshatch Holo",
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.DP_CROSSHATCH_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Legends_Awakened, 43, HoloRarity.DP_REVERSE_CROSSHATCH_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Supreme_Victors, 27, HoloRarity.DP_REVERSE_CROSSHATCH_HOLO_SP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.HGSS_CROSSHATCH_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Call_of_Legends, 89, HoloRarity.HGSS_CROSSHATCH_HOLO_ENERGY_COL), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unleashed, 14, HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Black_White, 109, HoloRarity.BWXY_CROSSHATCH_HOLO_ENERGY_BW), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.BWXY_CROSSHATCH_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Furious_Fists, 12, HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Plasma_Storm, 123, HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (4)",
					(HoloCards.Find(Sets.Legends_Awakened, 106, HoloRarity.DP_REVERSE_PLAIN_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Tinsel Holo",
					(HoloCards.Find(Sets.Noble_Victories, 15, HoloRarity.BWXY_TINSEL_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Plasma_Storm, 55, HoloRarity.BWXY_TINSEL_HOLO_PLASMA), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Dragon_Vault, 21, Rarity.Secret_BWXY), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Boundaries_Crossed, 138, Rarity.Ace_Spec), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Blast, 92, Rarity.Ace_Spec_Plasma), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Sheen Holo (1)",
					(HoloCards.Find(Sets.Primal_Clash, 12, HoloRarity.BWXY_SHEEN_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Phantom_Forces, 98, HoloRarity.BWXY_SHEEN_HOLO_FLARE), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Double_Crisis, 21, HoloRarity.BWXY_SHEEN_HOLO_AQUA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Double_Crisis, 2, HoloRarity.BWXY_SHEEN_HOLO_MAGMA), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.BWXY_SHEEN_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Evolutions, 11, HoloRarity.EV_SHEEN_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Boundaries_Crossed, 101.1, Rarity.EX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Storm, 14.1, Rarity.EX_Plasma), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Flashfire, 69.1, Rarity.M_EX), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Confetti Holo",
					(HoloCards.Find(Sets.Mc_Donalds_2011, 5, HoloRarity.BWXY_CONFETTI_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Mc_Donalds_2017, 4, HoloRarity.SM_CONFETTI_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Mc_Donalds_2022, 5, HoloRarity.SWSH_CONFETTI_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Mc_Donalds_2023, 6, HoloRarity.SV_CONFETTI_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Celebrations, 33, Rarity.Classic_Collection), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Star Holo (Evolutions)",
					(HoloCards.Find(Sets.Evolutions, 38, HoloRarity.EV_STAR_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Water Web Holo",
					(HoloCards.Find(Sets.Unified_Minds, 26, HoloRarity.SM_WATER_WEB_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SM_WATER_WEB_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Sun_Moon, 12, Rarity.GX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crimson_Invasion, 49, Rarity.UB_GX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Cosmic_Eclipse, 156, Rarity.TT_GX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Cosmic_Eclipse, 158, Rarity.TT_UB_GX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Lost_Thunder, 19, Rarity.Prism_Star), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Sheen Holo (2)",
					(HoloCards.Find(Sets.Alolan_Raichu_Half_Deck, 30, HoloRarity.SM_SHEEN_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Sheen Holo (3)",
					(HoloCards.Find(Sets.SM_Promo, 170, HoloRarity.SM_SHEEN_HOLO_DP), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SM_SHEEN_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SM_SHEEN_HOLO_ENERGY_TT), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Guardians_Rising, 68, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Sun_Moon, 135, HoloRarity.SM_REVERSE_SHEEN_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Sequin Holo (1)",
					(HoloCards.Find(Sets.Shining_Legends, 1, HoloRarity.SM_SEQUIN_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Line Holo",
					(HoloCards.Find(Sets.Chilling_Reign, 114, HoloRarity.SWSH_LINE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SWSH_LINE_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SWSH_LINE_HOLO_ENERGY_STAR), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rebel_Clash, 171, HoloRarity.SWSH_REVERSE_LINE_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Scarlet_Violet, 41, HoloRarity.SV_LINE_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Silver_Tempest, 156, Rarity.Seal_Stone), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (5)",
					(HoloCards.Find(Sets.Celebrations, 14, HoloRarity.SWSH_PLAIN_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SWSH_PLAIN_HOLO_ENERGY), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Unnumbered_Promo, -1, HoloRarity.SWSH_PLAIN_HOLO_ENERGY_STAR), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Rebel_Clash, 6, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Brilliant_Stars, 150, HoloRarity.SWSH_REVERSE_PLAIN_HOLO), AcetoneStatus.NO_PROGRESS),
					
					(Cards.Find(Sets.Celebrations, 5, Rarity.Full_Art_Pokemon_SWSH), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirror Holo (3)",
					(HoloCards.Find(Sets.SWSH_Promo, 220, HoloRarity.SWSH_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Sequin Holo (2)",
					(HoloCards.Find(Sets.SWSH_Promo, 39, HoloRarity.SWSH_SEQUIN_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirror Holo (4)",
					(HoloCards.Find(Sets.Rebel_Clash, 167, HoloRarity.SWSH_REVERSE_MIRROR_ENERGY_BANNER_HOLO), AcetoneStatus.NO_PROGRESS),
					(HoloCards.Find(Sets.Fusion_Strike, 237, HoloRarity.SWSH_REVERSE_MIRROR_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirage Holo (1)",
					(HoloCards.Find(Sets.Scarlet_Violet, 13, HoloRarity.SV_MIRAGE_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Plain Holo (6)",
					(HoloCards.Find(Sets.Scarlet_Violet, 80, HoloRarity.SV_REVERSE_ROCKY_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Mirage Holo (2)",
					(HoloCards.Find(Sets.Obsidian_Flames, 86, HoloRarity.SV_REVERSE_MIRAGE_ROCKY_HOLO), AcetoneStatus.NO_PROGRESS)
				),
				
				
				
				new AcetoneGroup("Unknown Holo (BW Gold)",
					(Cards.Find(Sets.Legendary_Treasures, 114, Rarity.Gold_Pokemon), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (XY Silver)",
					(Cards.Find(Sets.Phantom_Forces, 122, Rarity.Gold_Pokemon), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (SWSH Gold)",
					(Cards.Find(Sets.SWSH_Promo, 145, Rarity.Gold_Pokemon), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Shining Neo)",
					(Cards.Find(Sets.Neo_Destiny, 113, Rarity.Shining_Neo), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Mirror Holo (BWXY)",
					(Cards.Find(Sets.Black_White, 115, Rarity.Secret_BWXY), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Dark_Explorers, 110, Rarity.Secret_BWXY_Shiny), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Freeze, 117, Rarity.Secret_BWXY_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Fates_Collide, 72, Rarity.EX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Blast, 11, Rarity.EX_Plasma), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolutions, 26, Rarity.EX_Evolutions), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Flashfire, 69, Rarity.M_EX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Primal_Clash, 55, Rarity.M_EX_Primal), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolutions, 65, Rarity.M_EX_Evolutions), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Blast, 101, Rarity.Full_Art_Trainer_BW_XY), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Freeze, 115, Rarity.Full_Art_Trainer_BW_XY_Plasma), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolutions, 107, Rarity.Full_Art_Trainer_Evolutions), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Noble_Victories, 100, Rarity.Full_Art_Pokemon_BWXY_Textured), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.BW_Promo, 74, Rarity.Full_Art_Pokemon_BWXY_Plasma), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.XY_Promo, 78, Rarity.Full_Art_Pokemon_BWXY_Legendary), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.XY_Promo, 113, Rarity.Full_Art_Pokemon_BWXY_Mythical), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.XY_Yellow_A_Promo, 10, Rarity.EX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolutions, 106, Rarity.EX_Full_Art_Evolutions), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Plasma_Storm, 132, Rarity.EX_Full_Art_Plasma), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Double_Crisis, 6, Rarity.EX_Full_Art_Special), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.XY_Promo, 124, Rarity.EX_Full_Art_Special), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.XY_Yellow_A_Promo, 2, Rarity.M_EX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Primal_Clash, 151, Rarity.M_EX_Full_Art_Primal), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolutions, 101, Rarity.M_EX_Full_Art_Evolutions), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Steam_Siege, 116, Rarity.EX_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Ancient_Origins, 98, Rarity.M_EX_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Phantom_Forces, 121, Rarity.Secret_M_EX), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Confetti Holo (Radiant BW)",
					(Cards.Find(Sets.Legendary_Treasures_RC, 11, Rarity.EX_Radiant), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Legendary_Treasures_RC, 10, Rarity.Radiant_Collection_BW), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Legendary_Treasures_RC, 23, Rarity.Full_Art_Pokemon_BWXY_Radiant), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Legendary_Treasures_RC, 25, Rarity.EX_Full_Art_Radiant_BW), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Star Holo (Radiant BW)*", // some said it might come off with acetone
					(Cards.Find(Sets.Legendary_Treasures_RC, 20, Rarity.Radiant_Collection_BW), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo (Radiant XY)",
					(Cards.Find(Sets.Generations_RC, 21, Rarity.EX_Radiant), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Generations_RC, 13, Rarity.Radiant_Collection_XY), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Generations_RC, 29, Rarity.Full_Art_Pokemon_BWXY_Radiant), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Generations_RC, 28, Rarity.EX_Full_Art_Radiant_XY), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Generations_RC, 31, Rarity.M_EX_Full_Art_Radiant), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (BREAK)",
					(Cards.Find(Sets.Evolutions, 32, Rarity.BREAK), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Shining SM)",
					(Cards.Find(Sets.SM_Promo, 70, Rarity.Shining_SM), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo (SM, Confirmed: Factory Video)",
					(Cards.Find(Sets.Ultra_Prism, 151, Rarity.Full_Art_Trainer_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sun_Moon, 161, Rarity.Gold_Item_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Unified_Minds, 256, Rarity.Gold_Stadium_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sun_Moon, 162, Rarity.Gold_Energy_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Guardians_Rising, 166, Rarity.Gold_Special_Energy_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sun_Moon, 153, Rarity.GX_Rainbow), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crimson_Invasion, 115, Rarity.UB_GX_Rainbow), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Team_Up, 184, Rarity.TT_GX_Rainbow), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Unbroken_Bonds, 215, Rarity.TT_UB_GX_Rainbow), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Probably belong to above ^",
					(Cards.Find(Sets.Hidden_Fates_SV, 11, Rarity.Shiny_Vault_SM), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Hidden_Fates_SV, 49, Rarity.GX_Shiny_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Hidden_Fates_SV, 63, Rarity.UB_GX_Shiny_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Dragon_Majesty, 78, Rarity.GX_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SM_Promo, 247, Rarity.TT_GX_Gold), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Sheen Holo (SM)",
					(Cards.Find(Sets.Guardians_Rising, 138, Rarity.GX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crimson_Invasion, 105, Rarity.UB_GX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Team_Up, 160, Rarity.TT_GX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Unbroken_Bonds, 191, Rarity.TT_UB_GX_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Cosmic_Eclipse, 211, Rarity.GX_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Cosmic_Eclipse, 216, Rarity.TT_GX_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Cosmic_Eclipse, 224, Rarity.TT_UB_GX_Special_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Special Mewtwo GX)",
					(Cards.Find(Sets.Shining_Legends, 78, Rarity.GX_Special_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo (Character Art SM)",
					(Cards.Find(Sets.Cosmic_Eclipse, 237, Rarity.Character_Art_SM), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Sheen Holo (SWSH)",
					(Cards.Find(Sets.SWSH_Promo, 134, Rarity.V), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolving_Skies, 14, Rarity.VMAX), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Chilling_Reign, 75, Rarity.VMAX_Blue), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sword_Shield, 142, Rarity.VMAX_Gigantamax), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Darkness_Ablaze, 117, Rarity.VMAX_Eternamax), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Brilliant_Stars, 123, Rarity.VSTAR), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SWSH_Promo, 155, Rarity.V_Union), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Shining_Fates_SV, 104, Rarity.Shiny_Vault_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Brilliant_Stars, 212, Rarity.Full_Art_Trainer_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crown_Zenith, 157, Rarity.Full_Art_Energy_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SWSH_Promo, 255, Rarity.V_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Shining_Fates_SV, 118, Rarity.V_Shiny_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 63, Rarity.Special_Art_Trainer_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Astral_Radiance, 177, Rarity.V_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 55, Rarity.VSTAR_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Astral_Radiance, 229, Rarity.V_Character_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Lost_Origin, 234, Rarity.VMAX_Character_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SWSH_Promo, 289, Rarity.V_UNION_Character_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Amazing Rare)",
					(Cards.Find(Sets.Vivid_Voltage, 50, Rarity.Amazing_Rare), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Radiant)",
					(Cards.Find(Sets.Astral_Radiance, 46, Rarity.Radiant), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo 1 (SWSH)",
					(Cards.Find(Sets.Crown_Zenith, 160, Rarity.Full_Art_Pokemon_SWSH), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo 2 (SWSH)",
					(Cards.Find(Sets.SWSH_Promo, 20, Rarity.Full_Art_Pokemon_SWSH), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (VMAX Shiny & VMAX Special Art)",
					(Cards.Find(Sets.Shining_Fates_SV, 109, Rarity.VMAX_Shiny_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SWSH_Promo, 182, Rarity.VMAX_Special_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Gold SWSH)<br>Probably belong to above ^",
					(Cards.Find(Sets.Sword_Shield, 216, Rarity.Gold_Item_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Fusion_Strike, 282, Rarity.Gold_Stadium_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Chilling_Reign, 231, Rarity.Gold_Energy_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Battle_Styles, 182, Rarity.Gold_Special_Energy_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Evolving_Skies, 228, Rarity.Gold_Shiny), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sword_Shield, 211, Rarity.V_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Astral_Radiance, 209, Rarity.VSTAR_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Shining_Fates_SV, 122, Rarity.V_VMAX_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 70, Rarity.VSTAR_Gold_Special_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (Rainbow SWSH)<br>Probably belong to above ^",
					(Cards.Find(Sets.Vivid_Voltage, 195, Rarity.Rainbow_Trainer), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Sword_Shield, 205, Rarity.VMAX_Rainbow), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Chilling_Reign, 202, Rarity.VMAX_Rainbow_Blue), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Shining_Fates, 73, Rarity.VMAX_Rainbow_Gigantamax), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Darkness_Ablaze, 192, Rarity.VMAX_Rainbow_Eternamax), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Brilliant_Stars, 174, Rarity.VSTAR_Rainbow), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo 3 (SWSH)",
					(Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 13, Rarity.Special_Art_Pokemon_SWSH), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Crown_Zenith_Galarian_Gallery, 30, Rarity.Special_Art_Pokemon_SWSH_Forest), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Plain Holo 4 (SWSH)",
					(Cards.Find(Sets.Lost_Origin, 222, Rarity.Character_Art_SWSH), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Sheen Holo 1 (SV)**", // stars may come off with acetone
					(Cards.Find(Sets.Scarlet_Violet, 81, Rarity.ex_SV), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (SV Tera ex)",
					(Cards.Find(Sets.Scarlet_Violet, 32, Rarity.ex_SV_Tera), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Sheen Holo 2 (SV)",
					(Cards.Find(Sets.Scarlet_Violet, 238, Rarity.Full_Art_Trainer_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.SV_Promo, 27, Rarity.Full_Art_Pokemon_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Scarlet_Violet, 228, Rarity.ex_SV_Full_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Paldea_Evolved, 203, Rarity.Special_Art_Pokemon_SV), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (SV Tera ex Full Art)",
					(Cards.Find(Sets.Obsidian_Flames, 211, Rarity.ex_SV_Tera_Full_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (SV Special Illustration Rare)",
					(Cards.Find(Sets.Paldea_Evolved, 269, Rarity.Special_Art_Trainer_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Scarlet_Violet, 245, Rarity.ex_SV_Special_Art), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Obsidian_Flames, 223, Rarity.ex_SV_Tera_Special_Art), AcetoneStatus.NO_PROGRESS)
				),
				new AcetoneGroup("Unknown Holo (SV Gold)",
					(Cards.Find(Sets.Scarlet_Violet, 255, Rarity.Gold_Item_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Obsidian_Flames, 229, Rarity.Gold_Stadium_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Scarlet_Violet, 257, Rarity.Gold_Energy_SV), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Scarlet_Violet, 253, Rarity.ex_SV_Gold), AcetoneStatus.NO_PROGRESS),
					(Cards.Find(Sets.Obsidian_Flames, 228, Rarity.ex_SV_Tera_Gold), AcetoneStatus.NO_PROGRESS)
				),
			};
		}
		
		/*
		Deliberately not included:
		Metal
		Stamped
		Alph_Lithograph
		Secret_Evolutions
		Ancient_Trait_Alpha
		Ancient_Trait_Omega
		Ancient_Trait_Delta
		Ancient_Trait_Theta
		Mirrored_Stadium
		Seal_Stone_Non_Holo
		any Japanese cards
			Full_Art_Costume_Pikachu
			Secret_e_Series
			Lucario_ex
			Full_Art_Pokemon_BWXY_Other
			Full_Art_Pokemon_SM_Screaming
			Full_Art_Pokemon_SWSH_Stamp_Box
		*/
	}
}
