namespace TCG
{
	public class Card
	{
		public int id;
		public string name;
		public Rarity rarity;
		public Types type;
		public Sets set;
		public Pokedex dex;
		public double setNum;
		public decimal price;
		public bool have;

		public static int curID = 1;

		public Card(string name, Pokedex dex, Rarity rarity, Types type, Sets set, double setNum, decimal price, bool have = false)
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
		}

		public Card(string name, Pokedex dex, Rarity rarity, Types type, Sets set, double setNum, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			this.price = 0;
			this.have = have;

			id = curID++;
		}

		public override string ToString()
		{
			return id.ToString();
		}

		public bool IsEqualTo(Card card)
		{
			return set == card.set && setNum == card.setNum;
		}
	}
}