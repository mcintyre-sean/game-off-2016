using System;
using ItemUtils;
namespace CharacterUtils
{
	public class Player : Character
	{
		private int avgItemLevel;
		private Weapon rightHand;
		private Weapon leftHand;
		private Armor helmet;
		private Armor chest;
		private Armor gloves;
		private Armor boots;

		public Player() : base()
		{
			
		}

		public Player(String name, long hp, long strength, long dexterity, long intellect, double moveSpeed) :
		base(name, hp, strength, dexterity, intellect, moveSpeed) {
			
		}
	}
}
