using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class ParticaleTest : MonoBehaviour {
	ParticleSystem particleSys;
	ParticleSystem.ShapeModule shapeModule;
	// Use this for initialization
	void Start () {
		particleSys = GetComponent<ParticleSystem> ();
		shapeModule = particleSys.shape;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			shapeModule.radius += 2;
		}
		if (Input.GetMouseButtonDown (1)) {
			shapeModule.radius -= 2;
		}
	}
}
