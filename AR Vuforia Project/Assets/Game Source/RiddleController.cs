using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleController : MonoBehaviour {

    public InputField Field;
    public string answer;
    public FloatingText fText;
    public FloatingText wText;
    public GameObject Text;

    bool completou = false;
    GameObject trofeu;
    // Use this for initialization
    void Start()
    {
        trofeu = GameObject.Find("Trofeu");
    }


    public void CheckAnswer()
    {
        string ft = Field.text;
        if(ft.ToLower() == answer.ToLower())
        {
            fText.PopUpText();
            Text.SetActive(true);
            if(completou == false)
            {
                completou = true;
                trofeu.GetComponent<trofeu>().addcont();
            }
        }
        else
        {
            wText.PopUpText();
        }
        /*if (Field.text == answer)
        {
            fText.PopUpText();
            Text.SetActive(true);
        }
        else if (Field.text == answer.ToLower())
        {
            fText.PopUpText();
            Text.SetActive(true);
        }*/
    }
}
