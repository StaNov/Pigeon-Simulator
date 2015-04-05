using UnityEngine;
using System.Collections;

public class PigeonPooper : MonoBehaviour {

	public Transform ass;
	public ScoreUpdater scoreUpdater;
	
	void Start () {
	
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			// TODO pokad, co je pod tebou			
			Collider2D collider = Physics2D.OverlapPoint(ass.position);

			if (collider != null) {
				GameObject person = collider.transform.parent.gameObject;

				bool personWasPooped = person.GetComponent<PersonPoopReceiver>().ReceivePoop();

				if (personWasPooped) {
					scoreUpdater.AddScorePoints(20);
				}
			}
		}
	}
}
