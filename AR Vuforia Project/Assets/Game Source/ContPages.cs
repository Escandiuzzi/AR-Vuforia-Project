using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContPages : MonoBehaviour {

    // Use this for initialization

    public string[] nomes;
    public GameObject[] pages;
    bool[] objetos;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addObj(int n)
    {
        pages[n].GetComponent<PageStatus>().setBool(true);

    }

    public GameObject getPage(int i)
    {

        return pages[i];
    }
}
