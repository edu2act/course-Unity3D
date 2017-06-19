using UnityEngine;
using System.Collections;

public class Cube1_1 : MonoBehaviour {
    Rigidbody rig;
	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
        //rig.AddForce(new Vector3(1f, 1f, 1f));
        rig.AddForce(new Vector3(-5f, 0f, 0f), ForceMode.Force);
        //rig.AddRelativeForce(new Vector3(1f, 1f, 1f));

        rig.AddTorque(Vector3.up);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("111");
        collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("222");
        collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("333");
        collision.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
}
