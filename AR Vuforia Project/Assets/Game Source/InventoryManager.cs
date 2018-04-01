using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour {

    int itensFound;
    GameObject arMask;
    GameObject arBB8;
    public GameObject[] dPages;
    Scene myScene;
    int maskPos;
    int bb8Pos;
    PagesController thePageController;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        itensFound = -1;
        arMask = GameObject.Find("ar10");
        arBB8 = GameObject.Find("ar7");

        myScene = SceneManager.GetActiveScene();

        maskPos = -1;
        bb8Pos = -1;
    }
	
	// Update is called once per frame
	void Update () {
        myScene = SceneManager.GetActiveScene();

        if (myScene.name == "Inventory")
        {
            thePageController = FindObjectOfType<PagesController>();
            if (maskPos > -1)
            {
                thePageController.stackPages(maskPos, 0);
            }
            if (bb8Pos > -1)
            {
                thePageController.stackPages(bb8Pos, 1);
            }
 
        }

    }

    public void ObjectFound(string name)
    {

        if (name == "Mask")
        {

            itensFound++;
            maskPos = itensFound;
        }

        if (name == "BB8")
        {

            itensFound++;
            bb8Pos = itensFound;
        }
    }
}
