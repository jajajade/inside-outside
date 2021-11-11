using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndActions : MonoBehaviour
{
    //assign gameobjects and audio in the inspector
    public GameObject mess;
    public GameObject cleaned;
    public GameObject disablePlane;
    public AudioClip clip;
    public float volume = 1;


    // Start is called before the first frame update
    void Start()
    {
        cleaned.SetActive(false); //on start, hide the cleaned gameobjects
    }


    public void Clean()
    {
        cleaned.SetActive(true);    //show clean game objects
        mess.SetActive(false);      //hide mess game objects
        disablePlane.SetActive(false);      //disable the gameobject trigger for the event to avoid duplication
        AudioSource.PlayClipAtPoint(clip, transform.position, volume);      //play clean audio

    }

}
