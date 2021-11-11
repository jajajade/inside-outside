using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        //find gameobjects with the tag = music
        GameObject[] audio = GameObject.FindGameObjectsWithTag("Music");

        //if multiple objects (for some reason), destroy, if not, don't destroy between scenes
        if (audio.Length > 1)
        {
            Destroy(this.gameObject);
        }

        //dont destroy gameobjects with this script attached between scenes
        DontDestroyOnLoad(this.gameObject);

    }

}