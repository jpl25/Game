using UnityEngine;
using System.Collections;
using UnityEditor;

namespace DungeonExplorer{
	public class RandomLoot: MonoBehaviour {

		private int temp, num;
		private InventoryLoader loadInventory = new InventoryLoader ();
	
		public void randomItemSelection(){
		num = Random.Range (0, 10);
		temp = 0;
			if (num == 1) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1

				switch (temp) {
				case 1:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Broken Dagger", 15, 0, 2));
					break;
				case 3:
					loadInventory.addSpell(new Spells("Shock Spell", 85, 1));
					break;
				case 4:
					loadInventory.addSpell(new Spells("Lightning Spell", 25, 1));
					break;
				case 5:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				}
			} else if (num == 2) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addWeapon(new Weapons("Old Knive", 5, 0, 2));
					break;
				case 2:
					loadInventory.addSpell(new Spells("Shock Spell", 85, 5));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Elven Heavy Armor", 35, 1));
					break;
				case 5:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				}
			} else if (num == 3) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword of The Gods", 55, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Great Sword", 25, 3, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Light Armor", 15, 3));
					break;
				case 5:
					loadInventory.addArmor(new Armor("Golden Heavy Armor", 25, 1));
					break;
				}
			} else if (num == 4) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 5) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 6) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 7) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 8) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 9) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 10) {
				//THIS IS WHERE THE TEXT WILL GO
				//"Healing Spell", 85, 5
				//Sword", 15, 0, 1
				//Sword", 15, 0, 1
				//"Damaged Heavy Armor", 15, 1
				//"Master Key", 1
				switch (temp) {
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 2:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 4:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 5:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			}
		}
	}
}

