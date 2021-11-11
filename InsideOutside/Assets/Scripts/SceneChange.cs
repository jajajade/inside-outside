using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.8f;
    public GameObject canvas;

    private string sceneNameToLoad;
    private bool sceneLoaded;

    //NOTE: each function works the same way, so only the first has been commented to avoid duplication
    //this was split up into seperate functions so we can call on different events using the inspector

    public void Breathing()
    {
        //if bool is false...
        if (!sceneLoaded)
        {
            sceneLoaded = true;             //set bool to true to avoid coroutine constantly looping
            sceneNameToLoad = "0Breathing";  //set string for scene name
            StartCoroutine(LoadLevel());    //start coroutine
        }
    }

    public void TextIntro()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;  
            sceneNameToLoad = "TextIntro";
            StartCoroutine(LoadLevel());  
        }
    }

    public void TextPlantSwitch()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "TextTransition1";
            StartCoroutine(LoadLevel());
        }
    }

    public void TextHumanSwitch()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "TextTransition2";
            StartCoroutine(LoadLevel());
        }
    }

    public void SceneRoot()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "0RootScene";
            StartCoroutine(LoadLevel());
        }
    }

    public void SceneRoot2()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "0RootScene2";
            StartCoroutine(LoadLevel());
        }
    }

    public void ScenePlantView()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "Animation1Typing";
            StartCoroutine(LoadLevel());
        }
    }

    public void SceneOttomanSit()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "OttomanSit";
            StartCoroutine(LoadLevel());
        }
    }

    public void SceneTyping()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "TypingScene";
            StartCoroutine(LoadLevel());
        }
    }

    public void SceneWriting()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "WritingScene";
            StartCoroutine(LoadLevel());
        }
    }

    public void EndRoot()
    {
        if (!sceneLoaded)
        {
            sceneLoaded = true;
            sceneNameToLoad = "EndRoot";
            StartCoroutine(LoadLevel());
        }
    }


    IEnumerator LoadLevel()
    {
        //play animation
        transition.SetTrigger("Start");

        //hide canvas and reticle once screen fades to black
        canvas.SetActive(false);

        //wait
        yield return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(sceneNameToLoad);
    }

}