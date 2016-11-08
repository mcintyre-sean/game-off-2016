using System;
namespace ItemUtils
{
	public class Item
	{
		private string name;
		private bool equipped;
		private int itemLevel;
		private long strBonus;
		private long dexBonus;
		private long intBonus;
		private double moveSpdBonus;

		public Item()
		{
			this.name = "none equipped";
			this.equipped = false;
			this.itemLevel = 0;
			this.strBonus = 0;
			this.dexBonus = 0;
			this.intBonus = 0;
			this.moveSpdBonus = 0;
		}

		public Item(string name, int itemLevel, long strBonus, long dexBonus, long intBonus, double moveSpdBonus) {
			this.name = name;
			equipped = false;
			this.itemLevel = itemLevel;
			this.strBonus = strBonus;
			this.dexBonus = dexBonus;
			this.intBonus = intBonus;
			this.moveSpdBonus = moveSpdBonus;
		}

		public string Name {
			get { return name; }
			set { name = value; }
		}

		public bool Equipped {
			get { return equipped; }
			set { equipped = value; }
		}

		public int ItemLevel {
			get { return itemLevel; }
			set { itemLevel = value; }
		}

		public long StrBonus {
			get { return strBonus; }
			set { strBonus = value; }
		}

		public long DexBonus {
			get { return dexBonus; }
			set { dexBonus = value; }
		}

		public long IntBonus {
			get { return intBonus; }
			set { intBonus = value; }
		}

		public double MoveSpdBonus {
			get { return moveSpdBonus; }
			set { moveSpdBonus = value; }
		}

		public override string ToString() {
			var s = string.Format("{0}\n", Name);
			if (ItemLevel > 0)
				s += string.Format("\tItemLevel={0}\n", ItemLevel);
			if (StrBonus > 0)
				s += string.Format("\tStrBonus={0}\n", StrBonus);
			if (DexBonus > 0)
				s += string.Format("\tDexBonus={0}\n", DexBonus);
			if (IntBonus > 0)
				s += string.Format("\tIntBonus={0}\n", IntBonus);
			if (MoveSpdBonus > 0.0)
				s += string.Format("\tMoveSpdBonus={0}\n", MoveSpdBonus);

			return s;
		}
	}
}
