using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour {


    GameObject arMask;
    GameObject arBB8;
    Scene myScene;
    PagesController pControl;
    bool maskF;
    bool bb8F;
    bool mCalled;
    bool bCalled;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

        arMask = GameObject.Find("ar10");
        arBB8 = GameObject.Find("ar7");

        maskF = false;
        bb8F = false;
        mCalled = false;
        bCalled = false;

        myScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {

        myScene = SceneManager.GetActiveScene();
        if (myScene.name == "Inventory") {

            pControl = FindObjectOfType<PagesController>();
            if (maskF == true && mCalled == false) {

                pControl.SetPage(0);
                mCalled = true;
            }
            if (bb8F == true && bCalled == false)
            {
                pControl.SetPage(1);
                bCalled = true;
            }
        }

    }

    public void ObjectFound(string name)
    {

        if (name == "Mask")
        {
            maskF = true;
        }

        if (name == "BB8")
        {
            bb8F = true;
        }
    }
}
