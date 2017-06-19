using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProfileTest : MonoBehaviour {
	public List<string> playerNames;

	void Update () {
		if (Input.GetMouseButton (0)) {
			for (int i = 0; i < playerNames.Count; i++) {
				Debug.Log (playerNames[i]);
			}
		}
		transform.Rotate (Vector3.up, 1);
	}
}
