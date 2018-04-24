using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class RoomManager : MonoBehaviour {

	// Changes scene
	public void loadRoom(string room)
	{
		SceneManager.LoadScene (room);
	}
}
