using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PCont : MonoBehaviour {

	// Use this for initialization
    public bool puzzle;
    public bool pDone = false;
    public GameObject ArCamera;
    public GameObject back;
    GameObject trofeu;
    void Start () {
        puzzle = true;
        trofeu = GameObject.Find("Trofeu");
	}
	
	// Update is called once per frame
	void Update () {
        
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
            back.GetComponent<ButtonController>().puzzleBack();
        }
    }
    public void puzzleDone()
    {
        pDone = true;
        trofeu.GetComponent<trofeu>().addcont();
    }

}


