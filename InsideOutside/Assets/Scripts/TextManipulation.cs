using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManipulation : MonoBehaviour
{
    public GameObject text;
    public GameObject bg;
    public Text textChange;

    void Start()
    {
        text.SetActive(false); //on start, hide text
        bg.SetActive(false);   //hide the bg
    }

    //NOTE: each function works the same way, so only the first has been commented to avoid duplication
    //this was split up into seperate functions so we can call on different events using the inspector

    public void Select()
    {
        textChange.text = "Select";  //change text to string specified
        text.SetActive(true);       //show the text
        bg.SetActive(true);         //show the bg
    }

    public void Enter()
    {
        textChange.text = "Enter";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void TypingText()
    {
        textChange.text = "Use";
        text.SetActive(true);
        bg.SetActive(true);
    }


    public void WritingText()
    {
        textChange.text = "Work";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void OttomanText()
    {
        textChange.text = "Sit";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void ListenText()
    {
        textChange.text = "Listen";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void CleanText()
    {
        textChange.text = "Clean";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void WaterText()
    {
        textChange.text = "Water";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void PlantText()
    {
        textChange.text = "Change viewpoint";
        text.SetActive(true);
        bg.SetActive(true);
    }

    public void HideText()
    {
        text.SetActive(false);  //hide the text
        bg.SetActive(false);    //hide the bg
    }

}
