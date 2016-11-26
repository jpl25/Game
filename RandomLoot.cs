using UnityEngine;
using System.Collections;


namespace DungeonExplorer{
	public class RandomLoot{
	private  InventoryLoader loadInventory = new InventoryLoader ();
	private string [] itemSelectionList = new string[10];

		public RandomLoot(){

				itemSelectionList[0] = " Sword, 15, 0, 1 \n" +
				                       " Broken Dagger, 1, 0, 2 \n" +
				                       " Shock Spell, 15, 0, 1 \n" +
				                       " Lightning Spell, 15, 0, 1 \n" +
				                       " Sword, 5, 0, 1 \n";
			   
				itemSelectionList[1] = " Old Knive, 15, 0, 2 \n" +
					                   " Shock Spell, 85, 5 \n" +
					                   " Sword, 15, 0, 1 \n" +
					                   " Elven Heavy Armor, 35, 1 \n" +
					                   " Damaged Heavy Armor, 15, 1 \n";
				
				itemSelectionList[2] = " WindWalker Heavy Armor, 25, 1 \n" +
					                   " Sword of The Gods, 55, 0, 1 \n" +
					                   " Great Sword, 25, 3, 1 \n" +
					                   " Light Armor, 15, 3 \n" +
					                   " Golden Heavy Armor, 25, 1 \n";
				
				itemSelectionList[3] = " Healing Spell, 85, 5 \n" +
					                   " Old Dwarf Sword, 5, 0, 1 \n" +
					                   " Thunder Sword, 35, 10, 1 \n" +
					                   " Guard Heavy Armor, 15, 1 \n" +
					                   " Master Key, 1 \n";
			
				itemSelectionList[4] = " Healing Spell, 85, 5 \n" +
					                   " Light Sword, 25, 5, 1 \n" +
					                   " Broken Sword, 1, 0, 1 \n" +
					                   " Heavy Armor, 55, 1 \n" +
					                   " Master Key, 1 \n";
			
				itemSelectionList[5] = " Healing Spell, 85, 5 \n" +
					                   " Book, 3 \n" +
					                   " Sword, 25, 8, 1 \n" +
					                   " Damaged Heavy Armor, 15, 1 \n" +
					                   " Iron Ore, 3 \n";
			
				itemSelectionList[6] = " Rain Spell, 25, 5 \n" +
					                   " Glowing Sword, 45, 5, 1 \n" +
					                   " Sack of rocks, 3 \n" +
					                   " Damaged light Armor, 10, 3 \n" +
					                   " Key, 2 \n";
			
				itemSelectionList[7] = " Door Key, 1 \n" +
					                   " Bread, 3 \n" +
					                   " Sword, 15, 0, 1 \n" +
					                   " Damaged medium Armor, 20, 2 \n" +
					                   " Healing Spell, 85, 5 \n";
			
				itemSelectionList[8] = " Undead Spell, 185, 5 \n" +
					                   " Iron Great Sword, 35, 0, 1 \n" +
					                   " Magic Dagger, 25, 44, 2 \n" +
					                   " Damaged Heavy Armor, 15, 1 \n" +
					                   " Apple, 3 \n";
			
				itemSelectionList[9] = " Healing Spell, 85, 5 \n" +
					                   " Duel Knive, 15, 0, 2 \n" +
					                   " THE GOLDEN GREAT SWORD, 150, 0, 1 \n" +
					                   " Elven Medium Armor, 15, 2 \n" +
					                   " Rag Weed, 3 \n";
			}

		public string getRandomItemList(int randomNum){
			if (randomNum == 1) {
				return itemSelectionList [0];
			} else if (randomNum == 2) {
				return itemSelectionList [1];
			} else if (randomNum == 3) {
				return itemSelectionList [2];
			} else if (randomNum == 4) {
				return itemSelectionList [3];
			} else if (randomNum == 5) {
				return itemSelectionList [4];
			} else if (randomNum == 6) {
				return itemSelectionList [5];
			} else if (randomNum == 7) {
				return itemSelectionList [6];
			} else if (randomNum == 8) {
				return itemSelectionList [7];
			} else if (randomNum == 9) {
				return itemSelectionList [8];
			} else if (randomNum == 10) {
				return itemSelectionList [9];
			}
			return null;
		}
				
		public void randomItemSelection(int num, int selectItem){
			if (num == 1) {	
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Shock Spell", 85, 5));

					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Broken Dagger", 15, 0, 2));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addSpell(new Spells("Lightning Spell", 25, 5));
					break;
				case 1:
					loadInventory.addWeapon(new Weapons("Bent Sword", 5, 3, 1));
					break;
				}
			} else if (num == 2) {
				switch (selectItem) {
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
				switch (selectItem) {
				case 5:
					loadInventory.addArmor(new Armor("WindWalker Heavy Armor", 25, 1));
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
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Old Dwarf Sword", 5, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Thunder Sword", 35, 10, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Guard Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Master Key", 1));
					break;
				}
			} else if (num == 5) {
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Light Sword", 25, 5, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Broken Sword", 1, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Heavy Armor", 55, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Key", 1));
					break;
				}
			} else if (num == 6) {
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addItem(new Item("Book", 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 25, 8, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Iron Ore", 1));
					break;
				}
			} else if (num == 7) {
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Rain Spell", 25, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Glowing Sword", 45, 5, 1));
					break;
				case 3:
					loadInventory.addItem(new Item("Sack of rocks",1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged light Armor", 10, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Key", 1));
					break;
				}
			} else if (num == 8) {
				switch (selectItem) {
				case 5:
					loadInventory.addItem(new Item("Door Key", 1));
					break;
				case 4:
					loadInventory.addItem(new Item("Bread", 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Sword", 15, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged medium Armor", 20, 1));
					break;
				case 1:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				}
			} else if (num == 9) {
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Undead Spell", 185, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Iron Great Sword", 35, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("Magic Dagger", 25, 44, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Damaged Heavy Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Apple", 1));
					break;
				}
			} else if (num == 10) {
				switch (selectItem) {
				case 5:
					loadInventory.addSpell(new Spells("Healing Spell", 85, 5));
					break;
				case 4:
					loadInventory.addWeapon(new Weapons("Duel Knive", 35, 0, 1));
					break;
				case 3:
					loadInventory.addWeapon(new Weapons("THE GOLDEN GREAT SWORD", 150, 0, 1));
					break;
				case 2:
					loadInventory.addArmor(new Armor("Elven Medium Armor", 15, 1));
					break;
				case 1:
					loadInventory.addItem(new Item("Rag Weed", 1));
					break;
				}
			}
		}
	}
}

