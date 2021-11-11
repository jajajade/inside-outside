using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndWater : MonoBehaviour
{
    //fields for timer when scene begins
    [SerializeField] private float delayBeforeLoading = 5f;
    private float timeElapsed;

    //fields to load scene
    [SerializeField] private string sceneNameToLoad;
    public float transitionTime = 1f;
    public Animator transition;
    public GameObject canvas;
    public GameObject reticle;

    private float volume = 1;
    public AudioClip clip;

    private bool watered;

    private void Update()
    {
        //if watered bool = true (from the Water() function), start timer
        if (watered)
        {
            timeElapsed += Time.deltaTime;

            //if time exceeds the delay...load scene
            if (timeElapsed > delayBeforeLoading)
            {
                StartCoroutine(LoadLevel());    //start coroutine
                watered = false;    //set bool to false
            }
        }
    }

    public void Water()
    {
        watered = true;     //set bool to true
        AudioSource.PlayClipAtPoint(clip, transform.position, volume);    //play sound effect
    }

    IEnumerator LoadLevel()
    {
        //play animation
        transition.SetTrigger("Start");

        //hide canvas and reticle once screen fades to black
        canvas.SetActive(false);
        reticle.SetActive(false);

        //wait
        yield return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
