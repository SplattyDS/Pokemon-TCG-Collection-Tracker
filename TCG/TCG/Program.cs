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
			Card[] duplicates = Cards.HasDuplicates();
			if (duplicates != null)
				throw new Exception();

			WriteCards();
			ModifyCards();
			WriteSections();
			WriteSets();
			WriteTypes();
			WritePokedex();
			WriteFuture();
			WriteAll();
			WriteHave();
			WritePercent();
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
			List<(Pokedex,int)> mons = new List<(Pokedex, int)>((int)Pokedex.Length);

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
			List<string> code = new List<string>(6);

			IEnumerable<Card> cards = Cards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");

			code.Add("$all = array(" + cardArr + ");");
			code.Add("start($j++, 'All Cards', $have, $all);");
			code.Add("foreach ($all as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }");
			code.Add("finish();");

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

		static void WritePercent()
		{
			List<string> code = new List<string>(Sections.Get().Length + 2);
			IEnumerable<Section> orderedSections = Sections.Get().OrderByDescending(s => (decimal)Cards.Get(false).Where(c => c.rarity == s.rarity && c.have).Count() / (decimal)Cards.Get(false).Where(c => c.rarity == s.rarity).Count());
			
			code.Add("<?php");

			foreach (Section section in orderedSections)
				code.Add(CodeFromSection(section));

			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Percent.php", code);
		}

		static string CodeFromCards(Section section)
		{
			IEnumerable<Card> cards = CardsFromSection(section);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return "$" + section.rarity + " = array(" + cardArr + ");\r\n";
		}

		static string CodeFromSection(Section section)
		{
			IEnumerable<Card> cards = CardsFromSection(section);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"start($j++, '" + section.title + "', $have, $" + section.rarity + ");\r\n" +
				"foreach ($" + section.rarity + " as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }\r\n" +
				"finish();\r\n";
		}

		static string CodeFromCollection(IEnumerable<Card> cards)
		{
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));
			return "$have = array(" + cardArr + ");";
		}

		static string CodeFromSet(Sets set)
		{
			IEnumerable<Card> cards = CardsFromSet(set);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + set.ToString() + " = array(" + cardArr + ");\r\n" +
				"start($j++, '" + set.ToString().Replace('_', ' ') + "', $have, $" + set.ToString() + ");\r\n" +
				"foreach ($" + set.ToString() + " as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }\r\n" +
				"finish();\r\n";
		}

		static string CodeFromType(Types type)
		{
			IEnumerable<Card> cards = CardsFromType(type);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + type.ToString() + " = array(" + cardArr + ");\r\n" +
				"start($j++, '" + type.ToString().Replace('_', ' ') + "', $have, $" + type.ToString() + ");\r\n" +
				"foreach ($" + type.ToString() + " as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }\r\n" +
				"finish();\r\n";
		}

		static string CodeFromPokedex(Pokedex pokedex)
		{
			IEnumerable<Card> cards = CardsFromPokedex(pokedex);

			if (cards.Count() == 0)
				return "";

			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			return
				"$" + pokedex.ToString() + " = array(" + cardArr + ");\r\n" +
				"start($j++, '" + pokedex.ToString().Replace('_', ' ') + "', $have, $" + pokedex.ToString() + ");\r\n" +
				"foreach ($" + pokedex.ToString() + " as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }\r\n" +
				"finish();\r\n";
		}

		static IEnumerable<Card> GetMyCollection()
		{
			return Cards.Get().Where(c => c.have).OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.rarity);
		}

		static IEnumerable<Card> CardsFromSection(Section section)
		{
			IEnumerable<Card> cards = Cards.Get(false).Where(c => c.rarity == section.rarity);

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
				"start($j++, '" + section.name + "', $have, $FUT_" + section.id + ");\r\n" +
				"foreach ($FUT_" + section.id + " as $cur) { imgF($cur); }\r\n" +
				"finish();\r\n";
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
				"start($j++, 'All', $have, $FUT_All);\r\n" +
				"foreach ($FUT_All as $cur) { imgF($cur); }\r\n" +
				"finish();\r\n";
		}
	}
}
