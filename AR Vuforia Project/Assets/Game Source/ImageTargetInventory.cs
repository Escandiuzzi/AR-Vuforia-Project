using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class ImageTargetInventory : MonoBehaviour, ITrackableEventHandler
{
    protected TrackableBehaviour mTrackableBehaviour;
    InventoryManager theInventory;
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

        theInventory = FindObjectOfType<InventoryManager>();

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
                Debug.Log("Entrou no if ar1");
                if(fObjects[0] == false)
                {
                    theInventory.ObjectFound("Barrel");
                    fText.PopUpText();
                }

                fObjects[0] = true;

            }

            if (mTrackableBehaviour.TrackableName == "8")
            {
                Debug.Log("Entrou no primeiro if ar2");

                if (fObjects[1] == false)
                {
                    Debug.Log("Entrou no SEGUNDO if ar2");

                    theInventory.ObjectFound("Bomb");
                    fText.PopUpText();
                }

                fObjects[1] = true;

            }

            if (mTrackableBehaviour.TrackableName == "9")
            {
                if (fObjects[2] == false)
                {
                    theInventory.ObjectFound("Mug");
                    fText.PopUpText();
                }

                fObjects[2] = true;

            }

            if (mTrackableBehaviour.TrackableName == "5")
            {
                if (fObjects[3] == false)
                {
                    theInventory.ObjectFound("Hat");
                    fText.PopUpText();
                }

                fObjects[3] = true;

            }

            if (mTrackableBehaviour.TrackableName == "6")
            {
                if (fObjects[4] == false)
                {
                    theInventory.ObjectFound("Lunette");
                    fText.PopUpText();
                }

                fObjects[4] = true;

            }

            if (mTrackableBehaviour.TrackableName == "4")
            {
                if (fObjects[5] == false)
                {
                    theInventory.ObjectFound("Pistol");
                    fText.PopUpText();
                }

                fObjects[5] = true;

            }

            if (mTrackableBehaviour.TrackableName == "1")
            {
                if (fObjects[6] == false)
                {
                    theInventory.ObjectFound("Chest");
                    fText.PopUpText();
                }

                fObjects[6] = true;

            }

            if (mTrackableBehaviour.TrackableName == "2")
            {
                if (fObjects[7] == false)
                {
                    theInventory.ObjectFound("Sword");
                    fText.PopUpText();
                }

                fObjects[7] = true;

            }

            if (mTrackableBehaviour.TrackableName == "7")
            {
                if (fObjects[8] == false)
                {
                    theInventory.ObjectFound("Key");
                    fText.PopUpText();
                }

                fObjects[8] = true;

            }

            if (mTrackableBehaviour.TrackableName == "3")
            {
                if (fObjects[9] == false)
                {
                    theInventory.ObjectFound("Ship");
                    fText.PopUpText();
                }

                fObjects[9] = true;

            }

        }
  
    }

}