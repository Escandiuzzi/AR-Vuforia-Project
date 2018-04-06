using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour {


  
    GameObject[] arCards;
    Scene myScene;
    PagesController pControl;
    InventoryManager instance;
    bool[] objectF;
    bool[] oCalled;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);

        arCards = new GameObject[10];
        arCards[0] = GameObject.Find("ar1");
        arCards[1] = GameObject.Find("ar2");
        arCards[2] = GameObject.Find("ar3");
        arCards[3] = GameObject.Find("ar4");
        arCards[4] = GameObject.Find("ar5");
        arCards[5] = GameObject.Find("ar6");
        arCards[6] = GameObject.Find("ar7");
        arCards[7] = GameObject.Find("ar8");
        arCards[8] = GameObject.Find("ar9");
        arCards[9] = GameObject.Find("ar10");

        objectF = new bool[10];
        for (int i = 0; i < objectF.Length; i ++) {
            objectF[i] = false;
        }

        oCalled = new bool[10];
        for (int i = 0; i < objectF.Length; i++)
        {
            oCalled[i] = false;
        }

        if (FindObjectsOfType<InventoryManager>().Length > 1)
        {
            Destroy(gameObject);
        }

        myScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {

        myScene = SceneManager.GetActiveScene();
        if (myScene.name == "Inventory") {

            pControl = FindObjectOfType<PagesController>();
            if (objectF[0] == true && oCalled[0] == false) {

                pControl.SetPage(0);
                oCalled[0] = true;
            }

            if (objectF[1] == true && oCalled[1] == false)
            {

                pControl.SetPage(1);
                oCalled[1] = true;
            }

            if (objectF[2] == true && oCalled[2] == false)
            {

                pControl.SetPage(2);
                oCalled[2] = true;
            }

            if (objectF[3] == true && oCalled[3] == false)
            {

                pControl.SetPage(3);
                oCalled[3] = true;
            }

            if (objectF[4] == true && oCalled[4] == false)
            {

                pControl.SetPage(4);
                oCalled[4] = true;
            }

            if (objectF[5] == true && oCalled[5] == false)
            {

                pControl.SetPage(5);
                oCalled[5] = true;
            }

            if (objectF[6] == true && oCalled[6] == false)
            {

                pControl.SetPage(6);
                oCalled[6] = true;
            }

            if (objectF[7] == true && oCalled[7] == false)
            {

                pControl.SetPage(7);
                oCalled[7] = true;
            }

            if (objectF[8] == true && oCalled[8] == false)
            {

                pControl.SetPage(8);
                oCalled[8] = true;
            }

            if (objectF[9] == true && oCalled[9] == false)
            {

                pControl.SetPage(9);
                oCalled[9] = true;
            }

        }

    }

    public void ObjectFound(string name)
    {

        if (name == "Barrel")
        {
            objectF[0] = true;
        }

        if (name == "Bomb")
        {
            objectF[1] = true;
        }

        if (name == "Mug")
        {
            objectF[2] = true;
        }

        if (name == "Hat")
        {
            objectF[3] = true;
        }

        if (name == "Lunette")
        {
            objectF[4] = true;
        }

        if (name == "Pistol")
        {
            objectF[5] = true;
        }

        if (name == "Chest")
        {
            objectF[6] = true;
        }

        if (name == "Sword")
        {
            objectF[7] = true;
        }

        if (name == "Key")
        {
            objectF[8] = true;
        }

        if (name == "Ship")
        {
            objectF[9] = true;
        }

    }
}
