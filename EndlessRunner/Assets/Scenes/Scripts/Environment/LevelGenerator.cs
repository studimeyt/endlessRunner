using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public float zPos = -160.2533f;
    public bool creatingSection = false;
    public int secNumber;
    public float xPos =0f;
    public float yPos=0f;
    public int range = 3;

    // Update is called once per frame
    void Update()
    {
     
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GeneratingSection());
        }
    }

    IEnumerator GeneratingSection()
    {
        secNumber = Random.Range(0, range);
        Instantiate(section[secNumber], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        zPos += 50f;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
