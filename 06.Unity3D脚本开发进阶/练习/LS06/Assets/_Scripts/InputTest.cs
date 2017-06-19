using UnityEngine;
using System.Collections;

public class InputTest : MonoBehaviour {
    GameObject camera;
    Transform cameraTransform;
    float horizontalSpeed = 200.0f;
    float verticalSpeed = 200.0f;
	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Main Camera");
        cameraTransform = camera.GetComponent<Transform>();
        cameraTransform = camera.transform;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        //区分GetKey GetKeyDown GetKeyOn
        if (Input.GetKey(KeyCode.UpArrow))
        {
             Debug.Log("上方向键被按下");
             cameraTransform.Translate(new Vector3(0f,0.1f,0f));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("下方向键被按下");
            cameraTransform.Translate(new Vector3(0f,-0.1f,0f));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
          Debug.Log("空格键被按下");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("空格键被抬起");
        }
        */

        //float translationY = Input.GetAxis("Vertical") * 0.1f * Time.deltaTime;
        //float translationX = Input.GetAxis("Horizontal") * 0.1f * Time.deltaTime;
        //Debug.Log("translationY" + translationY);
        //Debug.Log("translationX" + translationX);

        if (Input.GetMouseButton(0))
        {
            Debug.Log("鼠标左键被按下");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("鼠标右键被按下");
        }
        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log("中键抬起");
            Debug.Log("当前鼠标的位置为：" + Input.mousePosition);
        }

        Touch touch = Input.GetTouch(0);

	}
}
