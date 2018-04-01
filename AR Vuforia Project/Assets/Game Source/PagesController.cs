using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagesController : MonoBehaviour {

    InventoryManager theInventoryManager;
    public GameObject[] sPages;
    public GameObject[] oPages;
	// Use this for initialization
	void Start () {

        theInventoryManager = FindObjectOfType<InventoryManager>();
   
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void stackPages(int pos, int pos2) {

        oPages[pos] = sPages[pos2];

    }

    public int ReturnPos(GameObject oName) {
        int pos = -1;
        for (int a = 0; a < oPages.Length; a++) {

            if (oPages[a] == oName)
            {

                pos = a;
               
            }

        }

        return pos;
    }

}
