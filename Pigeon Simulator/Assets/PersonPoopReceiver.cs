using UnityEngine;
using System.Collections;

public class PersonPoopReceiver : MonoBehaviour {

	public Material poopedPersonMaterial;

	public void ReceivePoop () {
		GetComponentInChildren<Renderer> ().material = poopedPersonMaterial;
	}
}
