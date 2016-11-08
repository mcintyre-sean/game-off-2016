using System;
namespace ItemUtils
{
	public class Weapon : Item
	{
		private long damageMin, damageMax;
		private bool twoHands;

		public long DamageMin {
			get { return damageMin; }
			set { damageMin = value; }
		}

		public long DamageMax {
			get { return damageMax; }
			set { damageMax = value; }
		}

		public bool TwoHands {
			get { return twoHands; }
			set { twoHands = value; }
		}

		public Weapon()
		{
			this.damageMin = 0;
			this.damageMax = 0;
			this.twoHands = false;
		}

		public Weapon(string name, int itemLevel, long strBonus, long dexBonus, long intBonus,
		              double moveSpdBonus, long damageMin, long damageMax, bool needsTwoHands) :
		base(name, itemLevel, strBonus, dexBonus, intBonus, moveSpdBonus) {
			this.damageMin = damageMin;
			this.damageMax = damageMax;
			this.twoHands = needsTwoHands;
		}

		public override string ToString() {
			return string.Format("\tDamage:s {0} - {1}\n" +
			                     "\tTwoHands={2}", DamageMin, DamageMax, TwoHands);
		}
	}
}
