using UnityEngine;
using System.Collections;

public class LS01_Sphere_Test : MonoBehaviour {
	GameObject target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (target.transform.position, Vector3.up, 5);
	}
}
