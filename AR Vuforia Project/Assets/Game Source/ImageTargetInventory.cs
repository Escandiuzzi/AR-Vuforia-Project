using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class ImageTargetInventory : MonoBehaviour, ITrackableEventHandler
{
    protected TrackableBehaviour mTrackableBehaviour;
    public GameObject contPages;
    [SerializeField] bool[] fObjects;
    public  FloatingText fText;
    Scene myScene;

    // Use this for initialization
    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        contPages = GameObject.Find("ContPages");

        fObjects = new bool[10];

        for (int i = 0; i < fObjects.Length; i++) {
            fObjects[i] = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        myScene = SceneManager.GetActiveScene();
        if (myScene.name == "Inventory") {

            VuforiaBehaviour.Instance.enabled = false;
        }

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
         

            if (mTrackableBehaviour.TrackableName == "10")
            {
                if(fObjects[0] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(0);
                    fText.PopUpText();
                }

                fObjects[0] = true;

            }

            if (mTrackableBehaviour.TrackableName == "8")
            {

                if (fObjects[1] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(1);

                    fText.PopUpText();
                }

                fObjects[1] = true;

            }

            if (mTrackableBehaviour.TrackableName == "9")
            {
                if (fObjects[2] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(2);

                    fText.PopUpText();
                }

                fObjects[2] = true;

            }

            if (mTrackableBehaviour.TrackableName == "5")
            {
                if (fObjects[3] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(3);

                    fText.PopUpText();
                }

                fObjects[3] = true;

            }

            if (mTrackableBehaviour.TrackableName == "6")
            {
                if (fObjects[4] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(4);

                    fText.PopUpText();
                }

                fObjects[4] = true;

            }

            if (mTrackableBehaviour.TrackableName == "4")
            {
                if (fObjects[5] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(5);

                    fText.PopUpText();
                }

                fObjects[5] = true;

            }

            if (mTrackableBehaviour.TrackableName == "1")
            {
                if (fObjects[6] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(6);

                    fText.PopUpText();
                }

                fObjects[6] = true;

            }

            if (mTrackableBehaviour.TrackableName == "2")
            {
                if (fObjects[7] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(7);

                    fText.PopUpText();
                }

                fObjects[7] = true;

            }

            if (mTrackableBehaviour.TrackableName == "7")
            {
                if (fObjects[8] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(8);

                    fText.PopUpText();
                }

                fObjects[8] = true;

            }

            if (mTrackableBehaviour.TrackableName == "3")
            {
                if (fObjects[9] == false)
                {
                    contPages.GetComponent<ContPages>().addObj(9);

                    fText.PopUpText();
                }

                fObjects[9] = true;

            }

        }
  
    }

}