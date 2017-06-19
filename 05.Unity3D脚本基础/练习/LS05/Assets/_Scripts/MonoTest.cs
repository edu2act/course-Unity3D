using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class MonoTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
			//Time.timeScale = 5.0f;
		Debug.Log (this.name + "Start");
		GetComponent<Renderer> ().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Update间隔：" + Time.deltaTime);
		/*
		if (this.name == "Cube") {
			transform.position += new Vector3 (0.5f * Time.deltaTime, 0, 0);
		} else {
			transform.position += new Vector3 (0.5f /60f, 0, 0);
		}
		*/
	}

	void FixedUpdate(){
		//Debug.Log ("FixedUpdate间隔：" + Time.deltaTime);
		transform.position += new Vector3 (0.01f, 0, 0);
	}

	void Awake(){
		Debug.Log (this.name + "Awake");
	}

}
