using UnityEngine;
using System.Collections;

public class PeopleSpawner : MonoBehaviour {

	public GameObject[] spawnPoints;
	public GameObject personPrefab;
	public Transform peopleParent;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnPersonCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private IEnumerator SpawnPersonCoroutine() {
		while (true) {
			SpawnPerson();
			yield return new WaitForSeconds(1);
		}
	}

	private void SpawnPerson() {
		// vyber náhodný spawnpoint, ze kterého človíček půjde
		GameObject fromPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

		// TODO otáčení
		// vyber náhodný spawnpoint, do kterého človíček půjde
		//GameObject targetPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

		// vyrob novýho človíčka ve zdrojovém spawnpointu
		GameObject spawnedPerson = Instantiate (personPrefab);
		spawnedPerson.transform.parent = peopleParent;
		spawnedPerson.transform.position = fromPoint.transform.position;
		spawnedPerson.transform.rotation = fromPoint.transform.rotation;

		// ... a natoč ho směrem do cíle
		//Debug.DrawLine (Vector3.zero, targetPoint.transform.position - fromPoint.transform.position, Color.cyan, 1);
		//spawnedPerson.transform.LookAt(Vector3.forward,Vector3.Cross(Vector3.forward,fromPoint.transform.position - targetPoint.transform.position));

	}
}
