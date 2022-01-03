using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableCounter : MonoBehaviour
{
    public static int coinCount;
    public GameObject collectableCountDisplay;
    // Update is called once per frame
    void Update()
    {
        collectableCountDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
