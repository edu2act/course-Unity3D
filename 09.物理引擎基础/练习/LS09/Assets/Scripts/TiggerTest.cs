using UnityEngine;
using System.Collections;

public class TiggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        //other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*500f);
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
        other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 30f);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
