using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour {
    public GameObject gEmpty;
    public Text aText;
    public Animator animator;
    bool cont;
    float time;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (cont) {
            time += 0.1f;
        }
        if(time >= 4.5f) {
            gEmpty.SetActive(false);
            cont = false;
            time = 0;
        }

	}

    public void PopUpText() {

        Debug.Log("Ativando Texto");
        gEmpty.SetActive(true);
        cont = true;



    }
}
