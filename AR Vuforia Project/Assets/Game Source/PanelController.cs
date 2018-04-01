using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PanelController : MonoBehaviour {

    public GameObject[] iPanels;
    public Button myButton;
    int pos;
    public Sprite sMask;
    public Sprite sBB8;
    public Sprite defaultImage;
    public GameObject panel;
    public GameObject mainPanel;
    // Use this for initialization
    void Start()
    {
        pos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void PanelClick()
    {
        if (myButton.image.sprite != defaultImage) {
            if (myButton.image.sprite == sMask)
            {
                pos = 0;
            }

            if (myButton.image.sprite == sBB8)
            {

                pos = 1;
            }
            iPanels[pos].SetActive(true);
            mainPanel.SetActive(false);
        }
    }
    public void ReturnClick() {

        panel.SetActive(false);
    }

}
