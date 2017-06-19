using UnityEngine;
using System.Collections;

public class WWWTest : MonoBehaviour {
	public GameObject goCube;
	public GameObject goSphere;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			StartCoroutine ("LoadLocalTexture");
		}
		if (Input.GetMouseButtonDown (1)) {
			StartCoroutine ("LoadWebTexture");
		}
	}
	IEnumerator LoadLocalTexture(){
		WWW www = new WWW ("file://" + Application.dataPath + "/Resources/Textures/DarkFloor.jpg");
		yield return www;
		goCube.GetComponent<Renderer> ().material.mainTexture = www.texture;
	}
	IEnumerator LoadWebTexture(){
		WWW www2 = new WWW ("https://www.baidu.com/img/bd_logo1.png");
		yield return www2;
		goSphere.GetComponent<Renderer> ().material.mainTexture = www2.texture;
	}
}
