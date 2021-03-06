﻿using UnityEngine;
using System.Collections;

public class PigeonController : MonoBehaviour {

	private Rigidbody2D rigidbody2D;
	public Transform headTransform;
	public Transform bodyTransform;
	public int flightSpeed = 10;
	public int walkSpeed = 5;
	public int turningSpeed = 2;

	private bool rotateRight = false;
	private bool rotateLeft = false;
	private bool goForward = false;
	private bool switchFlying = false;

	public bool isFlying = false;

	void Awake () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		rotateRight = Input.GetKey (KeyCode.RightArrow);
		rotateLeft = Input.GetKey (KeyCode.LeftArrow);
		goForward = Input.GetKey (KeyCode.UpArrow);
		switchFlying = Input.GetKeyDown(KeyCode.M);
	}
	
	void FixedUpdate () {
		Vector2 directionToAddForce = headTransform.position - bodyTransform.position;

		if (isFlying) {
			Vector2 directionToAddForceFlight = directionToAddForce * flightSpeed;
			rigidbody2D.AddForce (directionToAddForceFlight);
		} else if (goForward) {
			// jsem na zemi a hráč mačká šipku nahoru -> pohybuj se dopředu
			Vector2 directionToAddForceWalk = directionToAddForce * walkSpeed;
			rigidbody2D.AddForce (directionToAddForceWalk);
		}

		if (switchFlying) {

			if (isFlying) {
				// sedni na zem
				transform.Translate(0,0,2);
			} else {
				// vzlítni do vzduchu
				transform.Translate(0,0,-2);
			}

			isFlying = ! isFlying;
			GetComponent<Animator>().SetTrigger("toggleFlying");
			GetComponentInChildren<CircleCollider2D>().enabled = ! isFlying;
			switchFlying = false;
		}
		
		if (rotateRight) {
			transform.Rotate(0, 0, -turningSpeed);
		}
		
		if (rotateLeft) {
			transform.Rotate(0, 0, turningSpeed);
		}
	}
}
