using System;
using ItemUtils;
namespace CharacterUtils
{
	public class Player : Character
	{
		private const int GEAR_COUNT = 6;

		private int avgItemLevel;
		int AvgItemLevel {
			get { return avgItemLevel; }
			set { avgItemLevel = value; }
		}

		private Weapon rightHand;
		Weapon RightHand {
			get { return rightHand; }
			set { rightHand = value; }
		}

		private Weapon leftHand;
		Weapon LeftHand {
			get { return leftHand; }
			set { leftHand = value; }
		}

		private Armor helmet;
		Armor Helmet {
			get { return helmet; }
			set { helmet = value; }
		}

		private Armor chest;
		Armor Chest {
			get { return chest; }
			set { chest = value; }
		}

		private Armor gloves;
		Armor Gloves {
			get { return gloves; }
			set { gloves = value; }
		}

		private Armor boots;
		Armor Boots {
			get { return boots; }
			set { boots = value; }
		}

		public Player() : base()
		{
			this.rightHand = new Weapon();
			this.leftHand = new Weapon();
			this.helmet = new Armor();
			this.chest = new Armor();
			this.gloves = new Armor();
			this.boots = new Armor();
		}

		public Player(String name, long hp, long strength, long dexterity, long intellect, double moveSpeed) :
		base(name, hp, strength, dexterity, intellect, moveSpeed) {
			
		}

		private void newPlayerGear() {
			RightHand = new Weapon();
			LeftHand = new Weapon();
			Helmet = new Armor();
			Chest = new Armor();
			Gloves = new Armor();
			Boots = new Armor();
		}

		public void calculateAvgItemLevel() {
			int totalItemLevel = RightHand.ItemLevel + LeftHand.ItemLevel + Helmet.ItemLevel + Chest.ItemLevel + Gloves.ItemLevel + Boots.ItemLevel;
			AvgItemLevel = totalItemLevel / GEAR_COUNT;
		}
	}
}
