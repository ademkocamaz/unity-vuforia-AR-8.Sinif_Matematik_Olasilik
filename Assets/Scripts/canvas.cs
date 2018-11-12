/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class canvas : MonoBehaviour,
    ITrackableEventHandler
    {

        #region PRIVATE_MEMBER_VARIABLES

        private TrackableBehaviour mTrackableBehaviour;

        #endregion // PRIVATE_MEMBER_VARIABLES

        public GameObject objectToHide;

        #region UNTIY_MONOBEHAVIOUR_METHODS

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
            TrackableBehaviour.Status previousStatus,
            TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            objectToHide.SetActive(false);
            
            Canvas[] canvasComponents = GetComponentsInChildren<Canvas>(true);

            // Enable canvas objects
            foreach (Canvas component in canvasComponents)
            {
                component.enabled = true;
            }

            Animation[] animationComponents = GetComponentsInChildren<Animation>();

            foreach (Animation component in animationComponents)
            {
                component.enabled = true;
                component.Play();
            }

            Animator[] animatorComponents = GetComponentsInChildren<Animator>();

            foreach (Animator component in animatorComponents)
            {
                component.enabled = true;
            }
        }


        private void OnTrackingLost()
        {
            objectToHide.SetActive(true);
            Canvas[] canvasComponents = GetComponentsInChildren<Canvas>(true);

            // Disable canvas objects
            foreach (Canvas component in canvasComponents)
            {
                component.enabled = false;
            }

            Animation[] animationComponents = GetComponentsInChildren<Animation>();

            foreach (Animation component in animationComponents)
            {
                //print("hash kodu:"+component.GetCurrentAnimatorStateInfo(0).GetHashCode());
                component.Rewind();
                component.Stop();
                component.enabled = false;
            }

            Animator[] animatorComponents = GetComponentsInChildren<Animator>();

            foreach (Animator component in animatorComponents)
            {
                //print("hash kodu:"+component.GetCurrentAnimatorStateInfo(0).GetHashCode());
                component.Rebind();
                component.enabled=false;
            }

            AudioSource[] audioSourceComponents = GetComponentsInChildren<AudioSource>();

            foreach (AudioSource component in audioSourceComponents)
            {
                //print("hash kodu:"+component.GetCurrentAnimatorStateInfo(0).GetHashCode());
                component.Stop();
            }
        }

        #endregion // PRIVATE_METHODS
    }
}