using UnityEngine;
using System.Collections;

public class PushBoard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //new Vector3(0, 0, -1);
        transform.Translate(Vector3.back * (Mathf.Sin(Time.time) * 0.02f));
	}
}
