using UnityEngine;
using System.Collections;


namespace DungeonExplorer
{
	public class GetInventoryItem{
		private InventoryLoader inventory = new InventoryLoader();
		private Weapons wep;
		private Armor armor;
		private Item item;
		private Spells spell;

		public Weapons selectWeaponItem(int itemSlot){
			return inventory.getInventory ().selectWeapon (itemSlot);
		}

		public Armor selectArmorItem(int itemSlot){
			return inventory.getInventory ().selectArmor (itemSlot);
		}

		public Item selectItemItem(int itemSlot){
			return inventory.getInventory ().selectItem (itemSlot);
		}

		public Spells selectSpellItem(int itemSlot){
			return inventory.getInventory ().selectSpells (itemSlot);
		}
	}
}

