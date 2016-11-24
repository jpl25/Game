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

			wep = getInventoryItem.selectWeaponItem (2);
			Debug.Log (wep.getName());


			loot.randomItemSelection ();
			loadInventory.getInventory().displayInventory();

		}

	// Update is called once per frame
	void FixedUpdate () {
			/*This is intended to create a random number each time the character moves. if the number
			is 5 the random item selection will start prompting the user to select a item between 
			a list of five items */
			randomNumber = Random.Range (0, 10);
			/*if (randomNumber == 5) {
				loot.randomItemSelection ();
			}
			loadInventory.getInventory().displayInventory();
*/

	}


	
}



}