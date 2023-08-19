namespace TCG
{
	public class CardBase
	{
		public int id;
		public string name;
		public Types type;
		public Sets set;
		public Pokedex dex;
		public double setNum;
		public bool have;

		public override string ToString()
		{
			return id.ToString();
		}

		public bool IsEqualTo(CardBase card)
		{
			return set == card.set && setNum == card.setNum;
		}
	}

	public class Card : CardBase
	{
		public Rarity rarity;

		public static int curID = 1;
		
		public Card(string name, Pokedex dex, Rarity rarity, Types type, Sets set, double setNum, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			this.have = have;

			id = curID++;
		}
	}

	public class HoloCard : CardBase
	{
		public HoloRarity rarity;

		public static int curID = 1;

		public HoloCard(string name, Pokedex dex, HoloRarity rarity, Types type, Sets set, double setNum, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			this.have = have;

			id = curID++;
		}
	}
}