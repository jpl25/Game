using UnityEngine;
using System.Collections;

namespace DungeonExplorer{
	
	public class Item : MonoBehaviour{
		private string itemName;
		private int type;

		public Item(){
			this.name = null;
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
		public void toString(){
			Debug.Log (name);
		}
	}
}