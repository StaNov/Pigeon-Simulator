using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoodUpdater : MonoBehaviour {

	public double foodAmount = 30;

	void Start() {
		Render ();
	}
	
	public void AddFood(double amount) {
		foodAmount += amount;
		Render ();
	}
	
	public void DecreaseFood(double amount) {
		foodAmount -= amount;
		Render ();
	}

	private void Render() {
		GetComponent<Text> ().text = "Jídlo: " + Mathf.FloorToInt((float) foodAmount);
	}

	public double GetFoodAmount() {
		return foodAmount;
	}
}
