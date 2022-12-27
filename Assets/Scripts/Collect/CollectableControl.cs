using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject countDisplay;

    void Update()
    {
        countDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
