using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneCamera : MonoBehaviour {

    private void Awake()
    {
        Object sCamera = Instantiate(gameObject);
    }

    // Use this for initialization
    void Start () {
        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
