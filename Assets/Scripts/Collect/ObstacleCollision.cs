using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//bir engele çarptýðýnda durmasý ve geri sendelemesi

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        //turn off the collider
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        //stop the character
        thePlayer.GetComponent<PlayerLeftRightMove>().enabled = false;
        //engele çarptýðýnda sayacýn durmasý
        levelControl.GetComponent<LevelDistance>().enabled = false;

        charModel.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
