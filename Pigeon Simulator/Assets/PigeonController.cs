using UnityEngine;
using System.Collections;

public class PigeonController : MonoBehaviour {

	private Rigidbody2D rigidbody2D;
	public Transform headTransform;

	void Awake () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		
	}
	
	void FixedUpdate () {
		rigidbody2D.AddForce (Vector2.up);
		transform.Rotate (Vector3.back);
	}
}
