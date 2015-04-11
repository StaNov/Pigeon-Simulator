using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PoopSupplyUpdater : MonoBehaviour {

	private double poopSupply = 0.0;

	// Use this for initialization
	void Start () {
		Render ();
	}
	
	public void DecreasePoop (double poopAmount) {
		poopSupply -= poopAmount;
		Render ();
	}
	
	public void IncreasePoop (double poopAmount) {
		poopSupply += poopAmount;
		Render ();
	}

	public double GetPoopSupply() {
		return poopSupply;
	}

	private void Render() {
		GetComponent<Text>().text = "Munice: " + Mathf.FloorToInt((float) poopSupply);
	}
}
