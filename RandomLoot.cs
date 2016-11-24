using UnityEngine;
using System.Collections;


namespace DungeonExplorer{
	public class RandomLoot{

		private int temp, num;
		private  InventoryLoader loadInventory = new InventoryLoader ();
		private string  ItemSelectionOne, ItemSelectionTwo, ItemSelectionThree,
						ItemSelectionFour,ItemSelectionFive,ItemSelectionSix,
						ItemSelectionSeven,ItemSelectionEight,ItemSelectionNine, 
						ItemSelectionTen;
	
		public void randomItemSelection(int num){
			temp = 4;
			if (num == 1) {
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
										  " Broken Dagger, 1, 0, 2 \n" +
										  " Shock Spell, 15, 0, 1 \n" +
										  " Lightning Spell, 15, 0, 1 \n" +
										  " Sword, 5, 0, 1 \n";
				
			switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Shock Spell", 85, 1));

					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Broken Dagger", 15, 0, 2));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addSpell(new Spells("Lightning Spell", 25, 1));
					break;
				case 1:
					loadInventory.addWeapon(new Weapons("Sword", 5, 0, 1));
					break;
				}
			} else if (num == 2) {
				Debug.Log("TWO");
				string ItemSelectionOne = " Old Knive, 15, 0, 1 \n" +
										  " Shock Spell, 15, 0, 1 \n" +
										  " Sword, 15, 0, 1 \n" +
										  " Sword, 15, 0, 1 \n" +
										  " Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addWeapon(new Weapons("Old Knive", 5, 0, 2));
					break;
				case 4:
					loadInventory.addSpell(new Spells("Shock Spell", 85, 5));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Elven Heavy Armor", 35, 1));
					break;
				case 1:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				}
			} else if (num == 3) {
				Debug.Log("THREE");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword of The Gods", 55, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Great Sword", 25, 3, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Light Armor", 15, 3));
					break;
				case 1:
					loadInventory.addArmor(new Armor("Golden Heavy Armor", 25, 1));
					break;
				}
			} else if (num == 4) {
				Debug.Log("FOUR");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 5) {
				Debug.Log("FIVE");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 6) {
				Debug.Log("SIX");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 7) {
				Debug.Log("SEVEN");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 8) {
				Debug.Log("EIGHT");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 9) {
				Debug.Log("NINE");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 10) {
				Debug.Log("TEN");
				string ItemSelectionOne = " Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n" +
					" Sword, 15, 0, 1 \n";
				
				switch (temp) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("THE GOLDEN GREAT SWPRK", 150, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			}
		}
	}
}

