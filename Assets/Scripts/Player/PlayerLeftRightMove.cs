using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftRightMove : MonoBehaviour
{
    public float speed = 5;
    public float leftRightSpeed = 5;


    private void Update()
    {
        // (hangi y�ne gidece�i* ne kadar h�zl� gidece�i, )
        transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
      
        //karakterin a ve left arrow kullanarak sol tarafa gitmesini sa�lar
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //if our position greater than left side then we can move left
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }
        //karakterin d ve right arrow kullanarak sol tarafa gitmesini sa�lar
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }

    }

}
