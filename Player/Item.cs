using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

	private string itemName;



	public string ItemName 
	{

		get 
		{
			return itemName;
		}

		set 
		{
			this.itemName = value;
		}
	}

	public Item(string itemName)
	{
		ItemName = itemName;
	}

	public Item()
	{
		ItemName = "Not found";
	}
}
