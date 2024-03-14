using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class PrizePack
	{
		public int Series;
		// public HoloRarity[] HoloTypes;
		public HoloCard[] Cards;

		public PrizePack(int series, params HoloCard[] cards)
		{
			Series = series;
			Cards = cards;
		}
	}
}
