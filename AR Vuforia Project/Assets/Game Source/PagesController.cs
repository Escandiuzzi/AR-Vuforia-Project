using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PagesController : MonoBehaviour {

    public GameObject[] objs;
    Scene mS;
    bool[] objStatus;
    GetPages gPages;
    // Use this for initialization
    void Start () {

        gPages = FindObjectOfType<GetPages>();

        objStatus = new bool[10];
        for (int i = 0; i < objStatus.Length; i++) {

            objStatus[i] = false;
        }

        DontDestroyOnLoad(gameObject);

        if (FindObjectsOfType<PagesController>().Length > 1) {
           Destroy(gameObject);
        }
    
    }
	
	// Update is called once per frame
	void Update () {
        mS = SceneManager.GetActiveScene();
        if (mS.name == "Inventory")
        {
            objs[0] = gPages.returnPages(0);
            objs[1] = gPages.returnPages(1);
            objs[2] = gPages.returnPages(2);
            objs[3] = gPages.returnPages(3);
            objs[4] = gPages.returnPages(4);
            objs[5] = gPages.returnPages(5);
            objs[6] = gPages.returnPages(6);
            objs[7] = gPages.returnPages(7);
            objs[8] = gPages.returnPages(8);
            objs[9] = gPages.returnPages(9);
            checkStatus();
        }

    }

    public void SetPage(int pos) {
       
        
            objStatus[pos] = true;
    }

    void checkStatus() {

        if (objStatus[0] == true) {
            Debug.Log("entrou 1");
            objs[0].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[1] == true)
        {
            Debug.Log("entrou 2");
            objs[1].transform.GetChild(3).GetComponent<Text>().text = "Bomb";
        }

        if (objStatus[2] == true)
        {

            objs[2].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[3] == true)
        {

            objs[3].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[4] == true)
        {

            objs[4].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[5] == true)
        {

            objs[5].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[6] == true)
        {

            objs[6].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[7] == true)
        {

            objs[7].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[8] == true)
        {

            objs[8].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }

        if (objStatus[9] == true)
        {

            objs[9].transform.GetChild(3).GetComponent<Text>().text = "Barrel";
        }


    }
    
}
