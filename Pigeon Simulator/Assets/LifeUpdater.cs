using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeUpdater : MonoBehaviour {

	public double life = 100;

	void Start() {
		Render ();
	}

	public void DecreaseLife (double amount) {
		life -= amount;
		Render ();
	}

	private void Render() {
		GetComponent<Text> ().text = "Život: " + Mathf.CeilToInt((float) life);
	}

	public double GetLife() {
		return life;
	}


	// singleton
	private static LifeUpdater instance;

	void Awake() {
		instance = this;
	}

	public static LifeUpdater getInstance() {
		return instance;
	}
}
