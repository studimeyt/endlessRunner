using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollect : MonoBehaviour
{
    public AudioSource coinSFX;
    public float delay = 100f;
    public int waitBeforeDestoy = 2;
    void OnTriggerEnter(Collider other)
    {
        coinSFX.Play();
        CollactableCounter.coinCount += 1;
        this.gameObject.SetActive(false);
    }

   
}
