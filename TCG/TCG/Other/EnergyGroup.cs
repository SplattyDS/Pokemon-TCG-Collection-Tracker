using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class EnergyGroup
	{
		public string energyName;
		public CardBase[] cards;

		public EnergyGroup(string energyName, params CardBase[] cards)
		{
			this.energyName = energyName;
			this.cards = cards;
		}
	}


	public static class EnergyGroups
	{
		public static EnergyGroup[] TheGroups;

		public static IEnumerable<EnergyGroup> Get()
		{
			return TheGroups;
		}

		// hax
		public static CardBase[] CombineArrays(CardBase[] arr1, CardBase[] arr2)
		{
			List<CardBase> list = new List<CardBase>(arr1);
			list.AddRange(arr2);
			return list.ToArray();
		}

		public static CardBase[] CombineArrays(CardBase[] arr1, CardBase[] arr2, CardBase[] arr3)
		{
			List<CardBase> list = new List<CardBase>(arr1);
			list.AddRange(arr2);
			list.AddRange(arr3);
			return list.ToArray();
		}

		public static void Init()
		{
			TheGroups = new EnergyGroup[]
			{
				new EnergyGroup("Grass Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Grass_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Grass_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Vivid_Voltage, 162, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Fire Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Fire_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Fire_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Darkness_Ablaze, 174, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Water Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Water_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Water_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Vivid_Voltage, 165, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
						HoloCards.Find(Sets.Double_Crisis, 33, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_AQUA)
					})
				),
				new EnergyGroup("Lightning Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Lightning_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Lightning_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Rebel_Clash, 173, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Psychic Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Psychic_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Psychic_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Rebel_Clash, 172, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Fighting Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Fighting_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Fighting_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Vivid_Voltage, 164, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
						HoloCards.Find(Sets.Double_Crisis, 34, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_MAGMA)
					})
				),
				new EnergyGroup("Darkness Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Darkness_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Darkness_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Expedition, 158, HoloRarity.E_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.Aquapolis, 142, HoloRarity.E_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.EX_Ruby_Sapphire, 93, HoloRarity.EX_PIXEL_COSMOS_HOLO),
						HoloCards.Find(Sets.EX_Ruby_Sapphire, 93, HoloRarity.EX_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.EX_Emerald, 86, HoloRarity.EX_2D_POKEBALL_HOLO_E),
						HoloCards.Find(Sets.EX_Unseen_Forces, 96, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
						HoloCards.Find(Sets.EX_Delta_Species, 103, HoloRarity.EX_PLAIN_HOLO_DS),
						HoloCards.Find(Sets.EX_Holon_Phantoms, 94, HoloRarity.EX_MIRROR_HOLO_HP),
						HoloCards.Find(Sets.EX_Power_Keepers, 87, HoloRarity.EX_PLAIN_HOLO_PK),
						HoloCards.Find(Sets.Mysterious_Treasures, 119, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Secret_Wonders, 129, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Majestic_Dawn, 93, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Rising_Rivals, 99, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Undaunted, 79, HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO),
						HoloCards.Find(Sets.Undaunted, 79, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Call_of_Legends, 86, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.EX_Team_Rocket_Returns, 95, HoloRarity.EX_ENERGY_HOLO_TRR),
						HoloCards.Find(Sets.Darkness_Ablaze, 175, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Metal Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Metal_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Metal_Energy).ToArray(),
					new CardBase[] {
						HoloCards.Find(Sets.Neo_Genesis, 19, HoloRarity.NEO_PIXEL_COSMOS_HOLO),
						HoloCards.Find(Sets.Expedition, 159, HoloRarity.E_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.Aquapolis, 143, HoloRarity.E_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.EX_Ruby_Sapphire, 94, HoloRarity.EX_PIXEL_COSMOS_HOLO),
						HoloCards.Find(Sets.EX_Ruby_Sapphire, 94, HoloRarity.EX_REVERSE_PLAIN_HOLO),
						HoloCards.Find(Sets.EX_Emerald, 88, HoloRarity.EX_2D_POKEBALL_HOLO_E),
						HoloCards.Find(Sets.EX_Unseen_Forces, 97, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
						HoloCards.Find(Sets.EX_Delta_Species, 107, HoloRarity.EX_PLAIN_HOLO_DS),
						HoloCards.Find(Sets.EX_Holon_Phantoms, 95, HoloRarity.EX_MIRROR_HOLO_HP),
						HoloCards.Find(Sets.EX_Power_Keepers, 88, HoloRarity.EX_PLAIN_HOLO_PK),
						HoloCards.Find(Sets.Mysterious_Treasures, 120, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Secret_Wonders, 130, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Majestic_Dawn, 95, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Rising_Rivals, 100, HoloRarity.DP_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Undaunted, 80, HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO),
						HoloCards.Find(Sets.Undaunted, 80, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Call_of_Legends, 87, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
						HoloCards.Find(Sets.Vivid_Voltage, 163, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO)
					})
				),
				new EnergyGroup("Fairy Energy",
					CombineArrays(HoloCards.Get().Where(c => c.type == Types.Basic_Fairy_Energy).ToArray(),
					Cards.Get().Where(c => c.type == Types.Basic_Fairy_Energy).ToArray(),
					new CardBase[] {

					})
				),
				new EnergyGroup("Colorless Energy",
					// Recycle Energy
					HoloCards.FindUnnumbered("Recycle Energy", HoloRarity.NEO_PIXEL_COSMOS_HOLO),
					HoloCards.Find(Sets.Unified_Minds, 212, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Unified_Minds, 257, Rarity.Gold_Special_Energy_SM),

					// Full Heal Energy
					HoloCards.Find(Sets.Legendary_Collection, 100, HoloRarity.LC_REVERSE_FIREWORKS_HOLO),

					// Potion Energy
					HoloCards.Find(Sets.Legendary_Collection, 101, HoloRarity.LC_REVERSE_FIREWORKS_HOLO),

					// Boost Energy
					HoloCards.Find(Sets.Aquapolis, 145, HoloRarity.E_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Deoxys, 93, HoloRarity.EX_PRISM_HOLO_D),
					HoloCards.Find(Sets.EX_Unseen_Forces, 98, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 87, HoloRarity.EX_MIRROR_HOLO_DF),

					// Crystal Energy
					HoloCards.Find(Sets.Aquapolis, 146, HoloRarity.E_REVERSE_PLAIN_HOLO),

					// Warp Energy
					HoloCards.Find(Sets.Aquapolis, 147, HoloRarity.E_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Unseen_Forces, 100, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
					HoloCards.Find(Sets.EX_Power_Keepers, 91, HoloRarity.EX_PLAIN_HOLO_PK),
					HoloCards.Find(Sets.Stormfront, 95, HoloRarity.DP_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.Shining_Legends, 70, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Crimson_Invasion, 123, Rarity.Gold_Special_Energy_SM),

					// Bounce Energy
					HoloCards.Find(Sets.Skyridge, 142, HoloRarity.E_REVERSE_PLAIN_HOLO),

					// Cyclone Energy
					HoloCards.Find(Sets.Skyridge, 143, HoloRarity.E_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Unseen_Forces, 99, HoloRarity.EX_3D_POKEBALL_HOLO_UF),
					HoloCards.Find(Sets.EX_Power_Keepers, 90, HoloRarity.EX_PLAIN_HOLO_PK),
					HoloCards.Find(Sets.Stormfront, 94, HoloRarity.DP_REVERSE_MIRROR_HOLO),

					// Retro Energy
					HoloCards.Find(Sets.Skyridge, 144, HoloRarity.E_REVERSE_PLAIN_HOLO),

					// Multi Energy
					HoloCards.Find(Sets.EX_Sandstorm, 93, HoloRarity.EX_PIXEL_COSMOS_HOLO),
					HoloCards.Find(Sets.EX_Sandstorm, 93, HoloRarity.EX_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_FireRed_LeafGreen, 103, HoloRarity.EX_ENERGY_HOLO_FL),
					HoloCards.Find(Sets.EX_Emerald, 89, HoloRarity.EX_2D_POKEBALL_HOLO_E),
					HoloCards.Find(Sets.EX_Holon_Phantoms, 96, HoloRarity.EX_MIRROR_HOLO_HP),
					HoloCards.Find(Sets.EX_Power_Keepers, 89, HoloRarity.EX_PLAIN_HOLO_PK),
					HoloCards.Find(Sets.Mysterious_Treasures, 118, HoloRarity.DP_REVERSE_MIRROR_HOLO),

					// Heal Energy
					HoloCards.Find(Sets.EX_Deoxys, 94, HoloRarity.EX_PRISM_HOLO_D),

					// Scramble Energy
					HoloCards.Find(Sets.EX_Deoxys, 95, HoloRarity.EX_PRISM_HOLO_D),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 89, HoloRarity.EX_MIRROR_HOLO_DF),

					// Holon Energy FF
					HoloCards.Find(Sets.EX_Delta_Species, 104, HoloRarity.EX_PLAIN_HOLO_DS),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 84, HoloRarity.EX_MIRROR_HOLO_DF),

					// Holon Energy GL
					HoloCards.Find(Sets.EX_Delta_Species, 105, HoloRarity.EX_PLAIN_HOLO_DS),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 85, HoloRarity.EX_MIRROR_HOLO_DF),

					// Holon Energy WP
					HoloCards.Find(Sets.EX_Delta_Species, 106, HoloRarity.EX_PLAIN_HOLO_DS),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 86, HoloRarity.EX_MIRROR_HOLO_DF),

					// React Energy
					HoloCards.Find(Sets.EX_Legend_Maker, 82, HoloRarity.EX_PIXEL_COSMOS_HOLO_LM),

					// δ Rainbow Energy
					HoloCards.Find(Sets.EX_Holon_Phantoms, 98, HoloRarity.EX_MIRROR_HOLO_HP),
					HoloCards.Find(Sets.EX_Dragon_Frontiers, 88, HoloRarity.EX_MIRROR_HOLO_DF),

					// Call Energy
					HoloCards.Find(Sets.Majestic_Dawn, 92, HoloRarity.DP_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.Majestic_Dawn, 92, HoloRarity.DP_REVERSE_CROSSHATCH_HOLO),

					// Health Energy
					HoloCards.Find(Sets.Majestic_Dawn, 94, HoloRarity.DP_REVERSE_MIRROR_HOLO),

					// Recover Energy
					HoloCards.Find(Sets.Majestic_Dawn, 96, HoloRarity.DP_REVERSE_MIRROR_HOLO),

					// SP Energy
					HoloCards.Find(Sets.Rising_Rivals, 101, HoloRarity.DP_REVERSE_MIRROR_HOLO),

					// Upper Energy
					HoloCards.Find(Sets.Rising_Rivals, 102, HoloRarity.DP_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.Rising_Rivals, 102, HoloRarity.DP_REVERSE_CROSSHATCH_HOLO),

					// Double Colorless Energy
					HoloCards.Find(Sets.HeartGold_SoulSilver, 103, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.HeartGold_SoulSilver, 103, HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO),
					HoloCards.Find(Sets.Next_Destinies, 92, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Legendary_Treasures, 113, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.XY, 130, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Phantom_Forces, 111, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Generations, 74, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Fates_Collide, 114, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Evolutions, 90, HoloRarity.EV_MIRROR_HOLO_ENERGY),
					HoloCards.Find(Sets.Sun_Moon, 136, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Guardians_Rising, 166, Rarity.Gold_Special_Energy_SM),
					HoloCards.Find(Sets.Shining_Legends, 69, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					HoloCards.Find(Sets.Classic_Blastoise, 32, HoloRarity.OS_CLASSIC_STARS_HOLO),
					HoloCards.Find(Sets.Classic_Venusaur, 32, HoloRarity.OS_CLASSIC_STARS_HOLO),
					HoloCards.Find(Sets.Classic_Charizard, 32, HoloRarity.OS_CLASSIC_STARS_HOLO),

					// Rainbow Energy
					HoloCards.Find(Sets.HeartGold_SoulSilver, 104, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.HeartGold_SoulSilver, 104, HoloRarity.HGSS_REVERSE_CROSSHATCH_HOLO),
					HoloCards.Find(Sets.XY, 131, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.BREAKthrough, 152, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Sun_Moon, 137, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					HoloCards.Find(Sets.Celestial_Storm, 151, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Celestial_Storm, 183, Rarity.Gold_Special_Energy_SM),

					// Rescue Energy
					HoloCards.Find(Sets.Triumphant, 90, HoloRarity.HGSS_REVERSE_MIRROR_HOLO),

					// Prism Energy
					HoloCards.Find(Sets.Next_Destinies, 93, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),

					// Blend Energy GFPD
					HoloCards.Find(Sets.Dragons_Exalted, 117, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Dragons_Exalted, 117, HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO),

					// Blend Energy WLFM
					HoloCards.Find(Sets.Dragons_Exalted, 118, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Dragons_Exalted, 118, HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO),

					// Plasma Energy
					HoloCards.Find(Sets.Plasma_Storm, 127, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),
					HoloCards.Find(Sets.Plasma_Freeze, 106, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),
					HoloCards.Find(Sets.Plasma_Freeze, 106, HoloRarity.BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA),
					HoloCards.Find(Sets.Plasma_Blast, 91, HoloRarity.BWXY_REVERSE_MIRROR_HOLO_PLASMA),

					// Counter Energy
					HoloCards.Find(Sets.Crimson_Invasion, 100, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Crimson_Invasion, 122, Rarity.Gold_Special_Energy_SM),

					// Super Boost Energy
					Cards.Find(Sets.Ultra_Prism, 136, Rarity.Prism_Star),

					// Unit Energy GFW
					HoloCards.Find(Sets.Ultra_Prism, 137, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Ultra_Prism, 170, Rarity.Gold_Special_Energy_SM),

					// Unit Energy LPM
					HoloCards.Find(Sets.Ultra_Prism, 138, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Ultra_Prism, 171, Rarity.Gold_Special_Energy_SM),

					// Beast Energy
					Cards.Find(Sets.Forbidden_Light, 117, Rarity.Prism_Star),

					// Unit Energy FDF
					HoloCards.Find(Sets.Forbidden_Light, 118, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Forbidden_Light, 146, Rarity.Gold_Special_Energy_SM),

					// Memory Energy
					HoloCards.Find(Sets.Lost_Thunder, 194, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),

					// Triple Acceleration Energy
					HoloCards.Find(Sets.Unbroken_Bonds, 190, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Unbroken_Bonds, 234, Rarity.Gold_Special_Energy_SM),

					// Weakness Guard Energy
					HoloCards.Find(Sets.Unified_Minds, 213, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Unified_Minds, 258, Rarity.Gold_Special_Energy_SM),
					
					// Draw Energy
					HoloCards.Find(Sets.Cosmic_Eclipse, 209, HoloRarity.SM_REVERSE_BIG_ENERGY_HOLO),
					Cards.Find(Sets.Cosmic_Eclipse, 271, Rarity.Gold_Special_Energy_SM),

					// Capture Energy
					HoloCards.Find(Sets.Rebel_Clash, 171, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Rebel_Clash, 171, HoloRarity.SWSH_REVERSE_LINE_HOLO),
					Cards.Find(Sets.Darkness_Ablaze, 201, Rarity.Gold_Special_Energy_SWSH),

					// Twin Energy
					HoloCards.Find(Sets.Rebel_Clash, 174, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Rebel_Clash, 174, HoloRarity.SWSH_REVERSE_LINE_HOLO),
					Cards.Find(Sets.Rebel_Clash, 209, Rarity.Gold_Special_Energy_SWSH),

					// Powerful Colorless Energy
					HoloCards.Find(Sets.Darkness_Ablaze, 176, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Lucky Energy
					HoloCards.Find(Sets.Chilling_Reign, 158, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Treasure Energy
					HoloCards.Find(Sets.Evolving_Skies, 165, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Double Turbo Energy
					HoloCards.Find(Sets.Brilliant_Stars, 151, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Brilliant_Stars, 151, HoloRarity.SWSH_REVERSE_LINE_HOLO),
					HoloCards.Find(Sets.Brilliant_Stars, 151, HoloRarity.SWSH_REVERSE_PIXEL_COSMOS_HOLO),
					Cards.Find(Sets.Astral_Radiance, 216, Rarity.Gold_Special_Energy_SWSH),

					// Gift Energy
					HoloCards.Find(Sets.Lost_Origin, 171, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Regenerative Energy
					HoloCards.Find(Sets.Silver_Tempest, 168, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// V Guard Energy
					HoloCards.Find(Sets.Silver_Tempest, 169, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					Cards.Find(Sets.Silver_Tempest, 215, Rarity.Gold_Special_Energy_SWSH),

					// Jet Energy
					HoloCards.Find(Sets.Paldea_Evolved, 190, HoloRarity.SV_REVERSE_ROCKY_HOLO),
					HoloCards.Find(Sets.Paldea_Evolved, 190, HoloRarity.SV_REVERSE_PIXEL_COSMOS_HOLO),

					// Therapeutic Energy
					HoloCards.Find(Sets.Paldea_Evolved, 193, HoloRarity.SV_REVERSE_ROCKY_HOLO),

					// Medical Energy
					HoloCards.Find(Sets.Paradox_Rift, 182, HoloRarity.SV_REVERSE_ROCKY_HOLO)
				),
				new EnergyGroup("Rainbow Energy",
					HoloCards.Find(Sets.Team_Rocket, 17, HoloRarity.OS_PIXEL_COSMOS_HOLO),
					HoloCards.FindUnnumbered("Rainbow Energy", HoloRarity.OS_PIXEL_COSMOS_HOLO),
					HoloCards.Find(Sets.Aquapolis, 144, HoloRarity.E_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Ruby_Sapphire, 95, HoloRarity.EX_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Legend_Maker, 81, HoloRarity.EX_PIXEL_COSMOS_HOLO_LM),
					HoloCards.Find(Sets.Platinum, 121, HoloRarity.DP_REVERSE_MIRROR_HOLO),
					HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 88, HoloRarity.EX_REVERSE_PLAIN_HOLO),
					HoloCards.Find(Sets.EX_Emerald, 87, HoloRarity.EX_2D_POKEBALL_HOLO_E),
					HoloCards.Find(Sets.EX_Crystal_Guardians, 88, HoloRarity.EX_MIRROR_HOLO_CG)
				),
				new EnergyGroup("Miracle Energy",
					HoloCards.Find(Sets.Neo_Destiny, 16, HoloRarity.NEO_PIXEL_COSMOS_HOLO)
				),
				new EnergyGroup("Aqua Energy",
					HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 86, HoloRarity.EX_REVERSE_PLAIN_HOLO)
				),
				new EnergyGroup("Magma Energy",
					HoloCards.Find(Sets.EX_Team_Magma_vs_Team_Aqua, 87, HoloRarity.EX_REVERSE_PLAIN_HOLO)
				),
				new EnergyGroup("Dark Metal Energy",
					HoloCards.Find(Sets.EX_Team_Rocket_Returns, 94, HoloRarity.EX_ENERGY_HOLO_TRR),
					HoloCards.Find(Sets.EX_Holon_Phantoms, 97, HoloRarity.EX_MIRROR_HOLO_HP)
				),
				new EnergyGroup("Herbal Energy",
					HoloCards.Find(Sets.Furious_Fists, 103, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Burning Energy",
					HoloCards.Find(Sets.BREAKthrough, 151, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Splash Energy",
					HoloCards.Find(Sets.BREAKpoint, 113, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Flash Energy",
					HoloCards.Find(Sets.Ancient_Origins, 83, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Mystery Energy",
					HoloCards.Find(Sets.Phantom_Forces, 112, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Strong Energy",
					HoloCards.Find(Sets.Furious_Fists, 104, HoloRarity.BWXY_REVERSE_ENERGY_HOLO),
					HoloCards.Find(Sets.Fates_Collide, 115, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Dangerous Energy",
					HoloCards.Find(Sets.Ancient_Origins, 82, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Shield Energy",
					HoloCards.Find(Sets.Primal_Clash, 143, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Wonder Energy",
					HoloCards.Find(Sets.Primal_Clash, 144, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Dragon Energy",
					HoloCards.Find(Sets.Roaring_Skies, 97, HoloRarity.BWXY_REVERSE_ENERGY_HOLO)
				),
				new EnergyGroup("Aurora Energy",
					HoloCards.Find(Sets.Sword_Shield, 186, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Sword_Shield, 186, HoloRarity.SWSH_REVERSE_LINE_HOLO),

					// Impact Energy
					HoloCards.Find(Sets.Chilling_Reign, 157, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Spiral Energy
					HoloCards.Find(Sets.Chilling_Reign, 159, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),

					// Fusion Strike Energy
					HoloCards.Find(Sets.Fusion_Strike, 244, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Fusion_Strike, 244, HoloRarity.SWSH_REVERSE_LINE_HOLO)
				),
				new EnergyGroup("Rapid Strike Energy",
					HoloCards.Find(Sets.Battle_Styles, 140, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Battle_Styles, 140, HoloRarity.SWSH_REVERSE_LINE_HOLO),
					Cards.Find(Sets.Battle_Styles, 182, Rarity.Gold_Special_Energy_SWSH)
				),
				new EnergyGroup("Single Strike Energy",
					HoloCards.Find(Sets.Battle_Styles, 141, HoloRarity.SWSH_REVERSE_ENERGY_BANNER_HOLO),
					HoloCards.Find(Sets.Battle_Styles, 141, HoloRarity.SWSH_REVERSE_LINE_HOLO),
					Cards.Find(Sets.Battle_Styles, 183, Rarity.Gold_Special_Energy_SWSH)
				),
				new EnergyGroup("Luminous Energy",
					HoloCards.Find(Sets.Paldea_Evolved, 191, HoloRarity.SV_REVERSE_ROCKY_HOLO),
					HoloCards.Find(Sets.Paldea_Evolved, 191, HoloRarity.SV_REVERSE_PIXEL_COSMOS_HOLO),

					// Reversal Energy
					HoloCards.Find(Sets.Paldea_Evolved, 192, HoloRarity.SV_REVERSE_ROCKY_HOLO),
					HoloCards.Find(Sets.Paldea_Evolved, 192, HoloRarity.SV_REVERSE_PIXEL_COSMOS_HOLO),
					Cards.Find(Sets.Paradox_Rift, 266, Rarity.Gold_Special_Energy_SV),

					// Neo Upper Energy
					Cards.Find(Sets.Temporal_Forces, 162, Rarity.Ace_Spec_SV)
				),
				//new EnergyGroup("Rainbow Energy",
				//	HoloCards.Find(Sets.Base_Set, 4, HoloRarity.OS_STARLIGHT_HOLO)
				//),
			};
		}

		public static EnergyGroup FromRemaining()
		{
			List<CardBase> cards = new List<CardBase>();

			IEnumerable<HoloCard> holoSpecialEnergy = HoloCards.Get().Where(c => c.type == Types.Special_Energy);
			IEnumerable<Card> urSpecialEnergy = Cards.Get().Where(c => c.type == Types.Special_Energy);

			foreach (CardBase card in holoSpecialEnergy)
			{
				bool found = false;

				foreach (EnergyGroup group in TheGroups)
				{
					if (group.cards.Contains(card))
						found = true;
				}

				if (!found)
					cards.Add(card);
			}

			foreach (CardBase card in urSpecialEnergy)
			{
				bool found = false;

				foreach (EnergyGroup group in TheGroups)
				{
					if (group.cards.Contains(card))
						found = true;
				}

				if (!found)
					cards.Add(card);
			}

			if (cards.Count == 0)
				return null;

			return new EnergyGroup("Remaining", cards.ToArray());
		}


		public static EnergyGroup FromAll()
		{
			List<CardBase> cards = new List<CardBase>();

			foreach (EnergyGroup group in TheGroups)
				cards.AddRange(group.cards);

			EnergyGroup remaining = FromRemaining();

			if (remaining != null)
				cards.AddRange(remaining.cards);

			return new EnergyGroup("All", cards.ToArray());
		}
	}
}
