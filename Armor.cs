using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {
	private string armorName;
	private int damage;
	private int type;

	public Armor(){
		this.name = null;
		this.damage = 0;
		this.type = 0;
	}

	public Armor(string name, int damage, int type){
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
		this.armorName = addName;
	}

	public int getDamage(){
		return damage;	
	}

	public int getType(){
		return type;
	}

	public string getName(){
		return armorName;
	}
}
