using System;
namespace ItemUtils
{
	public class Item
	{
		private String name;
		private Boolean isEquipped;
		private int itemLevel;
		private long strBonus;
		private long dexBonus;
		private long intBonus;
		private double moveSpdBonus;

		public Item()
		{
			this.name = "none equipped";
			this.isEquipped = false;
			this.itemLevel = 0;
			this.strBonus = 0;
			this.dexBonus = 0;
			this.intBonus = 0;
			this.moveSpdBonus = 0;
		}

		public Item(String name, int itemLevel, long strBonus, long dexBonus, long intBonus, double moveSpdBonus) {
			this.name = name;
			isEquipped = false;
			this.itemLevel = itemLevel;
			this.strBonus = strBonus;
			this.dexBonus = dexBonus;
			this.intBonus = intBonus;
			this.moveSpdBonus = moveSpdBonus;
		}
	}
}
