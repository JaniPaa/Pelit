﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

	PieceController pieceCtrl;
	private ButtonController buttonLeft;
	private ButtonController buttonRight;
	private ButtonController buttonUp;
	private ButtonController buttonDown;
	DialogueManager dialogue;
	RawImage bgImage;

	void Start ()
	{
		pieceCtrl = GameObject.Find ("ChessPlayerSprite").GetComponent<PieceController> ();
		buttonLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		buttonRight = GameObject.Find ("ButtonRight").GetComponent<ButtonController> ();
		buttonUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		buttonDown = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
		//dialogue = GameObject.Find ("Dialogue").GetComponent<DialogueManager> ();
		//bgImage = GameObject.Find ("BackgroundImage").GetComponent<RawImage> ();
		//dialogue.ManageDialogue ();
	}

	// Check if any movement buttons are pressed.
	void Update ()
	{
		if (buttonRight.GetButtonPressed () || Input.GetKey("d")){
			pieceCtrl.Move ("right");
		}
		if (buttonLeft.GetButtonPressed () || Input.GetKey("a")) {
			pieceCtrl.Move ("left");
		}
		if (buttonUp.GetButtonPressed () || Input.GetKey("w")) {
			pieceCtrl.Move ("up");
		}
		if (buttonDown.GetButtonPressed () || Input.GetKey("s")) {
			pieceCtrl.Move ("down");
		}

	}
}
