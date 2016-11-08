using System;
namespace CharacterUtils
{
	public class Character
	{
		private string name;
		public string Name {
			get { return name; }
			set { name = value; }
		}

		private long hp;
		public long Hp {
			get { return hp; }
			set { hp = value; }
		}

		private long strength;
		public long Strength {
			get { return strength; }
			set { strength = value; }
		}

		private long dexterity;
		public long Dexterity {
			get { return dexterity; }
			set { dexterity = value; }
		}

		private long intellect;
		public long Intellect {
			get { return intellect; }
			set { intellect = value; }
		}

		private double moveSpeed;
		public double MoveSpeed {
			get { return moveSpeed; }
			set { moveSpeed = value; }
		}

		public Character()
		{
			this.name = "Default";
			this.hp = 10;
			this.strength = 1;
			this.dexterity = 1;
			this.intellect = 1;
			this.moveSpeed = 1.0;
		}

		public Character(string name, long hp, long strength, long dexterity, long intellect, double moveSpeed) {
			this.name = name;
			this.hp = hp;
			this.strength = strength;
			this.dexterity = dexterity;
			this.intellect = intellect;
			this.moveSpeed = moveSpeed;
		}

		public void changeMoveSpeed(double change) {
			double newSpeed = MoveSpeed + change;
			if (newSpeed < 0.0)
				newSpeed = 0.0;

			// An upper bound needs to be picked too

			MoveSpeed = newSpeed;
		}

	}
}
