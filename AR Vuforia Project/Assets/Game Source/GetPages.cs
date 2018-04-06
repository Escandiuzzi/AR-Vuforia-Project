using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPages : MonoBehaviour {

    public GameObject[] pages;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject returnPages(int s) {

        return pages[s];
    }
}
