using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

	private string room;

	private Room ()
	{
		this.room = "Cell";
	}

	public void getRoom(string currentRoom)
	{
		this.room = currentRoom;
	}


}
