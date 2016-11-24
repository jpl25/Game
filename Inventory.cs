using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace DungeonExplorer{
	
	public class Inventory{
		Dictionary<int, Weapons> newWeapon = new Dictionary<int, Weapons> ();
		Dictionary<int, Armor> newArmor = new Dictionary<int, Armor> ();
		Dictionary<int, Item> newItem = new Dictionary<int, Item> ();
		Dictionary<int, Spells> newSpell = new Dictionary<int, Spells> ();
		static int armorCnt = 1, wepCnt = 1, itemCnt = 1, spellCnt =1;

		public Inventory(){
		}

		public Inventory(Weapons wep, Armor armor){
			this.setWeapon (wep);
			this.setArmor (armor);
		}

		public void setArmor(Armor armor){
			newArmor.Add(armorCnt , armor);
			armorCnt++;
		}

		public void setWeapon(Weapons weapon){
			newWeapon.Add(wepCnt, weapon);
			wepCnt++;
		}

		public void setItem(Item item){
			newItem.Add(itemCnt, item);
			itemCnt++;
		}

		public void setSpell(Spells spell){
			newSpell.Add(spellCnt, spell);
			spellCnt++;
		}

		public Armor getArmor(int armor){
			if (!newArmor.ContainsKey (armor)) {
				Debug.Log ("You do not have armor in that slot.");
			} else {return newArmor [armor];}
			return null;
		}

		public Weapons getWeapon(int weapon){
			if (!newWeapon.ContainsKey (weapon)) {
				Debug.Log ("You do not have a weapon in that slot.");
			} else {return newWeapon [weapon];}
			return null;
		}

		public Item getItem(int item){
			if (!newItem.ContainsKey (item)) {
				Debug.Log ("You do not have an item in that slot.");
			} else {return newItem [item];}
			return null;
		}

		public Spells getSpells(int spell){
			if (!newSpell.ContainsKey (spell)) {
				Debug.Log ("You do not have a spell in that slot.");
			} else {return newSpell [spell];}
			return null;
		}

		public void displayInventory(){
			foreach (KeyValuePair<int, Weapons> kv in newWeapon) {
				Debug.Log("WEAPONS");
				Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () + " " +kv.Value.getDamage()); 
			}

			foreach (KeyValuePair<int, Armor> kv in newArmor) {
				Debug.Log("ARMOR");
				Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () + " " + kv.Value.getDamage()); 
			}

			if (newItem != null) {
				Debug.Log("ITEMS");
				foreach (KeyValuePair<int, Item> kv in newItem) {
					Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString () ); 
				}
			}
			if (newSpell != null) {
				Debug.Log("SPELLS");
				foreach (KeyValuePair<int, Spells> kv in newSpell) {
					Debug.Log(kv.Key.ToString() + " " + kv.Value.ToString ()  ); 
				}
			}
		}

	}
}