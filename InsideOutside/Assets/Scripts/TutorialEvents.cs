using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEvents : MonoBehaviour
{
    public GameObject cube;
    public GameObject canvas;
    public AudioClip clip;
    public float volume = 1;

    private void Start()
    {
        canvas.SetActive(false);
    }
    public void Disappear()
    {
        cube.SetActive(false);    //show clean game objects
        AudioSource.PlayClipAtPoint(clip, transform.position, volume);      //play audio
        canvas.SetActive(true);     //show canvas as next step
    }
}