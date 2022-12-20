using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Vector3 move;
    public float speed = 5;
    public float jumpForce, gravity, verticalVelocity;

    private CharacterController charController;
    
    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

   
    void Update()
    {

        move = Vector3.zero;
        move = transform.forward;

        if (charController.isGrounded)
        {
            verticalVelocity = 0;
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                verticalVelocity = jumpForce;
            }

        }
        else
        {
            gravity = 30;
            verticalVelocity -= gravity * Time.deltaTime;
        }

        move.y = verticalVelocity;
        move.Normalize();
        move *= speed;
        charController.Move(move * Time.deltaTime);
        
    }
}
