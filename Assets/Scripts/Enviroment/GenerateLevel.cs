using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//section larý rastgele bir þekilde create eder
public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    //bölümün oluþturulacaðý ilk pozisyon deðeri
    public int zPos = 40;
    public bool creatingSection = false;
    public int secNum;

    void Update()
    {
        //ayný Coroutine in hep üst üste gelmemesini saðlar
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
        //seçilen sayýya göre section baþlatýlmalý
        Instantiate(section[secNum], new Vector3((float)-9.170316, (float)-6.837324, zPos), Quaternion.identity);
        zPos += 40;
        //her þeyi yeniden etkinleþtirmek için
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
