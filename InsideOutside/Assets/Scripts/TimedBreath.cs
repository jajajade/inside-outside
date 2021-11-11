using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimedBreath : MonoBehaviour
{
    public GameObject text;
    public Text textChange;
    private bool breatheIn;
    private float timeElapsed;

    void Start()
    {
        breatheIn = false;
    }

    void Update()
    {
        //if bool false
        if (!breatheIn)
        {
            //start timer
            timeElapsed += Time.deltaTime;   

            //if time exceeds the delay...
            if (timeElapsed >= 3f)
            {
                textChange.text = "Breathe out";    //change text
                breatheIn = true;                   //set bool to true
                timeElapsed = 0f;                   //reset timeElapsed float to reset timer
            }
        }

        //if bool true
        if (breatheIn)
        {
            //start timer
            timeElapsed += Time.deltaTime; 

            //if time exceeds the delay...
            if (timeElapsed >= 6f)
            {
                textChange.text = "Breathe in";  //change text
                breatheIn = false;               //set bool to false
                timeElapsed = 0f;                //reset timeElapsed float to reset timer
            }
        }
    }
}
