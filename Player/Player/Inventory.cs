using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

	public List<Item> inventory = new List<Item> ();

	// Adds item to the inventory
	public void AddItem(Item item)
	{
		this.inventory.Add (item);
	}

	// Lists all the items in inventory and constructs the inventory output
	public string GetInventoryList()
	{
		string temp = " Inventory:";
		foreach (Item item in this.inventory) {
			temp += "\n - " + item.ItemName;
		}
		return temp;
 	}

	// Removes item from the inventory
	public void RemoveItem(Item item)
	{
		this.inventory.Remove (item);
	}
		
}
