﻿using UnityEngine;
using System.Collections;

public class PigeonPooper : MonoBehaviour {

	public Transform ass;
	public ScoreUpdater scoreUpdater;
	public PoopSupplyUpdater poopSupplyUpdater;
	
	void Start () {
	
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {

			if (poopSupplyUpdater.GetPoopSupply() < 5) {
				return;
			}

			poopSupplyUpdater.DecreasePoop(5);

			Collider2D collider = Physics2D.OverlapPoint(ass.position);

			if (collider != null) {
				GameObject person = collider.transform.parent.parent.gameObject;

				bool personWasPooped = person.GetComponent<PersonPoopReceiver>().ReceivePoop();

				if (personWasPooped) {
					scoreUpdater.AddScorePoints(20);
				}
			}
		}
	}
}
