using UnityEngine;
using System.Collections;

public class LoadAssetBundle : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			StartCoroutine (LoadCubeBundle ());
		}
		if(Input.GetKeyDown(KeyCode.DownArrow)){
			StartCoroutine (LoadSphereBundle ());
		}
	}
	IEnumerator LoadCubeBundle(){
		WWW www = new WWW("file://" + Application.dataPath + "/Resources/shape/cube");
		yield return www;
		AssetBundle bundle = www.assetBundle;
		GameObject cube = Instantiate (bundle.LoadAsset ("Cube")) as GameObject;
		cube.transform.position = new Vector3 (0, 0, 0);
	}

	IEnumerator LoadSphereBundle(){
		WWW www = new WWW("file://" + Application.dataPath + "/Resources/shape/sphere");
		yield return www;
		AssetBundle bundle = www.assetBundle;
		GameObject cube = Instantiate (bundle.LoadAsset ("Sphere")) as GameObject;
		cube.transform.position = new Vector3 (2, 0, 2);
	}
}
