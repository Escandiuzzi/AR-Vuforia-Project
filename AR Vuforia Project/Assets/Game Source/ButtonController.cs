using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    Scene myScene;
    public GameObject itemObject;
    public GameObject nextObject;
    public GameObject backObject;

    public Canvas iCanvas;
    public Canvas nCanvas;
    public Canvas bCanvas;

   

    // Use this for initialization
    void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {
        myScene = SceneManager.GetActiveScene();
       
    }

    public void InventoryButton() {

        SceneManager.LoadScene("Inventory");
    }

    public void CameraSceneButton() {

        SceneManager.LoadScene("Main");
    }


    public void nPage() {

        itemObject.SetActive(false);
        iCanvas.enabled = false;

        nextObject.SetActive(true);
        nCanvas.enabled = true; 
    }

    public void bPage() {

        itemObject.SetActive(false);
        iCanvas.enabled = true;

        backObject.SetActive(true);
        bCanvas.enabled = true;
    }
 

}
