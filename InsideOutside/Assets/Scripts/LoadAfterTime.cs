using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadAfterTime : MonoBehaviour
{
    //allow use of inspector to change the delay time and scene to load
    [SerializeField] private float delayBeforeLoading = 30f;
    [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;
    private bool sceneLoaded;

    public Animator transition;
    public float transitionTime = 1f;

    void Update()
    {
        //if scene not loaded, start counting time
        if (!sceneLoaded)
        {
            timeElapsed += Time.deltaTime;

            //if time exceeds the delay...start coroutine
            if (timeElapsed > delayBeforeLoading)
            {
                StartCoroutine(LoadLevel());
                sceneLoaded = true;     //change bool to true to prevent coroutine constantly looping
            }
        }
    }

    IEnumerator LoadLevel()
    {
        //play fade animation
        transition.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //load in scene
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
