using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBushTone : MonoBehaviour
{
    public AudioSource audioSource;
    public float bushNR;
    public TonePuzzle tonePz;

    private void Update()
    {
        //if () { }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.Play();
            bushNR = audioSource.pitch;
            tonePz.AddAndCheckList(bushNR);
        }
    }

}
