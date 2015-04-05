using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PoopSupplyUpdater : MonoBehaviour {

	private int poopSupply = 100;

	// Use this for initialization
	void Start () {
		Render ();
	}

	public void DecreasePoop (int poopAmount) {
		poopSupply -= poopAmount;
		Render ();
	}

	public int GetPoopSupply() {
		return poopSupply;
	}

	private void Render() {
		GetComponent<Text>().text = "Munice: " + poopSupply;
	}
}
