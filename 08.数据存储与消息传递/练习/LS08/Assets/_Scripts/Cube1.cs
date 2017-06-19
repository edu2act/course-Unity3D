using UnityEngine;
using System.Collections;

public class Cube1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //this.Cube1Fun();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Cube1Fun()
    {
        GameObject cube2 = GameObject.Find("Cube2");
        cube2.GetComponent<Cube2>().Cube2Fun();
    }
}
