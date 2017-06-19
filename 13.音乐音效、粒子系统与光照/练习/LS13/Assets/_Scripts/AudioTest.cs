using UnityEngine;
using System.Collections;

public class AudioTest : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip clip1;
	public AudioClip clip2;
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			audioSource.Pause ();
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			audioSource.clip = clip1;
			audioSource.Play();
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			audioSource.UnPause();
		}
	}
}
