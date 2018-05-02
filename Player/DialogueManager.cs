using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject textBox;
	public Text dialogueText;
	public TextAsset textFile;
	private string[] textLines;
	private int currentLine;
	private int lastLine;
	public string levelToLoad;
	
	public void ManageDialogue()
	{
		textLines = (textFile.text.Split ('\n'));
		lastLine = textLines.Length - 1;
	}

	void Update () 
	{
		dialogueText.text = textLines [currentLine];

		if (Input.GetKeyDown (KeyCode.Space)) {
			currentLine++;
		}

		if (currentLine > lastLine) {
			textBox.SetActive (false);

			Application.LoadLevel (levelToLoad);
		}
	}
}
