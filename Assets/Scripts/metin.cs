using UnityEngine;
using System.Collections;
using Vuforia;
public class metin : MonoBehaviour, ITrackableEventHandler {
	public Animator anim;

	private TrackableBehaviour mTrackableBehaviour;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

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
			anim.Play("sf1_01",-1,0f);
		}
		else
		{
			// Stop audio when target is lost
			anim.Stop();
		}
	}   
	// Update is called once per frame
	void Update () {

	}
}