using UnityEngine;
using System.Collections;

public class DebugTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Debug.Log ("Hello,World_1!");
		Debug.Log ("Hello,World_2!", this);

		Debug.LogWarning ("Warning_1!");
		Debug.LogWarning ("Warning_2!", this);

		Debug.LogError ("LogError_1!");
		Debug.LogError ("LogError_2!", this);

		Debug.DrawLine (new Vector3 (1, 0, 0), new Vector3 (1, 1, 1), Color.red, 1000);
		Debug.DrawRay (new Vector3 (1, 0, 0), new Vector3 (1, 1, 1), Color.green, 1000);

		//Debug.Break ();
		int a = 3;
		int b = 2;
		Debug.Assert ((a > b), "xxxx");

	}

	// Update is called once per frame
	void Update () {
//		Debug.Log ("Update!");
	}
}
