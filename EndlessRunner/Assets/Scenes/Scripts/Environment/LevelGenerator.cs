using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] section;
    public float zPos = -160.2533f;
    public bool creatingSection = false;
    public bool deletingSection = false;
    public int secNumber;
    public float xPos =0f;
    public float yPos=0f;
    public int range = 3;
    public float sectionLength = 50f;
    private int noOfSections;
    private List<GameObject> activeSection = new List<GameObject>();
    public GameObject player;

    // Update is called once per frame
    void Update()
    {if (player.transform.position.z + 85 > zPos -(noOfSections*sectionLength))
        {
            if (creatingSection == false)
            {
                creatingSection = true;
                StartCoroutine(GeneratingSection());
                if (deletingSection == false && player.transform.position.z - 35 > zPos - (noOfSections * sectionLength))
                {
                    deletingSection = true;
                    StartCoroutine(DeleteSection());
                }
            }
        }
    }

    IEnumerator GeneratingSection()
    {
        secNumber = Random.Range(0, range);
        GameObject go = Instantiate(section[secNumber], new Vector3(xPos, yPos, zPos), Quaternion.identity);
        activeSection.Add(go);
        zPos += sectionLength;
        noOfSections += 1;
        yield return new WaitForSeconds(2);
        creatingSection = false;
        //yield return new WaitForSeconds(waitForSec*5);
        //Destroy(this.gameObject,waitForSec);
    }
    IEnumerator DeleteSection()
    {
        yield return new WaitForSeconds(0f);
        Destroy(activeSection[0]);
        activeSection.RemoveAt(0);
        deletingSection = false;
    }

    /*IEnumerator DestroySection(section[secNumber])
    {
        yield return new WaitForSeconds(waitForSec);
        Destroy(section[secNumber]);
    }*/
}
