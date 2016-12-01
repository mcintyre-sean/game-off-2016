using System;
namespace ItemUtils
{
	public class Armor : Item
	{
		private enum Slot { Head, Chest, Hands, Feet };

		private long defence;

		public long Defence {
			get { return defence; }
			set { defence = value; }
		}

		public Armor()
		{
			this.defence = 0;
		}

		public Armor(string name, int itemLevel, long strBonus, long dexBonus, long intBonus,
					 double moveSpdBonus, long defence) :
		base(name, itemLevel, strBonus, dexBonus, intBonus, moveSpdBonus) {
			this.defence = defence;
		}

		public override string ToString() {
			return string.Format("\tDefence={0}", Defence);
		}
	}
}
