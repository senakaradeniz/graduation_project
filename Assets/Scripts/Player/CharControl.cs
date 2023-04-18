using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CharControl : MonoBehaviour
{

    public float speed = 0.8f;


    //Jump
    public float jumpSpeed;// = 18f;
    public float jumpHeight;// = 1.2f;
    public float forwardSpeed;// = 10;
    

    // X ekseninde karakterin gidebileceði max mesafe
    public float maxX = 3.5f, minX= -3.5f;

    private Vector3 move;
    private CharacterController characterController;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < maxX)
        {
            Move(1);
        }

        else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > minX)
        {
            Move(-1);
        }
        else
        {
            Move(0);
        }
        JumpControl();

    }

    void Move(float horizontalDirection)
    {
        move.x = (horizontalDirection / 20) * speed;
        move.z = forwardSpeed * Time.deltaTime;
        Vector3 movementDirection = move;
        characterController.Move(movementDirection);

    }


    void JumpControl()
    {
        if (characterController.isGrounded)
        {
            if (Input.GetButton("Jump") || Input.GetKey(KeyCode.UpArrow))
            {
                move.y = jumpHeight / 10;
            }


        }
        else if (!characterController.isGrounded)
        {
            move.y -= (9.81f * Time.deltaTime) / jumpSpeed;
        }

    }
}










//public GameObject playerObject;
//public bool isJumping = false;
//public bool comingDown = false;
//static public bool canMove = false;







//void Update()
//{
//    transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
//    if (canMove == true)
//    {
//        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < maxX)
//        {
//            Move(1);
//        }

//        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > minX)
//        {
//            Move(-1);
//        }

//        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)))
//        {
//            if(isJumping == false)
//            {
//                isJumping = true;
//                playerObject.GetComponent<Animator>().Play("Jump");
//                StartCoroutine(JumpSequence());
//            }

//        }

//        else
//        {
//            Move(0);
//        }

//    }
//    if(isJumping == true) {
//        if(comingDown == false)
//        {
//            transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
//        }
//        if(comingDown == true)
//        {
//            transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
//        }
//    }
//}


//void Move(float horizontalDirection)
//{
//    move.x = (horizontalDirection / 20) * speed;
//    move.z = forwardSpeed * Time.deltaTime;
//    Vector3 movementDirection = move;
//    characterController.Move(movementDirection);

//}


//IEnumerator JumpSequence()
//{
//    yield return new WaitForSeconds(0.45f);
//    comingDown = true;
//    yield return new WaitForSeconds(0.45f);
//    isJumping = false;
//    comingDown = false;
//    playerObject.GetComponent<Animator>().Play("Standart Run");


//}


