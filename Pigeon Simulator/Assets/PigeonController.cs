using UnityEngine;
using System.Collections;

public class PigeonController : MonoBehaviour {

	private Rigidbody2D rigidbody2D;
	public Transform headTransform;
	public Transform bodyTransform;
	public int flightSpeed = 10;
	public int turningSpeed = 2;

	private bool rotateRight = false;
	private bool rotateLeft = false;

	void Awake () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		rotateRight = Input.GetKey (KeyCode.RightArrow);
		rotateLeft = Input.GetKey (KeyCode.LeftArrow);
	}
	
	void FixedUpdate () {
		Vector2 directionToAddForce = headTransform.position - bodyTransform.position;
		directionToAddForce = directionToAddForce * flightSpeed;
		rigidbody2D.AddForce (directionToAddForce);
		
		if (rotateRight) {
			transform.Rotate(0, 0, -turningSpeed);
		}
		
		if (rotateLeft) {
			transform.Rotate(0, 0, turningSpeed);
		}
	}
}
