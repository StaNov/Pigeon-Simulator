using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	public double remaining = 20.0;

	public double bit = 0.1;

	public double Bite() {
		remaining -= bit;
		// TODO když už tam není dost na jedno kousnutí
		// TODO když už tam nic není, tak znič objekt semínek

		if (remaining <= 0) {
			DestroyImmediate(gameObject);
		}

		return bit;
	}
}
