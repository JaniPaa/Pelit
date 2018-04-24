using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

	// Use this for initialization
	private bool buttonPressed;

	// If movement button is being pressed
	public void OnPointerDown (PointerEventData e)
	{
		buttonPressed = true;

	}
	// If movement button are not being pressed
	public void OnPointerUp (PointerEventData e)
	{
		buttonPressed = false;

	}

	// returns if movement button is pressed
	public bool GetButtonPressed ()
	{
		return buttonPressed;
	}
}
