using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PagesController : MonoBehaviour {

    public GameObject[] objs;
    public Sprite spr_mask;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SetPage(int pos) {
        if (pos == 0) {

            objs[0].transform.GetChild(2).GetComponent<Image>().overrideSprite = (Sprite)Resources.Load("Mask");
            objs[0].transform.GetChild(3).GetComponent<Text>().text = "Mask";
        }

        if (pos == 1) {
            
            objs[1].transform.GetChild(2).GetComponent<Image>().overrideSprite = (Sprite)Resources.Load("BB8");
            objs[1].transform.GetChild(3).GetComponent<Text>().text = "BB8";
        }


    }
}
