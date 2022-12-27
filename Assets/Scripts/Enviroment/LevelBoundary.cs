using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    //S�n�rlar olu�turuldu ve static olduklar� i�in onlara eri�ilebilir.
    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public float internalLeft;
    public float internalRight;
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
