using UnityEngine;
using System.Collections;

public class Plane : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 1.0f);
        //DestroyImmediate(collision.gameObject);
    }
    void OnCollisionStay(Collision collision)
    {

    }
    void OnCollisionExit(Collision collision)
    {

    }
}
