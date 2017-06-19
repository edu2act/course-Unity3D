using UnityEngine;
using System.Collections;

public class TiggerCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    void OnTriggerStay(Collider other)
    {
        //Destroy(other.gameObject);
        Debug.Log("OnTriggerStay");
        other.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnTriggerExit(Collider other)
    {
        //Destroy(other.gameObject);
        Debug.Log("OnTriggerExit");
        other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

}
