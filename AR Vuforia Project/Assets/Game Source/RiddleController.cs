using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleController : MonoBehaviour {

    public InputField Field;
    public string answer;
    public FloatingText fText;
    public FloatingText wText;


    // Use this for initialization
    void Start()
    {

    }


    public void CheckAnswer()
    {
   
        if (Field.text == answer)
        {
            fText.PopUpText();
        }
        else
        {
            wText.PopUpText();
        }
     
    }
}
