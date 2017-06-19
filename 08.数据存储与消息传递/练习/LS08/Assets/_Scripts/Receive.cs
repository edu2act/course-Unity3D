using UnityEngine;
using System.Collections;

public class Receive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void fun1()
    {
        Debug.Log("fun1");
    }
    public void fun2(int v)
    {
        Debug.Log("fun_int" + v.ToString());
    }
    public void fun3(float v)
    {
        Debug.Log("fun_float" + v.ToString());
    }
    public void fun4(string v)
    {
        Debug.Log("fun_string" + v.ToString());
    }

    public void fun5(System.Object[] objArray)
    {
        Debug.Log("fun_Object" + objArray[0].ToString());
        Debug.Log("fun_Object" + objArray[1].ToString());
        Debug.Log("fun_Object" + objArray[2].ToString());
    }
}
