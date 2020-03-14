using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBushTone : MonoBehaviour
{
    public AudioSource audioSource;
    public TonePuzzle tonePz;
    public float bushNR;
    private bool hasEntered;

    private void Start()
    {
        hasEntered = false;
    }

    private void Update()
    {
        if (hasEntered && Input.GetKeyDown(KeyCode.Q))
        {
            audioSource.Play();
            bushNR = audioSource.pitch;
            tonePz.AddAndCheckList(bushNR);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasEntered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;
    }

}
