using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverHandler : MonoBehaviour {

	public LifeUpdater lifeUpdater;
	public ScoreUpdater scoreUpdater;
	public GameObject gameOverPanel;

	void Start() {
		Time.timeScale = 1;
	}
		
	void Update () {
		if (lifeUpdater.GetLife () <= 0) {
			Time.timeScale = 0;
			ShowGameOverPanel();
		}
	}

	private void ShowGameOverPanel() {
		gameOverPanel.SetActive (true);
		gameOverPanel.GetComponentInChildren<Text> ().text = "Konec hry!\nZískal jsi " + scoreUpdater.GetScore () + " bodů.";

	}

	public void TryAgain() {
		Application.LoadLevel (0);
	}
}
