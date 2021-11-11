using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlantAfterTime : MonoBehaviour
{
    //fields for timer
    [SerializeField] private float delayBeforeLoading = 10f;
    private float timeElapsed;

    //fields to declare objects in inspector
    public GameObject canvas;
    public GameObject gameobject;
    private bool canvasEnabled;


    void Start()
    {
        //on start hide plant canvas
        canvas.SetActive(false);

        //on start disable plant's box collider
        gameobject.GetComponent<BoxCollider>().enabled = false;
    }


    void Update()
    {
        //if bool false, start counting time
        if (!canvasEnabled)
        {
            timeElapsed += Time.deltaTime;

            //if time exceeds the delay...
            if (timeElapsed > delayBeforeLoading)
            { 
                canvas.SetActive(true);     //show UI canvas
                gameobject.GetComponent<BoxCollider>().enabled = true;    //enable box collider
                canvasEnabled = true;       //set bool to true

                Debug.Log("wait over");
            }
        }
    }
}
