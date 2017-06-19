using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//自转
		transform.Rotate (Vector3.down, 10.0f*Time.deltaTime*60.0f);
		//transform.Rotate (new Vector3(0,-1,0), 1.0f*Time.deltaTime*60.0f);

		//公转
		transform.RotateAround(Vector3.zero,Vector3.up,1.0f*Time.deltaTime*60.0f);
	}
}
