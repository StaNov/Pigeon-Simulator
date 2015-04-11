using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeUpdater : MonoBehaviour {

	private double life = 100;

	public void DecreaseLife (double amount) {
		life -= amount;
		Render ();
	}

	private void Render() {
		GetComponent<Text> ().text = "Život: " + Mathf.CeilToInt((float) life);
	}
}
