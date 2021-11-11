using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndAfterTime : MonoBehaviour
{
    //allow use of inspector to change the delay time and scene to load
    [SerializeField] private float delayBeforeLoading = 30f;
    public GameObject canvas;
    private float timeElapsed;
    private bool canvasLoaded;

    public Animator transition;
    public float transitionTime = 1f;

    private void Start()
    {
        canvas.SetActive(false);
    }

    void Update()
    {
        //if scene not loaded, start counting time
        if (!canvasLoaded)
        {
            timeElapsed += Time.deltaTime;

            //if time exceeds the delay...start coroutine
            if (timeElapsed > delayBeforeLoading)
            {
                canvas.SetActive(true);
                canvasLoaded = true;
            }
        }
    }
}
