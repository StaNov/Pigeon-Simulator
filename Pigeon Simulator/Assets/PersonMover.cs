using UnityEngine;
using System.Collections;

public class PersonMover : MonoBehaviour {

	private Rigidbody2D rigidbody2D;

	void Awake() {
		rigidbody2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		rigidbody2D.AddRelativeForce(Vector2.up);
		transform.Rotate (0, 0, 1);
	}
}
