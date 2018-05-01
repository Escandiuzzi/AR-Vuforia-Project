using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class ButtonController : MonoBehaviour {
    
    public GameObject main;
    public GameObject op;
    public GameObject puzzle;
    public GameObject ArCamera;
    GameObject contPage;
    public int indice;
    
    // Use this for initialization
    void Start () {

        contPage = GameObject.Find("ContPages");
    }

    // Update is called once per frame
    void Update () {
        
    }

    public void InventoryButton() {
        VuforiaBehaviour.Instance.enabled = false;
        main.SetActive(false);
        GameObject temp = contPage.GetComponent<ContPages>().getPage(0);
        temp.SetActive(true);
    }

    public void CameraSceneButton() {
        VuforiaBehaviour.Instance.enabled = true;
        op.SetActive(true);
        main.SetActive(false);
    }
    
    public void nPage() {
        op.SetActive(true);
        main.SetActive(false);
    }

    public void bPage() {
        op.SetActive(true);
        main.SetActive(false);
    }

    public void DPanel() {
        main.SetActive(false);
    }

    public void puzzleGo()
    {
        main.SetActive(false);
        puzzle.SetActive(true);
    }

    public void puzzleBack()
    {
        ArCamera.SetActive(true);
        op.SetActive(true);
        main.SetActive(false);
        
    }
    public void StartGame() {

        SceneManager.LoadScene("Main");            
    }
}
