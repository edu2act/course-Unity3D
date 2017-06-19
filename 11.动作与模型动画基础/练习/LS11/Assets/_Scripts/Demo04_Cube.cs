using UnityEngine;
using System.Collections;

public class Demo04_Cube : MonoBehaviour {
    Animator animatorCtl;
	// Use this for initialization
	void Start () {
        animatorCtl = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            animatorCtl.SetBool("ToAnimation", true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            animatorCtl.SetBool("ToAnimation", false);
        }
	}
}
