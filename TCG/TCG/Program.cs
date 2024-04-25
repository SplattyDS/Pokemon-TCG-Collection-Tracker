using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TCG
{
	class Program
	{
		static void Main(string[] args)
		{
			CardBase[] duplicates = Cards.HasDuplicates();
			if (duplicates != null)
				throw new Exception();

			/*duplicates = HoloCards.HasDuplicates();
			if (duplicates != null)
				throw new Exception();*/

			EnergyGroups.Init();
			AcetoneGroups.Init();

			WriteCards();
			ModifyCards();
			WriteSections();
			WriteSets();
			WriteTypes();
			WritePokedex();
			WriteFuture();
			WriteAll();
			WriteHave();
			WriteHaveBinder();
			WritePercent();

			WriteHoloCards();
			WriteHoloSections();
			WriteHoloSets();
			WriteHoloSetsReverse();
			WriteHoloTypes();
			WriteHoloPokedex();
			WriteHoloAll();
			WriteHoloHave();
			WriteHoloPrizePack();
			WriteHoloComp();

			WriteWorldsCards();
			WriteWorldsSections();
			WriteWorldsSets();
			WriteWorldsYears();
			WriteWorldsTypes();
			WriteWorldsPokedex();
			WriteWorldsAll();
			WriteWorldsHave();

			WritePocket();

			WriteEnergy();
			WriteAcetone();
			WriteClone();

			// PrintRarities();
		}

		/*static void PrintRarities()
		{
			foreach (Rarity rarity in Enum.GetValues(typeof(Rarity)))
				Console.WriteLine(rarity.ToString().Replace('_', ' ') + "    " + CountCardsWithRarity(rarity));

			Console.ReadKey();
		}*/

		static void WriteCards()
		{
			List<string> code = new List<string>(Sections.Get().Length + 3);

			code.Add("<?php");

			foreach (Section section in Sections.Get())
				code.Add(CodeFromCards(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Cards.php", code);
		}

		static void ModifyCards()
		{
			string[] lines = File.ReadAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Cards.php");
			Rarity rarity;

			for (int i = 0; i < lines.Length; i++)
			{
				if (!lines[i].StartsWith('$'))
					continue;

				string arrayName = lines[i].Substring(1, lines[i].IndexOf(' ') - 1);
				if (arrayName == "have" || !Enum.TryParse(arrayName, out rarity))
					continue;

				foreach (Group group in Groups.Get())
				{
					if (group.rarity != rarity)
						continue;

					lines[i] = group.ApplyRule(lines[i]);
				}
			}

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Cards.php", lines);
		}

		static void WriteSections()
		{
			List<string> code = new List<string>(Sections.Get().Length + 2);

			code.Add("<?php");

			foreach (Section section in Sections.Get())
				code.Add(CodeFromSection(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Sections.php", code);
		}

		static void WriteSets()
		{
			List<string> code = new List<string>((int)Sets.Length + 2);

			code.Add("<?php");

			foreach (Sets set in Enum.GetValues(typeof(Sets)))
				code.Add(CodeFromSet(set));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Sets.php", code);
		}

		static void WriteTypes()
		{
			List<string> code = new List<string>((int)Types.Length + 2);

			code.Add("<?php");

			foreach (Types type in Enum.GetValues(typeof(Types)))
				code.Add(CodeFromType(type));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Types.php", code);
		}

		static void WritePokedex()
		{
			List<string> code = new List<string>((int)Pokedex.Length + 2);
			List<(Pokedex, int)> mons = new List<(Pokedex, int)>((int)Pokedex.Length);

			code.Add("<?php");

			foreach (Pokedex pokedex in Enum.GetValues(typeof(Pokedex)))
				mons.Add((pokedex, CardsFromPokedex(pokedex).Count()));

			// IEnumerable<(Pokedex, int)> order = mons.OrderByDescending(p => p.Item2);
			IEnumerable<(Pokedex, int)> order = mons;

			foreach ((Pokedex, int) thing in order)
				code.Add(CodeFromPokedex(thing.Item1));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Pokedex.php", code);
		}

		static void WriteFuture()
		{
			List<string> code = new List<string>(FutureCardSections.Get().Length + 2);

			code.Add("<?php");

			foreach (FutureCardSection section in FutureCardSections.Get())
				code.Add(CodeFromFutureSection(section));

			code.Add(CodeFromAllFutureSections());

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Future.php", code);
		}

		static void WriteAll()
		{
			List<string> code = new List<string>(4);

			IEnumerable<Card> cards = Cards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$all = array(" + cardArr + ");");
			code.Add("printCards('All Cards', $all);");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_All.php", code);
		}

		static void WriteHave()
		{
			List<string> code = new List<string>(3);

			code.Add("<?php");
			code.Add(CodeFromCollection(GetMyCollection()));
			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Have.php", code);
		}

		static void WriteHaveBinder()
		{
			List<string> code = new List<string>(3);

			code.Add("<?php");
			code.Add(CodeFromBinderCollection(GetBinderCollection()));
			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_HaveBinder.php", code);
		}

		static void WritePercent()
		{
			List<string> code = new List<string>(Sections.Get().Length + 2);
			IEnumerable<Section> orderedSections;

			if (Sections.Get().Select(s => (decimal)Cards.Get(false).Where(c => c.rarity == s.rarity).Count()).Contains(0))
			{
				orderedSections = Sections.Get();
				Console.WriteLine("Error, empty section found, not sorting percent.");
				// Console.ReadKey();
			}
			else
			{
				orderedSections = Sections.Get().OrderByDescending(s => (decimal)Cards.Get(false).Where(c => c.rarity == s.rarity && c.have).Count() / (decimal)Cards.Get(false).Where(c => c.rarity == s.rarity).Count());
			}

			code.Add("<?php");

			foreach (Section section in orderedSections)
				code.Add(CodeFromSection(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Percent.php", code);
		}

		static void WriteHoloCards()
		{
			List<string> code = new List<string>(2 + HoloSections.Get().Length);

			code.Add("<?php");

			foreach (Section section in HoloSections.Get())
				code.Add(CodeFromHoloCards(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_HoloCards.php", code);
		}

		static void WriteHoloSections()
		{
			List<string> code = new List<string>(2 + HoloSections.Get().Length);

			code.Add("<?php");

			foreach (Section section in HoloSections.Get())
				code.Add(CodeFromHoloSection(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo.php", code);
		}

		static void WriteHoloHave()
		{
			List<string> code = new List<string>(3);
			IEnumerable<HoloCard> collection = GetMyHoloCollection();

			code.Add("<?php");
			code.Add("$holoHave = array(" + string.Join(',', collection.Select(c => c.ToString())) + ");");
			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_HoloHave.php", code);
		}

		static void WriteHoloSets()
		{
			List<string> code = new List<string>((int)Sets.Length + 2);

			code.Add("<?php");

			foreach (Sets set in Enum.GetValues(typeof(Sets)))
				code.Add(CodeFromHoloSet(set));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_Sets.php", code);
		}

		static void WriteHoloSetsReverse()
		{
			List<string> code = new List<string>((int)Sets.Length + 2);

			code.Add("<?php");

			foreach (Sets set in Enum.GetValues(typeof(Sets)))
				code.Add(CodeFromHoloSetReverse(set));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_Sets_Reverse.php", code);
		}

		static void WriteHoloTypes()
		{
			List<string> code = new List<string>((int)Types.Length + 2);

			code.Add("<?php");

			foreach (Types type in Enum.GetValues(typeof(Types)))
				code.Add(CodeFromHoloType(type));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_Types.php", code);
		}

		static void WriteHoloPokedex()
		{
			List<string> code = new List<string>((int)Pokedex.Length + 2);
			List<(Pokedex, int)> mons = new List<(Pokedex, int)>((int)Pokedex.Length);

			code.Add("<?php");

			foreach (Pokedex pokedex in Enum.GetValues(typeof(Pokedex)))
				mons.Add((pokedex, HoloCardsFromPokedex(pokedex).Count()));

			// IEnumerable<(Pokedex, int)> order = mons.OrderByDescending(p => p.Item2);
			IEnumerable<(Pokedex, int)> order = mons;

			foreach ((Pokedex, int) thing in order)
				code.Add(CodeFromHoloPokedex(thing.Item1));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_Pokedex.php", code);
		}

		static void WriteHoloAll()
		{
			List<string> code = new List<string>(4);

			IEnumerable<HoloCard> cards = HoloCards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$holoAll = array(" + cardArr + ");");
			code.Add("printHolo('All Holo Cards', $holoAll);");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_All.php", code);
		}

		static void WriteHoloPrizePack()
		{
			List<string> code = new List<string>(2 + PrizePacks.Get().Length * 2);

			code.Add("<?php");

			foreach (PrizePack prizePack in PrizePacks.Get())
			{
				IEnumerable<HoloCard> cards = prizePack.Cards;
				string cardArr = string.Join(',', cards.Select(c => c.ToString()));

				code.Add("$prizePack" + prizePack.Series + " = array(" + cardArr + ");");
				code.Add("printHolo('Prize Pack Series " + prizePack.Series + "', $prizePack" + prizePack.Series + ");");
				// code.Add("start($j++, 'Prize Pack Series " + prizePack.Series + "', $holoHave, $prizePack" + prizePack.Series + ");");
				// code.Add("foreach ($prizePack" + prizePack.Series + " as $cur) { if (in_array($cur, $holoHave, true)) {imgHN($cur);} else {imgH($cur);} }");
				// code.Add("finish();");
			}

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_PrizePack.php", code);
		}

		static void WriteHoloComp()
		{
			List<string> code = new List<string>(6);

			IEnumerable<HoloCard> cards = HoloCards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$holoAll = array(" + cardArr + ");");
			code.Add("start($j++, 'Compare SV Cosmos Holo Cards', $holoHave, array());");
			code.Add("printComp(array(" + GetSvCosmos() + "));");
			code.Add("finish();");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Holo_Comp.php", code);
		}

		static string GetSvCosmos()
		{
			IEnumerable<HoloCard> cards = HoloCards.Get();
			List<List<HoloCard>> res = new List<List<HoloCard>>();

			foreach (HoloCard card in cards)
			{
				if (card.rarity != HoloRarity.SV_PIXEL_COSMOS_HOLO && card.rarity != HoloRarity.SV_SMOOTH_COSMOS_HOLO)
					continue;

				bool contains = false;

				foreach (IEnumerable<HoloCard> arr in res)
				{
					if (arr.Where(c => c != null).Select(c => c.id).Contains(card.id))
						contains = true;
				}

				if (contains)
					continue;

				List<HoloCard> list = new List<HoloCard>();

				list.Add(cards.Where(c => c.set == card.set && c.setNum == card.setNum && c.rarity == HoloRarity.SV_SMOOTH_COSMOS_HOLO).FirstOrDefault());
				list.Add(cards.Where(c => c.set == card.set && c.setNum == card.setNum && c.rarity == HoloRarity.SV_PIXEL_COSMOS_HOLO).FirstOrDefault());

				res.Add(list);
			}

			string ret = "";

			foreach (List<HoloCard> arr in res)
			{
				ret += "array(";

				foreach (HoloCard cur in arr)
				{
					ret += (cur == null ? 0 : cur) + ",";
				}

				ret.Trim(',');
				ret += "),";
			}

			ret.Trim(',');

			return ret;
		}

		static void WriteWorldsCards()
		{
			List<string> code = new List<string>(2 + Sections.Get().Length);

			code.Add("<?php");

			foreach (Section section in Sections.Get())
				code.Add(CodeFromWorldsCards(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_WorldsCards.php", code);
		}

		static void WriteWorldsSections()
		{
			List<string> code = new List<string>(2 + Sections.Get().Length);

			code.Add("<?php");

			foreach (Section section in Sections.Get())
				code.Add(CodeFromWorldsSection(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds.php", code);
		}

		static void WriteWorldsHave()
		{
			List<string> code = new List<string>(3);
			IEnumerable<WorldsCard> collection = GetMyWorldsCollection();

			code.Add("<?php");
			code.Add("$worldsHave = array(" + string.Join(',', collection.Select(c => c.ToString())) + ");");
			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_WorldsHave.php", code);
		}

		static void WriteWorldsSets()
		{
			List<string> code = new List<string>((int)Sets.Length + 2);

			code.Add("<?php");

			foreach (Sets set in Enum.GetValues(typeof(Sets)))
				code.Add(CodeFromWorldsSet(set));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds_Sets.php", code);
		}

		static void WriteWorldsYears()
		{
			List<string> code = new List<string>(DateTime.Now.Year - 2004 + 1 + 2);

			code.Add("<?php");

			for (int i = 2004; i < DateTime.Now.Year + 1; i++)
				code.Add(CodeFromWorldsYear(i));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds_Years.php", code);
		}

		static void WriteWorldsTypes()
		{
			List<string> code = new List<string>((int)Types.Length + 2);

			code.Add("<?php");

			foreach (Types type in Enum.GetValues(typeof(Types)))
				code.Add(CodeFromWorldsType(type));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds_Types.php", code);
		}

		static void WriteWorldsPokedex()
		{
			List<string> code = new List<string>((int)Pokedex.Length + 2);
			List<(Pokedex, int)> mons = new List<(Pokedex, int)>((int)Pokedex.Length);

			code.Add("<?php");

			foreach (Pokedex pokedex in Enum.GetValues(typeof(Pokedex)))
				mons.Add((pokedex, WorldsCardsFromPokedex(pokedex).Count()));

			// IEnumerable<(Pokedex, int)> order = mons.OrderByDescending(p => p.Item2);
			IEnumerable<(Pokedex, int)> order = mons;

			foreach ((Pokedex, int) thing in order)
				code.Add(CodeFromWorldsPokedex(thing.Item1));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds_Pokedex.php", code);
		}

		static void WriteWorldsAll()
		{
			List<string> code = new List<string>(4);

			IEnumerable<WorldsCard> cards = WorldsCards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$worldsAll = array(" + cardArr + ");");
			code.Add("printWorlds('All Worlds Cards', $worldsAll);");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Worlds_All.php", code);
		}

		static void WritePocket()
		{
			List<string> code = new List<string>(5);

			IEnumerable<PocketCard> cards = PocketCards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$pocketHave = array();");
			code.Add("$pocketAll = array(" + cardArr + ");");
			code.Add("printPocket('All Revealed Pocket Cards', $pocketAll);");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Pocket.php", code);
		}

		static void WriteEnergy()
		{
			List<string> code = new List<string>(EnergyGroups.Get().Count() + 3);

			code.Add("<?php");

			foreach (EnergyGroup group in EnergyGroups.Get())
				code.Add(CodeFromEnergyGroup(group));

			EnergyGroup remaining = EnergyGroups.FromRemaining();
			if (remaining != null)
				code.Add(CodeFromEnergyGroup(remaining));

			code.Add(CodeFromEnergyGroup(EnergyGroups.FromAll()));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Energy.php", code);
		}

		static void WriteAcetone()
		{
			List<string> code = new List<string>();

			code.Add("<?php");

			code.Add(
				"function acetoneImg($ID, $color)\r\n" +
				"{\r\n" +
				"\tprint('<img class=\"card-img\" src=\"images/best_tracker/cards/'.idToName($ID).'.png\" style=\"background-color: '.$color.'; border: 5px solid '.$color.';\">');\r\n" +
				"}\r\n\r\n" +
				"function acetoneImgH($ID, $color)\r\n" +
				"{\r\n" +
				"\tprint('<img class=\"card-img\" src=\"images/best_tracker/holo/'.idToHoloName($ID).'.png\" style=\"background-color: '.$color.'; border: 5px solid '.$color.';\">');\r\n" +
				"}\r\n" +
				"function foreignImg($ID, $color)\r\n" +
				"{\r\n" +
				"\tprint('<img class=\"card-img\" src=\"images/best_tracker/foreign_holo_'.$ID.'.png\" style=\"background-color: '.$color.'; border: 5px solid '.$color.';\">');\r\n" +
				"}\r\n"
			);

			foreach (AcetoneGroup group in AcetoneGroups.Get())
				code.Add(CodeFromAcetoneGroup(group));

			foreach (ForeignGroup group in AcetoneGroups.Foreign())
				code.Add(CodeFromForeignGroup(group));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Acetone.php", code);
		}

		static void WriteClone()
		{
			List<string> code = new List<string>();

			code.Add("<?php");

			string arr = "$clones = array(";

			foreach (Card[] clones in CloneCards.Get())
				arr += string.Join(',', clones.Select(c => c.ToString())) + ",'\\n',";

			arr = arr.TrimEnd(',');
			arr += ");";

			code.Add(arr);
			code.Add("printCards('Clones', $clones);");

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Clone.php", code);
		}

		static string CodeFromCards(Section section)
		{
			IEnumerable<Card> cards = CardsFromSection(section);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return "$" + section.rarity + " = array(" + cardArr + ");\r\n";
		}

		static string CodeFromSection(Section section)
		{
			return "printCards('" + section.title + "', $" + section.rarity + ");\r\n";
		}

		static string CodeFromHoloCards(Section section)
		{
			IEnumerable<HoloCard> cards = HoloCardsFromSection(section);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return "$" + section.holoRarity + " = array(" + cardArr + ");\r\n";
		}

		static string CodeFromHoloSection(Section section)
		{
			return "printHolo('" + section.title + "', $" + section.holoRarity + ");\r\n";
		}

		static string CodeFromHoloSet(Sets set)
		{
			IEnumerable<HoloCard> cards = HoloCardsFromSet(set, false);

			if (cards == null || cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + set.ToString() + " = array(" + cardArr + ");\r\n" +
				"printHolo('" + set.ToString().Replace('_', ' ') + "', $" + set.ToString() + ");\r\n";
		}

		static string CodeFromHoloSetReverse(Sets set)
		{
			IEnumerable<HoloCard> cards = HoloCardsFromSet(set, true);

			if (cards == null || cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + set.ToString() + "_Rev = array(" + cardArr + ");\r\n" +
				"printHolo('" + set.ToString().Replace('_', ' ') + "', $" + set.ToString() + "_Rev);\r\n";
		}

		static string CodeFromHoloType(Types type)
		{
			IEnumerable<HoloCard> cards = HoloCardsFromType(type);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + type.ToString() + " = array(" + cardArr + ");\r\n" +
				"printHolo('" + type.ToString().Replace('_', ' ') + "', $" + type.ToString() + ");\r\n";
		}

		static string CodeFromHoloPokedex(Pokedex pokedex)
		{
			IEnumerable<HoloCard> cards = HoloCardsFromPokedex(pokedex);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + pokedex.ToString() + " = array(" + cardArr + ");\r\n" +
				"printHolo('" + pokedex.ToString().Replace('_', ' ') + "', $" + pokedex.ToString() + ");\r\n";
		}

		static string CodeFromWorldsCards(Section section)
		{
			IEnumerable<WorldsCard> cards = WorldsCardsFromSection(section);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return "$" + section.rarity + " = array(" + cardArr + ");\r\n";
		}

		static string CodeFromWorldsSection(Section section)
		{
			if (!WorldsCardsFromSection(section).Any())
				return "";

			return "printWorlds('" + section.title + "', $" + section.rarity + ");\r\n";
		}

		static string CodeFromWorldsSet(Sets set)
		{
			IEnumerable<WorldsCard> cards = WorldsCardsFromSet(set);

			if (cards == null || cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + set.ToString() + " = array(" + cardArr + ");\r\n" +
				"printWorlds('" + set.ToString().Replace('_', ' ') + "', $" + set.ToString() + ");\r\n";
		}

		static string CodeFromWorldsYear(int year)
		{
			IEnumerable<WorldsCard> cards = WorldsCardsFromYear(year);

			if (cards == null || cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));
			string back = "";

			if (year < 2022)
			{
				back = "cardImg('card-img', 'images/best_tracker/worlds/B" + year + ".png', false);\r\n";
			}
			else
			{
				for (int i = 0; i < 4; i++)
					back += "cardImg('card-img', 'images/best_tracker/worlds/B" + year + "_" + (i + 1) + ".png', false);\r\n";
			}

			back += "print('<br>');\r\n";

			return
				"$Worlds_" + year + " = array(" + cardArr + ");\r\n" +
				"start($j++, 'World Championships " + year + "', $worldsHave, $Worlds_" + year + ");\r\n" +
				back +
				"foreach ($Worlds_" + year + " as $cur) { if (in_array($cur, $worldsHave, true)) {imgWN($cur);} else {imgW($cur);} }\r\n" +
				"finish();\r\n";
		}

		static string CodeFromWorldsType(Types type)
		{
			IEnumerable<WorldsCard> cards = WorldsCardsFromType(type);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + type.ToString() + " = array(" + cardArr + ");\r\n" +
				"printWorlds('" + type.ToString().Replace('_', ' ') + "', $" + type.ToString() + ");\r\n";
		}

		static string CodeFromWorldsPokedex(Pokedex pokedex)
		{
			IEnumerable<WorldsCard> cards = WorldsCardsFromPokedex(pokedex);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + pokedex.ToString() + " = array(" + cardArr + ");\r\n" +
				"printWorlds('" + pokedex.ToString().Replace('_', ' ') + "', $" + pokedex.ToString() + ");\r\n";
		}

		static string CodeFromCollection(IEnumerable<Card> cards)
		{
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));
			return "$have = array(" + cardArr + ");";
		}

		static string CodeFromBinderCollection(IEnumerable<Card> cards)
		{
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));
			return "$haveBinder = array(" + cardArr + ");";
		}

		static string CodeFromSet(Sets set)
		{
			IEnumerable<Card> cards = CardsFromSet(set);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + set.ToString() + " = array(" + cardArr + ");\r\n" +
				"printCards('" + set.ToString().Replace('_', ' ') + "', $" + set.ToString() + ");\r\n";
		}

		static string CodeFromType(Types type)
		{
			IEnumerable<Card> cards = CardsFromType(type);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + type.ToString() + " = array(" + cardArr + ");\r\n" +
				"printCards('" + type.ToString().Replace('_', ' ') + "', $" + type.ToString() + ");\r\n";
		}

		static string CodeFromPokedex(Pokedex pokedex)
		{
			IEnumerable<Card> cards = CardsFromPokedex(pokedex);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + pokedex.ToString() + " = array(" + cardArr + ");\r\n" +
				"printCards('" + pokedex.ToString().Replace('_', ' ') + "', $" + pokedex.ToString() + ");\r\n";
		}

		static string CodeFromEnergyGroup(EnergyGroup group)
		{
			string cardArr = "";

			foreach (CardBase card in group.cards)
			{
				if (card is Card)
					cardArr += "imgN(" + card.id + ");";
				else if (card is HoloCard)
					cardArr += "imgHN(" + card.id + ");";
			}

			return
				"start($j++, '" + group.energyName + "', array(), array());\r\n" +
				cardArr + "\r\n" +
				"finish();\r\n";
		}

		static string CodeFromAcetoneGroup(AcetoneGroup group)
		{
			string[] colors = new string[(int)AcetoneStatus.NUM_STATUSES] { "red", "orange", "lime", "deepskyblue", "purple" };
			string cardArr = string.Join(',', group.cards.Select(c => "array(" + c.Item1.ToString() + ",'" + (c.Item1 is Card ? "u" : "h") + "', '" + colors[(int)c.Item2] + "')"));

			return
				"$temp = array(" + cardArr + ");\r\n" +
				"print('<div id=\"container - '.$j++.'\" class=\"center\">');\r\n" +
				"print('<h1>" + group.holoName + "</h1>');\r\n" +
				"foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }\r\n" +
				"print('</div>');\r\n";
		}

		static string CodeFromForeignGroup(ForeignGroup group)
		{
			string[] colors = new string[(int)AcetoneStatus.NUM_STATUSES] { "red", "orange", "lime", "deepskyblue", "purple" };
			string cardArr = string.Join(',', group.cards.Select(c => "array(" + c.Item1.ToString() + ", '" + colors[(int)c.Item2] + "')"));

			return
				"$temp = array(" + cardArr + ");\r\n" +
				"print('<div id=\"container - '.$j++.'\" class=\"center\">');\r\n" +
				"print('<h1>" + group.holoName + "</h1>');\r\n" +
				"foreach ($temp as $cur) { foreignImg($cur[0], $cur[1]); }\r\n" +
				"print('</div>');\r\n";
		}

		static IEnumerable<CardBase> SortCards(IEnumerable<CardBase> cards, SortMode sortMode)
		{
			switch (sortMode)
			{
				case SortMode.NO_SORT:
					return cards;

				case SortMode.SORT_BY_SET:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.set);

				case SortMode.SORT_BY_TYPE:
					return cards.OrderBy(c => c.type);

				case SortMode.SORT_BY_NAME:
					return cards.OrderBy(c => c.name);

				case SortMode.SORT_BY_NAME_AND_TYPE:
					return cards.OrderBy(c => c.name).OrderBy(c => c.type);

				case SortMode.SORT_BY_SET_AND_TYPE:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.type);

				case SortMode.SORT_BY_SET_AND_DEX:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex);

				case SortMode.SORT_BY_TYPE_AND_SET:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.type).OrderBy(c => c.set);

				case SortMode.SORT_BY_SET_AND_DEX_AND_TYPE:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type);

				case SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type);

					List<CardBase> noExtraSort = cards.Where(c => c.type != Types.Item && c.type != Types.Tool && c.type != Types.Technical_Machine && c.type != Types.Supporter && c.type != Types.Stadium && c.type != Types.Special_Energy).ToList();

					List<CardBase> sortedItem = cards.Where(c => c.type == Types.Item).OrderBy(c => c.name).ToList();
					List<CardBase> sortedTool = cards.Where(c => c.type == Types.Tool).OrderBy(c => c.name).ToList();
					List<CardBase> sortedTM = cards.Where(c => c.type == Types.Technical_Machine).OrderBy(c => c.name).ToList();
					List<CardBase> sortedR = cards.Where(c => c.type == Types.Rockets_Secret_Machine).OrderBy(c => c.name).ToList();
					List<CardBase> sortedSupporter = cards.Where(c => c.type == Types.Supporter).OrderBy(c => c.name).ToList();
					List<CardBase> sortedStadium = cards.Where(c => c.type == Types.Stadium).OrderBy(c => c.name).ToList();
					List<CardBase> sortedSpecialEnergy = cards.Where(c => c.type == Types.Special_Energy).OrderBy(c => c.name).ToList();

					noExtraSort.AddRange(sortedItem);
					noExtraSort.AddRange(sortedTool);
					noExtraSort.AddRange(sortedTM);
					noExtraSort.AddRange(sortedR);
					noExtraSort.AddRange(sortedSupporter);
					noExtraSort.AddRange(sortedStadium);
					noExtraSort.AddRange(sortedSpecialEnergy);

					return noExtraSort.OrderBy(c => c.type);

				case SortMode.SORT_BY_SET_AND_NAME_AND_DEX_AND_TYPE:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.name).OrderBy(c => c.dex).OrderBy(c => c.type);

				case SortMode.SORT_BY_DEX_AND_TYPE_AND_SET:
					return cards.OrderBy(c => c.setNum).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.set);

				default:
					throw new NotSupportedException(sortMode.ToString());
			}
		}

		static IEnumerable<Card> GetMyCollection()
		{
			IEnumerable<Card> unsorted = Cards.Get().Where(c => c.have);
			List<Card> sorted = new List<Card>();

			foreach (Section section in Sections.Get())
				sorted.AddRange(SortCards(unsorted.Where(c => c.rarity == section.rarity), section.sortMode).OfType<Card>());

			if (unsorted.Count() != sorted.Count)
				throw new Exception();

			return sorted;

			// return Cards.Get().Where(c => c.have).OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.rarity);
		}

		static IEnumerable<Card> GetBinderCollection()
		{
			IEnumerable<Card> unsorted = GetMyCollection();
			List<Card> sorted = new List<Card>();

			foreach (Rarity rarity in CurrentCollectionOrder.Order)
				sorted.AddRange(unsorted.Where(c => c.rarity == rarity));

			return sorted;
		}

		static IEnumerable<HoloCard> GetMyHoloCollection()
		{
			IEnumerable<HoloCard> unsorted = HoloCards.Get().Where(c => c.have);
			List<HoloCard> sorted = new List<HoloCard>();

			foreach (Section section in HoloSections.Get())
				sorted.AddRange(SortCards(unsorted.Where(c => c.rarity == section.holoRarity), section.sortMode).OfType<HoloCard>());

			if (unsorted.Count() != sorted.Count)
				throw new Exception();

			return sorted;

			// return HoloCards.Get().Where(c => c.have).OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.rarity);
		}

		static IEnumerable<WorldsCard> GetMyWorldsCollection()
		{
			IEnumerable<WorldsCard> unsorted = WorldsCards.Get().Where(c => c.have);
			List<WorldsCard> sorted = new List<WorldsCard>();

			foreach (Section section in Sections.Get())
				sorted.AddRange(SortCards(unsorted.Where(c => c.rarity == section.rarity), section.sortMode).OfType<WorldsCard>());

			if (unsorted.Count() != sorted.Count)
				throw new Exception();

			return sorted;

			// return WorldsCards.Get().Where(c => c.have).OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.rarity);
		}

		static IEnumerable<Card> CardsFromSection(Section section)
		{
			IEnumerable<Card> cards = Cards.Get(false).Where(c => c.rarity == section.rarity);

			return SortCards(cards, section.sortMode).OfType<Card>();
		}

		static IEnumerable<HoloCard> HoloCardsFromSection(Section section)
		{
			IEnumerable<HoloCard> cards = HoloCards.Get().Where(c => c.rarity == section.holoRarity);

			return SortCards(cards, section.sortMode).OfType<HoloCard>();
		}

		static IEnumerable<WorldsCard> WorldsCardsFromSection(Section section)
		{
			IEnumerable<WorldsCard> cards = WorldsCards.Get().Where(c => c.rarity == section.rarity);

			switch (section.sortMode)
			{
				case SortMode.NO_SORT:
					break;

				case SortMode.SORT_BY_SET:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set);
					break;

				case SortMode.SORT_BY_TYPE:
					cards = cards.OrderBy(c => c.type);
					break;

				case SortMode.SORT_BY_NAME:
					cards = cards.OrderBy(c => c.name);
					break;

				case SortMode.SORT_BY_NAME_AND_TYPE:
					cards = cards.OrderBy(c => c.name).OrderBy(c => c.type);
					break;

				case SortMode.SORT_BY_SET_AND_TYPE:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.type);
					break;

				case SortMode.SORT_BY_SET_AND_DEX:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex);
					break;

				case SortMode.SORT_BY_TYPE_AND_SET:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.type).OrderBy(c => c.set);
					break;

				case SortMode.SORT_BY_SET_AND_DEX_AND_TYPE:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type);
					break;

				case SortMode.SORT_BY_SET_AND_DEX_AND_TYPE_DX:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type);

					List<WorldsCard> noExtraSort = cards.Where(c => c.type != Types.Item && c.type != Types.Tool && c.type != Types.Technical_Machine && c.type != Types.Supporter && c.type != Types.Stadium && c.type != Types.Special_Energy).ToList();

					List<WorldsCard> sortedItem = cards.Where(c => c.type == Types.Item).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedTool = cards.Where(c => c.type == Types.Tool).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedTM = cards.Where(c => c.type == Types.Technical_Machine).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedR = cards.Where(c => c.type == Types.Rockets_Secret_Machine).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedSupporter = cards.Where(c => c.type == Types.Supporter).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedStadium = cards.Where(c => c.type == Types.Stadium).OrderBy(c => c.name).ToList();
					List<WorldsCard> sortedSpecialEnergy = cards.Where(c => c.type == Types.Special_Energy).OrderBy(c => c.name).ToList();

					noExtraSort.AddRange(sortedItem);
					noExtraSort.AddRange(sortedTool);
					noExtraSort.AddRange(sortedTM);
					noExtraSort.AddRange(sortedR);
					noExtraSort.AddRange(sortedSupporter);
					noExtraSort.AddRange(sortedStadium);
					noExtraSort.AddRange(sortedSpecialEnergy);

					cards = noExtraSort.OrderBy(c => c.type);

					break;

				case SortMode.SORT_BY_SET_AND_NAME_AND_DEX_AND_TYPE:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.name).OrderBy(c => c.dex).OrderBy(c => c.type);
					break;

				case SortMode.SORT_BY_DEX_AND_TYPE_AND_SET:
					cards = cards.OrderBy(c => c.setNum).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.set);
					break;

				default:
					throw new NotSupportedException(section.sortMode.ToString());
			}

			return cards;
		}

		static IEnumerable<Card> CardsFromSet(Sets set)
		{
			return Cards.Get().Where(c => c.set == set).OrderBy(c => c.setNum);
		}

		static IEnumerable<Card> CardsFromType(Types type)
		{
			return Cards.Get().Where(c => c.type == type).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		static IEnumerable<Card> CardsFromPokedex(Pokedex pokedex)
		{
			return Cards.Get().Where(c => c.dex == pokedex).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		static IEnumerable<HoloCard> HoloCardsFromSet(Sets set, bool reverse)
		{
			return SetReverses.FilterCards(HoloCards.Get().Where(c => c.set == set).OrderBy(c => c.rarity).OrderBy(c => c.setNum), set, reverse);
		}

		static IEnumerable<HoloCard> HoloCardsFromType(Types type)
		{
			return HoloCards.Get().Where(c => c.type == type).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		static IEnumerable<HoloCard> HoloCardsFromPokedex(Pokedex pokedex)
		{
			return HoloCards.Get().Where(c => c.dex == pokedex).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		static IEnumerable<WorldsCard> WorldsCardsFromSet(Sets set)
		{
			return WorldsCards.Get().Where(c => c.set == set).OrderBy(c => c.setNum);
		}

		static IEnumerable<WorldsCard> WorldsCardsFromYear(int year)
		{
			return WorldsCards.Get().Where(c => c.year == year);
		}

		static IEnumerable<WorldsCard> WorldsCardsFromType(Types type)
		{
			return WorldsCards.Get().Where(c => c.type == type).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		static IEnumerable<WorldsCard> WorldsCardsFromPokedex(Pokedex pokedex)
		{
			return WorldsCards.Get().Where(c => c.dex == pokedex).OrderBy(c => c.setNum).OrderBy(c => c.set);
		}

		/*static int CountCardsWithRarity(Rarity rarity)
		{
			return Cards.Get(false).Count(c => c.rarity == rarity);
		}*/

		static string CodeFromFutureSection(FutureCardSection section)
		{
			string cardArr = "";
			for (int i = 1; i <= section.numCards; i++)
				cardArr += (i != 1 ? ",'" : "'") + section.id + i + "'";

			return
				"$FUT_" + section.id + " = array(" + cardArr + ");\r\n" +
				"printFuture('" + section.name + "', $FUT_" + section.id + ");\r\n";
		}

		static string CodeFromAllFutureSections()
		{
			string cardArr = "";
			bool first = true;

			foreach (FutureCardSection section in FutureCardSections.Get())
			{
				for (int i = 1; i <= section.numCards; i++)
				{
					cardArr += (!first ? ",'" : "'") + section.id + i + "'";
					first = false;
				}
			}

			return
				"$FUT_All = array(" + cardArr + ");\r\n" +
				"printFuture('All', $FUT_All);\r\n";
		}
	}
}
