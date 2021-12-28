using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public float zPos = 40f;
    public bool creatingSection = false;
    public int secNumber;

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
        secNumber = Random.Range(0, 3);
        Instantiate(section[secNumber], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 40f;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
