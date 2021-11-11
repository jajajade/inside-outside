using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PromptAfterTime : MonoBehaviour
{
    //fields for timer
    [SerializeField] private float delayBeforeLoading = 10f;
    private float timeElapsed;
    //fields to declare in inspector
    public GameObject canvas;
    public GameObject firstPersonScript;
    public GameObject recticle;
    private bool prompted;


    void Start()
    {
        //on start hide endRoot canvas
        canvas.SetActive(false); // false to hide, true to show

        //on start disable mouse movement, recticle, and vr gaze control
        firstPersonScript.GetComponent<MouseLookRestricted>().enabled = false;
        firstPersonScript.GetComponent<VRGazeController>().enabled = false;
        firstPersonScript.GetComponent<RadialReticle>().enabled = false;

        //hide recticle game object
        recticle.SetActive(false);

    }


    void Update()
    {
        //if bool is false, start counting time
        if (!prompted)
        {
            timeElapsed += Time.deltaTime;

            //if time exceeds the delay...
            if (timeElapsed > delayBeforeLoading)
            {
                canvas.SetActive(true);     //show canvas
                prompted = true;        //set bool to true

                //enable limited mouse look controls and gaze control
                firstPersonScript.GetComponent<MouseLookRestricted>().enabled = true;
                firstPersonScript.GetComponent<VRGazeController>().enabled = true;
                firstPersonScript.GetComponent<RadialReticle>().enabled = true;

                //enable recticle game object
                recticle.SetActive(true);

                Debug.Log("prompted");
            }
        }
    }
}
