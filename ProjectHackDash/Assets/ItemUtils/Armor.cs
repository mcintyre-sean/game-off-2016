using System;
namespace ItemUtils
{
	public class Armor : Item
	{
		private long defence;

		public long Defence {
			get { return defence; }
			set { defence = value; }
		}

		public Armor() : base()
		{
			this.defence = 0;
		}

		public Armor(String name, int itemLevel, long strBonus, long dexBonus, long intBonus,
					  double moveSpdBonus, long defence)
			: base(name, itemLevel, strBonus, dexBonus, intBonus, moveSpdBonus)
		{
			this.defence = defence;
		}
	}
}
