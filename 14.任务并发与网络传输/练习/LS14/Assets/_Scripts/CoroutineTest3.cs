using UnityEngine;
using System.Collections;

public class CoroutineTest3 : MonoBehaviour {
	IEnumerator Fade() {
		Debug.Log ("fadeCube");
	    for (float f = 1f; f >= 0; f -= 0.01f) {
			GetComponent<Renderer>().material.color = new Color(1,f,f);
			yield return new WaitForSeconds(.2f); //yield return null;
    	}
	}
	IEnumerator Fade2() {
		for (float f = 1f; f >= 0; f -= 0.01f) {
			Debug.Log ("do something");
			yield return new WaitForSeconds(.1f);
			}
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)) {
        	StartCoroutine("Fade");
			StartCoroutine ("Fade2");
   		 }
	}

}
