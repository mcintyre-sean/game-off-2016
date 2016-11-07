using System;
namespace ItemUtils
{
	public class Weapon : Item
	{
		private long damageMin, damageMax;
		private Boolean needsTwoHands;

		public Weapon() : base()
		{
			this.damageMin = 0;
			this.damageMax = 0;
			this.needsTwoHands = false;
		}
	}
}
