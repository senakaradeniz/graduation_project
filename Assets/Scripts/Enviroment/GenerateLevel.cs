using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//section lari rastgele bir sekilde create eder
public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public GameObject endSection;
    //bolumun olusturulacagi ilk pozisyon degeri
    public int zPos = 40;
    public bool creatingSection = false;
    public int secNum;

    void Update()
    {
        //ayni Coroutine in hep ust uste gelmemesini saglar
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
            if (zPos==400)
            {
                StartCoroutine(GenerateSection2());
                StopAllCoroutines();


            }
        }
    }

    //adds delay to the game
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        //secilen sayiya gore section baslatilmali
        Instantiate(section[secNum], new Vector3((float)-9.170316, (float)-6.837324, zPos), Quaternion.identity);
        zPos += 40;
        //her seyi yeniden etkinlestirmek icin
        yield return new WaitForSeconds(4f);
        creatingSection = false;
    }
    IEnumerator GenerateSection2()
    {
        //secilen sayiya gore section baslatilmali
        Instantiate(endSection, new Vector3((float)-9.170316, (float)-6.837324, zPos), Quaternion.identity);
        zPos += 40;
        //her seyi yeniden etkinlestirmek icin
        yield return new WaitForSeconds(4f);
        StopCoroutine(GenerateSection());
    }
}
