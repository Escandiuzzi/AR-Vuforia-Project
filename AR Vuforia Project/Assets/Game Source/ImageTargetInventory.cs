using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ImageTargetInventory : MonoBehaviour, ITrackableEventHandler
{
    protected TrackableBehaviour mTrackableBehaviour;
    InventoryManager theInventory;
    bool fmask, fbb;
    public  FloatingText fText;

    // Use this for initialization
    void Start () {

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        theInventory = FindObjectOfType<InventoryManager>();
        fmask = false;
        fbb = false;
    }
	
	// Update is called once per frame
	void Update () {
        

    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        IEnumerable<TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetActiveTrackableBehaviours();
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
         

            if (mTrackableBehaviour.TrackableName == "10Ace")
            {
                if(fmask == false)
                {
                    theInventory.ObjectFound("Mask");
                    fText.PopUpText();
                }
                fmask = true;

               
            }

            if (mTrackableBehaviour.TrackableName == "7")
            {
                if(fbb == false)
                {
                    theInventory.ObjectFound("BB8");
                    fText.PopUpText();
                }
                fbb = true;
               
            }



        }
  
    }

}