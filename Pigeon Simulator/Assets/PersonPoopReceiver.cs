using UnityEngine;
using System.Collections;

public class PersonPoopReceiver : MonoBehaviour {

	public void ReceivePoop () {
		// TODO změn materiál na PoopedPerson
		Debug.Log(gameObject.name + " has been pooped!");
	}
}
