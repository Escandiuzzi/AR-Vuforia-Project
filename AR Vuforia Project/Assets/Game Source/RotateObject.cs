using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    // Use this for initialization
    Vector3 posInicial, posNova;
    public string name;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(name == "Mask")
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 2));
        }
        else if(name == "BB8")
        {
            gameObject.transform.Rotate(new Vector3(0, 5, 0));
        }
    }
}
