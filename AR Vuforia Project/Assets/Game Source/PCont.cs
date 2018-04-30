using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PCont : MonoBehaviour {

	// Use this for initialization
    public bool puzzle;
    public bool pDone = false;
    public GameObject ArCamera;

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            puzzle = true;
        }
        if(pDone)
        {
            puzzle = false;
        }
		if(puzzle)
        {
            VuforiaBehaviour.Instance.enabled = false;
            ArCamera.SetActive(false);
        }
        else if (!puzzle)
        {
            VuforiaBehaviour.Instance.enabled = true;
            ArCamera.SetActive(true);
        }
    }
    public void puzzleDone()
    {
        pDone = true;
    }

}


