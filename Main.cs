using UnityEngine;
using System.Collections;
using UnityEditor;

namespace DungeonExplorer{
public class Main : MonoBehaviour {

		public int characterClass, randomNumber;
		public InventoryLoader loadInventory = new InventoryLoader();
		public RandomLoot randLoot = new RandomLoot();
		public GetInventoryItem getInventoryItem = new GetInventoryItem();
		private Weapons wep;
		private Armor armor;
		private Spells spell;
		private Item item;



	// Use this for initialization
	void Start () {
			
			// Auto load the inventory
			loadInventory.setCharacterClass (1);
			wep = getInventoryItem.selectWeaponItem (1);
			armor = getInventoryItem.selectArmorItem (1);
			item = getInventoryItem.selectItemItem (1);
			spell = getInventoryItem.selectSpellItem (1);
			Debug.Log (wep.getName());
			Debug.Log (armor.getName());
			Debug.Log (item.getName());
			Debug.Log (spell.getName());
			Debug.Log("SHIT");
		}

	// Update is called once per frame
	void FixedUpdate () {
			
			/*This is intended to create a random number each time the character moves. if the number
			is 5 the random item selection will start prompting the user to select a item between 
			a list of five items */
			randomNumber = Random.Range (0, 10);
			if (randomNumber == 5) {
				randLoot.randomItemSelection ();
			}

	}


	
}



}