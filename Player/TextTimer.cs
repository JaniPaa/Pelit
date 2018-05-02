using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour {

	Text textKeyFound;
	public float time = 3;
	public static string found;

	IEnumerator Start ()
	{
		textKeyFound = GameObject.Find ("TextKeyFound").GetComponent<Text> ();
		yield return new WaitForSeconds (time);
		Destroy (textKeyFound);
	}

	public string itemFound(string item)
	{
		return found;
	}
		
	public void getString(string item)
	{
		found = "You found " + item + "!";
	}
}
