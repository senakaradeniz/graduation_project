using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;


    void Update()
    {
        //mesafe eklenmiyorsa belirli aral�kl�kla metre eklenmesi gerekti�i
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        //bekleme s�resi eklenir
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }



}
