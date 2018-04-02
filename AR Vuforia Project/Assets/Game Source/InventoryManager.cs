using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour {

    int itensFound;
    GameObject arMask;
    GameObject arBB8;
    Scene myScene;


	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

        arMask = GameObject.Find("ar10");
        arBB8 = GameObject.Find("ar7");

        myScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {

        myScene = SceneManager.GetActiveScene();
    }

    public void ObjectFound(string name)
    {

        if (name == "Mask")
        {

            itensFound++;
        }

        if (name == "BB8")
        {

            itensFound++;
        }
    }
}
