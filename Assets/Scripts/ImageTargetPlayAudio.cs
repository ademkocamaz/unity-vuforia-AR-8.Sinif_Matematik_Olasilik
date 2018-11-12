using UnityEngine;
using System.Collections;
using Vuforia;

public class ImageTargetPlayAudio : MonoBehaviour, ITrackableEventHandler {

	public AudioSource audioSource;

	private TrackableBehaviour mTrackableBehaviour;
	// Use this for initialization
	void Start () {
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			audioSource.Play();

//			Animation[] animationComponents=GetComponentsInChildren<Animation>();
//
//			foreach (Animation component in animationComponents) {
//				//print("hash kodu:"+component.GetCurrentAnimatorStateInfo(0).GetHashCode());
//				component.Play ();
//			}

		}
		else
		{
			// Stop audio when target is lost
			audioSource.Stop();

//			Animation[] animationComponents=GetComponentsInChildren<Animation>();
//			foreach (Animation component in animationComponents) {
//				//print("hash kodu:"+component.GetCurrentAnimatorStateInfo(0).GetHashCode());
//				component.Stop ();
//			}	
		}
	}   
	// Update is called once per frame
	void Update () {

	}
}