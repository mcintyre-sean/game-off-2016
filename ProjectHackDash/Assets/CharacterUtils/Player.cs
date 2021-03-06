﻿using System;
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

		private Armor head;
		Armor Head {
			get { return head; }
			set { head = value; }
		}

		private Armor chest;
		Armor Chest {
			get { return chest; }
			set { chest = value; }
		}

		private Armor hands;
		Armor Hands {
			get { return hands; }
			set { hands = value; }
		}

		private Armor feet;
		Armor Feet {
			get { return feet; }
			set { feet = value; }
		}

		public Player() {
			newPlayerGear();
		}

		public Player(string name, long hp, long strength, long dexterity, long intellect, double moveSpeed) :
		base(name, hp, strength, dexterity, intellect, moveSpeed) {
			newPlayerGear();
		}

		private void newPlayerGear() {
			RightHand = new Weapon();
			LeftHand = new Weapon();
			Head = new Armor();
			Chest = new Armor();
			Hands = new Armor();
			Feet = new Armor();
		}

		public void calculateAvgItemLevel() {
			var totalItemLevel = RightHand.ItemLevel + LeftHand.ItemLevel + Head.ItemLevel + Chest.ItemLevel + Hands.ItemLevel + Feet.ItemLevel;
			AvgItemLevel = totalItemLevel / GEAR_COUNT;
		}

		public override string ToString() {
			return string.Format("\tPlayer: AvgItemLevel={0}\n" +
			                     "\tRightHand={1}\n" +
			                     "\tLeftHand={2}\n" +
			                     "\tHelmet={3}\n" +
			                     "\tChest={4}\n" +
			                     "\tGloves={5}\n" +
			                     "\tBoots={6}", AvgItemLevel, RightHand, LeftHand, Head, Chest, Hands, Feet);
		}
	}
}
