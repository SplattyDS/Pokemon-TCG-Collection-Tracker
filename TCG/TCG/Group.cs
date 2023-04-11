using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class Group
	{
		public Rarity rarity;
		public Rules rule;
		public Card[] cards;

		public Group(Rarity rarity, Rules rule, params Card[] cards)
		{
			this.rarity = rarity;
			this.rule = rule;
			this.cards = cards;
		}

		public string ApplyRule(string strArr)
		{
			// does not apply to this rarity
			if (!strArr.StartsWith("$" + rarity.ToString()))
				return strArr;

			string valsStr = strArr.Substring(10 + rarity.ToString().Length).Replace(");", "");
			int[] vals = valsStr.Split(',').Select(v => int.Parse(v)).ToArray();

			int[] newVals = new int[vals.Length];

			switch (rule)
			{
				case Rules.ENFORCE_LAST:
					int curIndex = 0;
					int[] IDs = cards.Select(c => c.id).ToArray();

					for (int i = 0; i < vals.Length; i++)
					{
						if (!IDs.Contains(vals[i]))
							newVals[curIndex++] = vals[i];
					}

					for (int i = 0; i < vals.Length; i++)
					{
						if (IDs.Contains(vals[i]))
							newVals[curIndex + Array.IndexOf(IDs, vals[i])] = vals[i];
					}

					break;

				case Rules.GROUP_CARDS:
					int firstID = cards[0].id;
					int groupIndex = 0;
					curIndex = 0;
					IDs = cards.Select(c => c.id).ToArray();

					for (int i = 0; i < vals.Length; i++)
					{
						if (!IDs.Contains(vals[i]))
						{
							newVals[curIndex++] = vals[i];
						}
						else if (vals[i] == firstID)
						{
							groupIndex = curIndex;
							curIndex += IDs.Count();
						}
					}

					for (int i = 0; i < vals.Length; i++)
					{
						if (IDs.Contains(vals[i]))
							newVals[groupIndex + Array.IndexOf(IDs, vals[i])] = vals[i];
					}

					break;

				default:
					throw new NotSupportedException(rule.ToString());
			}

			return "$" + rarity.ToString() + " = array(" + string.Join(',', newVals.Select(v => v.ToString())) + ");";
		}
	}
}
