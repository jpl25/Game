using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace GAME{
public class Inventory : MonoBehaviour {
	Dictionary<int, Weapons> newWeapon = new Dictionary<int, Weapons> ();
	Dictionary<int, Armor> newArmor = new Dictionary<int, Armor> ();
	Dictionary<int, Item> newItem = new Dictionary<int, Item> ();
	Dictionary<int, Spells> newSpell = new Dictionary<int, Spells> ();
	static int armorCnt, wepCnt, itemCnt, spellCnt = 0;


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
		return newArmor[armor];
	}

	public Weapons getWeapon(int weapon){
		return newWeapon[weapon];
	}

	public Item getItem(int item){
		return newItem[item];
	}

	public Spells getSpells(int spell){
		return newSpell[spell];
	}

	public void displayInventory(){
		for (int i = 0; i <= 50; i++) {
			Debug.Log (newWeapon [i]);
			Debug.Log (newItem [i]);
			Debug.Log (newArmor [i]);
			Debug.Log (newSpell [i]);
		}
	}

}
}