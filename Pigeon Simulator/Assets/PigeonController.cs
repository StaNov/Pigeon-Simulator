using UnityEngine;
using System.Collections;

public class PigeonController : MonoBehaviour {

	private Rigidbody2D rigidbody2D;
	public Transform headTransform;
	public Transform bodyTransform;
	public int flightSpeed = 10;

	void Awake () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		
	}
	
	void FixedUpdate () {
		Vector2 directionToAddForce = headTransform.position - bodyTransform.position;
		directionToAddForce = directionToAddForce * flightSpeed;
		rigidbody2D.AddForce (directionToAddForce);
		//transform.Rotate (Vector3.back);
	}
}
