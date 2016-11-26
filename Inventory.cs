using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace DungeonExplorer{
	
	public class Inventory{
		Dictionary<int, Weapons> weapon = new Dictionary<int, Weapons> ();
		Dictionary<int, Armor> armor = new Dictionary<int, Armor> ();
		Dictionary<int, Item> item = new Dictionary<int, Item> ();
		Dictionary<int, Spells> spell = new Dictionary<int, Spells> ();
		static int armorCnt = 1, wepCnt = 1, itemCnt = 1, spellCnt =1;

		public Inventory(){
		}

		public Inventory(Weapons wep, Armor armor){
			this.setWeapon (wep);
			this.setArmor (armor);
		}

		public void setArmor(Armor newArmor){
			armor.Add(armorCnt , newArmor);
			armorCnt++;
		}

		public void setWeapon(Weapons newWeapon){
			weapon.Add(wepCnt, newWeapon);
			wepCnt++;
		}

		public void setItem(Item newItem){
			item.Add(itemCnt, newItem);
			itemCnt++;
		}

		public void setSpell(Spells newSpell){
			spell.Add(spellCnt, newSpell);
			spellCnt++;
		}

		public Dictionary <int,Weapons> getWeapon(){
			return weapon;
		}

		public Dictionary <int,Armor> getArmor(){
			return armor;
		}

		public Dictionary <int,Item> getItems(){
			return item;
		}

		public Dictionary <int,Spells> getSpells(){
			return spell;
		}

		public Armor selectArmor(int armorSelection){
			if (!armor.ContainsKey (armorSelection)) {
				Debug.Log ("You do not have armor in that slot.");
			} else {return armor [armorSelection];}
			return null;
		}

		public Weapons selectWeapon(int weaponSelection){
			if (!weapon.ContainsKey (weaponSelection)) {
				Debug.Log ("You do not have a weapon in that slot.");
			} else {return weapon [weaponSelection];}
			return null;
		}

		public Item selectItem(int itemSelection){
			if (!item.ContainsKey (itemSelection)) {
				Debug.Log ("You do not have an item in that slot.");
			} else {return item [itemSelection];}
			return null;
		}

		public Spells selectSpells(int spellSelection){
			if (!spell.ContainsKey (spellSelection)) {
				Debug.Log ("You do not have a spell in that slot.");
			} else {return spell [spellSelection];}
			return null;
		}
			
	}
}