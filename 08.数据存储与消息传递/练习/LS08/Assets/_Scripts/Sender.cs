using UnityEngine;
using System.Collections;

public class Sender : MonoBehaviour {
    public GameObject receiver;
    public GameObject parent;
    public GameObject child;
	// Use this for initialization
	void Start () {
        /*
        receiver.SendMessage("fun1");
        receiver.SendMessage("fun2",10);
        receiver.SendMessage("fun3", 123.0f);
        receiver.SendMessage("fun4", "hello world!");

        System.Object[] objArr = new System.Object[3];
        objArr[0] = "hello";
        objArr[1] = 5;
        objArr[2] = 20.0f;
        receiver.SendMessage("fun5",objArr);
         */

        //广播 向下传递
        //parent.BroadcastMessage("DisplayInfo");

        //向上传递
        child.SendMessageUpwards("DisplayInfo");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
