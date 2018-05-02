using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {

	public List<Item> inventory = new List<Item> ();


	public void AddItem(Item item)
	{
		// Adds item to the inventory
		this.inventory.Add (item);
	}


	public string GetInventoryList()
	{
		// Lists all the items in inventory and constructs the inventory output
		string temp = " Inventory:";
		foreach (Item item in this.inventory) {
			temp += "\n - " + item.ItemName;
		}
		return temp;
 	}


	public void RemoveItem(Item item)
	{
		// Removes item from the inventory
		this.inventory.Remove (item);
	}
		
}
