using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class TreeWhisper : MonoBehaviour
{

    public int thisTreeNr;
    public int nextWhisperNr = 0;
    private bool hasEntered;
    AudioSource audioSource;

    public WhisperRandom whisp;
    int[] treeOrder;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hasEntered = false;
    }

    private void Update()
    {
        if (hasEntered && Input.GetKeyDown(KeyCode.Q))
        {
            if (treeOrder[nextWhisperNr] == thisTreeNr)
            {
                whisp.Increment();
                StopWhisper();
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasEntered = true;

        GetTreeNr();
        if(collision.CompareTag("Player") && treeOrder[nextWhisperNr] == thisTreeNr)
        {
            PlayWhisper();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasEntered = false;

        GetTreeNr();
        if (collision.CompareTag("Player") && audioSource.isPlaying)
        {
            StopWhisper();
        }
    }

    public void GetTreeNr()
    {
        treeOrder = whisp.order;
        nextWhisperNr = whisp.turnInOrder;
    }

    public void PlayWhisper()
    {
        audioSource.Play();
    }

    public void StopWhisper()
    {
        audioSource.Stop();
    }

}
