using UnityEngine;
using System.Collections;

public class RoadManager : MonoBehaviour {
	GameObject[] roadArray;
	public float timeScale = 1.0f;
	// Use this for initialization
	void Start () {
		roadArray = new GameObject[2];
		roadArray[0] = GameObject.Find ("Street1");
		roadArray[1] = GameObject.Find ("Street2");
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = timeScale;
//		foreach (GameObject road in roadArray) {
//			if(road.transform.position.z < -40.0){
//				road.transform.position += new Vector3 (0, 0, 80f);
//			}else{
//				road.transform.position += new Vector3 (0, 0, -0.1f);
//			}
//		}
	}

	void FixedUpdate(){
		foreach (GameObject road in roadArray) {
			if(road.transform.position.z < -40.0){
				road.transform.position += new Vector3 (0, 0, 80f);
			}else{
				road.transform.position += new Vector3 (0, 0, -0.1f);
			}
		}
	}
		
}
