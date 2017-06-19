using UnityEngine;
using System.Collections;

public class ButtonTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MyBtnPressed(int value)
    {
        Debug.Log("MyBtnPressed"+value);
        //GameObject.Find("Cube").GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
