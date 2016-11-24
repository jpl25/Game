using UnityEngine;
using System.Collections;

namespace DungeonExplorer{
	
	public class Item{
		private string itemName;
		private int type;

		public Item(){
			this.itemName = null;
			this.type = 0;
		}

		public Item(string name, int type){
			this.setName (name);
			this.setType(type);
		}

		public void setType(int updateType){
			this.type = updateType;	
		}

		public void setName(string addName){
			this.itemName = addName;
		}
				
		public int getWeight(){
			return type;	
		}

		public string getName(){
			return itemName;
		}

		public override string ToString(){
			return itemName;
		}
	}
}