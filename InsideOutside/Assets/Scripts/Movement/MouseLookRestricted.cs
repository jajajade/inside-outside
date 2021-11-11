using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookRestricted : MonoBehaviour
{
    public Transform playerBody;
    [SerializeField] private float mouseSensitivity = 100f;

    float xRotation = 0f;
    //float yRotation = 0f;


    void Start()
    {
        //on start, hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //gather input based on our mouse position and mouse sensitivity set in the inspector
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //set camera rotation but limit rotation to 180 degrees to avoid overrotation
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
