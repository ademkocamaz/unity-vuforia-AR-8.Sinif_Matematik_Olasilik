using UnityEngine;
using System.Collections;

public class erkekSes : MonoBehaviour {
	
	public AudioSource audioSource;
	public AudioClip audioClip;

	// Use this for initialization
	void Start () {
		audioSource.clip = audioClip;
		audioSource.Play ();
	}
				
}
