using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class RoomManager : PieceController {

	// Changes scene
	public void loadRoom(string room)
	{
		SceneManager.LoadScene (room);
	}

	public string getCurrentLevel(string lvl)
	{
		PieceController.currentLevel = lvl;

		return lvl;
	}

	public void resetLevel()
	{
		Application.LoadLevel (Application.loadedLevel);
	}


}
