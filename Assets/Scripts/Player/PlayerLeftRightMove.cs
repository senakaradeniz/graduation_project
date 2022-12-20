using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftRightMove : MonoBehaviour
{
    //private Vector3 move;
    public float speed = 5;
    public float leftRightSpeed = 10;

    private CharacterController characterController;

    private void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
      
        //karakterin a ve left arrow kullanarak sol tarafa gitmesini saðlar
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        //karakterin d ve right arrow kullanarak sol tarafa gitmesini saðlar
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }

    }

}
