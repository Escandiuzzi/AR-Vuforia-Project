using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {
    public string nome;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);

        if (FindObjectsOfType<TEST>().Length > 1)
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
