using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUpdater : MonoBehaviour {

	private int currentPoints = 0;

	void Start() {
		RenderScoreBox ();
	}

	public void AddScorePoints(int points) {
		currentPoints += points;
		RenderScoreBox ();
	}

	private void RenderScoreBox() {
		GetComponent<Text> ().text = "Skóre: " + currentPoints;
	}
}
