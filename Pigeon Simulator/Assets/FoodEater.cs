using UnityEngine;
using System.Collections;

public class FoodEater : MonoBehaviour {

	public PoopSupplyUpdater poopSupplyUpdater;

	private Collider2D currentlyEatenFood = null;

	void OnTriggerEnter2D(Collider2D collider) {
		currentlyEatenFood = collider;
	}
	
	void OnTriggerExit2D(Collider2D collider) {
		currentlyEatenFood = null;
	}

	void FixedUpdate() {
		if (currentlyEatenFood == null) {
			return;
		}

		double bitten = currentlyEatenFood.gameObject.GetComponent<Food>().Bite();

		poopSupplyUpdater.IncreasePoop(bitten);
		// TODO kolidovat jenom zobáček, ne celý holub
	}
}
