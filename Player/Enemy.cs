﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Enemy : PieceController {


	public float speed;
	private PieceController doorOpener;
	private Transform target;

	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		doorOpener = new PieceController ();
	}
	// Moves the enemy towards the player's coordinates
	void Update () {
		if (doorOpener.openDoor == true) {
			transform.position = Vector2.MoveTowards (transform.position, target.position, speed * Time.deltaTime);
			doorOpener.openDoor = true;
		}
	}
}
