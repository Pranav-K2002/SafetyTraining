using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 12f;
    public float gravity = -9.8f;

    public CharacterController playerController;    
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;


    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y <= 0)
        {
            velocity.y =-2f;
        }


        float x= Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; 

        velocity.y +=gravity*Time.deltaTime;

        playerController.Move(move*speed* Time.deltaTime);

        playerController.Move(velocity* Time.deltaTime);
    }
}
