using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    Scene myScene;
    public GameObject itemPanel;
    public GameObject nextPanel;
    public GameObject backPanel;

    public Canvas iCanvas;
    public Canvas nCanvas;
    public Canvas bCanvas;

    public PagesController pController;
    public GameObject oName;
   


    // Use this for initialization
    void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {
        myScene = SceneManager.GetActiveScene();
       
    }
    void TaskOnClick()
    {

        if(myScene.name == "Main")
            SceneManager.LoadScene("Inventory");

        if (myScene.name == "Inventory")
            SceneManager.LoadScene("Main");

    }
    public void InventoryButton() {

        SceneManager.LoadScene("Inventory");
    }

    public void CameraSceneButton() {

        SceneManager.LoadScene("Main");
    }

    public void NextPage()
    {
   
        //nextPanel = pController.oPages[pController.ReturnPos(oName) + 1];
        //nextPanel.SetActive(true);
        //itemPanel.SetActive(false);
    }

    public void BackPage() {
       //backPanel = pController.oPages[pController.ReturnPos(oName) -1];
       //backPanel.SetActive(true);
       //itemPanel.SetActive(false);
    }

    public void nPage() {

        itemPanel.SetActive(false);
        iCanvas.enabled = false;

        nextPanel.SetActive(true);
        nCanvas.enabled = true;
        
    }

    public void bPage() {
        itemPanel.SetActive(false);
        iCanvas.enabled = true;

        backPanel.SetActive(true);
        bCanvas.enabled = true;

    }
 

}
