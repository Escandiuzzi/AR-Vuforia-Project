using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;

public class ButtonController : MonoBehaviour {
    
    public GameObject main;
    public GameObject op;

    GameObject contPage;
    public int indice;


    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered

    // Use this for initialization
    void Start () {

        contPage = GameObject.Find("ContPages");
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
    }

    // Update is called once per frame
    void Update () {
        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe
                            Debug.Log("Right Swipe");
                            nPage();
                        }
                        else
                        {   //Left swipe
                            Debug.Log("Left Swipe");
                            bPage();
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            Debug.Log("Up Swipe");
                        }
                        else
                        {   //Down swipe
                            Debug.Log("Down Swipe");
                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    Debug.Log("Tap");
                }
            }
        }
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
 

}
