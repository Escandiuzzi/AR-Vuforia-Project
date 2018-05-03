using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trofeu : MonoBehaviour {
    public GameObject botao;
    //bool completou = false;
    int cont = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(cont == 10)
        {
            botao.SetActive(true);
        }
	}
    public void addcont()
    {
        cont++;
    }
}
