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
			WriteFuture();
			WriteAll();
			WriteHave();
			// PrintRarities();
		}

		static void PrintRarities()
		{
			foreach (Rarity rarity in Enum.GetValues(typeof(Rarity)))
				Console.WriteLine(rarity.ToString().Replace('_', ' ') + "    " + CountCardsWithRarity(rarity));

			Console.ReadKey();
		}

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
			List<string> code = new List<string>(Sections.Get().Length + 3);

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

		static void WriteFuture()
		{
			List<string> code = new List<string>(FutureCardSections.Get().Length + 2);

			code.Add("<?php");

			foreach (FutureCardSection section in FutureCardSections.Get())
				code.Add(CodeFromFutureSection(section));
			
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

			IEnumerable<Card> cards = Cards.Get().OrderBy(c => c.setNum).OrderBy(c => c.set);
			string cardArr = string.Join(',', cards.Select(c => c.ToString()));

			code.Add("<?php");
			code.Add(CodeFromCollection(GetMyCollection()));
			code.Add("?>");

			File.WriteAllLines("C:\\wamp64\\www\\PHP\\TCG\\BestTracker_Have.php", code);
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

		static IEnumerable<Card> GetMyCollection()
		{
			return Cards.Get().Where(c => c.have).OrderBy(c => c.setNum).OrderBy(c => c.set).OrderBy(c => c.dex).OrderBy(c => c.type).OrderBy(c => c.rarity);
		}

		static IEnumerable<Card> CardsFromSection(Section section)
		{
			IEnumerable<Card> cards = Cards.Get().Where(c => c.rarity == section.rarity);

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
			return Cards.Get().Where(c => c.set == set && c.rarity != Rarity.Stamped).OrderBy(c => c.setNum);
		}

		static int CountCardsWithRarity(Rarity rarity)
		{
			return Cards.Get().Count(c => c.rarity == rarity);
		}

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
	}
}
