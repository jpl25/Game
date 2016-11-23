using UnityEngine;
using System.Collections;
using UnityEditor;

namespace DungeonExplorer
{
	public class GetInventoryItem{
		private InventoryLoader inventory = new InventoryLoader();
		private Weapons wep;
		private Armor armor;
		private Item item;
		private Spells spell;

		public Weapons selectWeaponItem(int itemSlot){
			return inventory.getInventory ().getWeapon (itemSlot);
		}

		public Armor selectArmorItem(int itemSlot){
			return inventory.getInventory ().getArmor (itemSlot);
		}

		public Item selectItemItem(int itemSlot){
			return inventory.getInventory ().getItem (itemSlot);
		}

		public Spells selectSpellItem(int itemSlot){
			return inventory.getInventory ().getSpells (itemSlot);
		}
	}
}

