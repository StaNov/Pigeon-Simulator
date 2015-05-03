using UnityEngine;
using System.Collections;

public class PeopleKiller : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject collidingObject = collider.transform.parent.parent.gameObject;

		if (collidingObject.CompareTag ("person")) {
			Destroy(collidingObject);
		}
	}
}
