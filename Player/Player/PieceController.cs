using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PieceController : MonoBehaviour{

	public float pieceSpeed = 1;
	private bool onCollision = false;
	Inventory inventory;
	Item keyItem;
	Text textPlayerInventory;
	List<Item> door = new List<Item>();
	Text textNextLevel;
	Text textGameOver;
	RoomManager roomer;
	public bool openDoor = true;

	public bool checkDoorOpen()
	{
		openDoor = true;
		return openDoor;
	}

	// Collisions with different objects are detected. Tag indicates what object has been hit
	void OnCollisionEnter2D (Collision2D other)
	{
		// If player comes in contact with an item tagged as "key", it will be added to his inventory
		// and the item will dissapear from the map.
		if (other.gameObject.CompareTag ("Key")) {
			other.gameObject.SetActive (false);
			inventory.AddItem (keyItem);
			textPlayerInventory.text = inventory.GetInventoryList ();
			door.Add (keyItem);
		}
		// If player comes in contact with cell door with cell key in his inventory, the door will open and inventory will be refreshed
		if(other.gameObject.CompareTag("CellDoor") && door.Contains(keyItem)){
			other.gameObject.SetActive (false);
			door.Remove (keyItem);
			inventory.RemoveItem (keyItem);
			textPlayerInventory.text = inventory.GetInventoryList ();
			checkDoorOpen ();

		}
		// If player touches door in the wall, Room2 loads
		if(other.gameObject.CompareTag("Level")){
			roomer.loadRoom ("Room2");
		}
		// If player is hit by enemy, it calls gameover method and the room restarts
		if (other.gameObject.CompareTag ("Enemy")) {
			other.gameObject.SetActive (false);
			textGameOver.text = endGame ();
			Application.LoadLevel (Application.loadedLevel);
		}
	}
		
	// Moves the player according to the direction that it's getting
	public void Move (string dir)
	{
		if (!onCollision) {
			if (dir == "right") {
				transform.Translate (pieceSpeed * 0.05f, 0, 0);
			}
			if (dir == "left") {
				transform.Translate (pieceSpeed * -0.05f, 0, 0);
			}
			if (dir == "up") {
				transform.Translate (pieceSpeed * 0, 0.05f, 0);
			}
			if (dir == "down") {
				transform.Translate (pieceSpeed * 0, -0.05f, 0);
			}
		}
	}


	// Use this for initialization
	void Start ()
	{
		roomer = new RoomManager ();
		textPlayerInventory = GameObject.Find ("TextPlayerInventory").GetComponent<Text> ();
		textPlayerInventory.text = (" Inventory: " + "\n - Empty -");
		inventory = new Inventory();
		keyItem = new Item ("Cell Key");
		textGameOver = GameObject.Find ("TextGameOver").GetComponent<Text> ();
	}
	// Displays "Game Over!" message
	public string endGame()
	{
		string end = "Game Over!";
		return end;
	}
}