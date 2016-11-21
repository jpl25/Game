using UnityEngine;
using System.Collections;

public class Weapons : MonoBehaviour {
	private string weaponName;
	private int damage;
	private int enchantment;
	private int type;

	public Weapons(){
		this.name = null;
		this.damage = 0;
		this.enchantment = 0;
		this.type = 0;
	}

	public Weapons(string name, int damage, int enchantment, int type){
		this.setName (name);
		this.setDamage(damage);
		this.setEnchantment(enchantment);
		this.setType(type);
	}

	public void setDamage(int updateDamage){
		this.damage = updateDamage;	
	}

	public void setEnchantment(int updateEnchatment){
		this.enchantment = updateEnchatment;	
	}

	public void setType(int updateType){
		this.type = updateType;	
	}

	public void setName(string addName){
		this.name = addName;
	}

	public int getDamage(){
		return damage;	
	}

	public int getEnchantment(){
		return enchantment;
	}

	public int getWeight(){
		return type;	
	}

	public string getName(){
		return name;
	}

}