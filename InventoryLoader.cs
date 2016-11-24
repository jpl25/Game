using UnityEngine;
using System.Collections;


namespace DungeonExplorer{
	public class InventoryLoader{
		private static int characterClass;
		private Weapons wep;
		private Armor armor;
		private Spells spell;
		private Item item;
		private static Inventory inventory = new Inventory();

		public Inventory getInventory(){
			return inventory;
		}

		public void setCharacterClass(int cClass){
			characterClass = cClass;
			preloadInventory (cClass);
		}

		//This is the method that loads the invenory when the game is started.
		public void preloadInventory(int cClass){
			if (cClass == 1) {
				wep = new Weapons ("Rusty Sword", 4, 0, 1);
				armor = new Armor ("Rusty lite armor", 2, 2);
				addWeapon (wep);
				addArmor (armor);

			} else if (cClass == 2) {
				wep = new Weapons ("Broken Mage Staff", 3, 3, 1);
				armor = new Armor ("Tattered robe", 0, 2);
				addWeapon (wep);
				addArmor (armor);
			} else if (cClass == 3) {
				wep = new Weapons ("Crappy Dager", 1, 0, 1);
				armor = new Armor ("Riped Shirt", 3, 5);
				addWeapon (wep);
				addArmor (armor);
			}
		}

		public void addWeapon(Weapons addWeapon){
			int weaponType = addWeapon.getType();
			double weaponDamage = addWeapon.getDamage ();
			if (characterClass == 1) {
				if (weaponType == 1) {
					addWeapon.setDamage ((weaponDamage *  .50) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 2) {
					addWeapon.setDamage ((weaponDamage *  .10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 3) {
					addWeapon.setDamage ((weaponDamage * -.45) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 4) {
					addWeapon.setDamage ((weaponDamage *  .05) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 5) {
					addWeapon.setDamage ((weaponDamage *  .10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				}
			} else if (characterClass == 2) {
				if (weaponType == 1) {
					addWeapon.setDamage ((weaponDamage * -.30) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 2) {
					addWeapon.setDamage ((weaponDamage * -.10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 3) {
					addWeapon.setDamage ((weaponDamage *  .55) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 4) {
					addWeapon.setDamage ((weaponDamage *  .10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 5) {
					addWeapon.setDamage ((weaponDamage *  .40) + weaponDamage);
					inventory.setWeapon (addWeapon);
				}
			} else if (characterClass == 3) {
				if (weaponType == 1) {
					addWeapon.setDamage ((weaponDamage *  .10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 2) {
					addWeapon.setDamage ((weaponDamage *  .30) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 3) {
					addWeapon.setDamage ((weaponDamage * -.30) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 4) {
					addWeapon.setDamage ((weaponDamage *  .30) + weaponDamage);
					inventory.setWeapon (addWeapon);
				} else if (weaponType == 5) {
					addWeapon.setDamage ((weaponDamage *  .10) + weaponDamage);
					inventory.setWeapon (addWeapon);
				}

			}
		}

		//Method to add armor, check character class, and adjust damage for each class.
		public void addArmor(Armor addArmor){
			int armorType = addArmor.getType();
			double armorDamage = addArmor.getDamage ();
			if (characterClass == 1) {
				if (armorType == 1) {
					addArmor.setDamage ((armorDamage *  .40) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 2) {
					addArmor.setDamage ((armorDamage *  .40) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 3) {
					addArmor.setDamage ((armorDamage *  .15) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 4) {
					addArmor.setDamage ((armorDamage * -.60) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 5) {
					addArmor.setDamage ((armorDamage * -.45) + armorDamage);
					inventory.setArmor (addArmor);
				}
			} else if (characterClass == 2) {
				if (armorType == 1) {
					addArmor.setDamage ((armorDamage * -.50) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 2) {
					addArmor.setDamage ((armorDamage * -.30) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 3) {
					addArmor.setDamage ((armorDamage * -.15) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 4) {
					addArmor.setDamage ((armorDamage *  .50) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 5) {
					addArmor.setDamage ((armorDamage *  .05) + armorDamage);
					inventory.setArmor (addArmor);
				}
			} else if (characterClass == 3) {
				if (armorType == 1) {
					addArmor.setDamage ((armorDamage *  .05) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 2) {
					addArmor.setDamage ((armorDamage *  .10) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 3) {
					addArmor.setDamage ((armorDamage *  .15) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 4) {
					addArmor.setDamage ((armorDamage * -.20) + armorDamage);
					inventory.setArmor (addArmor);
				} else if (armorType == 5) {
					addArmor.setDamage ((armorDamage *  .55) + armorDamage);
					inventory.setArmor (addArmor);
				}
			}

		}

		public void addSpell(Spells addSpell){
			inventory.setSpell (addSpell);
		}

		public void addItem(Item addItem){
			inventory.setItem (addItem);
		}

	}
}

