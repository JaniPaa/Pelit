using System.Collections;
using System.Collections.Generic;

public class Room{

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
