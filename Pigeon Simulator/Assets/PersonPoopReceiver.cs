using UnityEngine;
using System.Collections;

public class PersonPoopReceiver : MonoBehaviour {

	public Material poopedPersonMaterial;
	private bool isPooped = false;

	/**
	 * Returns true if person was pooped now and hasn't been pooped before, false otherwise.
	 */ 
	public bool ReceivePoop () {
		if (isPooped) {
			// posrání už posraného člověka nic neznamená
			return false;
		}

		isPooped = true;
		GetComponentInChildren<Renderer> ().material = poopedPersonMaterial;
		return true;
	}
}
