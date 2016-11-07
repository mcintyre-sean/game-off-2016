using System;
namespace CharacterUtils
{
	public class Character
	{
		private String name;
		private long hp;
		private long strength;
		private long dexterity;
		private long intellect;
		private double moveSpeed;

		public Character()
		{
			this.name = "Default";
			this.hp = 10;
			this.strength = 1;
			this.dexterity = 1;
			this.intellect = 1;
			this.moveSpeed = 1.0;
		}

		public Character(String name, long HP, long strength, long dexterity, long intellect, double moveSpeed) {
			this.name = name;
			this.hp = HP;
			this.strength = strength;
			this.dexterity = dexterity;
			this.intellect = intellect;
			this.moveSpeed = moveSpeed;
		}

		public String getName() { return this.name; }
		public void setName(String name) { this.name = name; }

		public long getHP(long HP) { return this.hp; }
		public void setHP(long HP) { this.hp = HP; }

		public long getStrength() { return this.strength; }
		public void setStrength(long strength) { this.strength = strength; }

		public long getDexterity() { return this.dexterity; }
		public void setDexterity(long dexterity) { this.dexterity = dexterity; }

		public long getIntellect() { return this.intellect; }
		public void setIntellect(long intellect) { this.intellect = intellect; }

		public double getMoveSpeed() { return moveSpeed; }
		public void setMoveSpeed(double moveSpeed) { this.moveSpeed = moveSpeed; }
		public void changeMoveSpeed(double change) {
			double newSpeed = getMoveSpeed() + change;
			if (newSpeed < 0.0)
				newSpeed = 0.0;

			// An upper bound needs to be picked too

			setMoveSpeed(newSpeed);
		}

	}
}
