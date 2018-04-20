using System.Collections;
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


	void Start ()
	{
		pieceCtrl = GameObject.Find ("ChessPlayerSprite").GetComponent<PieceController> ();
		buttonLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		buttonRight = GameObject.Find ("ButtonRight").GetComponent<ButtonController> ();
		buttonUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		buttonDown = GameObject.Find ("ButtonDown").GetComponent<ButtonController> ();
	}

	// Chech if any movement buttons are pressed.
	void Update ()
	{
		if (buttonRight.GetButtonPressed () || Input.GetKeyDown("d")){
			pieceCtrl.Move ("right");
		}
		if (buttonLeft.GetButtonPressed () || Input.GetKeyDown("a")) {
			pieceCtrl.Move ("left");
		}
		if (buttonUp.GetButtonPressed () || Input.GetKeyDown("w")) {
			pieceCtrl.Move ("up");
		}
		if (buttonDown.GetButtonPressed () || Input.GetKeyDown("s")) {
			pieceCtrl.Move ("down");
		}
			
	}
}
