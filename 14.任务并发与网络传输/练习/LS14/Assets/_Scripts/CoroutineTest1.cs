using UnityEngine;
using System.Collections;

public class CoroutineTest1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Debug.Log ("Log1");
		StartCoroutine (CoroutineLog());
		Debug.Log ("Log4");
	}
	IEnumerator CoroutineLog(){
		Debug.Log ("Log2");
		yield return null;
		Debug.Log ("Log3");
	}


	// Update is called once per frame
	void Update () {

	}

}
