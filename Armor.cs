using UnityEngine;
using System.Collections;

namespace DungeonExplorer{
	
	public class Armor{
		private string armorName;
		private double damage;
		private int type;

		public Armor(){
			this.armorName = null;
			this.damage = 0;
			this.type = 0;
		}

		public Armor(string name, double damage, int type){
			this.setName (name);
			this.setDamage(damage);
			this.setType(type);

		}

		public void setDamage(double updateDamage){
			this.damage = updateDamage;	
		}

		public void setType(int updateType){
			this.type = updateType;	
		}
			

		public void setName(string addName){
			this.armorName = addName;
		}

		public double getDamage(){
			return damage;	
		}

		public int getType(){
			return type;
		}

		public string getName(){
			return armorName;
		}
		public override string ToString(){
			return armorName;
		}
	}
}