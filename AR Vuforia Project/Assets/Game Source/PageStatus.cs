using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageStatus : MonoBehaviour {

    // Use this for initialization
    bool achou;
    public string nome;
    public Sprite spr;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (achou == false)
        {
            //Debug.Log(nome + " FALSE");
        }
        else
        {
            gameObject.transform.GetChild(3).GetComponent<Text>().text = nome;
            gameObject.transform.GetChild(2).GetComponent<Image>().sprite = spr;
        }
    }

    /*void Awake()
    {
        if(achou == false)
        {
            Debug.Log(nome + " FALSE");
        }
        else
        {
            gameObject.transform.GetChild(3).GetComponent<Text>().text = nome;
            gameObject.transform.GetChild(2).GetComponent<Image>().sprite = spr;
        }
    }*/

    public void setBool(bool b)
    {
        achou = b;
    }
}
