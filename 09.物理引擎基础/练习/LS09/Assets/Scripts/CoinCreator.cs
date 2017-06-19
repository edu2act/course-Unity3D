using UnityEngine;
using System.Collections;

public class CoinCreator : MonoBehaviour {
    public GameObject coinPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * (Mathf.Sin(Time.time) * 0.02f));
        if (Input.GetMouseButton(0))
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
	}
}
