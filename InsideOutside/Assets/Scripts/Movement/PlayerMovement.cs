using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        //check if player is standing on an object assigned to a ground layer
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if the player is grounded and velocity is less than 0, apply gravity
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //move locally according to player rotation
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //before applying gravity, if player on the ground and presses spcebar, jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        //make player fall if character is not on the ground
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        
        
    }
}
