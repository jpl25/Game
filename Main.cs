using UnityEngine;
using System.Collections;
using UnityEditor;


namespace DungeonExplorer{
public class Main : MonoBehaviour {

		public int characterClass, randomNumber;
		public InventoryLoader loadInventory = new InventoryLoader();
		public RandomLoot randLoot = new RandomLoot();
		public GetInventoryItem getInventoryItem = new GetInventoryItem();
		RandomLoot loot = new RandomLoot ();
		private Weapons wep;
		private Armor armor;
		private Spells spell;
		private Item item;


	// Use this for initialization
	void Start () {
			
		//ask for c class
		// Auto load the inventory
		loadInventory.setCharacterClass (1);
		//loot.randomItemSelection (Random.Range (1, 10));
		
		//Get Select Inventory.
		//wep = getInventoryItem.selectWeaponItem (2);
		if(wep != null){
			//Debug.Log (wep.getName () + " " + wep.getDamage ());
		}	

		
		loadInventory.getInventory().displayInventory();
	}

	// Update is called once per frame
	void FixedUpdate () {
			/*This is intended to create a random number each time the character moves. if the number
			is 5 the random item selection will start prompting the user to select a item between 
			a list of five items */
			randomNumber = Random.Range (0, 1000);
			if (randomNumber == 500) {
				loot.randomItemSelection (Random.Range (0, 10));
				loadInventory.getInventory().displayInventory();
			}

		}


	
}



}