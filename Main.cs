using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.UI;

namespace DungeonExplorer{
public class Main : MonoBehaviour {

		public int characterClass, ranNum;
		Dictionary<int, Weapons> weaponList = new Dictionary<int, Weapons> ();
		Dictionary<int, Armor> armorList = new Dictionary<int, Armor> ();
		Dictionary<int, Item> itemList = new Dictionary<int, Item> ();
		Dictionary<int, Spells> spellList = new Dictionary<int, Spells> ();
		public InventoryLoader loadInventory = new InventoryLoader();
		public GetInventoryItem getInventoryItem = new GetInventoryItem();
		private RandomLoot loot = new RandomLoot ();
		private Weapons wep;
		private Armor armor;
		private Spells spell;
		private Item item;

		public Text LootTextBody;


	// Use this for initialization
	void Start () {
			
			//ask for character class

			//This is just just to generate a character for testing
			int randomCharacterClass = Random.Range (1, 3);
			characterClass = randomCharacterClass;

			if (characterClass == 1) {
				Debug.Log ("You Are A Warrior!");

			}
			if (characterClass == 2) {
				Debug.Log ("You Are A Mage!");
			} 
			if (characterClass == 3) {
				Debug.Log ("You Are A Rouge!");
			}

			// Auto load the inventory
			loadInventory.setCharacterClass (randomCharacterClass);



			//This generates the random number for random loot encounter 
			//this is just for testing this will be in the fixed update method 
			//we will have a range from 1 to 1000 with 500 being the number that 
			// the random number will have to land on to prompt the random loot 
		

			//Debug.Log(loot.getRandomItemList (ranNum));
			//string l = loot.getRandomItemList (ranNum);


		
			//Display all items in inventory
			//displayInventoryItems ();

			//Select an Item out of an inventory slot
			selectItem(1);
			selectSpell (1);
			selectWeapon (1);
			selectArmor (1);

	}


	// Update is called once per frame
	void Update () {
			/*This is intended to create a random number each time the character moves. if the number
			is 5 the random item selection will start prompting the user to select a item between 
			a list of five items */
			int ranNum1 = Random.Range (1, 10);
			int ranNum2 = Random.Range (1, 5);
			//this selects the propper switch case and select an item. the second
			//argument will be somthing that is inserted depending on a button 
			//the button numbers will be between 1 and 5 when the item is selected
			//this metod will run and the value for the second argument will be inserted.
			int randomNum = Random.Range (0, 5000);
			if (randomNum == 1500) {
				//Prints out random list of items for selection
				Debug.Log(loot.getRandomItemList (ranNum1));
				loot.randomItemSelection (ranNum1,ranNum2);
				displayInventoryItems();
			}

		}

		public void lootButtonSelection(int value){
			
			loot.randomItemSelection (ranNum, Random.Range (1, value));

		}

		//Spell selection method. loads the spell varable with the spell item
		public void selectSpell(int slotNum){
			spell = getInventoryItem.selectSpellItem (slotNum);
			if (spell != null) {Debug.Log ("You Selected: " + spell.getName () + " " + spell.getDamage ());}
		}

		//Weapon selection method. Loads the weapon varable withe the weapon item
		public void selectWeapon(int slotNum){
			wep = getInventoryItem.selectWeaponItem (slotNum);
			if (wep != null) {Debug.Log ("You Selected: " + wep.getName () + " " + wep.getDamage ());}
		}

		//Armor selection method. Loads the armor varable withe the armor item
		public void selectArmor(int slotNum){
			armor = getInventoryItem.selectArmorItem (slotNum);
			if (armor != null) {Debug.Log ("You Selected: " + armor.getName () + " " + armor.getDamage ());}
		}

		//Item selection method. Loads the item varable withe the  item
		public void selectItem(int slotNum){
			item = getInventoryItem.selectItemItem (slotNum);
			if (item != null) {Debug.Log ("You Selected: " + item.getName ());}
		}

		//Display items in main, and load varables to use in gui
		public void displayInventoryItems(){
			weaponList = loadInventory.getInventory ().getWeapon ();
			armorList = loadInventory.getInventory ().getArmor ();
			itemList = loadInventory.getInventory ().getItems ();
			spellList = loadInventory.getInventory ().getSpells ();
			foreach (KeyValuePair<int, Weapons> kv in weaponList) {
				Debug.Log("WEAPONS: Name,   Damage,  Enchantment");
				Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () + " " +kv.Value.getDamage() + " " + kv.Value.getEnchantment()); 
			}
			foreach (KeyValuePair<int, Armor> kv in armorList) {
				Debug.Log("ARMOR: Name,   Strength");
				Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () + " " + kv.Value.getDamage()); 
			}

			if (itemList != null) {
				
				foreach (KeyValuePair<int, Item> kv in itemList) {
					Debug.Log("ITEMS: Name");
					Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () ); 
				}
			}
			if (spellList != null) {
				Debug.Log("SPELLS: Name");
				foreach (KeyValuePair<int, Spells> kv in spellList) {
					Debug.Log("SPELLS: Name");
					Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString ()  ); 
				}
			}
		}

	
	}
}

