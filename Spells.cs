﻿using UnityEngine;
using System.Collections;

namespace DungeonExplorer{
	
	public class Spells{
		private string spellName;
		private int damage;
		private int type;

		public Spells(){
			this.spellName = null;
			this.damage = 0;
			this.type = 0;
		}

		public Spells(string name, int damage, int type){
			this.setName (name);
			this.setDamage(damage);
			this.setType(type);
		}

		public void setDamage(int updateDamage){
			this.damage = updateDamage;	
		}
			

		public void setType(int updateType){
			this.type = updateType;	
		}

		public void setName(string addName){
			this.spellName = addName;
		}

		public int getDamage(){
			return damage;	
		}

		public int getWeight(){
			return type;	
		}

		public string getName(){
			return spellName;
		}
		public override string ToString(){
			return spellName;
		}

}
}
