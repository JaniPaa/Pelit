using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

	public List<Item> inventory = new List<Item> ();

	public void AddItem(Item item)
	{
		this.inventory.Add (item);
	}

	public string GetInventoryList()
	{
		string temp = " Inventory:";
		foreach (Item item in this.inventory) {
			temp += "\n - " + item.ItemName;
		}
		return temp;
 	}
	public void RemoveItem(Item item)
	{
		this.inventory.Remove (item);
	}
}
