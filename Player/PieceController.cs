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
	Item crowbarItem;
	Text textPlayerInventory;
	List<Item> door = new List<Item>();
	Text textNextLevel;
	Text textGameOver;
	Text textKeyFound;
	RoomManager roomer;
	public static bool openDoor = false;
	Room rooms;
	Room kitchen;
	public static string currentLevel = "Cell";
	TextTimer tTimer;

	// Checks if the door has been opened
	public bool checkDoorOpen()
	{
		openDoor = true;
		return openDoor;
	}
	// If the player dies, the door is closed again
	public bool resetDoor()
	{
		openDoor = false;
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
			tTimer.itemFound ("Cell Key");
			tTimer.itemMessage ();
			textKeyFound.text = "Cell Key";
		}
		if (other.gameObject.CompareTag ("Crowbar")) {
			other.gameObject.SetActive (false);
			inventory.AddItem (crowbarItem);
			textPlayerInventory.text = inventory.GetInventoryList ();
			door.Add (crowbarItem);
		}
		// If player comes in contact with cell door with cell key in his inventory, the door will open and inventory will be refreshed and the enemies wake up
		if(other.gameObject.CompareTag("CellDoor") && door.Contains(keyItem)){
			other.gameObject.SetActive (false);
			door.Remove (keyItem);
			inventory.RemoveItem (keyItem);
			textPlayerInventory.text = inventory.GetInventoryList ();
			checkDoorOpen ();

		}
		// If player touches door in the wall, Room2 loads
		if(other.gameObject.CompareTag("Level")){
			resetDoor ();
			roomer.getCurrentLevel ("Hallway");
			textNextLevel.text = currentLevel;
			roomer.loadRoom ("CEV3Scene 1");

		}
		// If player is hit by enemy, it calls gameover method and the room restarts
		if (other.gameObject.CompareTag ("Enemy")) {
			other.gameObject.SetActive (false);
			textGameOver.text = endGame ();
			roomer.resetLevel ();
			resetDoor ();

		}
		// Loads level 3 when player hits door with crowbar in his inventory
		if (other.gameObject.CompareTag ("Level3") && door.Contains(crowbarItem)) {
			roomer.getCurrentLevel ("Kitchen");
			textNextLevel.text = currentLevel;
			roomer.loadRoom ("CEV3Scene 2");
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
		crowbarItem = new Item ("Crowbar");
		textGameOver = GameObject.Find ("TextGameOver").GetComponent<Text> ();
		textNextLevel = GameObject.Find ("TextLevel").GetComponent<Text> ();
		rooms = new Room ("Hallway");
		kitchen = new Room ("Kitchen");
		textNextLevel.text = currentLevel;
		textKeyFound = GameObject.Find ("TextItemFound").GetComponent<Text> ();
	}
	// Displays "Game Over!" message
	public string endGame()
	{
		string end = "You Died!";
		return end;
	}
}