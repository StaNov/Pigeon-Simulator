using UnityEngine;
using System.Collections;

public class PoopCreator : MonoBehaviour {

	public PoopSupplyUpdater poopUpdater;
	public FoodUpdater foodUpdater;
	public LifeUpdater lifeUpdater;
	public double transformingSpeed = 0.1;

	void FixedUpdate () {
		if (foodUpdater.GetFoodAmount() < transformingSpeed) {
			lifeUpdater.DecreaseLife(transformingSpeed);
			return;
		}

		poopUpdater.IncreasePoop (transformingSpeed);
		foodUpdater.DecreaseFood (transformingSpeed);
	}
}
