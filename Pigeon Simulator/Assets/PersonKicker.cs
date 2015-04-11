using UnityEngine;
using System.Collections;

public class PersonKicker : MonoBehaviour {

	private LifeUpdater lifeUpdater;

	void Start() {
		lifeUpdater = LifeUpdater.getInstance ();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		// pokud kopeš do něčeho, co není holub, nedělej nic
		if (! collision.gameObject.CompareTag ("pigeon")) {
			return;
		}

		lifeUpdater.DecreaseLife (5.0);
	}
}
