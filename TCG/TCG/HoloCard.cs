namespace TCG
{
	public class HoloCard
	{
		public int id;
		public string name;
		public HoloRarity rarity;
		public Types type;
		public Sets set;
		public Pokedex dex;
		public double setNum;
		// public decimal price;
		public bool have;

		public static int curID = 1;

		/*public HoloCard(string name, Pokedex dex, HoloRarity rarity, Types type, Sets set, double setNum, decimal price, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			this.price = price;
			this.have = have;

			id = curID++;
		}*/

		public HoloCard(string name, Pokedex dex, HoloRarity rarity, Types type, Sets set, double setNum, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			// this.price = 0;
			this.have = have;

			id = curID++;
		}

		public override string ToString()
		{
			return id.ToString();
		}

		public bool IsEqualTo(HoloCard holoCard)
		{
			return set == holoCard.set && setNum == holoCard.setNum;
		}
	}
}