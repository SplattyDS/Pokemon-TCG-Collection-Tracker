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
			return set == card.set && setNum == card.setNum && set != Sets.Unnumbered_Promo;
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

		public bool IsEqualTo(HoloCard card)
		{
			return set == card.set && setNum == card.setNum && rarity == card.rarity && set != Sets.Unnumbered_Promo;
		}
	}

	public class WorldsCard : CardBase
	{
		public Rarity rarity;
		public int year;

		public static int curID = 1;

		public WorldsCard(string name, Pokedex dex, Rarity rarity, Types type, Sets set, double setNum, int year, bool have = false)
		{
			this.name = name;
			this.dex = dex;
			this.rarity = rarity;
			this.type = type;
			this.set = set;
			this.setNum = setNum;
			this.year = year;
			this.have = have;

			id = curID++;
		}
	}

	public class PocketCard : CardBase
	{
		public PocketRarity rarity;

		public static int curID = 1;

		public PocketCard(string name, Pokedex dex, PocketRarity rarity, Types type, Sets set, double setNum, bool have = false)
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

	public class JumboCard : CardBase
	{
		public JumboRarity rarity;

		public static int curID = 1;

		public JumboCard(string name, Pokedex dex, JumboRarity rarity, Types type, Sets set, double setNum, bool have = false)
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