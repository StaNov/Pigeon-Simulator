using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoodUpdater : MonoBehaviour {

	private double foodAmount = 30;

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
		GetComponent<Text> ().text = "Jídlo: " + Mathf.RoundToInt((float) foodAmount);
	}

	public double GetFoodAmount() {
		return foodAmount;
	}
}
