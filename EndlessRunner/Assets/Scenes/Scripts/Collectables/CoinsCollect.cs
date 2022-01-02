using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollect : MonoBehaviour
{
    public AudioSource coinSFX;
    public float delay = 100f;
    void OnTriggerEnter(Collider other)
    {
        coinSFX.Play();
        this.gameObject.SetActive(false);
    }
}
