using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCG
{
	public class FutureCardSection
	{
		public string name;
		public string id;
		public int numCards;

		public FutureCardSection(string name, string id, int numCards)
		{
			this.name = name;
			this.id = id;
			this.numCards = numCards;
		}
	}
}
