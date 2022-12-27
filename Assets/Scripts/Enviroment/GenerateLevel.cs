using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//section lar� rastgele bir �ekilde create eder
public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    //b�l�m�n olu�turulaca�� ilk pozisyon de�eri
    public int zPos = 40;
    public bool creatingSection = false;
    public int secNum;

    void Update()
    {
        //ayn� Coroutine in hep �st �ste gelmemesini sa�lar
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    //adds delay to the game
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        //se�ilen say�ya g�re section ba�lat�lmal�
        Instantiate(section[secNum], new Vector3((float)-9.170316, (float)-6.837324, zPos), Quaternion.identity);
        zPos += 40;
        //her �eyi yeniden etkinle�tirmek i�in
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
