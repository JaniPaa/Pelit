using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour {

	private string roomName;

	public string RoomName
	{
		get
		{
			return roomName;
		}
		set
		{
			this.roomName = value;
		}
		
	}

	public Room (string roomName)
	{
		RoomName = roomName;
	}
	public Room ()
	{
		RoomName = "Cell";
	}

}
