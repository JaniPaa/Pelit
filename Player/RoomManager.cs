using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class RoomManager : MonoBehaviour{

	// Changes scene
	public void loadRoom(string room)
	{
		//loads a scene, what it receives as a parameter
		SceneManager.LoadScene (room);
	}

	public string getCurrentLevel(string lvl)
	{
		//Displays current level player is on
		PieceController.currentLevel = lvl;

		return lvl;
	}

	public void resetLevel()
	{
		// Resets the level
		Application.LoadLevel (Application.loadedLevel);
	}


}
